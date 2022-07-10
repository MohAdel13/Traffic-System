namespace TrafficSystem
{
    partial class Fine_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fine_info));
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Info_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(545, 393);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(80, 36);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(197, 393);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(100, 36);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "Main Menu";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Info_txt
            // 
            this.Info_txt.AutoSize = true;
            this.Info_txt.BackColor = System.Drawing.Color.Transparent;
            this.Info_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_txt.ForeColor = System.Drawing.Color.Snow;
            this.Info_txt.Location = new System.Drawing.Point(12, 9);
            this.Info_txt.Name = "Info_txt";
            this.Info_txt.Size = new System.Drawing.Size(47, 25);
            this.Info_txt.TabIndex = 4;
            this.Info_txt.Text = "Info";
            // 
            // Fine_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrafficSystem.Properties.Resources.raining_g0e9f21d87_1280;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Info_txt);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fine_info";
            this.Text = "Fine_info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fine_info_FormClosed);
            this.Load += new System.EventHandler(this.Fine_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label Info_txt;
    }
}