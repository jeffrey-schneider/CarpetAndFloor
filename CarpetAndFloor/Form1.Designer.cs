
namespace CarpetAndFloor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.txtQuotation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtLaborTotal = new System.Windows.Forms.TextBox();
            this.txtMaterials = new System.Windows.Forms.TextBox();
            this.txtLaborCharge = new System.Windows.Forms.TextBox();
            this.txtSqYd = new System.Windows.Forms.TextBox();
            this.txtSqFt = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtFloorPrice = new System.Windows.Forms.TextBox();
            this.txtFloorCtgry = new System.Windows.Forms.TextBox();
            this.txtFloorName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSelf = new System.Windows.Forms.RadioButton();
            this.rdoInstall = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFloorList = new System.Windows.Forms.DataGridView();
            this.Ctgry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstState = new System.Windows.Forms.ListBox();
            this.txtCustZip = new System.Windows.Forms.TextBox();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.txtCustomerAddr2 = new System.Windows.Forms.TextBox();
            this.txtCustomerAddr = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindFloor = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloorList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "&File";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 19);
            this.mnuFile.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 19);
            this.mnuEdit.Text = "&Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontDialog_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.ColorDialog_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 19);
            this.mnuHelp.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.pb1);
            this.tabPage2.Controls.Add(this.txtQuotation);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtTotalCost);
            this.tabPage2.Controls.Add(this.txtLaborTotal);
            this.tabPage2.Controls.Add(this.txtMaterials);
            this.tabPage2.Controls.Add(this.txtLaborCharge);
            this.tabPage2.Controls.Add(this.txtSqYd);
            this.tabPage2.Controls.Add(this.txtSqFt);
            this.tabPage2.Controls.Add(this.txtLength);
            this.tabPage2.Controls.Add(this.txtWidth);
            this.tabPage2.Controls.Add(this.txtFloorPrice);
            this.tabPage2.Controls.Add(this.txtFloorCtgry);
            this.tabPage2.Controls.Add(this.txtFloorName);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnCalculate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgvFloorList);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(980, 621);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Job Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 21);
            this.label11.TabIndex = 61;
            this.label11.Text = "label11";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(441, 45);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(500, 231);
            this.pb1.TabIndex = 59;
            this.pb1.TabStop = false;
            // 
            // txtQuotation
            // 
            this.txtQuotation.Enabled = false;
            this.txtQuotation.Location = new System.Drawing.Point(964, 589);
            this.txtQuotation.Multiline = true;
            this.txtQuotation.Name = "txtQuotation";
            this.txtQuotation.ReadOnly = true;
            this.txtQuotation.Size = new System.Drawing.Size(13, 29);
            this.txtQuotation.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 465);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 21);
            this.label14.TabIndex = 56;
            this.label14.Text = "Labor Cost";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 500);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 21);
            this.label13.TabIndex = 55;
            this.label13.Text = "Total Estimate";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(204, 492);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(93, 29);
            this.txtTotalCost.TabIndex = 54;
            this.txtTotalCost.Tag = "Clear";
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLaborTotal
            // 
            this.txtLaborTotal.Location = new System.Drawing.Point(204, 457);
            this.txtLaborTotal.Name = "txtLaborTotal";
            this.txtLaborTotal.ReadOnly = true;
            this.txtLaborTotal.Size = new System.Drawing.Size(93, 29);
            this.txtLaborTotal.TabIndex = 53;
            this.txtLaborTotal.Tag = "Clear";
            this.txtLaborTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaterials
            // 
            this.txtMaterials.Location = new System.Drawing.Point(204, 422);
            this.txtMaterials.Name = "txtMaterials";
            this.txtMaterials.ReadOnly = true;
            this.txtMaterials.Size = new System.Drawing.Size(93, 29);
            this.txtMaterials.TabIndex = 50;
            this.txtMaterials.Tag = "Clear";
            this.txtMaterials.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLaborCharge
            // 
            this.txtLaborCharge.Location = new System.Drawing.Point(405, 462);
            this.txtLaborCharge.Name = "txtLaborCharge";
            this.txtLaborCharge.Size = new System.Drawing.Size(92, 29);
            this.txtLaborCharge.TabIndex = 48;
            this.txtLaborCharge.Tag = "Clear";
            this.txtLaborCharge.Text = "30.00";
            this.txtLaborCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLaborCharge.TextChanged += new System.EventHandler(this.button2_Click);
            // 
            // txtSqYd
            // 
            this.txtSqYd.Location = new System.Drawing.Point(405, 392);
            this.txtSqYd.Name = "txtSqYd";
            this.txtSqYd.ReadOnly = true;
            this.txtSqYd.Size = new System.Drawing.Size(92, 29);
            this.txtSqYd.TabIndex = 44;
            this.txtSqYd.Tag = "Clear";
            this.txtSqYd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSqFt
            // 
            this.txtSqFt.Location = new System.Drawing.Point(204, 387);
            this.txtSqFt.Name = "txtSqFt";
            this.txtSqFt.ReadOnly = true;
            this.txtSqFt.Size = new System.Drawing.Size(93, 29);
            this.txtSqFt.TabIndex = 43;
            this.txtSqFt.Tag = "Clear";
            this.txtSqFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(204, 352);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(93, 29);
            this.txtLength.TabIndex = 39;
            this.txtLength.Tag = "Clear";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLength.TextChanged += new System.EventHandler(this.button2_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(204, 317);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(93, 29);
            this.txtWidth.TabIndex = 38;
            this.txtWidth.Tag = "Clear";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWidth.TextChanged += new System.EventHandler(this.button2_Click);
            // 
            // txtFloorPrice
            // 
            this.txtFloorPrice.Location = new System.Drawing.Point(314, 282);
            this.txtFloorPrice.Name = "txtFloorPrice";
            this.txtFloorPrice.ReadOnly = true;
            this.txtFloorPrice.Size = new System.Drawing.Size(75, 29);
            this.txtFloorPrice.TabIndex = 37;
            this.txtFloorPrice.Tag = "Clear";
            this.txtFloorPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFloorCtgry
            // 
            this.txtFloorCtgry.Location = new System.Drawing.Point(204, 282);
            this.txtFloorCtgry.Name = "txtFloorCtgry";
            this.txtFloorCtgry.ReadOnly = true;
            this.txtFloorCtgry.Size = new System.Drawing.Size(93, 29);
            this.txtFloorCtgry.TabIndex = 36;
            this.txtFloorCtgry.Tag = "Clear";
            // 
            // txtFloorName
            // 
            this.txtFloorName.Location = new System.Drawing.Point(22, 282);
            this.txtFloorName.Name = "txtFloorName";
            this.txtFloorName.ReadOnly = true;
            this.txtFloorName.Size = new System.Drawing.Size(148, 29);
            this.txtFloorName.TabIndex = 35;
            this.txtFloorName.Tag = "Clear";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 52;
            this.label12.Text = "Mat\'l Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(309, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 49;
            this.label10.Text = "Labor (Yd)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "Sq Feet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Sq Yard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSelf);
            this.groupBox1.Controls.Add(this.rdoInstall);
            this.groupBox1.Location = new System.Drawing.Point(593, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 101);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation";
            // 
            // rdoSelf
            // 
            this.rdoSelf.AutoSize = true;
            this.rdoSelf.Location = new System.Drawing.Point(6, 60);
            this.rdoSelf.Name = "rdoSelf";
            this.rdoSelf.Size = new System.Drawing.Size(54, 25);
            this.rdoSelf.TabIndex = 1;
            this.rdoSelf.TabStop = true;
            this.rdoSelf.Text = "Self";
            this.rdoSelf.UseVisualStyleBackColor = true;
            // 
            // rdoInstall
            // 
            this.rdoInstall.AutoSize = true;
            this.rdoInstall.Location = new System.Drawing.Point(6, 29);
            this.rdoInstall.Name = "rdoInstall";
            this.rdoInstall.Size = new System.Drawing.Size(113, 25);
            this.rdoInstall.TabIndex = 0;
            this.rdoInstall.TabStop = true;
            this.rdoInstall.Text = "Professional";
            this.rdoInstall.UseVisualStyleBackColor = true;
            this.rdoInstall.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(314, 318);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 35);
            this.btnCalculate.TabIndex = 42;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Length";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Photo (todo)";
            // 
            // dgvFloorList
            // 
            this.dgvFloorList.AllowUserToAddRows = false;
            this.dgvFloorList.AllowUserToDeleteRows = false;
            this.dgvFloorList.AutoGenerateColumns = false;
            this.dgvFloorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFloorList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFloorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFloorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Ctgry,
            this.priceDataGridViewTextBoxColumn});
            this.dgvFloorList.DataSource = this.bindFloor;
            this.dgvFloorList.Location = new System.Drawing.Point(26, 45);
            this.dgvFloorList.MultiSelect = false;
            this.dgvFloorList.Name = "dgvFloorList";
            this.dgvFloorList.ReadOnly = true;
            this.dgvFloorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFloorList.Size = new System.Drawing.Size(366, 231);
            this.dgvFloorList.TabIndex = 0;
            this.dgvFloorList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // Ctgry
            // 
            this.Ctgry.DataPropertyName = "Ctgry";
            this.Ctgry.HeaderText = "Ctgry";
            this.Ctgry.Name = "Ctgry";
            this.Ctgry.ReadOnly = true;
            this.Ctgry.Width = 73;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.pb2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lstState);
            this.tabPage1.Controls.Add(this.txtCustZip);
            this.tabPage1.Controls.Add(this.txtCustomerCity);
            this.tabPage1.Controls.Add(this.txtCustomerAddr2);
            this.tabPage1.Controls.Add(this.txtCustomerAddr);
            this.tabPage1.Controls.Add(this.txtCustomerName);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(417, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "label15";
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(421, 36);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(461, 308);
            this.pb2.TabIndex = 15;
            this.pb2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 344);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(231, 105);
            this.textBox1.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(267, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 42);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "City/State/Zip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // lstState
            // 
            this.lstState.FormattingEnabled = true;
            this.lstState.ItemHeight = 21;
            this.lstState.Items.AddRange(new object[] {
            "",
            "AL",
            "GA",
            "NC",
            "SC",
            "TN"});
            this.lstState.Location = new System.Drawing.Point(153, 229);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(73, 46);
            this.lstState.Sorted = true;
            this.lstState.TabIndex = 5;
            // 
            // txtCustZip
            // 
            this.txtCustZip.Location = new System.Drawing.Point(232, 229);
            this.txtCustZip.Name = "txtCustZip";
            this.txtCustZip.Size = new System.Drawing.Size(132, 29);
            this.txtCustZip.TabIndex = 4;
            this.txtCustZip.Tag = "Clear";
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(153, 194);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(231, 29);
            this.txtCustomerCity.TabIndex = 3;
            this.txtCustomerCity.Tag = "Clear";
            // 
            // txtCustomerAddr2
            // 
            this.txtCustomerAddr2.Location = new System.Drawing.Point(153, 159);
            this.txtCustomerAddr2.Name = "txtCustomerAddr2";
            this.txtCustomerAddr2.Size = new System.Drawing.Size(231, 29);
            this.txtCustomerAddr2.TabIndex = 2;
            this.txtCustomerAddr2.Tag = "Clear";
            // 
            // txtCustomerAddr
            // 
            this.txtCustomerAddr.Location = new System.Drawing.Point(153, 124);
            this.txtCustomerAddr.Name = "txtCustomerAddr";
            this.txtCustomerAddr.Size = new System.Drawing.Size(231, 29);
            this.txtCustomerAddr.TabIndex = 1;
            this.txtCustomerAddr.Tag = "Clear";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(153, 89);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(231, 29);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Tag = "Clear";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 655);
            this.tabControl1.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 77;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 69;
            // 
            // bindFloor
            // 
            this.bindFloor.DataSource = typeof(CarpetAndFloor.FloorType);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 716);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Carpet And Floor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloorList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindFloor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtLaborTotal;
        private System.Windows.Forms.TextBox txtMaterials;
        private System.Windows.Forms.TextBox txtLaborCharge;
        private System.Windows.Forms.TextBox txtSqYd;
        private System.Windows.Forms.TextBox txtSqFt;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtFloorPrice;
        private System.Windows.Forms.TextBox txtFloorCtgry;
        private System.Windows.Forms.TextBox txtFloorName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSelf;
        private System.Windows.Forms.RadioButton rdoInstall;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvFloorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstState;
        private System.Windows.Forms.TextBox txtCustZip;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerAddr2;
        private System.Windows.Forms.TextBox txtCustomerAddr;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtQuotation;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctgry;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label label15;
    }
}

