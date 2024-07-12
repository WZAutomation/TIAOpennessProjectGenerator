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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siemens.Engineering;
using Siemens.Engineering.HW;
using Siemens.Engineering.HW.Features;
using Siemens.Engineering.Library;
using Siemens.Engineering.Library.MasterCopies;
using Siemens.Engineering.Library.Types;
using Siemens.Engineering.SW;
using Siemens.Engineering.SW.Blocks;

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
            UpdateUserHint(toolNavigator.SelectedIndex);
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

        private void UpdateUserHint(int tabindex)
        {
            userHints.Clear();
            switch (tabindex)
            {
                case 0:
                    userHints.Text = "Please select a TIA Portal instance to continue.";
                    break;
                case 1:
                    userHints.Text = "Please select or create a new project for the ensuing program and hardware generation.";
                    break;
                case 2:
                    userHints.Text = "Please open the library that you want to use for the ensuing program and hardware generation.";
                    break;
                case 3:
                    userHints.Text = "Please specify the hardware mastercopy for the hardware configuration generation and their number and properties.";
                    break;
                case 4:
                    userHints.Text = "Please specify the software for generation and their number.";
                    break;
                default:
                    userHints.Text = "Error, please restart.";
                    break;
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

        private void ToolNavigatorIndexChanged(object sender, EventArgs e)
        {
            UpdateUserHint(toolNavigator.SelectedIndex);
            
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


                tiaportal.Projects.Create(new DirectoryInfo(projectPathText.Text), "TIAOpennessGeneratedProject");
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
                        else if (theMasterCopy.Name.Contains("HMI") || theMasterCopy.Name.Contains("ET200ECO"))
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
                        if (createdDevice.Name.Contains("ET 200eco"))
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
    }
}
