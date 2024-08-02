namespace TIAOpennessProjectGenerator
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.toolNavigator = new System.Windows.Forms.TabControl();
            this.startTIATab = new System.Windows.Forms.TabPage();
            this.tiaPortalInstanceList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createNewInstance = new System.Windows.Forms.Button();
            this.linkSelectedInstance = new System.Windows.Forms.Button();
            this.searchTIAPortalInsstance = new System.Windows.Forms.Button();
            this.openProjectTab = new System.Windows.Forms.TabPage();
            this.createProject = new System.Windows.Forms.Button();
            this.openProject = new System.Windows.Forms.Button();
            this.projectPathText = new System.Windows.Forms.TextBox();
            this.browseForProject = new System.Windows.Forms.Button();
            this.openLibraryTab = new System.Windows.Forms.TabPage();
            this.openLibrary = new System.Windows.Forms.Button();
            this.browseForLibrary = new System.Windows.Forms.Button();
            this.libraryPathText = new System.Windows.Forms.TextBox();
            this.hwConfigTab = new System.Windows.Forms.TabPage();
            this.updateHWItem = new System.Windows.Forms.Button();
            this.masterCopyStartIPAddress = new System.Windows.Forms.TextBox();
            this.masterCopyNumberToCreate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.configHW = new System.Windows.Forms.Button();
            this.hwListForUser = new System.Windows.Forms.ListView();
            this.Colunm1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colunm2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colunm3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addProgramTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.startDBNumber = new System.Windows.Forms.Label();
            this.numberOfInstancesToCreate = new System.Windows.Forms.Label();
            this.addSW_Button = new System.Windows.Forms.Button();
            this.updateSWList_Button = new System.Windows.Forms.Button();
            this.typeInstanceDBStartNumber = new System.Windows.Forms.TextBox();
            this.numberofInstanceDBstoCreate = new System.Windows.Forms.TextBox();
            this.swListForUser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s120Config = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.s120StationsList = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s120ConfigList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.configS120Modules_Button = new System.Windows.Forms.Button();
            this.updateS120ModuleList_Button = new System.Windows.Forms.Button();
            this.startIOAddressofS120Module = new System.Windows.Forms.TextBox();
            this.numberofS120ModulestoCreate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.et200SPConfig = new System.Windows.Forms.TabPage();
            this.et200SPStationList = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.startIOAddressofET200SP = new System.Windows.Forms.TextBox();
            this.numberofET200SPModulestoCreate = new System.Windows.Forms.TextBox();
            this.configET200SP_Button = new System.Windows.Forms.Button();
            this.updateET200SPList_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.et200SPConfigList = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.navePrev = new System.Windows.Forms.Button();
            this.naveNext = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolNavigator.SuspendLayout();
            this.startTIATab.SuspendLayout();
            this.openProjectTab.SuspendLayout();
            this.openLibraryTab.SuspendLayout();
            this.hwConfigTab.SuspendLayout();
            this.addProgramTab.SuspendLayout();
            this.s120Config.SuspendLayout();
            this.et200SPConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolNavigator
            // 
            this.toolNavigator.Controls.Add(this.startTIATab);
            this.toolNavigator.Controls.Add(this.openProjectTab);
            this.toolNavigator.Controls.Add(this.openLibraryTab);
            this.toolNavigator.Controls.Add(this.hwConfigTab);
            this.toolNavigator.Controls.Add(this.addProgramTab);
            this.toolNavigator.Controls.Add(this.s120Config);
            this.toolNavigator.Controls.Add(this.et200SPConfig);
            this.toolNavigator.Location = new System.Drawing.Point(0, 0);
            this.toolNavigator.Name = "toolNavigator";
            this.toolNavigator.SelectedIndex = 0;
            this.toolNavigator.Size = new System.Drawing.Size(644, 451);
            this.toolNavigator.TabIndex = 0;
            this.toolNavigator.SelectedIndexChanged += new System.EventHandler(this.ToolNavigatorIndexChanged);
            // 
            // startTIATab
            // 
            this.startTIATab.Controls.Add(this.tiaPortalInstanceList);
            this.startTIATab.Controls.Add(this.createNewInstance);
            this.startTIATab.Controls.Add(this.linkSelectedInstance);
            this.startTIATab.Controls.Add(this.searchTIAPortalInsstance);
            this.startTIATab.Location = new System.Drawing.Point(4, 22);
            this.startTIATab.Name = "startTIATab";
            this.startTIATab.Padding = new System.Windows.Forms.Padding(3);
            this.startTIATab.Size = new System.Drawing.Size(636, 425);
            this.startTIATab.TabIndex = 0;
            this.startTIATab.Tag = "";
            this.startTIATab.Text = "Link TIA";
            this.startTIATab.UseVisualStyleBackColor = true;
            // 
            // tiaPortalInstanceList
            // 
            this.tiaPortalInstanceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.projectName});
            this.tiaPortalInstanceList.HideSelection = false;
            this.tiaPortalInstanceList.Location = new System.Drawing.Point(8, 64);
            this.tiaPortalInstanceList.MultiSelect = false;
            this.tiaPortalInstanceList.Name = "tiaPortalInstanceList";
            this.tiaPortalInstanceList.Size = new System.Drawing.Size(622, 213);
            this.tiaPortalInstanceList.TabIndex = 3;
            this.tiaPortalInstanceList.UseCompatibleStateImageBehavior = false;
            this.tiaPortalInstanceList.View = System.Windows.Forms.View.Details;
            this.tiaPortalInstanceList.SelectedIndexChanged += new System.EventHandler(this.tiaPortalInstanceList_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "TIA Portal ID";
            this.id.Width = 107;
            // 
            // projectName
            // 
            this.projectName.Text = "Project Name";
            this.projectName.Width = 270;
            // 
            // createNewInstance
            // 
            this.createNewInstance.Location = new System.Drawing.Point(509, 6);
            this.createNewInstance.Name = "createNewInstance";
            this.createNewInstance.Size = new System.Drawing.Size(75, 40);
            this.createNewInstance.TabIndex = 2;
            this.createNewInstance.Text = "Start New";
            this.createNewInstance.UseVisualStyleBackColor = true;
            this.createNewInstance.Click += new System.EventHandler(this.CreateNewInstance);
            // 
            // linkSelectedInstance
            // 
            this.linkSelectedInstance.Location = new System.Drawing.Point(158, 6);
            this.linkSelectedInstance.Name = "linkSelectedInstance";
            this.linkSelectedInstance.Size = new System.Drawing.Size(75, 40);
            this.linkSelectedInstance.TabIndex = 1;
            this.linkSelectedInstance.Text = "Link Selected";
            this.linkSelectedInstance.UseVisualStyleBackColor = true;
            this.linkSelectedInstance.Click += new System.EventHandler(this.LinkSelectedInstance);
            // 
            // searchTIAPortalInsstance
            // 
            this.searchTIAPortalInsstance.Location = new System.Drawing.Point(52, 6);
            this.searchTIAPortalInsstance.Name = "searchTIAPortalInsstance";
            this.searchTIAPortalInsstance.Size = new System.Drawing.Size(75, 40);
            this.searchTIAPortalInsstance.TabIndex = 0;
            this.searchTIAPortalInsstance.Text = "Search for TIA Portal";
            this.searchTIAPortalInsstance.UseVisualStyleBackColor = true;
            this.searchTIAPortalInsstance.Click += new System.EventHandler(this.SearchTIAPortalInsstance);
            // 
            // openProjectTab
            // 
            this.openProjectTab.Controls.Add(this.createProject);
            this.openProjectTab.Controls.Add(this.openProject);
            this.openProjectTab.Controls.Add(this.projectPathText);
            this.openProjectTab.Controls.Add(this.browseForProject);
            this.openProjectTab.Location = new System.Drawing.Point(4, 22);
            this.openProjectTab.Name = "openProjectTab";
            this.openProjectTab.Padding = new System.Windows.Forms.Padding(3);
            this.openProjectTab.Size = new System.Drawing.Size(636, 425);
            this.openProjectTab.TabIndex = 1;
            this.openProjectTab.Text = "Open Project";
            this.openProjectTab.UseVisualStyleBackColor = true;
            // 
            // createProject
            // 
            this.createProject.Location = new System.Drawing.Point(155, 45);
            this.createProject.Name = "createProject";
            this.createProject.Size = new System.Drawing.Size(75, 40);
            this.createProject.TabIndex = 3;
            this.createProject.Text = "Create Project";
            this.createProject.UseVisualStyleBackColor = true;
            this.createProject.Click += new System.EventHandler(this.CreateProject);
            // 
            // openProject
            // 
            this.openProject.Location = new System.Drawing.Point(52, 45);
            this.openProject.Name = "openProject";
            this.openProject.Size = new System.Drawing.Size(75, 40);
            this.openProject.TabIndex = 2;
            this.openProject.Text = "Open Project";
            this.openProject.UseVisualStyleBackColor = true;
            this.openProject.Click += new System.EventHandler(this.OpenProject);
            // 
            // projectPathText
            // 
            this.projectPathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectPathText.Location = new System.Drawing.Point(8, 16);
            this.projectPathText.Name = "projectPathText";
            this.projectPathText.Size = new System.Drawing.Size(622, 21);
            this.projectPathText.TabIndex = 1;
            // 
            // browseForProject
            // 
            this.browseForProject.Location = new System.Drawing.Point(509, 45);
            this.browseForProject.Name = "browseForProject";
            this.browseForProject.Size = new System.Drawing.Size(75, 40);
            this.browseForProject.TabIndex = 0;
            this.browseForProject.Text = "Browse";
            this.browseForProject.UseVisualStyleBackColor = true;
            this.browseForProject.Click += new System.EventHandler(this.BrowseForProject);
            // 
            // openLibraryTab
            // 
            this.openLibraryTab.Controls.Add(this.openLibrary);
            this.openLibraryTab.Controls.Add(this.browseForLibrary);
            this.openLibraryTab.Controls.Add(this.libraryPathText);
            this.openLibraryTab.Location = new System.Drawing.Point(4, 22);
            this.openLibraryTab.Name = "openLibraryTab";
            this.openLibraryTab.Padding = new System.Windows.Forms.Padding(3);
            this.openLibraryTab.Size = new System.Drawing.Size(636, 425);
            this.openLibraryTab.TabIndex = 2;
            this.openLibraryTab.Text = "Open Library";
            this.openLibraryTab.UseVisualStyleBackColor = true;
            // 
            // openLibrary
            // 
            this.openLibrary.Location = new System.Drawing.Point(52, 45);
            this.openLibrary.Name = "openLibrary";
            this.openLibrary.Size = new System.Drawing.Size(75, 40);
            this.openLibrary.TabIndex = 3;
            this.openLibrary.Text = "Open Library";
            this.openLibrary.UseVisualStyleBackColor = true;
            this.openLibrary.Click += new System.EventHandler(this.OpenLibrary);
            // 
            // browseForLibrary
            // 
            this.browseForLibrary.Location = new System.Drawing.Point(509, 45);
            this.browseForLibrary.Name = "browseForLibrary";
            this.browseForLibrary.Size = new System.Drawing.Size(75, 40);
            this.browseForLibrary.TabIndex = 2;
            this.browseForLibrary.Text = "Browse";
            this.browseForLibrary.UseVisualStyleBackColor = true;
            this.browseForLibrary.Click += new System.EventHandler(this.BrowseForLibrary);
            // 
            // libraryPathText
            // 
            this.libraryPathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.libraryPathText.Location = new System.Drawing.Point(8, 17);
            this.libraryPathText.Name = "libraryPathText";
            this.libraryPathText.Size = new System.Drawing.Size(622, 21);
            this.libraryPathText.TabIndex = 1;
            // 
            // hwConfigTab
            // 
            this.hwConfigTab.Controls.Add(this.updateHWItem);
            this.hwConfigTab.Controls.Add(this.masterCopyStartIPAddress);
            this.hwConfigTab.Controls.Add(this.masterCopyNumberToCreate);
            this.hwConfigTab.Controls.Add(this.label2);
            this.hwConfigTab.Controls.Add(this.label1);
            this.hwConfigTab.Controls.Add(this.configHW);
            this.hwConfigTab.Controls.Add(this.hwListForUser);
            this.hwConfigTab.Location = new System.Drawing.Point(4, 22);
            this.hwConfigTab.Name = "hwConfigTab";
            this.hwConfigTab.Size = new System.Drawing.Size(636, 425);
            this.hwConfigTab.TabIndex = 3;
            this.hwConfigTab.Text = "Config HW";
            this.hwConfigTab.UseVisualStyleBackColor = true;
            // 
            // updateHWItem
            // 
            this.updateHWItem.Location = new System.Drawing.Point(407, 6);
            this.updateHWItem.Name = "updateHWItem";
            this.updateHWItem.Size = new System.Drawing.Size(75, 40);
            this.updateHWItem.TabIndex = 6;
            this.updateHWItem.Text = "Update HW Item";
            this.updateHWItem.UseVisualStyleBackColor = true;
            this.updateHWItem.Click += new System.EventHandler(this.UpdateHWItem);
            // 
            // masterCopyStartIPAddress
            // 
            this.masterCopyStartIPAddress.Location = new System.Drawing.Point(125, 25);
            this.masterCopyStartIPAddress.Name = "masterCopyStartIPAddress";
            this.masterCopyStartIPAddress.Size = new System.Drawing.Size(100, 21);
            this.masterCopyStartIPAddress.TabIndex = 5;
            this.masterCopyStartIPAddress.Validated += new System.EventHandler(this.MasterCopyStartIPAddress_Changed);
            // 
            // masterCopyNumberToCreate
            // 
            this.masterCopyNumberToCreate.Location = new System.Drawing.Point(9, 25);
            this.masterCopyNumberToCreate.Name = "masterCopyNumberToCreate";
            this.masterCopyNumberToCreate.Size = new System.Drawing.Size(100, 21);
            this.masterCopyNumberToCreate.TabIndex = 4;
            this.masterCopyNumberToCreate.Validated += new System.EventHandler(this.MasterCopyNumberToCreate_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number to Create";
            // 
            // configHW
            // 
            this.configHW.Location = new System.Drawing.Point(509, 6);
            this.configHW.Name = "configHW";
            this.configHW.Size = new System.Drawing.Size(75, 40);
            this.configHW.TabIndex = 1;
            this.configHW.Text = "ConfigHW";
            this.configHW.UseVisualStyleBackColor = true;
            this.configHW.Click += new System.EventHandler(this.ConfigHW);
            // 
            // hwListForUser
            // 
            this.hwListForUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Colunm1,
            this.Colunm2,
            this.Colunm3});
            this.hwListForUser.GridLines = true;
            this.hwListForUser.HideSelection = false;
            this.hwListForUser.LabelEdit = true;
            this.hwListForUser.Location = new System.Drawing.Point(8, 52);
            this.hwListForUser.MultiSelect = false;
            this.hwListForUser.Name = "hwListForUser";
            this.hwListForUser.Size = new System.Drawing.Size(623, 370);
            this.hwListForUser.TabIndex = 0;
            this.hwListForUser.UseCompatibleStateImageBehavior = false;
            this.hwListForUser.View = System.Windows.Forms.View.Details;
            this.hwListForUser.SelectedIndexChanged += new System.EventHandler(this.HWListForUser_SelectedIndexChanged);
            // 
            // Colunm1
            // 
            this.Colunm1.Text = "Hardware Master Copy";
            this.Colunm1.Width = 138;
            // 
            // Colunm2
            // 
            this.Colunm2.Text = "Number to Create";
            this.Colunm2.Width = 117;
            // 
            // Colunm3
            // 
            this.Colunm3.Text = "Start IP Address";
            this.Colunm3.Width = 146;
            // 
            // addProgramTab
            // 
            this.addProgramTab.Controls.Add(this.button1);
            this.addProgramTab.Controls.Add(this.startDBNumber);
            this.addProgramTab.Controls.Add(this.numberOfInstancesToCreate);
            this.addProgramTab.Controls.Add(this.addSW_Button);
            this.addProgramTab.Controls.Add(this.updateSWList_Button);
            this.addProgramTab.Controls.Add(this.typeInstanceDBStartNumber);
            this.addProgramTab.Controls.Add(this.numberofInstanceDBstoCreate);
            this.addProgramTab.Controls.Add(this.swListForUser);
            this.addProgramTab.Location = new System.Drawing.Point(4, 22);
            this.addProgramTab.Name = "addProgramTab";
            this.addProgramTab.Size = new System.Drawing.Size(636, 425);
            this.addProgramTab.TabIndex = 4;
            this.addProgramTab.Text = "Add Software";
            this.addProgramTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // startDBNumber
            // 
            this.startDBNumber.AutoSize = true;
            this.startDBNumber.Location = new System.Drawing.Point(128, 6);
            this.startDBNumber.Name = "startDBNumber";
            this.startDBNumber.Size = new System.Drawing.Size(95, 12);
            this.startDBNumber.TabIndex = 6;
            this.startDBNumber.Text = "Start DB Number";
            // 
            // numberOfInstancesToCreate
            // 
            this.numberOfInstancesToCreate.AutoSize = true;
            this.numberOfInstancesToCreate.Location = new System.Drawing.Point(9, 6);
            this.numberOfInstancesToCreate.Name = "numberOfInstancesToCreate";
            this.numberOfInstancesToCreate.Size = new System.Drawing.Size(101, 12);
            this.numberOfInstancesToCreate.TabIndex = 5;
            this.numberOfInstancesToCreate.Text = "Number to Create";
            // 
            // addSW_Button
            // 
            this.addSW_Button.Location = new System.Drawing.Point(509, 6);
            this.addSW_Button.Name = "addSW_Button";
            this.addSW_Button.Size = new System.Drawing.Size(75, 40);
            this.addSW_Button.TabIndex = 4;
            this.addSW_Button.Text = "Add Software";
            this.addSW_Button.UseVisualStyleBackColor = true;
            this.addSW_Button.Click += new System.EventHandler(this.AddSW_Button);
            // 
            // updateSWList_Button
            // 
            this.updateSWList_Button.Location = new System.Drawing.Point(407, 6);
            this.updateSWList_Button.Name = "updateSWList_Button";
            this.updateSWList_Button.Size = new System.Drawing.Size(75, 40);
            this.updateSWList_Button.TabIndex = 3;
            this.updateSWList_Button.Text = "Update SW List";
            this.updateSWList_Button.UseVisualStyleBackColor = true;
            this.updateSWList_Button.Click += new System.EventHandler(this.UpdateSWList_Button);
            // 
            // typeInstanceDBStartNumber
            // 
            this.typeInstanceDBStartNumber.Location = new System.Drawing.Point(125, 25);
            this.typeInstanceDBStartNumber.Name = "typeInstanceDBStartNumber";
            this.typeInstanceDBStartNumber.Size = new System.Drawing.Size(100, 21);
            this.typeInstanceDBStartNumber.TabIndex = 2;
            this.typeInstanceDBStartNumber.Validated += new System.EventHandler(this.TypeInstanceDBStartNumber_Changed);
            // 
            // numberofInstanceDBstoCreate
            // 
            this.numberofInstanceDBstoCreate.Location = new System.Drawing.Point(9, 25);
            this.numberofInstanceDBstoCreate.Name = "numberofInstanceDBstoCreate";
            this.numberofInstanceDBstoCreate.Size = new System.Drawing.Size(100, 21);
            this.numberofInstanceDBstoCreate.TabIndex = 1;
            this.numberofInstanceDBstoCreate.Validated += new System.EventHandler(this.NumberofInstanceDBstoCreate_Changed);
            // 
            // swListForUser
            // 
            this.swListForUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.swListForUser.GridLines = true;
            this.swListForUser.HideSelection = false;
            this.swListForUser.Location = new System.Drawing.Point(8, 52);
            this.swListForUser.MultiSelect = false;
            this.swListForUser.Name = "swListForUser";
            this.swListForUser.Size = new System.Drawing.Size(623, 168);
            this.swListForUser.TabIndex = 0;
            this.swListForUser.UseCompatibleStateImageBehavior = false;
            this.swListForUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type Name";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number of Instances";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start DB Number";
            this.columnHeader3.Width = 112;
            // 
            // s120Config
            // 
            this.s120Config.Controls.Add(this.label7);
            this.s120Config.Controls.Add(this.s120StationsList);
            this.s120Config.Controls.Add(this.s120ConfigList);
            this.s120Config.Controls.Add(this.configS120Modules_Button);
            this.s120Config.Controls.Add(this.updateS120ModuleList_Button);
            this.s120Config.Controls.Add(this.startIOAddressofS120Module);
            this.s120Config.Controls.Add(this.numberofS120ModulestoCreate);
            this.s120Config.Controls.Add(this.label4);
            this.s120Config.Controls.Add(this.label3);
            this.s120Config.Location = new System.Drawing.Point(4, 22);
            this.s120Config.Name = "s120Config";
            this.s120Config.Size = new System.Drawing.Size(636, 425);
            this.s120Config.TabIndex = 5;
            this.s120Config.Text = "S120 Config";
            this.s120Config.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "S120 Stations to Config";
            // 
            // s120StationsList
            // 
            this.s120StationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11});
            this.s120StationsList.GridLines = true;
            this.s120StationsList.HideSelection = false;
            this.s120StationsList.Location = new System.Drawing.Point(426, 52);
            this.s120StationsList.MultiSelect = false;
            this.s120StationsList.Name = "s120StationsList";
            this.s120StationsList.Size = new System.Drawing.Size(205, 370);
            this.s120StationsList.TabIndex = 7;
            this.s120StationsList.UseCompatibleStateImageBehavior = false;
            this.s120StationsList.View = System.Windows.Forms.View.Details;
            this.s120StationsList.SelectedIndexChanged += new System.EventHandler(this.S120StationsList_SelectedIndexChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "S120 Stations";
            this.columnHeader11.Width = 195;
            // 
            // s120ConfigList
            // 
            this.s120ConfigList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.s120ConfigList.GridLines = true;
            this.s120ConfigList.HideSelection = false;
            this.s120ConfigList.Location = new System.Drawing.Point(8, 52);
            this.s120ConfigList.MultiSelect = false;
            this.s120ConfigList.Name = "s120ConfigList";
            this.s120ConfigList.Size = new System.Drawing.Size(409, 370);
            this.s120ConfigList.TabIndex = 6;
            this.s120ConfigList.UseCompatibleStateImageBehavior = false;
            this.s120ConfigList.View = System.Windows.Forms.View.Details;
            this.s120ConfigList.SelectedIndexChanged += new System.EventHandler(this.S120ConfigList_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Number to Create";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Start IO Address";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Telegram";
            this.columnHeader7.Width = 64;
            // 
            // configS120Modules_Button
            // 
            this.configS120Modules_Button.Location = new System.Drawing.Point(342, 6);
            this.configS120Modules_Button.Name = "configS120Modules_Button";
            this.configS120Modules_Button.Size = new System.Drawing.Size(75, 40);
            this.configS120Modules_Button.TabIndex = 5;
            this.configS120Modules_Button.Text = "Config S120";
            this.configS120Modules_Button.UseVisualStyleBackColor = true;
            this.configS120Modules_Button.Click += new System.EventHandler(this.ConfigS120Modules_Button);
            // 
            // updateS120ModuleList_Button
            // 
            this.updateS120ModuleList_Button.Location = new System.Drawing.Point(240, 6);
            this.updateS120ModuleList_Button.Name = "updateS120ModuleList_Button";
            this.updateS120ModuleList_Button.Size = new System.Drawing.Size(75, 40);
            this.updateS120ModuleList_Button.TabIndex = 4;
            this.updateS120ModuleList_Button.Text = "Update List";
            this.updateS120ModuleList_Button.UseVisualStyleBackColor = true;
            this.updateS120ModuleList_Button.Click += new System.EventHandler(this.UpdateS120ModuleList_Button);
            // 
            // startIOAddressofS120Module
            // 
            this.startIOAddressofS120Module.Location = new System.Drawing.Point(125, 25);
            this.startIOAddressofS120Module.Name = "startIOAddressofS120Module";
            this.startIOAddressofS120Module.Size = new System.Drawing.Size(100, 21);
            this.startIOAddressofS120Module.TabIndex = 3;
            this.startIOAddressofS120Module.Validated += new System.EventHandler(this.StartIOAddressofS120Module_Changed);
            // 
            // numberofS120ModulestoCreate
            // 
            this.numberofS120ModulestoCreate.Location = new System.Drawing.Point(9, 25);
            this.numberofS120ModulestoCreate.Name = "numberofS120ModulestoCreate";
            this.numberofS120ModulestoCreate.Size = new System.Drawing.Size(100, 21);
            this.numberofS120ModulestoCreate.TabIndex = 2;
            this.numberofS120ModulestoCreate.Validated += new System.EventHandler(this.NumberofS120ModulestoCreate_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "PLC IO Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number to Create";
            // 
            // et200SPConfig
            // 
            this.et200SPConfig.Controls.Add(this.et200SPStationList);
            this.et200SPConfig.Controls.Add(this.label8);
            this.et200SPConfig.Controls.Add(this.startIOAddressofET200SP);
            this.et200SPConfig.Controls.Add(this.numberofET200SPModulestoCreate);
            this.et200SPConfig.Controls.Add(this.configET200SP_Button);
            this.et200SPConfig.Controls.Add(this.updateET200SPList_Button);
            this.et200SPConfig.Controls.Add(this.label6);
            this.et200SPConfig.Controls.Add(this.label5);
            this.et200SPConfig.Controls.Add(this.et200SPConfigList);
            this.et200SPConfig.Location = new System.Drawing.Point(4, 22);
            this.et200SPConfig.Name = "et200SPConfig";
            this.et200SPConfig.Padding = new System.Windows.Forms.Padding(3);
            this.et200SPConfig.Size = new System.Drawing.Size(636, 425);
            this.et200SPConfig.TabIndex = 6;
            this.et200SPConfig.Text = "ET200SP Config";
            this.et200SPConfig.UseVisualStyleBackColor = true;
            // 
            // et200SPStationList
            // 
            this.et200SPStationList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.et200SPStationList.GridLines = true;
            this.et200SPStationList.HideSelection = false;
            this.et200SPStationList.Location = new System.Drawing.Point(426, 52);
            this.et200SPStationList.MultiSelect = false;
            this.et200SPStationList.Name = "et200SPStationList";
            this.et200SPStationList.Size = new System.Drawing.Size(205, 370);
            this.et200SPStationList.TabIndex = 8;
            this.et200SPStationList.UseCompatibleStateImageBehavior = false;
            this.et200SPStationList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ET200SP Stations";
            this.columnHeader12.Width = 199;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "ET200SP Stations to Config";
            // 
            // startIOAddressofET200SP
            // 
            this.startIOAddressofET200SP.Location = new System.Drawing.Point(125, 25);
            this.startIOAddressofET200SP.Name = "startIOAddressofET200SP";
            this.startIOAddressofET200SP.Size = new System.Drawing.Size(100, 21);
            this.startIOAddressofET200SP.TabIndex = 6;
            this.startIOAddressofET200SP.Validated += new System.EventHandler(this.StartIOAddressofEt200SP_Changed);
            // 
            // numberofET200SPModulestoCreate
            // 
            this.numberofET200SPModulestoCreate.Location = new System.Drawing.Point(9, 25);
            this.numberofET200SPModulestoCreate.Name = "numberofET200SPModulestoCreate";
            this.numberofET200SPModulestoCreate.Size = new System.Drawing.Size(100, 21);
            this.numberofET200SPModulestoCreate.TabIndex = 5;
            this.numberofET200SPModulestoCreate.Validated += new System.EventHandler(this.NumberofET200SPModulestoCreate_Changed);
            // 
            // configET200SP_Button
            // 
            this.configET200SP_Button.Location = new System.Drawing.Point(342, 6);
            this.configET200SP_Button.Name = "configET200SP_Button";
            this.configET200SP_Button.Size = new System.Drawing.Size(75, 40);
            this.configET200SP_Button.TabIndex = 4;
            this.configET200SP_Button.Text = "Config ET200SP";
            this.configET200SP_Button.UseVisualStyleBackColor = true;
            this.configET200SP_Button.Click += new System.EventHandler(this.ConfigET200SP_Button);
            // 
            // updateET200SPList_Button
            // 
            this.updateET200SPList_Button.Location = new System.Drawing.Point(240, 6);
            this.updateET200SPList_Button.Name = "updateET200SPList_Button";
            this.updateET200SPList_Button.Size = new System.Drawing.Size(75, 40);
            this.updateET200SPList_Button.TabIndex = 3;
            this.updateET200SPList_Button.Text = "Update List";
            this.updateET200SPList_Button.UseVisualStyleBackColor = true;
            this.updateET200SPList_Button.Click += new System.EventHandler(this.UpdateET200SPList_Button);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "PLC IO Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Number to Create";
            // 
            // et200SPConfigList
            // 
            this.et200SPConfigList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.et200SPConfigList.GridLines = true;
            this.et200SPConfigList.HideSelection = false;
            this.et200SPConfigList.Location = new System.Drawing.Point(8, 52);
            this.et200SPConfigList.MultiSelect = false;
            this.et200SPConfigList.Name = "et200SPConfigList";
            this.et200SPConfigList.Size = new System.Drawing.Size(409, 370);
            this.et200SPConfigList.TabIndex = 0;
            this.et200SPConfigList.UseCompatibleStateImageBehavior = false;
            this.et200SPConfigList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            this.columnHeader8.Width = 82;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Number to Create";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Start IO Address";
            this.columnHeader10.Width = 167;
            // 
            // navePrev
            // 
            this.navePrev.Location = new System.Drawing.Point(56, 457);
            this.navePrev.Name = "navePrev";
            this.navePrev.Size = new System.Drawing.Size(75, 40);
            this.navePrev.TabIndex = 1;
            this.navePrev.Text = "Prev";
            this.navePrev.UseVisualStyleBackColor = true;
            this.navePrev.Click += new System.EventHandler(this.NavePrev);
            // 
            // naveNext
            // 
            this.naveNext.Location = new System.Drawing.Point(513, 457);
            this.naveNext.Name = "naveNext";
            this.naveNext.Size = new System.Drawing.Size(75, 40);
            this.naveNext.TabIndex = 2;
            this.naveNext.Text = "Next";
            this.naveNext.UseVisualStyleBackColor = true;
            this.naveNext.Click += new System.EventHandler(this.NaveNext);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 506);
            this.Controls.Add(this.naveNext);
            this.Controls.Add(this.navePrev);
            this.Controls.Add(this.toolNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "TIA Openness Project Generator";
            this.toolNavigator.ResumeLayout(false);
            this.startTIATab.ResumeLayout(false);
            this.openProjectTab.ResumeLayout(false);
            this.openProjectTab.PerformLayout();
            this.openLibraryTab.ResumeLayout(false);
            this.openLibraryTab.PerformLayout();
            this.hwConfigTab.ResumeLayout(false);
            this.hwConfigTab.PerformLayout();
            this.addProgramTab.ResumeLayout(false);
            this.addProgramTab.PerformLayout();
            this.s120Config.ResumeLayout(false);
            this.s120Config.PerformLayout();
            this.et200SPConfig.ResumeLayout(false);
            this.et200SPConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl toolNavigator;
        private System.Windows.Forms.TabPage startTIATab;
        private System.Windows.Forms.TabPage openProjectTab;
        private System.Windows.Forms.TabPage openLibraryTab;
        private System.Windows.Forms.TabPage hwConfigTab;
        private System.Windows.Forms.TabPage addProgramTab;
        private System.Windows.Forms.Button navePrev;
        private System.Windows.Forms.Button naveNext;
        private System.Windows.Forms.Button createNewInstance;
        private System.Windows.Forms.Button linkSelectedInstance;
        private System.Windows.Forms.Button searchTIAPortalInsstance;
        private System.Windows.Forms.ListView tiaPortalInstanceList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader projectName;
        private System.Windows.Forms.Button browseForProject;
        private System.Windows.Forms.Button createProject;
        private System.Windows.Forms.Button openProject;
        private System.Windows.Forms.TextBox projectPathText;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox libraryPathText;
        private System.Windows.Forms.Button openLibrary;
        private System.Windows.Forms.Button browseForLibrary;
        private System.Windows.Forms.Button configHW;
        private System.Windows.Forms.ListView hwListForUser;
        private System.Windows.Forms.ColumnHeader Colunm1;
        private System.Windows.Forms.ColumnHeader Colunm2;
        private System.Windows.Forms.ColumnHeader Colunm3;
        private System.Windows.Forms.Button updateHWItem;
        private System.Windows.Forms.TextBox masterCopyStartIPAddress;
        private System.Windows.Forms.TextBox masterCopyNumberToCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView swListForUser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label startDBNumber;
        private System.Windows.Forms.Label numberOfInstancesToCreate;
        private System.Windows.Forms.Button addSW_Button;
        private System.Windows.Forms.Button updateSWList_Button;
        private System.Windows.Forms.TextBox typeInstanceDBStartNumber;
        private System.Windows.Forms.TextBox numberofInstanceDBstoCreate;
        private System.Windows.Forms.TabPage s120Config;
        private System.Windows.Forms.TabPage et200SPConfig;
        private System.Windows.Forms.ListView s120ConfigList;
        private System.Windows.Forms.Button configS120Modules_Button;
        private System.Windows.Forms.Button updateS120ModuleList_Button;
        private System.Windows.Forms.TextBox startIOAddressofS120Module;
        private System.Windows.Forms.TextBox numberofS120ModulestoCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button configET200SP_Button;
        private System.Windows.Forms.Button updateET200SPList_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView et200SPConfigList;
        private System.Windows.Forms.TextBox startIOAddressofET200SP;
        private System.Windows.Forms.TextBox numberofET200SPModulestoCreate;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView s120StationsList;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView et200SPStationList;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

