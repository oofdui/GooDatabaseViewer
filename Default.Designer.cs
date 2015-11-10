namespace GooDatabaseViewer
{
    partial class Default
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.tbDefault = new System.Windows.Forms.TableLayoutPanel();
            this.tbForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblConfigHeader = new System.Windows.Forms.Label();
            this.lblIPServer = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblReload = new System.Windows.Forms.Label();
            this.txtReload = new System.Windows.Forms.TextBox();
            this.lblSQLQuery = new System.Windows.Forms.Label();
            this.txtSQLQuery = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.lblHighlightValue = new System.Windows.Forms.Label();
            this.txtHighlightValue = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbODBC = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDNS = new System.Windows.Forms.Label();
            this.txtDNS = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDataHeader = new System.Windows.Forms.Label();
            this.gvDefault = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDataCount = new System.Windows.Forms.Label();
            this.timerDefault = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerDefault = new System.ComponentModel.BackgroundWorker();
            this.pbDefault = new System.Windows.Forms.ProgressBar();
            this.ttDefault = new System.Windows.Forms.ToolTip(this.components);
            this.lblTimerLabel = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tbDefault.SuspendLayout();
            this.tbForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDefault)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDefault
            // 
            this.tbDefault.ColumnCount = 2;
            this.tbDefault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tbDefault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbDefault.Controls.Add(this.tbForm, 0, 0);
            this.tbDefault.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tbDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDefault.Location = new System.Drawing.Point(0, 0);
            this.tbDefault.Margin = new System.Windows.Forms.Padding(0);
            this.tbDefault.Name = "tbDefault";
            this.tbDefault.RowCount = 1;
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 494F));
            this.tbDefault.Size = new System.Drawing.Size(848, 494);
            this.tbDefault.TabIndex = 0;
            // 
            // tbForm
            // 
            this.tbForm.AutoSize = true;
            this.tbForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tbForm.ColumnCount = 1;
            this.tbForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbForm.Controls.Add(this.lblConfigHeader, 0, 0);
            this.tbForm.Controls.Add(this.lblIPServer, 0, 5);
            this.tbForm.Controls.Add(this.lblDatabase, 0, 7);
            this.tbForm.Controls.Add(this.lblUsername, 0, 9);
            this.tbForm.Controls.Add(this.txtIPServer, 0, 6);
            this.tbForm.Controls.Add(this.txtDatabase, 0, 8);
            this.tbForm.Controls.Add(this.txtUsername, 0, 10);
            this.tbForm.Controls.Add(this.lblPassword, 0, 11);
            this.tbForm.Controls.Add(this.txtPassword, 0, 12);
            this.tbForm.Controls.Add(this.lblReload, 0, 13);
            this.tbForm.Controls.Add(this.txtReload, 0, 14);
            this.tbForm.Controls.Add(this.lblSQLQuery, 0, 17);
            this.tbForm.Controls.Add(this.txtSQLQuery, 0, 18);
            this.tbForm.Controls.Add(this.tableLayoutPanel1, 0, 19);
            this.tbForm.Controls.Add(this.lblHighlightValue, 0, 15);
            this.tbForm.Controls.Add(this.txtHighlightValue, 0, 16);
            this.tbForm.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tbForm.Controls.Add(this.label11, 0, 1);
            this.tbForm.Controls.Add(this.lblDNS, 0, 3);
            this.tbForm.Controls.Add(this.txtDNS, 0, 4);
            this.tbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbForm.Location = new System.Drawing.Point(0, 0);
            this.tbForm.Margin = new System.Windows.Forms.Padding(0);
            this.tbForm.Name = "tbForm";
            this.tbForm.Padding = new System.Windows.Forms.Padding(5);
            this.tbForm.RowCount = 20;
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbForm.Size = new System.Drawing.Size(300, 494);
            this.tbForm.TabIndex = 0;
            // 
            // lblConfigHeader
            // 
            this.lblConfigHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfigHeader.AutoSize = true;
            this.lblConfigHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblConfigHeader.ForeColor = System.Drawing.Color.White;
            this.lblConfigHeader.Location = new System.Drawing.Point(8, 5);
            this.lblConfigHeader.Name = "lblConfigHeader";
            this.lblConfigHeader.Size = new System.Drawing.Size(284, 24);
            this.lblConfigHeader.TabIndex = 0;
            this.lblConfigHeader.Text = "Config";
            this.lblConfigHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIPServer
            // 
            this.lblIPServer.AutoSize = true;
            this.lblIPServer.ForeColor = System.Drawing.Color.White;
            this.lblIPServer.Location = new System.Drawing.Point(8, 104);
            this.lblIPServer.Name = "lblIPServer";
            this.lblIPServer.Size = new System.Drawing.Size(51, 13);
            this.lblIPServer.TabIndex = 0;
            this.lblIPServer.Text = "IP Server";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.ForeColor = System.Drawing.Color.White;
            this.lblDatabase.Location = new System.Drawing.Point(8, 143);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 1;
            this.lblDatabase.Text = "Database";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(8, 182);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtIPServer
            // 
            this.txtIPServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIPServer.Location = new System.Drawing.Point(8, 120);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(284, 20);
            this.txtIPServer.TabIndex = 3;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatabase.Location = new System.Drawing.Point(8, 159);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(284, 20);
            this.txtDatabase.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(8, 198);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(284, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(8, 221);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(8, 237);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(284, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblReload
            // 
            this.lblReload.AutoSize = true;
            this.lblReload.ForeColor = System.Drawing.Color.White;
            this.lblReload.Location = new System.Drawing.Point(8, 260);
            this.lblReload.Name = "lblReload";
            this.lblReload.Size = new System.Drawing.Size(87, 13);
            this.lblReload.TabIndex = 2;
            this.lblReload.Text = "Reload (Second)";
            // 
            // txtReload
            // 
            this.txtReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReload.Location = new System.Drawing.Point(8, 276);
            this.txtReload.Name = "txtReload";
            this.txtReload.Size = new System.Drawing.Size(284, 20);
            this.txtReload.TabIndex = 6;
            // 
            // lblSQLQuery
            // 
            this.lblSQLQuery.AutoSize = true;
            this.lblSQLQuery.ForeColor = System.Drawing.Color.White;
            this.lblSQLQuery.Location = new System.Drawing.Point(8, 338);
            this.lblSQLQuery.Name = "lblSQLQuery";
            this.lblSQLQuery.Size = new System.Drawing.Size(59, 13);
            this.lblSQLQuery.TabIndex = 2;
            this.lblSQLQuery.Text = "SQL Query";
            // 
            // txtSQLQuery
            // 
            this.txtSQLQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(181)))), ((int)(((byte)(170)))));
            this.txtSQLQuery.Location = new System.Drawing.Point(8, 354);
            this.txtSQLQuery.Multiline = true;
            this.txtSQLQuery.Name = "txtSQLQuery";
            this.txtSQLQuery.Size = new System.Drawing.Size(284, 103);
            this.txtSQLQuery.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btStart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btStop, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 460);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 29);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btStart
            // 
            this.btStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btStart.Location = new System.Drawing.Point(67, 3);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(148, 3);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // lblHighlightValue
            // 
            this.lblHighlightValue.AutoSize = true;
            this.lblHighlightValue.ForeColor = System.Drawing.Color.White;
            this.lblHighlightValue.Location = new System.Drawing.Point(8, 299);
            this.lblHighlightValue.Name = "lblHighlightValue";
            this.lblHighlightValue.Size = new System.Drawing.Size(78, 13);
            this.lblHighlightValue.TabIndex = 2;
            this.lblHighlightValue.Text = "Highlight Value";
            // 
            // txtHighlightValue
            // 
            this.txtHighlightValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHighlightValue.Location = new System.Drawing.Point(8, 315);
            this.txtHighlightValue.Name = "txtHighlightValue";
            this.txtHighlightValue.Size = new System.Drawing.Size(284, 20);
            this.txtHighlightValue.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.rbSQL);
            this.flowLayoutPanel1.Controls.Add(this.rbODBC);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 42);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 23);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Checked = true;
            this.rbSQL.ForeColor = System.Drawing.Color.White;
            this.rbSQL.Location = new System.Drawing.Point(3, 3);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(77, 17);
            this.rbSQL.TabIndex = 9;
            this.rbSQL.TabStop = true;
            this.rbSQL.Text = "SQLServer";
            this.rbSQL.UseVisualStyleBackColor = true;
            this.rbSQL.CheckedChanged += new System.EventHandler(this.rbSQL_CheckedChanged);
            // 
            // rbODBC
            // 
            this.rbODBC.AutoSize = true;
            this.rbODBC.ForeColor = System.Drawing.Color.White;
            this.rbODBC.Location = new System.Drawing.Point(86, 3);
            this.rbODBC.Name = "rbODBC";
            this.rbODBC.Size = new System.Drawing.Size(55, 17);
            this.rbODBC.TabIndex = 9;
            this.rbODBC.Text = "ODBC";
            this.rbODBC.UseVisualStyleBackColor = true;
            this.rbODBC.CheckedChanged += new System.EventHandler(this.rbODBC_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "ConnectionType";
            // 
            // lblDNS
            // 
            this.lblDNS.AutoSize = true;
            this.lblDNS.ForeColor = System.Drawing.Color.White;
            this.lblDNS.Location = new System.Drawing.Point(8, 65);
            this.lblDNS.Name = "lblDNS";
            this.lblDNS.Size = new System.Drawing.Size(30, 13);
            this.lblDNS.TabIndex = 0;
            this.lblDNS.Text = "DNS";
            // 
            // txtDNS
            // 
            this.txtDNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDNS.Enabled = false;
            this.txtDNS.Location = new System.Drawing.Point(8, 81);
            this.txtDNS.Name = "txtDNS";
            this.txtDNS.Size = new System.Drawing.Size(284, 20);
            this.txtDNS.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblDataHeader, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gvDefault, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pbDefault, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(300, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(548, 494);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lblDataHeader
            // 
            this.lblDataHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataHeader.AutoSize = true;
            this.lblDataHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDataHeader.ForeColor = System.Drawing.Color.Black;
            this.lblDataHeader.Location = new System.Drawing.Point(8, 5);
            this.lblDataHeader.Name = "lblDataHeader";
            this.lblDataHeader.Size = new System.Drawing.Size(532, 24);
            this.lblDataHeader.TabIndex = 0;
            this.lblDataHeader.Text = "Data";
            this.lblDataHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvDefault
            // 
            this.gvDefault.AllowUserToAddRows = false;
            this.gvDefault.AllowUserToDeleteRows = false;
            this.gvDefault.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvDefault.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvDefault.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvDefault.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gvDefault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDefault.Location = new System.Drawing.Point(10, 83);
            this.gvDefault.Margin = new System.Windows.Forms.Padding(5);
            this.gvDefault.MultiSelect = false;
            this.gvDefault.Name = "gvDefault";
            this.gvDefault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDefault.ShowEditingIcon = false;
            this.gvDefault.Size = new System.Drawing.Size(528, 381);
            this.gvDefault.TabIndex = 1;
            this.gvDefault.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblTimer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLastUpdate, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTimerLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDataCount, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 29);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(538, 20);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.ForeColor = System.Drawing.Color.Crimson;
            this.lblLastUpdate.Location = new System.Drawing.Point(71, 0);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(197, 20);
            this.lblLastUpdate.TabIndex = 3;
            this.lblLastUpdate.Text = "-";
            this.lblLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "LastUpdate";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(274, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "DataCount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataCount
            // 
            this.lblDataCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataCount.AutoSize = true;
            this.lblDataCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDataCount.Location = new System.Drawing.Point(338, 0);
            this.lblDataCount.Name = "lblDataCount";
            this.lblDataCount.Size = new System.Drawing.Size(197, 20);
            this.lblDataCount.TabIndex = 3;
            this.lblDataCount.Text = "-";
            this.lblDataCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDefault
            // 
            this.timerDefault.Interval = 1000;
            this.timerDefault.Tick += new System.EventHandler(this.timerDefault_Tick);
            // 
            // backgroundWorkerDefault
            // 
            this.backgroundWorkerDefault.WorkerSupportsCancellation = true;
            this.backgroundWorkerDefault.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDefault_DoWork);
            // 
            // pbDefault
            // 
            this.pbDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDefault.Location = new System.Drawing.Point(8, 52);
            this.pbDefault.Name = "pbDefault";
            this.pbDefault.Size = new System.Drawing.Size(532, 23);
            this.pbDefault.Step = 1;
            this.pbDefault.TabIndex = 3;
            // 
            // lblTimerLabel
            // 
            this.lblTimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerLabel.AutoSize = true;
            this.lblTimerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimerLabel.Location = new System.Drawing.Point(3, 3);
            this.lblTimerLabel.Name = "lblTimerLabel";
            this.lblTimerLabel.Size = new System.Drawing.Size(1, 13);
            this.lblTimerLabel.TabIndex = 2;
            this.lblTimerLabel.Text = "Timer";
            this.lblTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer.Location = new System.Drawing.Point(3, 3);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(1, 13);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "-";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 494);
            this.Controls.Add(this.tbDefault);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Default";
            this.Text = "Default";
            this.Load += new System.EventHandler(this.Default_Load);
            this.tbDefault.ResumeLayout(false);
            this.tbDefault.PerformLayout();
            this.tbForm.ResumeLayout(false);
            this.tbForm.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDefault)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbDefault;
        private System.Windows.Forms.TableLayoutPanel tbForm;
        private System.Windows.Forms.DataGridView gvDefault;
        private System.Windows.Forms.Label lblIPServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblReload;
        private System.Windows.Forms.TextBox txtReload;
        private System.Windows.Forms.Label lblSQLQuery;
        private System.Windows.Forms.TextBox txtSQLQuery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer timerDefault;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDefault;
        private System.Windows.Forms.Label lblConfigHeader;
        private System.Windows.Forms.Label lblDataHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDataCount;
        private System.Windows.Forms.Label lblHighlightValue;
        private System.Windows.Forms.TextBox txtHighlightValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.RadioButton rbODBC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDNS;
        private System.Windows.Forms.TextBox txtDNS;
        private System.Windows.Forms.ProgressBar pbDefault;
        private System.Windows.Forms.ToolTip ttDefault;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimerLabel;
    }
}