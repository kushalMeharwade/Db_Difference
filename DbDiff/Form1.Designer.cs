namespace DbDiff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnLatest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientPass = new System.Windows.Forms.TextBox();
            this.txtLatestPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MissingTables = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClientTables = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LatestTableList = new System.Windows.Forms.ListBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnColumns = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnColumns);
            this.panel1.Controls.Add(this.btnCompare);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnLatest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtClientPass);
            this.panel1.Controls.Add(this.txtLatestPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 828);
            this.panel1.TabIndex = 0;
            // 
            // btnClient
            // 
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClient.Location = new System.Drawing.Point(13, 360);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(240, 64);
            this.btnClient.TabIndex = 7;
            this.btnClient.Text = "openClient Db";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnLatest
            // 
            this.btnLatest.Location = new System.Drawing.Point(11, 290);
            this.btnLatest.Name = "btnLatest";
            this.btnLatest.Size = new System.Drawing.Size(241, 54);
            this.btnLatest.TabIndex = 6;
            this.btnLatest.Text = "open Latest DB";
            this.btnLatest.UseVisualStyleBackColor = true;
            this.btnLatest.Click += new System.EventHandler(this.btnLatest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latest Database";
            // 
            // txtClientPass
            // 
            this.txtClientPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientPass.Location = new System.Drawing.Point(29, 235);
            this.txtClientPass.Name = "txtClientPass";
            this.txtClientPass.Size = new System.Drawing.Size(211, 35);
            this.txtClientPass.TabIndex = 3;
            // 
            // txtLatestPass
            // 
            this.txtLatestPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatestPass.Location = new System.Drawing.Point(29, 94);
            this.txtLatestPass.Name = "txtLatestPass";
            this.txtLatestPass.Size = new System.Drawing.Size(211, 35);
            this.txtLatestPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Database";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(263, 728);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(263, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1234, 728);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(665, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(360, 726);
            this.panel6.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MissingTables);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 726);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Missing Tables";
            // 
            // MissingTables
            // 
            this.MissingTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MissingTables.FormattingEnabled = true;
            this.MissingTables.ItemHeight = 29;
            this.MissingTables.Location = new System.Drawing.Point(3, 31);
            this.MissingTables.Name = "MissingTables";
            this.MissingTables.Size = new System.Drawing.Size(354, 692);
            this.MissingTables.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(307, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 726);
            this.panel5.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClientTables);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 726);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Database Tables";
            // 
            // ClientTables
            // 
            this.ClientTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientTables.FormattingEnabled = true;
            this.ClientTables.ItemHeight = 29;
            this.ClientTables.Location = new System.Drawing.Point(3, 31);
            this.ClientTables.Name = "ClientTables";
            this.ClientTables.Size = new System.Drawing.Size(352, 692);
            this.ClientTables.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 726);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LatestTableList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 726);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Latest Database Tables";
            // 
            // LatestTableList
            // 
            this.LatestTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LatestTableList.FormattingEnabled = true;
            this.LatestTableList.ItemHeight = 29;
            this.LatestTableList.Location = new System.Drawing.Point(3, 31);
            this.LatestTableList.Name = "LatestTableList";
            this.LatestTableList.Size = new System.Drawing.Size(301, 692);
            this.LatestTableList.TabIndex = 0;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(13, 444);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(239, 65);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "Compare Tables";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnColumns
            // 
            this.btnColumns.Location = new System.Drawing.Point(11, 532);
            this.btnColumns.Name = "btnColumns";
            this.btnColumns.Size = new System.Drawing.Size(241, 49);
            this.btnColumns.TabIndex = 9;
            this.btnColumns.Text = "Compare Columns";
            this.btnColumns.UseVisualStyleBackColor = true;
            this.btnColumns.Click += new System.EventHandler(this.btnColumns_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 828);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Db Differ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClientPass;
        private System.Windows.Forms.TextBox txtLatestPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnLatest;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox MissingTables;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ClientTables;
        private System.Windows.Forms.ListBox LatestTableList;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnColumns;
    }
}

