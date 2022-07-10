namespace TrafficSystem
{
    partial class AddressEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressEdit));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.RefBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.InsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EdtBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DelBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Gov_txt = new System.Windows.Forms.TextBox();
            this.Cit_txt = new System.Windows.Forms.TextBox();
            this.St_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.Main_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.RefBtn,
            this.toolStripSeparator1,
            this.InsBtn,
            this.toolStripSeparator2,
            this.EdtBtn,
            this.toolStripSeparator3,
            this.DelBtn,
            this.toolStripSeparator5,
            this.HelpBtn,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Re";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // RefBtn
            // 
            this.RefBtn.Image = global::TrafficSystem.Properties.Resources.refresh;
            this.RefBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefBtn.Name = "RefBtn";
            this.RefBtn.Size = new System.Drawing.Size(66, 22);
            this.RefBtn.Text = "Refresh";
            this.RefBtn.Click += new System.EventHandler(this.RefBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // InsBtn
            // 
            this.InsBtn.Image = global::TrafficSystem.Properties.Resources.insert;
            this.InsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsBtn.Name = "InsBtn";
            this.InsBtn.Size = new System.Drawing.Size(56, 22);
            this.InsBtn.Text = "Insert";
            this.InsBtn.Click += new System.EventHandler(this.InsBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // EdtBtn
            // 
            this.EdtBtn.Image = global::TrafficSystem.Properties.Resources.editing;
            this.EdtBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EdtBtn.Name = "EdtBtn";
            this.EdtBtn.Size = new System.Drawing.Size(47, 22);
            this.EdtBtn.Text = "Edit";
            this.EdtBtn.Click += new System.EventHandler(this.EdtBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DelBtn
            // 
            this.DelBtn.Image = global::TrafficSystem.Properties.Resources.remove;
            this.DelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(60, 22);
            this.DelBtn.Text = "Delete";
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // HelpBtn
            // 
            this.HelpBtn.Image = global::TrafficSystem.Properties.Resources.question;
            this.HelpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(52, 22);
            this.HelpBtn.Text = "Help";
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // Gov_txt
            // 
            this.Gov_txt.Location = new System.Drawing.Point(669, 140);
            this.Gov_txt.Name = "Gov_txt";
            this.Gov_txt.Size = new System.Drawing.Size(160, 20);
            this.Gov_txt.TabIndex = 6;
            // 
            // Cit_txt
            // 
            this.Cit_txt.Location = new System.Drawing.Point(669, 207);
            this.Cit_txt.Name = "Cit_txt";
            this.Cit_txt.Size = new System.Drawing.Size(160, 20);
            this.Cit_txt.TabIndex = 7;
            // 
            // St_txt
            // 
            this.St_txt.Location = new System.Drawing.Point(669, 270);
            this.St_txt.Name = "St_txt";
            this.St_txt.Size = new System.Drawing.Size(160, 20);
            this.St_txt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(539, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Governorate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(539, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "City :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(539, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Street :";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IDLabel.Location = new System.Drawing.Point(539, 70);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(30, 18);
            this.IDLabel.TabIndex = 12;
            this.IDLabel.Text = "ID :";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(669, 70);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(77, 20);
            this.ID_txt.TabIndex = 13;
            // 
            // Main_btn
            // 
            this.Main_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_btn.Location = new System.Drawing.Point(192, 391);
            this.Main_btn.Name = "Main_btn";
            this.Main_btn.Size = new System.Drawing.Size(100, 36);
            this.Main_btn.TabIndex = 14;
            this.Main_btn.Text = "Main menu";
            this.Main_btn.UseVisualStyleBackColor = true;
            this.Main_btn.Click += new System.EventHandler(this.Main_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(558, 391);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(80, 36);
            this.Exit_btn.TabIndex = 15;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // AddressEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrafficSystem.Properties.Resources.highway_g962400c1b_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Main_btn);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.St_txt);
            this.Controls.Add(this.Cit_txt);
            this.Controls.Add(this.Gov_txt);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddressEdit";
            this.Text = "AddressEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddressEdit_FormClosed);
            this.Load += new System.EventHandler(this.AddressEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RefBtn;
        private System.Windows.Forms.ToolStripButton DelBtn;
        private System.Windows.Forms.ToolStripButton InsBtn;
        private System.Windows.Forms.ToolStripButton EdtBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TextBox Gov_txt;
        private System.Windows.Forms.TextBox Cit_txt;
        private System.Windows.Forms.TextBox St_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Button Main_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.ToolStripButton HelpBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}