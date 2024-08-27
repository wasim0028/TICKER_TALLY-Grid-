namespace TICKER_TALLY
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.cmbVizHost = new System.Windows.Forms.ComboBox();
            this.listState = new System.Windows.Forms.ListBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.tbSTotal = new System.Windows.Forms.TextBox();
            this.tbPartyNo = new System.Windows.Forms.TextBox();
            this.dgvStateTally = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbParty1 = new System.Windows.Forms.TextBox();
            this.tbParty2 = new System.Windows.Forms.TextBox();
            this.tbParty3 = new System.Windows.Forms.TextBox();
            this.tbParty4 = new System.Windows.Forms.TextBox();
            this.tbParty5 = new System.Windows.Forms.TextBox();
            this.tbSeats5 = new System.Windows.Forms.TextBox();
            this.tbSeats4 = new System.Windows.Forms.TextBox();
            this.tbSeats3 = new System.Windows.Forms.TextBox();
            this.tbSeats2 = new System.Windows.Forms.TextBox();
            this.tbSeats1 = new System.Windows.Forms.TextBox();
            this.tbStot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSceneLoad = new System.Windows.Forms.Button();
            this.tbSeats6 = new System.Windows.Forms.TextBox();
            this.tbParty6 = new System.Windows.Forms.TextBox();
            this.dgvZone3 = new System.Windows.Forms.DataGridView();
            this.timerZone3 = new System.Windows.Forms.Timer(this.components);
            this.tbZone3State = new System.Windows.Forms.TextBox();
            this.tbZone3Cname = new System.Windows.Forms.TextBox();
            this.tbZone3Pname = new System.Windows.Forms.TextBox();
            this.tbZone3CandName = new System.Windows.Forms.TextBox();
            this.tbZone3Status = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Zone3Check = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rd_Backup = new System.Windows.Forms.RadioButton();
            this.rd_MainDB = new System.Windows.Forms.RadioButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateTally)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZone3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Enabled = false;
            this.tbIP.Location = new System.Drawing.Point(541, 50);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 0;
            // 
            // cmbVizHost
            // 
            this.cmbVizHost.FormattingEnabled = true;
            this.cmbVizHost.Location = new System.Drawing.Point(653, 49);
            this.cmbVizHost.Name = "cmbVizHost";
            this.cmbVizHost.Size = new System.Drawing.Size(135, 21);
            this.cmbVizHost.TabIndex = 1;
            this.cmbVizHost.SelectedIndexChanged += new System.EventHandler(this.cmbVizHost_SelectedIndexChanged);
            // 
            // listState
            // 
            this.listState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listState.FormattingEnabled = true;
            this.listState.ItemHeight = 18;
            this.listState.Location = new System.Drawing.Point(12, 31);
            this.listState.Name = "listState";
            this.listState.Size = new System.Drawing.Size(140, 166);
            this.listState.TabIndex = 2;
            this.listState.SelectedIndexChanged += new System.EventHandler(this.listState_SelectedIndexChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(208, 49);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(46, 20);
            this.tbID.TabIndex = 3;
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(263, 49);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(120, 20);
            this.tbSname.TabIndex = 4;
            // 
            // tbSTotal
            // 
            this.tbSTotal.Location = new System.Drawing.Point(398, 49);
            this.tbSTotal.Name = "tbSTotal";
            this.tbSTotal.Size = new System.Drawing.Size(49, 20);
            this.tbSTotal.TabIndex = 5;
            // 
            // tbPartyNo
            // 
            this.tbPartyNo.Location = new System.Drawing.Point(458, 50);
            this.tbPartyNo.Name = "tbPartyNo";
            this.tbPartyNo.Size = new System.Drawing.Size(46, 20);
            this.tbPartyNo.TabIndex = 6;
            // 
            // dgvStateTally
            // 
            this.dgvStateTally.AllowUserToAddRows = false;
            this.dgvStateTally.AllowUserToDeleteRows = false;
            this.dgvStateTally.BackgroundColor = System.Drawing.Color.Black;
            this.dgvStateTally.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStateTally.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStateTally.Location = new System.Drawing.Point(12, 233);
            this.dgvStateTally.Name = "dgvStateTally";
            this.dgvStateTally.Size = new System.Drawing.Size(444, 150);
            this.dgvStateTally.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(12, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "LOOP STATE\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbParty1
            // 
            this.tbParty1.Location = new System.Drawing.Point(209, 111);
            this.tbParty1.Name = "tbParty1";
            this.tbParty1.Size = new System.Drawing.Size(52, 20);
            this.tbParty1.TabIndex = 9;
            // 
            // tbParty2
            // 
            this.tbParty2.Location = new System.Drawing.Point(282, 111);
            this.tbParty2.Name = "tbParty2";
            this.tbParty2.Size = new System.Drawing.Size(52, 20);
            this.tbParty2.TabIndex = 10;
            // 
            // tbParty3
            // 
            this.tbParty3.Location = new System.Drawing.Point(355, 111);
            this.tbParty3.Name = "tbParty3";
            this.tbParty3.Size = new System.Drawing.Size(52, 20);
            this.tbParty3.TabIndex = 11;
            // 
            // tbParty4
            // 
            this.tbParty4.Location = new System.Drawing.Point(429, 111);
            this.tbParty4.Name = "tbParty4";
            this.tbParty4.Size = new System.Drawing.Size(52, 20);
            this.tbParty4.TabIndex = 12;
            // 
            // tbParty5
            // 
            this.tbParty5.Location = new System.Drawing.Point(503, 111);
            this.tbParty5.Name = "tbParty5";
            this.tbParty5.Size = new System.Drawing.Size(52, 20);
            this.tbParty5.TabIndex = 13;
            // 
            // tbSeats5
            // 
            this.tbSeats5.Location = new System.Drawing.Point(503, 154);
            this.tbSeats5.Name = "tbSeats5";
            this.tbSeats5.Size = new System.Drawing.Size(52, 20);
            this.tbSeats5.TabIndex = 18;
            // 
            // tbSeats4
            // 
            this.tbSeats4.Location = new System.Drawing.Point(429, 154);
            this.tbSeats4.Name = "tbSeats4";
            this.tbSeats4.Size = new System.Drawing.Size(52, 20);
            this.tbSeats4.TabIndex = 17;
            // 
            // tbSeats3
            // 
            this.tbSeats3.Location = new System.Drawing.Point(355, 154);
            this.tbSeats3.Name = "tbSeats3";
            this.tbSeats3.Size = new System.Drawing.Size(52, 20);
            this.tbSeats3.TabIndex = 16;
            // 
            // tbSeats2
            // 
            this.tbSeats2.Location = new System.Drawing.Point(282, 154);
            this.tbSeats2.Name = "tbSeats2";
            this.tbSeats2.Size = new System.Drawing.Size(52, 20);
            this.tbSeats2.TabIndex = 15;
            // 
            // tbSeats1
            // 
            this.tbSeats1.Location = new System.Drawing.Point(209, 154);
            this.tbSeats1.Name = "tbSeats1";
            this.tbSeats1.Size = new System.Drawing.Size(52, 20);
            this.tbSeats1.TabIndex = 14;
            // 
            // tbStot
            // 
            this.tbStot.Location = new System.Drawing.Point(355, 75);
            this.tbStot.Name = "tbStot";
            this.tbStot.Size = new System.Drawing.Size(46, 20);
            this.tbStot.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // btnSceneLoad
            // 
            this.btnSceneLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSceneLoad.Location = new System.Drawing.Point(492, 302);
            this.btnSceneLoad.Name = "btnSceneLoad";
            this.btnSceneLoad.Size = new System.Drawing.Size(288, 81);
            this.btnSceneLoad.TabIndex = 22;
            this.btnSceneLoad.Text = "LOAD";
            this.btnSceneLoad.UseVisualStyleBackColor = true;
            this.btnSceneLoad.Click += new System.EventHandler(this.btnSceneLoad_Click);
            // 
            // tbSeats6
            // 
            this.tbSeats6.Location = new System.Drawing.Point(570, 154);
            this.tbSeats6.Name = "tbSeats6";
            this.tbSeats6.Size = new System.Drawing.Size(52, 20);
            this.tbSeats6.TabIndex = 24;
            // 
            // tbParty6
            // 
            this.tbParty6.Location = new System.Drawing.Point(570, 111);
            this.tbParty6.Name = "tbParty6";
            this.tbParty6.Size = new System.Drawing.Size(52, 20);
            this.tbParty6.TabIndex = 23;
            // 
            // dgvZone3
            // 
            this.dgvZone3.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZone3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvZone3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZone3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvZone3.Enabled = false;
            this.dgvZone3.Location = new System.Drawing.Point(12, 509);
            this.dgvZone3.Name = "dgvZone3";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZone3.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvZone3.Size = new System.Drawing.Size(729, 134);
            this.dgvZone3.TabIndex = 1;
            this.dgvZone3.Visible = false;
            // 
            // timerZone3
            // 
            this.timerZone3.Interval = 5000;
            this.timerZone3.Tick += new System.EventHandler(this.timerZone3_Tick);
            // 
            // tbZone3State
            // 
            this.tbZone3State.Enabled = false;
            this.tbZone3State.Location = new System.Drawing.Point(15, 483);
            this.tbZone3State.Name = "tbZone3State";
            this.tbZone3State.Size = new System.Drawing.Size(90, 20);
            this.tbZone3State.TabIndex = 25;
            this.tbZone3State.Visible = false;
            // 
            // tbZone3Cname
            // 
            this.tbZone3Cname.Enabled = false;
            this.tbZone3Cname.Location = new System.Drawing.Point(108, 483);
            this.tbZone3Cname.Name = "tbZone3Cname";
            this.tbZone3Cname.Size = new System.Drawing.Size(90, 20);
            this.tbZone3Cname.TabIndex = 26;
            this.tbZone3Cname.Visible = false;
            // 
            // tbZone3Pname
            // 
            this.tbZone3Pname.Enabled = false;
            this.tbZone3Pname.Location = new System.Drawing.Point(204, 483);
            this.tbZone3Pname.Name = "tbZone3Pname";
            this.tbZone3Pname.Size = new System.Drawing.Size(57, 20);
            this.tbZone3Pname.TabIndex = 27;
            this.tbZone3Pname.Visible = false;
            // 
            // tbZone3CandName
            // 
            this.tbZone3CandName.Enabled = false;
            this.tbZone3CandName.Location = new System.Drawing.Point(267, 483);
            this.tbZone3CandName.Name = "tbZone3CandName";
            this.tbZone3CandName.Size = new System.Drawing.Size(134, 20);
            this.tbZone3CandName.TabIndex = 28;
            this.tbZone3CandName.Visible = false;
            // 
            // tbZone3Status
            // 
            this.tbZone3Status.Enabled = false;
            this.tbZone3Status.Location = new System.Drawing.Point(407, 483);
            this.tbZone3Status.Name = "tbZone3Status";
            this.tbZone3Status.Size = new System.Drawing.Size(49, 20);
            this.tbZone3Status.TabIndex = 29;
            this.tbZone3Status.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(332, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "START ZONE3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zone3Check
            // 
            this.Zone3Check.AutoSize = true;
            this.Zone3Check.Enabled = false;
            this.Zone3Check.Location = new System.Drawing.Point(647, 670);
            this.Zone3Check.Name = "Zone3Check";
            this.Zone3Check.Size = new System.Drawing.Size(94, 17);
            this.Zone3Check.TabIndex = 31;
            this.Zone3Check.Text = "LOOP ZONE3";
            this.Zone3Check.UseVisualStyleBackColor = true;
            this.Zone3Check.Visible = false;
            this.Zone3Check.CheckedChanged += new System.EventHandler(this.Zone3Check_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Red;
            this.checkBox2.Location = new System.Drawing.Point(627, 206);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 20);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "AUTO UPDATE";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(540, 400);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 40;
            this.button6.Text = "GPI OUT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(420, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 23);
            this.button5.TabIndex = 39;
            this.button5.Text = "GPI IN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(295, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "REC";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "LIVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rd_Backup
            // 
            this.rd_Backup.AutoSize = true;
            this.rd_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Backup.Location = new System.Drawing.Point(347, 7);
            this.rd_Backup.Name = "rd_Backup";
            this.rd_Backup.Size = new System.Drawing.Size(78, 17);
            this.rd_Backup.TabIndex = 42;
            this.rd_Backup.TabStop = true;
            this.rd_Backup.Text = "BACK UP";
            this.rd_Backup.UseVisualStyleBackColor = true;
            this.rd_Backup.CheckedChanged += new System.EventHandler(this.rd_Backup_CheckedChanged);
            // 
            // rd_MainDB
            // 
            this.rd_MainDB.AutoSize = true;
            this.rd_MainDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_MainDB.Location = new System.Drawing.Point(198, 7);
            this.rd_MainDB.Name = "rd_MainDB";
            this.rd_MainDB.Size = new System.Drawing.Size(56, 17);
            this.rd_MainDB.TabIndex = 41;
            this.rd_MainDB.TabStop = true;
            this.rd_MainDB.Text = "MAIN";
            this.rd_MainDB.UseVisualStyleBackColor = true;
            this.rd_MainDB.CheckedChanged += new System.EventHandler(this.rd_MainDB_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tbServerName
            // 
            this.tbServerName.Enabled = false;
            this.tbServerName.Location = new System.Drawing.Point(492, 8);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(76, 20);
            this.tbServerName.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(261, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "MANUAL TALLY PLAY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.rd_Backup);
            this.Controls.Add(this.rd_MainDB);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Zone3Check);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbZone3Status);
            this.Controls.Add(this.tbZone3CandName);
            this.Controls.Add(this.tbZone3Pname);
            this.Controls.Add(this.tbZone3Cname);
            this.Controls.Add(this.tbZone3State);
            this.Controls.Add(this.dgvZone3);
            this.Controls.Add(this.tbSeats6);
            this.Controls.Add(this.tbParty6);
            this.Controls.Add(this.btnSceneLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStot);
            this.Controls.Add(this.tbSeats5);
            this.Controls.Add(this.tbSeats4);
            this.Controls.Add(this.tbSeats3);
            this.Controls.Add(this.tbSeats2);
            this.Controls.Add(this.tbSeats1);
            this.Controls.Add(this.tbParty5);
            this.Controls.Add(this.tbParty4);
            this.Controls.Add(this.tbParty3);
            this.Controls.Add(this.tbParty2);
            this.Controls.Add(this.tbParty1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvStateTally);
            this.Controls.Add(this.tbPartyNo);
            this.Controls.Add(this.tbSTotal);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.listState);
            this.Controls.Add(this.cmbVizHost);
            this.Controls.Add(this.tbIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateTally)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZone3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.ComboBox cmbVizHost;
        private System.Windows.Forms.ListBox listState;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.TextBox tbSTotal;
        private System.Windows.Forms.TextBox tbPartyNo;
        private System.Windows.Forms.DataGridView dgvStateTally;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbParty1;
        private System.Windows.Forms.TextBox tbParty2;
        private System.Windows.Forms.TextBox tbParty3;
        private System.Windows.Forms.TextBox tbParty4;
        private System.Windows.Forms.TextBox tbParty5;
        private System.Windows.Forms.TextBox tbSeats5;
        private System.Windows.Forms.TextBox tbSeats4;
        private System.Windows.Forms.TextBox tbSeats3;
        private System.Windows.Forms.TextBox tbSeats2;
        private System.Windows.Forms.TextBox tbSeats1;
        private System.Windows.Forms.TextBox tbStot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSceneLoad;
        private System.Windows.Forms.TextBox tbSeats6;
        private System.Windows.Forms.TextBox tbParty6;
        private System.Windows.Forms.DataGridView dgvZone3;
        private System.Windows.Forms.Timer timerZone3;
        private System.Windows.Forms.TextBox tbZone3State;
        private System.Windows.Forms.TextBox tbZone3Cname;
        private System.Windows.Forms.TextBox tbZone3Pname;
        private System.Windows.Forms.TextBox tbZone3CandName;
        private System.Windows.Forms.TextBox tbZone3Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Zone3Check;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rd_Backup;
        private System.Windows.Forms.RadioButton rd_MainDB;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Label label3;
    }
}

