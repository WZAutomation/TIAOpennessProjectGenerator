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
            this.navePrev = new System.Windows.Forms.Button();
            this.naveNext = new System.Windows.Forms.Button();
            this.userHints = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolNavigator.SuspendLayout();
            this.startTIATab.SuspendLayout();
            this.openProjectTab.SuspendLayout();
            this.openLibraryTab.SuspendLayout();
            this.hwConfigTab.SuspendLayout();
            this.addProgramTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolNavigator
            // 
            this.toolNavigator.Controls.Add(this.startTIATab);
            this.toolNavigator.Controls.Add(this.openProjectTab);
            this.toolNavigator.Controls.Add(this.openLibraryTab);
            this.toolNavigator.Controls.Add(this.hwConfigTab);
            this.toolNavigator.Controls.Add(this.addProgramTab);
            this.toolNavigator.Location = new System.Drawing.Point(0, 0);
            this.toolNavigator.Name = "toolNavigator";
            this.toolNavigator.SelectedIndex = 0;
            this.toolNavigator.Size = new System.Drawing.Size(472, 451);
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
            this.startTIATab.Size = new System.Drawing.Size(464, 425);
            this.startTIATab.TabIndex = 0;
            this.startTIATab.Tag = "";
            this.startTIATab.Text = "Start / Link TIA Portal";
            this.startTIATab.UseVisualStyleBackColor = true;
            // 
            // tiaPortalInstanceList
            // 
            this.tiaPortalInstanceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.projectName});
            this.tiaPortalInstanceList.HideSelection = false;
            this.tiaPortalInstanceList.Location = new System.Drawing.Point(30, 103);
            this.tiaPortalInstanceList.MultiSelect = false;
            this.tiaPortalInstanceList.Name = "tiaPortalInstanceList";
            this.tiaPortalInstanceList.Size = new System.Drawing.Size(397, 116);
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
            this.createNewInstance.Location = new System.Drawing.Point(383, 6);
            this.createNewInstance.Name = "createNewInstance";
            this.createNewInstance.Size = new System.Drawing.Size(75, 40);
            this.createNewInstance.TabIndex = 2;
            this.createNewInstance.Text = "Start New";
            this.createNewInstance.UseVisualStyleBackColor = true;
            this.createNewInstance.Click += new System.EventHandler(this.CreateNewInstance);
            // 
            // linkSelectedInstance
            // 
            this.linkSelectedInstance.Location = new System.Drawing.Point(89, 6);
            this.linkSelectedInstance.Name = "linkSelectedInstance";
            this.linkSelectedInstance.Size = new System.Drawing.Size(75, 40);
            this.linkSelectedInstance.TabIndex = 1;
            this.linkSelectedInstance.Text = "Link Selected";
            this.linkSelectedInstance.UseVisualStyleBackColor = true;
            this.linkSelectedInstance.Click += new System.EventHandler(this.LinkSelectedInstance);
            // 
            // searchTIAPortalInsstance
            // 
            this.searchTIAPortalInsstance.Location = new System.Drawing.Point(8, 6);
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
            this.openProjectTab.Size = new System.Drawing.Size(464, 425);
            this.openProjectTab.TabIndex = 1;
            this.openProjectTab.Text = "Open Project";
            this.openProjectTab.UseVisualStyleBackColor = true;
            // 
            // createProject
            // 
            this.createProject.Location = new System.Drawing.Point(284, 57);
            this.createProject.Name = "createProject";
            this.createProject.Size = new System.Drawing.Size(75, 40);
            this.createProject.TabIndex = 3;
            this.createProject.Text = "Create Project";
            this.createProject.UseVisualStyleBackColor = true;
            this.createProject.Click += new System.EventHandler(this.CreateProject);
            // 
            // openProject
            // 
            this.openProject.Location = new System.Drawing.Point(99, 57);
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
            this.projectPathText.Size = new System.Drawing.Size(370, 21);
            this.projectPathText.TabIndex = 1;
            // 
            // browseForProject
            // 
            this.browseForProject.Location = new System.Drawing.Point(383, 6);
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
            this.openLibraryTab.Size = new System.Drawing.Size(464, 425);
            this.openLibraryTab.TabIndex = 2;
            this.openLibraryTab.Text = "Open Library";
            this.openLibraryTab.UseVisualStyleBackColor = true;
            // 
            // openLibrary
            // 
            this.openLibrary.Location = new System.Drawing.Point(99, 57);
            this.openLibrary.Name = "openLibrary";
            this.openLibrary.Size = new System.Drawing.Size(75, 40);
            this.openLibrary.TabIndex = 3;
            this.openLibrary.Text = "Open Library";
            this.openLibrary.UseVisualStyleBackColor = true;
            this.openLibrary.Click += new System.EventHandler(this.OpenLibrary);
            // 
            // browseForLibrary
            // 
            this.browseForLibrary.Location = new System.Drawing.Point(383, 6);
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
            this.libraryPathText.Size = new System.Drawing.Size(370, 21);
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
            this.hwConfigTab.Size = new System.Drawing.Size(464, 425);
            this.hwConfigTab.TabIndex = 3;
            this.hwConfigTab.Text = "Config HW";
            this.hwConfigTab.UseVisualStyleBackColor = true;
            // 
            // updateHWItem
            // 
            this.updateHWItem.Location = new System.Drawing.Point(261, 6);
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
            this.configHW.Location = new System.Drawing.Point(383, 6);
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
            this.hwListForUser.Size = new System.Drawing.Size(450, 370);
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
            this.addProgramTab.Controls.Add(this.startDBNumber);
            this.addProgramTab.Controls.Add(this.numberOfInstancesToCreate);
            this.addProgramTab.Controls.Add(this.addSW_Button);
            this.addProgramTab.Controls.Add(this.updateSWList_Button);
            this.addProgramTab.Controls.Add(this.typeInstanceDBStartNumber);
            this.addProgramTab.Controls.Add(this.numberofInstanceDBstoCreate);
            this.addProgramTab.Controls.Add(this.swListForUser);
            this.addProgramTab.Location = new System.Drawing.Point(4, 22);
            this.addProgramTab.Name = "addProgramTab";
            this.addProgramTab.Size = new System.Drawing.Size(464, 425);
            this.addProgramTab.TabIndex = 4;
            this.addProgramTab.Text = "Add Software";
            this.addProgramTab.UseVisualStyleBackColor = true;
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
            this.addSW_Button.Location = new System.Drawing.Point(383, 6);
            this.addSW_Button.Name = "addSW_Button";
            this.addSW_Button.Size = new System.Drawing.Size(75, 40);
            this.addSW_Button.TabIndex = 4;
            this.addSW_Button.Text = "Add Software";
            this.addSW_Button.UseVisualStyleBackColor = true;
            this.addSW_Button.Click += new System.EventHandler(this.AddSW_Button);
            // 
            // updateSWList_Button
            // 
            this.updateSWList_Button.Location = new System.Drawing.Point(261, 6);
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
            this.swListForUser.Size = new System.Drawing.Size(450, 370);
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
            // navePrev
            // 
            this.navePrev.Location = new System.Drawing.Point(103, 457);
            this.navePrev.Name = "navePrev";
            this.navePrev.Size = new System.Drawing.Size(75, 40);
            this.navePrev.TabIndex = 1;
            this.navePrev.Text = "Prev";
            this.navePrev.UseVisualStyleBackColor = true;
            this.navePrev.Click += new System.EventHandler(this.NavePrev);
            // 
            // naveNext
            // 
            this.naveNext.Location = new System.Drawing.Point(288, 457);
            this.naveNext.Name = "naveNext";
            this.naveNext.Size = new System.Drawing.Size(75, 40);
            this.naveNext.TabIndex = 2;
            this.naveNext.Text = "Next";
            this.naveNext.UseVisualStyleBackColor = true;
            this.naveNext.Click += new System.EventHandler(this.NaveNext);
            // 
            // userHints
            // 
            this.userHints.Location = new System.Drawing.Point(478, 22);
            this.userHints.Multiline = true;
            this.userHints.Name = "userHints";
            this.userHints.ReadOnly = true;
            this.userHints.Size = new System.Drawing.Size(157, 425);
            this.userHints.TabIndex = 3;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 506);
            this.Controls.Add(this.userHints);
            this.Controls.Add(this.naveNext);
            this.Controls.Add(this.navePrev);
            this.Controls.Add(this.toolNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox userHints;
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
    }
}

