
namespace Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxHeating = new System.Windows.Forms.ComboBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.comboBoxBer = new System.Windows.Forms.ComboBox();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkWheelchairAccess = new System.Windows.Forms.CheckBox();
            this.chkProximityArea = new System.Windows.Forms.CheckBox();
            this.chkSolarPanel = new System.Windows.Forms.CheckBox();
            this.chkAircondition = new System.Windows.Forms.CheckBox();
            this.chkBroadband = new System.Windows.Forms.CheckBox();
            this.chkAlarm = new System.Windows.Forms.CheckBox();
            this.chkGarden = new System.Windows.Forms.CheckBox();
            this.chkParking = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSaveAsCsv = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnCloseFile = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClearRecords = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.radioButtonOn = new System.Windows.Forms.RadioButton();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Items.AddRange(new object[] {
            "Abbey Street",
            "Amiens Street",
            "Capel Street",
            "Dorset Street",
            "Henry Street",
            "Mary Street",
            "Mountjoy Square",
            "Marlborough Street",
            "North Wall",
            "O\'Connell Street",
            "Parnell Square",
            "Talbot Street",
            "Ballybough",
            "North Strand",
            "Clonliffe",
            "Clontarf",
            "Dollymount",
            "East Wall",
            "East Point",
            "Fairview",
            "Killester",
            "Marino",
            "Artane",
            "Coolock",
            "Harmonstown",
            "Kilbarrack",
            "Raheny",
            "Arbour Hill",
            "Ashtown",
            "Broadstone",
            "Cabra",
            "Grangegorman",
            "Oxmantown",
            "Phibsboro",
            "Smithfield",
            "Stoneybatter",
            "Ballymun",
            "East Ballymun Road",
            "Shangan",
            "Coultry",
            "Beaumont",
            "Donnycarney",
            "Drumcondra",
            "Elm Mount",
            "Griffith Avenue",
            "St Mobhi",
            "Botanic Gardens",
            "Met Éireann",
            "Santry",
            "Whitehall",
            "Ballymun",
            "West Ballymun Road",
            "Sillogue",
            "Balcurris",
            "Balbutcher",
            "Poppintree",
            "Sandyhill",
            "Wadelai",
            "Dubber Cross",
            "Finglas",
            "Ballygall",
            "Cappagh",
            "Glasnevin",
            "Cremore",
            "Addison",
            "Violet Hill",
            "Finglas Road",
            "Old Finglas Road",
            "Glasnevin Cemetery",
            "Kilshane Cross",
            "The Ward",
            "Coolquay",
            "Baldoyle",
            "Bayside",
            "Donaghmede",
            "Clongriffin",
            "Sutton",
            "Howth",
            "Ayrfield",
            "Ashtown",
            "Blanchardstown",
            "Castleknock",
            "Coolmine",
            "Clonsilla",
            "Corduff",
            "Mulhuddart",
            "Tyrrelstown",
            "Clonee",
            "Ongar",
            "Balgriffin",
            "Coolock",
            "Belcamp",
            "Darndale",
            "Priorswood",
            "River Liffey",
            "Merrion Square",
            "Trinity College",
            "Temple Bar",
            "Grafton Street",
            "St Stephen\'s Green",
            "Dame Street",
            "Leeson Street",
            "Grand Canal Dock",
            "City Quay",
            "Leinster House",
            "Government Buildings",
            "Mansion House",
            "Aungier",
            "Wexford street",
            "Camden Streets",
            "Ballsbridge",
            "Belfield",
            "Donnybrook",
            "Irishtown",
            "Merrion",
            "Pembroke",
            "Ringsend",
            "Sandymount",
            "RDS grounds",
            "Lansdowne Road stadium",
            "Milltown",
            "Ranelagh",
            "Terenure",
            "Rathmines",
            "Dartry",
            "Rathgar",
            "Harold\'s Cross",
            "Templeogue",
            "Kimmage",
            "Terenure",
            "Dolphin\'s Barn",
            "Inchicore",
            "Islandbridge",
            "Kilmainham",
            "Merchants Quay",
            "Portobello",
            "South Circular Road",
            "Phoenix Park",
            "Liberties",
            "Ballyfermot",
            "Sarsfield Road",
            "Cherry Orchard",
            "Bluebell",
            "Crumlin",
            "Drimnagh",
            "Greenhills",
            "Perrystown",
            "Walkinstown",
            "Churchtown",
            "Clonskeagh",
            "Dundrum",
            "Goatstown",
            "Lower Rathfarnham",
            "Windy Arbour",
            "Ballinteer",
            "Ballyboden",
            "Dundrum",
            "Kilmashogue",
            "Knocklyon",
            "Upper Rathfarnham",
            "Rockbrook",
            "Cabinteely",
            "Carrickmines",
            "Foxrock",
            "Kilternan",
            "Sandyford",
            "Shankill",
            "Ticknock",
            "Ballyedmonduff",
            "Stepaside",
            "Leopardstown",
            "Chapelizod",
            "Palmerstown",
            "Clondalkin",
            "Rowlagh",
            "Quarryvale",
            "Liffey Valley",
            "Neilstown",
            "Firhouse",
            "Jobstown",
            "Old Bawn",
            "Tallaght"});
            this.comboBoxArea.Location = new System.Drawing.Point(108, 216);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(143, 21);
            this.comboBoxArea.TabIndex = 0;
            this.comboBoxArea.MouseHover += new System.EventHandler(this.comboBoxArea_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "House Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Street:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "District:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Heating:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Room:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "BER Rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(491, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Size (sqm):";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "House",
            "Detached House",
            "Semi-Detached House",
            "Terraced House",
            "End of Terrace House",
            "Townhouse",
            "Apartment",
            "Studio Apartment",
            "Duplex",
            "Penthouse",
            "Bungalow"});
            this.comboBoxType.Location = new System.Drawing.Point(345, 83);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(143, 21);
            this.comboBoxType.TabIndex = 11;
            this.comboBoxType.MouseHover += new System.EventHandler(this.comboBoxType_MouseHover);
            // 
            // comboBoxHeating
            // 
            this.comboBoxHeating.FormattingEnabled = true;
            this.comboBoxHeating.Items.AddRange(new object[] {
            "Gas central heating system",
            "Biomass heating system",
            "Electric central heating system",
            "LPG central heating system",
            "Oil central heating system",
            "Immersion heater",
            "Storage heater"});
            this.comboBoxHeating.Location = new System.Drawing.Point(345, 149);
            this.comboBoxHeating.Name = "comboBoxHeating";
            this.comboBoxHeating.Size = new System.Drawing.Size(143, 21);
            this.comboBoxHeating.TabIndex = 12;
            this.comboBoxHeating.MouseHover += new System.EventHandler(this.comboBoxHeating_MouseHover);
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "5+"});
            this.comboBoxRoom.Location = new System.Drawing.Point(345, 216);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(143, 21);
            this.comboBoxRoom.TabIndex = 13;
            this.comboBoxRoom.MouseHover += new System.EventHandler(this.comboBoxRoom_MouseHover);
            // 
            // comboBoxBer
            // 
            this.comboBoxBer.FormattingEnabled = true;
            this.comboBoxBer.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B2",
            "B3",
            "C1",
            "C2",
            "C3",
            "D1",
            "D2",
            "D3",
            "E1",
            "E2",
            "F",
            "G",
            "Exempt(SI666)"});
            this.comboBoxBer.Location = new System.Drawing.Point(345, 284);
            this.comboBoxBer.Name = "comboBoxBer";
            this.comboBoxBer.Size = new System.Drawing.Size(143, 21);
            this.comboBoxBer.TabIndex = 14;
            this.comboBoxBer.MouseHover += new System.EventHandler(this.comboBoxBer_MouseHover);
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(108, 83);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(143, 20);
            this.txtHouseNumber.TabIndex = 15;
            this.txtHouseNumber.MouseHover += new System.EventHandler(this.txtHouseNumber_MouseHover);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(108, 149);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(143, 20);
            this.txtStreet.TabIndex = 16;
            this.txtStreet.MouseHover += new System.EventHandler(this.txtStreet_MouseHover);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(566, 217);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(143, 20);
            this.txtSize.TabIndex = 18;
            this.txtSize.MouseHover += new System.EventHandler(this.txtSize_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkWheelchairAccess);
            this.groupBox1.Controls.Add(this.chkProximityArea);
            this.groupBox1.Controls.Add(this.chkSolarPanel);
            this.groupBox1.Controls.Add(this.chkAircondition);
            this.groupBox1.Controls.Add(this.chkBroadband);
            this.groupBox1.Controls.Add(this.chkAlarm);
            this.groupBox1.Controls.Add(this.chkGarden);
            this.groupBox1.Controls.Add(this.chkParking);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(494, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 111);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facilities";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // chkWheelchairAccess
            // 
            this.chkWheelchairAccess.AutoSize = true;
            this.chkWheelchairAccess.Location = new System.Drawing.Point(102, 88);
            this.chkWheelchairAccess.Name = "chkWheelchairAccess";
            this.chkWheelchairAccess.Size = new System.Drawing.Size(140, 19);
            this.chkWheelchairAccess.TabIndex = 12;
            this.chkWheelchairAccess.Text = "Wheelchair Access";
            this.chkWheelchairAccess.UseVisualStyleBackColor = true;
            // 
            // chkProximityArea
            // 
            this.chkProximityArea.AutoSize = true;
            this.chkProximityArea.Location = new System.Drawing.Point(102, 65);
            this.chkProximityArea.Name = "chkProximityArea";
            this.chkProximityArea.Size = new System.Drawing.Size(116, 19);
            this.chkProximityArea.TabIndex = 11;
            this.chkProximityArea.Text = "Proximity Area";
            this.chkProximityArea.UseVisualStyleBackColor = true;
            // 
            // chkSolarPanel
            // 
            this.chkSolarPanel.AutoSize = true;
            this.chkSolarPanel.Location = new System.Drawing.Point(102, 42);
            this.chkSolarPanel.Name = "chkSolarPanel";
            this.chkSolarPanel.Size = new System.Drawing.Size(94, 19);
            this.chkSolarPanel.TabIndex = 10;
            this.chkSolarPanel.Text = "Solar Panel";
            this.chkSolarPanel.UseVisualStyleBackColor = true;
            // 
            // chkAircondition
            // 
            this.chkAircondition.AutoSize = true;
            this.chkAircondition.Location = new System.Drawing.Point(102, 19);
            this.chkAircondition.Name = "chkAircondition";
            this.chkAircondition.Size = new System.Drawing.Size(99, 19);
            this.chkAircondition.TabIndex = 9;
            this.chkAircondition.Text = "Aircondition";
            this.chkAircondition.UseVisualStyleBackColor = true;
            // 
            // chkBroadband
            // 
            this.chkBroadband.AutoSize = true;
            this.chkBroadband.Location = new System.Drawing.Point(16, 88);
            this.chkBroadband.Name = "chkBroadband";
            this.chkBroadband.Size = new System.Drawing.Size(89, 19);
            this.chkBroadband.TabIndex = 8;
            this.chkBroadband.Text = "Broadband";
            this.chkBroadband.UseVisualStyleBackColor = true;
            // 
            // chkAlarm
            // 
            this.chkAlarm.AutoSize = true;
            this.chkAlarm.Location = new System.Drawing.Point(16, 65);
            this.chkAlarm.Name = "chkAlarm";
            this.chkAlarm.Size = new System.Drawing.Size(62, 19);
            this.chkAlarm.TabIndex = 7;
            this.chkAlarm.Text = "Alarm";
            this.chkAlarm.UseVisualStyleBackColor = true;
            // 
            // chkGarden
            // 
            this.chkGarden.AutoSize = true;
            this.chkGarden.Location = new System.Drawing.Point(16, 42);
            this.chkGarden.Name = "chkGarden";
            this.chkGarden.Size = new System.Drawing.Size(68, 19);
            this.chkGarden.TabIndex = 6;
            this.chkGarden.Text = "Garden";
            this.chkGarden.UseVisualStyleBackColor = true;
            // 
            // chkParking
            // 
            this.chkParking.AutoSize = true;
            this.chkParking.Location = new System.Drawing.Point(16, 19);
            this.chkParking.Name = "chkParking";
            this.chkParking.Size = new System.Drawing.Size(71, 19);
            this.chkParking.TabIndex = 5;
            this.chkParking.Text = "Parking";
            this.chkParking.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "A button to add your new record to your collection.";
            this.btnAdd.AccessibleName = "Add";
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(748, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "&Add Record";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleDescription = "A button to update your current record in your collection.";
            this.btnUpdate.AccessibleName = "Update";
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(748, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "&Update Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "A button to delete current record in your collection.";
            this.btnDelete.AccessibleName = "Delete";
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(748, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "&Delete Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleDescription = "A button to clear all fields.";
            this.btnClear.AccessibleName = "Clear";
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(748, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClearAll_Click_1);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(566, 285);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 20);
            this.txtPrice.TabIndex = 25;
            this.txtPrice.MouseHover += new System.EventHandler(this.txtPrice_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(491, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Price:";
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Items.AddRange(new object[] {
            "D1.",
            "D2.",
            "D3",
            "D4",
            "D5",
            "D6",
            "D6w",
            "D7",
            "D8",
            "D9",
            "D10",
            "D11",
            "D12",
            "D13",
            "D14",
            "D15",
            "D16",
            "D17",
            "D18",
            "D20",
            "D22",
            "D24"});
            this.comboBoxDistrict.Location = new System.Drawing.Point(108, 284);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(143, 21);
            this.comboBoxDistrict.TabIndex = 27;
            this.comboBoxDistrict.MouseHover += new System.EventHandler(this.comboBoxDistrict_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleDescription = "A button navigate you to the search form.";
            this.btnSearch.AccessibleName = "Search";
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(748, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "&Search Record";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleDescription = "A button to exit thhe application.";
            this.btnExit.AccessibleName = "Exit";
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(748, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "A button to cancel any edit on the current record.";
            this.btnCancel.AccessibleName = "Cancel";
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(748, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cance&l";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLast.Location = new System.Drawing.Point(650, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(105, 47);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = "Last";
            this.btnLast.UseCompatibleTextRendering = true;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click_1);
            this.btnLast.MouseHover += new System.EventHandler(this.btnLast_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(523, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 47);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseCompatibleTextRendering = true;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPrevious.Location = new System.Drawing.Point(237, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(105, 47);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseCompatibleTextRendering = true;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            this.btnPrevious.MouseHover += new System.EventHandler(this.btnPrevious_MouseHover);
            // 
            // btnSaveAsCsv
            // 
            this.btnSaveAsCsv.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsCsv.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSaveAsCsv.Location = new System.Drawing.Point(623, 65);
            this.btnSaveAsCsv.Name = "btnSaveAsCsv";
            this.btnSaveAsCsv.Size = new System.Drawing.Size(113, 23);
            this.btnSaveAsCsv.TabIndex = 8;
            this.btnSaveAsCsv.Text = "Save As CSV";
            this.btnSaveAsCsv.UseVisualStyleBackColor = true;
            this.btnSaveAsCsv.Click += new System.EventHandler(this.btnSaveAsCsv_Click_1);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAs.Location = new System.Drawing.Point(396, 65);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 7;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(509, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(134, 65);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(108, 23);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click_1);
            // 
            // btnCloseFile
            // 
            this.btnCloseFile.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFile.Location = new System.Drawing.Point(283, 65);
            this.btnCloseFile.Name = "btnCloseFile";
            this.btnCloseFile.Size = new System.Drawing.Size(75, 23);
            this.btnCloseFile.TabIndex = 4;
            this.btnCloseFile.Text = "Close File";
            this.btnCloseFile.UseVisualStyleBackColor = true;
            this.btnCloseFile.Click += new System.EventHandler(this.btnCloseFile_Click_1);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnFirst.Location = new System.Drawing.Point(108, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(105, 47);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "First";
            this.btnFirst.UseCompatibleTextRendering = true;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click_1);
            this.btnFirst.MouseHover += new System.EventHandler(this.btnFirst_MouseHover);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("News706 BT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(257, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(375, 45);
            this.label11.TabIndex = 32;
            this.label11.Text = "The Property Guide";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearRecords
            // 
            this.btnClearRecords.AccessibleDescription = "A button to erase all records in your collection.";
            this.btnClearRecords.AccessibleName = "Erase";
            this.btnClearRecords.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnClearRecords.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRecords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearRecords.Location = new System.Drawing.Point(748, 171);
            this.btnClearRecords.Name = "btnClearRecords";
            this.btnClearRecords.Size = new System.Drawing.Size(112, 23);
            this.btnClearRecords.TabIndex = 33;
            this.btnClearRecords.Text = "Clear &Records";
            this.btnClearRecords.UseVisualStyleBackColor = false;
            this.btnClearRecords.Click += new System.EventHandler(this.btnClearRecord_Click);
            this.btnClearRecords.MouseHover += new System.EventHandler(this.btnClearRecord_MouseHover);
            // 
            // txtIndex
            // 
            this.txtIndex.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIndex.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex.Location = new System.Drawing.Point(396, 25);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.ReadOnly = true;
            this.txtIndex.Size = new System.Drawing.Size(75, 23);
            this.txtIndex.TabIndex = 12;
            this.txtIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIndex.MouseHover += new System.EventHandler(this.txtIndex_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtIndex);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnSaveAsCsv);
            this.panel1.Controls.Add(this.btnSaveAs);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnCloseFile);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 100);
            this.panel1.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(649, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Guiding Mode";
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.AutoSize = true;
            this.radioButtonOn.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOn.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonOn.Location = new System.Drawing.Point(742, 9);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(39, 19);
            this.radioButtonOn.TabIndex = 35;
            this.radioButtonOn.Text = "on";
            this.radioButtonOn.UseVisualStyleBackColor = false;
            this.radioButtonOn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOff.Checked = true;
            this.radioButtonOff.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOff.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonOff.Location = new System.Drawing.Point(787, 9);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(40, 19);
            this.radioButtonOff.TabIndex = 36;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "off";
            this.radioButtonOff.UseVisualStyleBackColor = false;
            this.radioButtonOff.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.Location = new System.Drawing.Point(843, 7);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(30, 23);
            this.btnHelp.TabIndex = 37;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 491);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.radioButtonOff);
            this.Controls.Add(this.radioButtonOn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClearRecords);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxDistrict);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.comboBoxBer);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.comboBoxHeating);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Property List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxHeating;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.ComboBox comboBoxBer;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.CheckBox chkWheelchairAccess;
        private System.Windows.Forms.CheckBox chkProximityArea;
        private System.Windows.Forms.CheckBox chkSolarPanel;
        private System.Windows.Forms.CheckBox chkAircondition;
        private System.Windows.Forms.CheckBox chkBroadband;
        private System.Windows.Forms.CheckBox chkAlarm;
        private System.Windows.Forms.CheckBox chkGarden;
        private System.Windows.Forms.CheckBox chkParking;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSaveAsCsv;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnCloseFile;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClearRecords;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButtonOn;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.Button btnHelp;
    }
}

