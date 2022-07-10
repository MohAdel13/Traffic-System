namespace TrafficSystem
{
    partial class Driver_Mode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver_Mode));
            this.label1 = new System.Windows.Forms.Label();
            this.Car_box = new System.Windows.Forms.ComboBox();
            this.chk_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Info1_txt = new System.Windows.Forms.Label();
            this.Info2_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(133, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car you want to check for:";
            // 
            // Car_box
            // 
            this.Car_box.FormattingEnabled = true;
            this.Car_box.Location = new System.Drawing.Point(364, 306);
            this.Car_box.Name = "Car_box";
            this.Car_box.Size = new System.Drawing.Size(163, 21);
            this.Car_box.TabIndex = 2;
            // 
            // chk_btn
            // 
            this.chk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_btn.Location = new System.Drawing.Point(599, 296);
            this.chk_btn.Name = "chk_btn";
            this.chk_btn.Size = new System.Drawing.Size(80, 36);
            this.chk_btn.TabIndex = 3;
            this.chk_btn.Text = "Check";
            this.chk_btn.UseVisualStyleBackColor = true;
            this.chk_btn.Click += new System.EventHandler(this.chk_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(543, 387);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(80, 36);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.Location = new System.Drawing.Point(214, 387);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(80, 36);
            this.Logout_btn.TabIndex = 5;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Info1_txt
            // 
            this.Info1_txt.AutoSize = true;
            this.Info1_txt.BackColor = System.Drawing.Color.Transparent;
            this.Info1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info1_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.Info1_txt.Location = new System.Drawing.Point(12, 9);
            this.Info1_txt.Name = "Info1_txt";
            this.Info1_txt.Size = new System.Drawing.Size(28, 16);
            this.Info1_txt.TabIndex = 6;
            this.Info1_txt.Text = "Info";
            // 
            // Info2_txt
            // 
            this.Info2_txt.AutoSize = true;
            this.Info2_txt.BackColor = System.Drawing.Color.Transparent;
            this.Info2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info2_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.Info2_txt.Location = new System.Drawing.Point(12, 151);
            this.Info2_txt.Name = "Info2_txt";
            this.Info2_txt.Size = new System.Drawing.Size(28, 16);
            this.Info2_txt.TabIndex = 7;
            this.Info2_txt.Text = "Info";
            // 
            // Driver_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrafficSystem.Properties.Resources.raining_g0e9f21d87_1280;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Info2_txt);
            this.Controls.Add(this.Info1_txt);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.chk_btn);
            this.Controls.Add(this.Car_box);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Driver_Mode";
            this.Text = "Driver_Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Driver_Mode_FormClosed);
            this.Load += new System.EventHandler(this.Driver_Mode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Car_box;
        private System.Windows.Forms.Button chk_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label Info1_txt;
        private System.Windows.Forms.Label Info2_txt;
    }
}