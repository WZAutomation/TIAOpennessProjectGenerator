using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siemens.Engineering;
using Siemens.Engineering.HW;
using Siemens.Engineering.HW.Features;
using Siemens.Engineering.Library;
using Siemens.Engineering.Library.MasterCopies;
using Siemens.Engineering.Library.Types;
using Siemens.Engineering.MC.Drives;
using Siemens.Engineering.SW;
using Siemens.Engineering.SW.Blocks;
using Siemens.Engineering.SW.Tags;
using Siemens.Engineering.SW.Types;

namespace TIAOpennessProjectGenerator
{
    public partial class MainPage : Form
    {
        //Global variables declaration
        int targetPortalID = 0;
        TiaPortal tiaportal;

        public MainPage()
        {
            InitializeComponent();
        }

        #region Shared Functions

        /// <summary>
        /// Button function to switch the tabs
        /// </summary>
        private void NavePrev(object sender, EventArgs e)
        {
            if (toolNavigator.SelectedIndex > 0)
            {
                toolNavigator.SelectedIndex--;

                if (tiaportal == null)
                {
                    targetPortalID = 0;
                }
            }
        }
        /// <summary>
        /// Button function to switch the tabs
        /// </summary>
        private void NaveNext(object sender, EventArgs e)
        {
            if (toolNavigator.SelectedIndex < toolNavigator.TabCount - 1)
            {
                toolNavigator.SelectedIndex++;

                if (tiaportal == null)
                {
                    targetPortalID = 0;
                }
            }
        }

        private void UpdateProjectPathText()
        {
            if (tiaportal != null && tiaportal.Projects.Count == 1)
            {
                projectPathText.Text = tiaportal.Projects[0].Path.ToString();
            }
        }

        private void UpdateLibraryPathText()
        {
            
            if (tiaportal != null)
            {
                foreach (GlobalLibrary globalLibrary in tiaportal.GlobalLibraries)
                {
                    if (globalLibrary.Name == "OpennessTestLib")
                    {
                        libraryPathText.Text = globalLibrary.Path.ToString();
                        break;
                    }
                }
                
            }
        }

        private void UpdateHWList()
        {
            int i = 0;
            hwListForUser.Items.Clear();
            List<MasterCopy> hwList = new List<MasterCopy>();

            if (libraryPathText.TextLength > 0 && tiaportal.GlobalLibraries.Count > 0)
            {
                foreach (GlobalLibrary globalLibrary in tiaportal.GlobalLibraries)
                {
                    if (globalLibrary.Name + ".al19" == Path.GetFileName(libraryPathText.Text))
                    {
                        hwList = globalLibrary.MasterCopyFolder.Folders.Find("HW").MasterCopies.ToList();
                        break;
                    }
                }
                foreach (MasterCopy hw in hwList)
                {
                    hwListForUser.Items.Add(hw.Name);
                    hwListForUser.Items[i].SubItems.Add("0");
                    hwListForUser.Items[i].SubItems.Add("192.168.100.0");
                    i++;
                }
            }
        }

        private void UpdateSWList()
        {
            int i = 0;
            swListForUser.Items.Clear();

            LibraryTypeComposition theTypes = null;
            
            if (libraryPathText.TextLength > 0 && tiaportal.GlobalLibraries.Count > 0)
            {
                foreach (GlobalLibrary globalLibrary in tiaportal.GlobalLibraries)
                {
                    if (globalLibrary.Name + ".al19" == Path.GetFileName(libraryPathText.Text))
                    {
                        theTypes = globalLibrary.TypeFolder.Folders.Find("ProgramBlocks").Types;
                    }
                }
                foreach (LibraryType type in theTypes)
                {
                    swListForUser.Items.Add(type.Name);
                    swListForUser.Items[i].SubItems.Add("0");
                    swListForUser.Items[i].SubItems.Add("1000");
                    i++;
                }
            }
        }

        private void UpdateS120ModuleList()
        {
            int i = 0;
            s120ConfigList.Items.Clear();

            string[] s120Modules = { "BLM", "SLM", "ALM", "SMM", "DMM" };

            for (int index = 0; index < 5; index ++)
            {
                s120ConfigList.Items.Add(s120Modules[index]);
                s120ConfigList.Items[i].SubItems.Add("0");
                s120ConfigList.Items[i].SubItems.Add("500");
                s120ConfigList.Items[i].SubItems.Add("999");
                i++;
            }
        }
         
        private void UpdateConfigeredS120List()
        {
            if (tiaportal.Projects[0].Devices.Count > 0)
            {
                s120StationsList.Items.Clear();
                DeviceComposition configuredDevices = tiaportal.Projects[0].Devices;

                foreach (Device theDevice in configuredDevices)
                {
                    if (theDevice.Name.Contains("SINAMICS S"))
                    {
                        s120StationsList.Items.Add(theDevice.Name);
                    }
                }
            }
        }

        private void UpdateET200SPModuleList()
        {
            int i = 0;
            et200SPConfigList.Items.Clear();

            string[] et200SPModules = { "DI8", "DQ8", "AI2", "AO2", "F-DI8", "F-DQ8" };

            for (int index = 0; index < 6; index ++)
            {
                et200SPConfigList.Items.Add(et200SPModules[index]);
                et200SPConfigList.Items[i].SubItems.Add("0");
                et200SPConfigList.Items[i].SubItems.Add("1000");
                i++;
            }
        }

        private void UpdateConfiguredET200SPList()
        {
            if (tiaportal.Projects[0].Devices.Count > 0)
            {
                et200SPStationList.Items.Clear();
                DeviceComposition configuredDevices = tiaportal.Projects[0].Devices;

                foreach (Device theDevice in configuredDevices)
                {
                    if (theDevice.Name.Contains("WZET200"))
                    {
                        et200SPStationList.Items.Add(theDevice.Name);
                    }
                }
            }
        }

        private void ToolNavigatorIndexChanged(object sender, EventArgs e)
        {   
            switch (toolNavigator.SelectedIndex)
            {
                case 1:

                    UpdateProjectPathText();
                    break;

                case 2:
                    UpdateLibraryPathText();
                    break;

                case 3:
                    if (tiaportal != null && tiaportal.GlobalLibraries.Count > 0)
                    {
                        UpdateHWList();
                    }
                    break;

                case 4:
                    if (tiaportal != null && tiaportal.GlobalLibraries.Count > 0)
                    {
                        UpdateSWList();
                    }
                    break;

                case 5:
                    if (tiaportal != null && tiaportal.GlobalLibraries.Count > 0)
                    {
                        UpdateS120ModuleList();
                        UpdateConfigeredS120List();
                    }
                    break;

                case 6:
                    if (tiaportal != null && tiaportal.GlobalLibraries.Count > 0)
                    {
                        UpdateET200SPModuleList();
                        UpdateConfiguredET200SPList();
                    }
                    break;

                default:
                    break;    
            }
        }

        #endregion

        #region Start/Link TIA Portal tab
        /// <summary>
        /// Search for all active TIA Portal instances and list their process ID and attached projct.
        /// </summary>
        private void SearchTIAPortalInsstance(object sender, EventArgs e)
        {
            targetPortalID = 0;

            if (TiaPortal.GetProcesses().Count > 0)
            {
                tiaPortalInstanceList.Items.Clear();
                int i = 0;

                foreach (TiaPortalProcess tiaPortalProcess in TiaPortal.GetProcesses())
                {
                    tiaPortalInstanceList.Items.Add(tiaPortalProcess.Id.ToString());

                    if (tiaPortalProcess.ProjectPath != null)
                    {
                        tiaPortalInstanceList.Items[i].SubItems.Add(tiaPortalProcess.ProjectPath.Name);
                    }
                    else
                    {
                        tiaPortalInstanceList.Items[i].SubItems.Add("");
                    }

                    i ++;
                }
            }
        }

        private void LinkSelectedInstance(object sender, EventArgs e)
        {
            if (targetPortalID > 0 && tiaportal == null)
            {
                TiaPortalProcess tiaPortalProcess = TiaPortal.GetProcess(targetPortalID);
                tiaportal = tiaPortalProcess.Attach();
                MessageBox.Show("Application has been linked to TIA Portal process " + targetPortalID.ToString() + ", \nplease proceed to \"Open Project\"");
            }
            else if (targetPortalID == 0)
            {
                MessageBox.Show("Please select a TIA Portal instance.");
            }
            else if (targetPortalID > 0 && tiaportal != null)
            {
                MessageBox.Show("Application has been linked to TIA Portal process " + targetPortalID.ToString() + ", \nplease proceed to \"Open Project\"");
            }
        }

        private void CreateNewInstance(object sender, EventArgs e)
        {
            targetPortalID = 0;

            if (tiaportal == null)
            {
                tiaportal = new TiaPortal(TiaPortalMode.WithUserInterface);
                targetPortalID = tiaportal.GetCurrentProcess().Id;

                MessageBox.Show("A new TIA Portal instance has been created with ID " + targetPortalID.ToString() + ", \nplease proceed to \"Open Project\"");
            }
            else
            {
                targetPortalID = tiaportal.GetCurrentProcess().Id;
                MessageBox.Show("A new TIA Portal instance has been created with ID " + targetPortalID.ToString() + ", \nplease proceed to \"Open Project\"");
            }

            if (TiaPortal.GetProcesses().Count > 0)
            {
                tiaPortalInstanceList.Items.Clear();
                int i = 0;

                foreach (TiaPortalProcess tiaPortalProcess in TiaPortal.GetProcesses())
                {
                    tiaPortalInstanceList.Items.Add(tiaPortalProcess.Id.ToString());

                    if (tiaPortalProcess.ProjectPath != null)
                    {
                        tiaPortalInstanceList.Items[i].SubItems.Add(tiaPortalProcess.ProjectPath.Name);
                    }
                    else
                    {
                        tiaPortalInstanceList.Items[i].SubItems.Add("");
                    }

                    i++;
                }
            }

        }

        /// <summary>
        /// Get the process ID of the TIA Portal instance for the app to work on
        /// </summary>
        private void tiaPortalInstanceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tiaPortalInstanceList.SelectedItems.Count == 1 )
            {
                targetPortalID = Int32.Parse(tiaPortalInstanceList.SelectedItems[0].Text);
            }
        }
        #endregion

        #region Open Project tab

        private void OpenProject(object sender, EventArgs e)
        {
            if (projectPathText.Text.Length > 0)
            {
                string[] files = Directory.GetFiles(projectPathText.Text, "*.ap19");

                if (tiaportal == null)
                {
                    MessageBox.Show("Please link TIA Portal instance first.");
                }
                else if (tiaportal != null && files.Length == 0)
                {
                    MessageBox.Show("There is no project file in the selected folder, check your path or create new project.");
                }
                else
                {                   
                    tiaportal.Projects.Open(new FileInfo(files[0]));
                }
            }
            else
            {
                MessageBox.Show("Please select a path for the project first");
            }
        }

        private void CreateProject(object sender, EventArgs e)
        {
            if (tiaportal == null)
            {
                MessageBox.Show("Please link TIA Portal instance first.");
            }
            else if (projectPathText.Text.Length == 0)
            {
                MessageBox.Show("Please select a path for the project first.");
            }
            else
            {
                PromptWindow promptWindow = new PromptWindow("Please input project name", "Project Name");
                string projectname = promptWindow.Result;
                if (projectname != "")
                {
                    tiaportal.Projects.Create(new DirectoryInfo(projectPathText.Text), projectname);
                }

                promptWindow.Dispose();
            }
        }

        private void BrowseForProject(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                projectPathText.Text = dialog.SelectedPath;
            }
        }

        #endregion

        #region Open Library tab

        private void BrowseForLibrary(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                libraryPathText.Text = dialog.SelectedPath;
            }
        }

        private void OpenLibrary(object sender, EventArgs e)
        {
            if (libraryPathText.Text.Length > 0)
            {
                string[] files = Directory.GetFiles(libraryPathText.Text, "*.al19");
                
                if (tiaportal == null)
                {
                    MessageBox.Show("Please link TIA Portal instance first.");
                }
                else if (tiaportal != null && files.Length == 0)
                {
                    MessageBox.Show("There is no library file in the selected folder, check your path.");
                }
                else
                {
                    if (tiaportal.GlobalLibraries.Count > 0)
                    {
                        bool libraryOpened = false;
                        foreach (GlobalLibrary globallibrary in tiaportal.GlobalLibraries)
                        {
                            if ((globallibrary.Name + ".al19") == Path.GetFileName(files[0]))
                            {
                                MessageBox.Show("Library in the path is already opened.");
                                libraryOpened = true;
                                break;
                            }
                        }

                        if (! libraryOpened)
                        {
                            tiaportal.GlobalLibraries.Open(new FileInfo(libraryPathText.Text), OpenMode.ReadOnly);
                        }
                    }
                    else
                    {
                        tiaportal.GlobalLibraries.Open(new FileInfo(libraryPathText.Text), OpenMode.ReadOnly);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a path for the library first");
            }
        }

        #endregion

        #region Config HW tab

        private void HWListForUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateHWItem(object sender, EventArgs e)
        {
            if (hwListForUser.Items.Count > 0)
            {
                hwListForUser.SelectedItems[0].SubItems[1].Text = masterCopyNumberToCreate.Text;
                hwListForUser.SelectedItems[0].SubItems[2].Text = masterCopyStartIPAddress.Text;
            }

            if (hwListForUser.SelectedItems[0].Text.Contains("PLC"))
            {
                hwListForUser.SelectedItems[0].SubItems[1].Text = "1";
            }
        }

        private void ConfigHW(object sender, EventArgs e)
        {
            MasterCopyFolder theMasterCopyFolder = null;
            IoSystem iosystem = null;

            tiaportal.Projects[0].ShowHwEditor(Siemens.Engineering.HW.View.Network);

            if (tiaportal != null && tiaportal.Projects.Count > 0 && hwListForUser.Items.Count > 0)
            {
                Project theProject = tiaportal.Projects[0];

                foreach (GlobalLibrary globallibray in tiaportal.GlobalLibraries)
                {
                    if (globallibray.Name + ".al19" == Path.GetFileName(libraryPathText.Text))
                    {
                        theMasterCopyFolder = globallibray.MasterCopyFolder.Folders.Find("HW");
                        break;
                    }
                }

                Subnet theSubNet = theProject.Subnets.Create("System:Subnet.Ethernet","Subnet");

                foreach (MasterCopy theMasterCopy in theMasterCopyFolder.MasterCopies)
                {
                    ListViewItem deviceToBeCreated = hwListForUser.FindItemWithText(theMasterCopy.Name);

                    string startIPAddress = deviceToBeCreated.SubItems[2].Text;

                    for (int index = int.Parse(deviceToBeCreated.SubItems[1].Text); index > 0; index--)
                    {
                        Device deviceJustCreated = theProject.Devices.CreateFrom(theMasterCopy);
                        deviceJustCreated.DeviceItems[1].Name = (theMasterCopy.Name) + "_" + index.ToString();
                        Siemens.Engineering.HW.Features.NetworkInterface deviceInterface = null;

                        if (theMasterCopy.Name.Contains("PLC"))
                        {
                            deviceInterface = deviceJustCreated.DeviceItems[1].DeviceItems[3].GetService<Siemens.Engineering.HW.Features.NetworkInterface>();
                            deviceInterface.Nodes[0].ConnectToSubnet(theSubNet);
                            iosystem = deviceInterface.IoControllers[0].CreateIoSystem("fieldIOs");
                        }
                        else if (theMasterCopy.Name.Contains("HMI") || theMasterCopy.Name.Contains("ECO") || theMasterCopy.Name.Contains("WZS120"))
                        {
                            deviceInterface = deviceJustCreated.DeviceItems[1].DeviceItems[0].GetService<Siemens.Engineering.HW.Features.NetworkInterface>();
                            deviceInterface.Nodes[0].ConnectToSubnet(theSubNet);
                        }
                        else
                        {
                            deviceInterface = deviceJustCreated.DeviceItems[1].DeviceItems[1].GetService<Siemens.Engineering.HW.Features.NetworkInterface>();
                            deviceInterface.Nodes[0].ConnectToSubnet(theSubNet);
                        }

                        byte[] ipAddressSegments = IPAddress.Parse(startIPAddress).GetAddressBytes();
                        ipAddressSegments[3] = Convert.ToByte(ipAddressSegments[3] + Convert.ToByte(index) - Convert.ToByte(1));
                        deviceInterface.Nodes[0].SetAttribute("Address", String.Join(".", ipAddressSegments));
                    }
                }

                if (iosystem != null)
                {
                    foreach (Device createdDevice in theProject.Devices)
                    {
                        if (createdDevice.Name.Contains("ET 200eco") || createdDevice.Name.Contains("SINAMICS S"))
                        {
                            createdDevice.DeviceItems[1].DeviceItems[0].GetService<Siemens.Engineering.HW.Features.NetworkInterface>().IoConnectors[0].ConnectToIoSystem(iosystem);
                        }
                        else if (createdDevice.Name.Contains("SINAMICS G") || createdDevice.Name.Contains("ET200"))
                        {
                            createdDevice.DeviceItems[1].DeviceItems[1].GetService<Siemens.Engineering.HW.Features.NetworkInterface>().IoConnectors[0].ConnectToIoSystem(iosystem);
                        }
                    }
                }
            }
        }

        private void MasterCopyNumberToCreate_Changed(object sender, EventArgs e)
        {
            int number = 0;
            if (! string.IsNullOrEmpty(masterCopyNumberToCreate.Text))
            {
                if (! int.TryParse(masterCopyNumberToCreate.Text, out number))
                {
                    masterCopyNumberToCreate.Text = "0";
                    MessageBox.Show("Please input integer number");
                }
                else if (number < 0)
                {
                    masterCopyNumberToCreate.Text = "0";
                    MessageBox.Show("Please input a positive integer number");
                }
            }
        }

        private void MasterCopyStartIPAddress_Changed(object sender, EventArgs e)
        {
            IPAddress ipaddress;
            if (! string.IsNullOrEmpty(masterCopyStartIPAddress.Text))
            {
                if (! IPAddress.TryParse(masterCopyStartIPAddress.Text, out ipaddress))
                {
                    masterCopyStartIPAddress.Text = "192.168.100.0";
                    MessageBox.Show("Please input correct IP(V4) address");
                }
                else
                {
                    masterCopyStartIPAddress.Text = ipaddress.ToString();
                }
            }
        }

        #endregion

        #region Add Software tab
        private void UpdateSWList_Button(object sender, EventArgs e)
        {
            if (swListForUser.Items.Count > 0)
            {
                swListForUser.SelectedItems[0].SubItems[1].Text = numberofInstanceDBstoCreate.Text;
                swListForUser.SelectedItems[0].SubItems[2].Text = typeInstanceDBStartNumber.Text;
            }

            if (swListForUser.SelectedItems[0].Text.EndsWith("FC"))
            {
                swListForUser.SelectedItems[0].SubItems[1].Text = "1";
                swListForUser.SelectedItems[0].SubItems[2].Text = "0";
            }
        }

        private void AddSW_Button(object sender, EventArgs e)
        {
            LibraryTypeFolder typefolder = null;

            if (tiaportal != null && tiaportal.Projects.Count == 1 && tiaportal.GlobalLibraries.Count > 0)
            {
                DeviceItem plcitem = null;

                foreach (Device device in tiaportal.Projects[0].Devices)
                {
                    if (device.Name.Contains("PLC"))
                    {
                        plcitem = device.DeviceItems[1];
                        break;
                    }
                }

                if (plcitem == null)
                {
                    return;
                }

                PlcSoftware wzPLCSoftware = plcitem.GetService<SoftwareContainer>().Software as PlcSoftware;

                wzPLCSoftware.BlockGroup.Groups.Create("types");
                wzPLCSoftware.BlockGroup.Groups.Create("Instances");

                foreach (GlobalLibrary thelibrary in tiaportal.GlobalLibraries)
                {
                    if (thelibrary.Name + ".al19" == Path.GetFileName(libraryPathText.Text))
                    {
                        typefolder = thelibrary.TypeFolder.Folders.Find("ProgramBlocks");
                        break;
                    }
                }

                if (typefolder != null)
                { 
                    for (int i = typefolder.Types.Count - 1; i >= 0; i--)
                    {
                        foreach (CodeBlockLibraryTypeVersion programblocktype in typefolder.Types[i].Versions)
                        {
                            if (programblocktype.IsDefault)
                            {
                                wzPLCSoftware.BlockGroup.Groups.Find("types").Blocks.CreateFrom(programblocktype);

                                if (programblocktype.Parent.GetAttribute("Name").ToString().EndsWith("FB"))
                                {
                                    int amountDBsToCreate = int.Parse(swListForUser.FindItemWithText(programblocktype.Parent.GetAttribute("Name").ToString()).SubItems[1].Text);
                                    int DBNumber = int.Parse(swListForUser.FindItemWithText(programblocktype.Parent.GetAttribute("Name").ToString()).SubItems[1].Text);

                                    for (int j = amountDBsToCreate; j > 0; j--)
                                    {
                                        wzPLCSoftware.BlockGroup.Groups.Find("Instances").Blocks.CreateInstanceDB(programblocktype.Parent.GetAttribute("Name").ToString() + "_" + j.ToString(), true, DBNumber + amountDBsToCreate, programblocktype.Parent.GetAttribute("Name").ToString());
                                    }
                                }
                            }

                        }
                    }
                }
            } 
        }

        private void TypeInstanceDBStartNumber_Changed(object sender, EventArgs e)
        {
            int number = 0;
            if (!string.IsNullOrEmpty(typeInstanceDBStartNumber.Text))
            {
                if (!int.TryParse(typeInstanceDBStartNumber.Text, out number))
                {
                    typeInstanceDBStartNumber.Text = "0";
                    MessageBox.Show("Please input integer number");
                }
                else if (number < 0)
                {
                    typeInstanceDBStartNumber.Text = "0";
                    MessageBox.Show("Please input a positive integer number");
                }
            }
        }

        private void NumberofInstanceDBstoCreate_Changed(object sender, EventArgs e)
        {
            int number = 0;
            if (!string.IsNullOrEmpty(numberofInstanceDBstoCreate.Text))
            {
                if (!int.TryParse(numberofInstanceDBstoCreate.Text, out number))
                {
                    numberofInstanceDBstoCreate.Text = "0";
                    MessageBox.Show("Please input integer number");
                }
                else if (number < 0)
                {
                    numberofInstanceDBstoCreate.Text = "0";
                    MessageBox.Show("Please input a positive integer number");
                }
            }
        }
        #endregion

        #region Config S120
        private void UpdateS120ModuleList_Button(object sender, EventArgs e)
        {
            if (s120ConfigList.Items.Count > 0)
            {
                if (s120ConfigList.SelectedItems[0].SubItems[0].Text.Contains("LM"))
                {
                    s120ConfigList.SelectedItems[0].SubItems[1].Text = "1";
                    s120ConfigList.SelectedItems[0].SubItems[3].Text = "370";

                    switch (s120ConfigList.SelectedItems[0].Index)
                    {
                        case 0:
                            s120ConfigList.Items[1].SubItems[1].Text = "0";
                            s120ConfigList.Items[2].SubItems[1].Text = "0";
                            break;

                        case 1:
                            s120ConfigList.Items[0].SubItems[1].Text = "0";
                            s120ConfigList.Items[2].SubItems[1].Text = "0";
                            break;

                        case 2:
                            s120ConfigList.Items[0].SubItems[1].Text = "0";
                            s120ConfigList.Items[1].SubItems[1].Text = "0";
                            break;
                    }
                }
                else
                {
                    s120ConfigList.SelectedItems[0].SubItems[1].Text = numberofS120ModulestoCreate.Text;
                    s120ConfigList.SelectedItems[0].SubItems[3].Text = "3";
                }

                foreach (ListViewItem s120ConfigListItem in s120ConfigList.Items)
                {
                    s120ConfigListItem.SubItems[2].Text = startIOAddressofS120Module.Text;
                }
            }
        }

        private void ConfigS120Modules_Button(object sender, EventArgs e)
        {
            Device theS120Station;

            if (s120StationsList.Items.Count > 0 && s120StationsList.SelectedItems.Count == 1)
            {
                theS120Station = tiaportal.Projects[0].Devices.Find(s120StationsList.SelectedItems[0].SubItems[0].Text);

                if (theS120Station.DeviceItems[1].DeviceItems[0].GetService<Siemens.Engineering.HW.Features.NetworkInterface>().IoConnectors[0].ConnectedToIoSystem != null)
                {
                    theS120Station.DeviceItems[1].DeviceItems[0].GetService<Siemens.Engineering.HW.Features.NetworkInterface>().IoConnectors[0].DisconnectFromIoSystem();
                }

                foreach(ListViewItem theS120Module in s120ConfigList.Items)
                {
                    if (theS120Module.SubItems[0].Text.Contains("LM") && theS120Module.SubItems[1].Text == "1")
                    {
                        switch (theS120Module.SubItems[0].Text)
                        {
                            case "BLM":
                                theS120Station.PlugNew("OrderNumber:6SL3130-1TE22-0Axx", "WZBLM", 65535);
                                break;

                            case "SLM":
                                theS120Station.PlugNew("OrderNumber:6SL3130-6TE23-6Axx", "WZSLM", 65535);
                                break;

                            case "ALM":
                                theS120Station.PlugNew("OrderNumber:6SL3130-7TE23-6Axx", "WZALM", 65535);
                                break;
                        }
                        break;
                    }
                }

                foreach(ListViewItem theS120Module in s120ConfigList.Items)
                {
                    if (theS120Module.SubItems[0].Text == "SMM" && int.Parse(theS120Module.SubItems[1].Text) > 0)
                    {
                        for (int index = 1; index <= int.Parse(theS120Module.SubItems[1].Text); index ++)
                        {
                            theS120Station.PlugNew("OrderNumber:6SL3120-1TE13-0Axx//10001", "WZSMM_" + index.ToString(), 65535);
                        }
                    }

                    else if (theS120Module.SubItems[0].Text == "DMM" && int.Parse(theS120Module.SubItems[1].Text) > 0)
                    {
                        for (int index = 1; index <= int.Parse(theS120Module.SubItems[1].Text); index++)
                        {
                            theS120Station.PlugNew("OrderNumber:6SL3120-2TE13-0Axx//10011", "WZDMM_" + index.ToString(), 65535);
                        }
                    }
                }

                PlcSoftware thePLCSoftware = null;

                foreach (Device configuredDevice in tiaportal.Projects[0].Devices)
                {
                    if (configuredDevice.Name.Contains("PLCX"))
                    {
                        IoSystem theIOSystem = configuredDevice.DeviceItems[1].DeviceItems[3].GetService<Siemens.Engineering.HW.Features.NetworkInterface>().IoControllers[0].IoSystem;
                        theS120Station.DeviceItems[1].DeviceItems[0].GetService<Siemens.Engineering.HW.Features.NetworkInterface>().IoConnectors[0].ConnectToIoSystem(theIOSystem);
                        
                        thePLCSoftware = configuredDevice.DeviceItems[1].GetService<SoftwareContainer>().Software as PlcSoftware;
                        thePLCSoftware.TagTableGroup.TagTables.Create(theS120Station.Name);
                        break;
                    }
                }
                
                if (thePLCSoftware.TypeGroup.Groups.Find("S120Telegram") == null)
                {
                    thePLCSoftware.TypeGroup.Groups.Create("S120Telegram");

                    if (libraryPathText.TextLength > 0 && tiaportal.GlobalLibraries.Count > 0)
                    {
                        foreach (GlobalLibrary globalLibrary in tiaportal.GlobalLibraries)
                        {
                            if (globalLibrary.Name + ".al19" == Path.GetFileName(libraryPathText.Text))
                            {
                                LibraryTypeFolder theS120TelegramFolder = globalLibrary.TypeFolder.Folders.Find("UDT").Folders.Find("S120Telegram");
                                
                                foreach (LibraryType theS120Telegram in theS120TelegramFolder.Types)
                                {
                                    foreach (PlcTypeLibraryTypeVersion theS120TelegramVersions in theS120Telegram.Versions)
                                    {
                                        if (theS120TelegramVersions.IsDefault)
                                        {
                                            thePLCSoftware.TypeGroup.Groups.Find("S120Telegram").Types.CreateFrom(theS120TelegramVersions);
                                            break;
                                        }
                                    }
                                    
                                }
                            break;
                            }
                        }
                    }
                }

                Int32 addressOffset = 0;

                foreach (DeviceItem theS120Module in theS120Station.DeviceItems)
                {
                    DriveObjectContainer theS120DriveObject = theS120Module.GetService<DriveObjectContainer>();

                    if (theS120Module.Name.Contains("Infeed"))
                    {
                        theS120DriveObject.DriveObjects[0].Telegrams[0].TelegramNumber = 370;
                        theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].StartAddress = Int32.Parse(s120ConfigList.Items[0].SubItems[2].Text) + addressOffset;
                        addressOffset += Math.Max(theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].Length / 8, theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[1].Length / 8);

                        if (thePLCSoftware != null)
                        {
                            PlcTag thePLCTag_I = thePLCSoftware.TagTableGroup.TagTables.Find(theS120Station.Name).Tags.Create(theS120Station.Name + "_Infeed_I");
                            PlcTag thePLCTag_Q = thePLCSoftware.TagTableGroup.TagTables.Find(theS120Station.Name).Tags.Create(theS120Station.Name + "_Infeed_Q");

                            thePLCTag_I.DataTypeName = "S120_LM_Tele370_I";
                            thePLCTag_Q.DataTypeName = "S120_LM_Tele370_Q";

                            thePLCTag_I.LogicalAddress = "%I" + theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].StartAddress.ToString() + ".0";
                            thePLCTag_Q.LogicalAddress = "%Q" + theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].StartAddress.ToString() + ".0";
                        }
                    }
                    else if (theS120Module.Name == "WZS120CU320-2PN")
                    {
                        theS120DriveObject.DriveObjects[0].Telegrams[0].TelegramNumber = 390;
                        theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].StartAddress = Int32.Parse(s120ConfigList.Items[0].SubItems[2].Text) + addressOffset;
                        addressOffset += Math.Max(theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].Length / 8, theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[1].Length / 8);

                        if (thePLCSoftware != null)
                        {
                            PlcTag thePLCTag_I = thePLCSoftware.TagTableGroup.TagTables.Find(theS120Station.Name).Tags.Create(theS120Station.Name + "_CU320_I");
                            PlcTag thePLCTag_Q = thePLCSoftware.TagTableGroup.TagTables.Find(theS120Station.Name).Tags.Create(theS120Station.Name + "_CU320_Q");

                            thePLCTag_I.DataTypeName = "S120_CU_Tele390_I";
                            thePLCTag_Q.DataTypeName = "S120_CU_Tele390_Q";

                            thePLCTag_I.LogicalAddress = "%I" + theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].StartAddress.ToString() + ".0";
                            thePLCTag_Q.LogicalAddress = "%Q" + theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].StartAddress.ToString() + ".0";
                        }
                    }
                    else if (theS120Module.Name.Contains("Drive axis"))
                    {
                        theS120DriveObject.DriveObjects[0].Telegrams[0].TelegramNumber = 3;
                        theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].StartAddress = Int32.Parse(s120ConfigList.Items[0].SubItems[2].Text) + addressOffset;
                        addressOffset += Math.Max(theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].Length / 8, theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[1].Length / 8);

                        if (thePLCSoftware != null)
                        {
                            PlcTag thePLCTag_I = thePLCSoftware.TagTableGroup.TagTables.Find(theS120Station.Name).Tags.Create(theS120Station.Name + "_" + theS120Module.Name + "_I");
                            PlcTag thePLCTag_Q = thePLCSoftware.TagTableGroup.TagTables.Find(theS120Station.Name).Tags.Create(theS120Station.Name + "_" + theS120Module.Name + "_Q");

                            thePLCTag_I.DataTypeName = "S120_MM_Tele3_I";
                            thePLCTag_Q.DataTypeName = "S120_MM_Tele3_Q";

                            thePLCTag_I.LogicalAddress = "%I" + theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].StartAddress.ToString() + ".0";
                            thePLCTag_Q.LogicalAddress = "%Q" + theS120DriveObject.DriveObjects[0].Telegrams[0].Addresses[0].StartAddress.ToString() + ".0";

                            if (thePLCSoftware.TechnologicalObjectGroup.Groups.Find(theS120Station.Name) == null)
                            {
                                thePLCSoftware.TechnologicalObjectGroup.Groups.Create(theS120Station.Name);
                                thePLCSoftware.TechnologicalObjectGroup.Groups.Find(theS120Station.Name).TechnologicalObjects.Create(theS120Station.Name + "_" + theS120Module.Name, "TO_PositioningAxis", new Version("8.0"));
                            }
                            else
                            {
                                thePLCSoftware.TechnologicalObjectGroup.Groups.Find(theS120Station.Name).TechnologicalObjects.Create(theS120Station.Name + "_" + theS120Module.Name, "TO_PositioningAxis", new Version("8.0"));
                            }
                        }
                    }
                }
            }
        }
 
        private void S120ConfigList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void S120StationsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumberofS120ModulestoCreate_Changed(object sender, EventArgs e)
        {
            int number = 0;
            if (!string.IsNullOrEmpty(numberofS120ModulestoCreate.Text))
            {
                if (!int.TryParse(numberofS120ModulestoCreate.Text, out number))
                {
                    numberofS120ModulestoCreate.Text = "0";
                    MessageBox.Show("Please input integer number");
                }
                else if (number < 0)
                {
                    numberofS120ModulestoCreate.Text = "0";
                    MessageBox.Show("Please input a positive integer number");
                }
            }
        }

        private void StartIOAddressofS120Module_Changed(object sender, EventArgs e)
        {
            int number = 0;
            if (!string.IsNullOrEmpty(startIOAddressofS120Module.Text))
            {
                if (!int.TryParse(startIOAddressofS120Module.Text, out number))
                {
                    startIOAddressofS120Module.Text = "0";
                    MessageBox.Show("Please input integer number");
                }
                else if (number < 0)
                {
                    startIOAddressofS120Module.Text = "0";
                    MessageBox.Show("Please input a positive integer number");
                }
            }
        }

        #endregion

        #region Config ET200SP

        private void ConfigET200SP_Button(object sender, EventArgs e)
        {
            Device theET200SPStation = null;
            PlcTagTable theET200SPIOTagTable = null;
            PlcSoftware thePLCSoftware = null;

            int slot = 1;
            int addressOffset = 0;

            theET200SPStation = tiaportal.Projects[0].Devices.Find(et200SPStationList.SelectedItems[0].SubItems[0].Text);

            foreach (Device configuredDevice in tiaportal.Projects[0].Devices)
            {
                if (configuredDevice.Name.Contains("PLCX"))
                {
                    thePLCSoftware = configuredDevice.DeviceItems[1].GetService<SoftwareContainer>().Software as PlcSoftware;
                    theET200SPIOTagTable = thePLCSoftware.TagTableGroup.TagTables.Create(theET200SPStation.Name);
                    break;
                }
            }

            if (et200SPStationList.Items.Count > 0)
            {
                foreach (ListViewItem theET200SPModule in et200SPConfigList.Items)
                {
                    switch (theET200SPModule.SubItems[0].Text)
                    { 
                        case "DI8":

                            for (int index = 0; index < int.Parse(theET200SPModule.SubItems[1].Text); index++)
                            {
                                DeviceItem newModule = theET200SPStation.DeviceItems[0].PlugNew("OrderNumber:6ES7131-6BF01-0BA0/V0.0",theET200SPStation.Name + "_DI8_" + index.ToString(),slot);
                                int theIOAddress = newModule.DeviceItems[0].Addresses[0].StartAddress = int.Parse(startIOAddressofET200SP.Text) + addressOffset;
                                slot += 1;
                                addressOffset += newModule.DeviceItems[0].Addresses[0].Length / 8;

                                for (int tagnumber = 0; tagnumber < newModule.DeviceItems[0].Addresses[0].Length; tagnumber++)
                                {
                                    theET200SPIOTagTable.Tags.Create(newModule.Name + "_" + tagnumber.ToString(), "BOOL", "%I" + theIOAddress.ToString() + "." + tagnumber.ToString());
                                }
                            }

                            break;

                        case "DQ8":

                            for (int index = 0; index < int.Parse(theET200SPModule.SubItems[1].Text); index++)
                            {
                                DeviceItem newModule = theET200SPStation.DeviceItems[0].PlugNew("OrderNumber:6ES7 132-6BF01-0BA0/V0.0", theET200SPStation.Name + "_DQ8_" + index.ToString(), slot);
                                int theIOAddress = newModule.DeviceItems[0].Addresses[0].StartAddress = int.Parse(startIOAddressofET200SP.Text) + addressOffset;
                                slot += 1;
                                addressOffset += newModule.DeviceItems[0].Addresses[0].Length / 8;

                                for (int tagnumber = 0; tagnumber < newModule.DeviceItems[0].Addresses[0].Length; tagnumber++)
                                {
                                    theET200SPIOTagTable.Tags.Create(newModule.Name + "_" + tagnumber.ToString(), "BOOL", "%Q" + theIOAddress.ToString() + "." + tagnumber.ToString());
                                }
                            }

                            break;

                        case "AI2":

                            for (int index = 0; index < int.Parse(theET200SPModule.SubItems[1].Text); index++)
                            {
                                DeviceItem newModule = theET200SPStation.DeviceItems[0].PlugNew("OrderNumber:6ES7134-6HB00-0CA1/V2.0", theET200SPStation.Name + "_AI2_" + index.ToString(), slot);
                                int theIOAddress = newModule.DeviceItems[0].Addresses[0].StartAddress = int.Parse(startIOAddressofET200SP.Text) + addressOffset;
                                slot += 1;
                                addressOffset += newModule.DeviceItems[0].Addresses[0].Length / 8;

                                for (int tagnumber = 0; tagnumber < newModule.DeviceItems[0].Addresses[0].Length / 16; tagnumber++)
                                {
                                    theET200SPIOTagTable.Tags.Create(newModule.Name + "_" + tagnumber.ToString(), "WORD", "%IW" + (theIOAddress + tagnumber * 2).ToString());
                                }
                            }

                            break;

                        case "AO2":

                            for (int index = 0; index < int.Parse(theET200SPModule.SubItems[1].Text); index++)
                            {
                                DeviceItem newModule = theET200SPStation.DeviceItems[0].PlugNew("OrderNumber:6ES7135-6HB00-0CA1/V1.0", theET200SPStation.Name + "_AQ2_" + index.ToString(), slot);
                                int theIOAddress = newModule.DeviceItems[0].Addresses[0].StartAddress = int.Parse(startIOAddressofET200SP.Text) + addressOffset;
                                slot += 1;
                                addressOffset += newModule.DeviceItems[0].Addresses[0].Length / 8;

                                for (int tagnumber = 0; tagnumber < newModule.DeviceItems[0].Addresses[0].Length / 16; tagnumber++)
                                {
                                    theET200SPIOTagTable.Tags.Create(newModule.Name + "_" + tagnumber.ToString(), "WORD", "%QW" + (theIOAddress + tagnumber * 2).ToString());
                                }
                            }

                            break;

                        case "F-DI8":

                            for (int index = 0; index < int.Parse(theET200SPModule.SubItems[1].Text); index++)
                            {
                                DeviceItem newModule = theET200SPStation.DeviceItems[0].PlugNew("OrderNumber:6ES7136-6BA01-0CA0/V2.0", theET200SPStation.Name + "_FDI8_" + index.ToString(), slot);
                                int theIOAddress = newModule.DeviceItems[0].Addresses[0].StartAddress = int.Parse(startIOAddressofET200SP.Text) + addressOffset;
                                slot += 1;
                                addressOffset += newModule.DeviceItems[0].Addresses[0].Length / 8;

                                for (int tagnumber = 0; tagnumber < 8; tagnumber++)
                                {
                                    theET200SPIOTagTable.Tags.Create(newModule.Name + "_" + tagnumber.ToString(), "BOOL", "%I" + theIOAddress.ToString() + "." + tagnumber.ToString());
                                }
                            }

                            break;

                        case "F-DQ8":

                            for (int index = 0; index < int.Parse(theET200SPModule.SubItems[1].Text); index++)
                            {
                                DeviceItem newModule = theET200SPStation.DeviceItems[0].PlugNew("OrderNumber:6ES7136-6DC00-0CA0/V1.0", theET200SPStation.Name + "_FDQ8_" + index.ToString(), slot);
                                int theIOAddress = newModule.DeviceItems[0].Addresses[0].StartAddress = int.Parse(startIOAddressofET200SP.Text) + addressOffset;
                                slot += 1;
                                addressOffset += newModule.DeviceItems[0].Addresses[0].Length / 8;

                                for (int tagnumber = 0; tagnumber < 8; tagnumber++)
                                {
                                    theET200SPIOTagTable.Tags.Create(newModule.Name + "_" + tagnumber.ToString(), "BOOL", "%Q" + theIOAddress.ToString() + "." + tagnumber.ToString());
                                }
                            }
                            break;
                    }
                }
            }
        }
        private void UpdateET200SPList_Button(object sender, EventArgs e)
        {
            if (et200SPConfigList.Items.Count > 0)
            {
                et200SPConfigList.SelectedItems[0].SubItems[1].Text = numberofET200SPModulestoCreate.Text;
                et200SPConfigList.SelectedItems[0].SubItems[2].Text = startIOAddressofET200SP.Text;
            }
        }

        private void NumberofET200SPModulestoCreate_Changed(object sender, EventArgs e)
        {
            int number = 0;
            if (!string.IsNullOrEmpty(numberofET200SPModulestoCreate.Text))
            {
                if (!int.TryParse(numberofET200SPModulestoCreate.Text, out number))
                {
                    numberofET200SPModulestoCreate.Text = "0";
                    MessageBox.Show("Please input integer number");
                }
                else if (number < 0)
                {
                    numberofET200SPModulestoCreate.Text = "0";
                    MessageBox.Show("Please input a positive integer number");
                }
            }
        }

        private void StartIOAddressofEt200SP_Changed(object sender, EventArgs e)
        {
            int number = 0;
            if (!string.IsNullOrEmpty(startIOAddressofET200SP.Text))
            {
                if (!int.TryParse(startIOAddressofET200SP.Text, out number))
                {
                    startIOAddressofET200SP.Text = "0";
                    MessageBox.Show("Please input integer number");
                }
                else if (number < 0)
                {
                    startIOAddressofET200SP.Text = "0";
                    MessageBox.Show("Please input a positive integer number");
                }
            }
        }

        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tiaportal != null && tiaportal.Projects.Count > 0)
            {
                PlcSoftware thePLCSoftware = tiaportal.Projects[0].Devices.Find("WZDemoPLCX").DeviceItems[1].GetService<SoftwareContainer>().Software as PlcSoftware;

                PlcBlock theBlock = thePLCSoftware.BlockGroup.Blocks.Find("Main");
                theBlock.ShowInEditor();

                //SendKeys.Send("This is a Text");
            }
        }
    }
    public class PromptWindow : IDisposable
    {
        private Form prompt { get; set; }
        public string Result { get; }

        public PromptWindow(string text, string caption)
        {
            Result = ShowDialog(text, caption);
        }
        //use a using statement
        private string ShowDialog(string text, string caption)
        {
            prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };

            System.Windows.Forms.Label textLabel = new System.Windows.Forms.Label()
            {
                Left = 50,
                Top = 20,
                Text = text,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            TextBox textBox = new TextBox()
            {
                Left = 50,
                Top = 50,
                Width = 400
            };

            Button confirmation = new Button()
            {
                Text = "Ok",
                Left = 350,
                Width = 100,
                Top = 75,
                DialogResult = DialogResult.OK
            };

            confirmation.Click += (sender, e) => {prompt.Close();};
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public void Dispose()
        {
            //See Marcus comment
            if (prompt != null)
            {
                prompt.Dispose();
            }
        }
    }
}
