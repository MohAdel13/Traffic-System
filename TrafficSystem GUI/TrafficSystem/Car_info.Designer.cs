namespace TrafficSystem
{
    partial class Car_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_info));
            this.Fine_show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fines_box = new System.Windows.Forms.ComboBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Info_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fine_show
            // 
            this.Fine_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fine_show.Location = new System.Drawing.Point(580, 277);
            this.Fine_show.Name = "Fine_show";
            this.Fine_show.Size = new System.Drawing.Size(110, 36);
            this.Fine_show.TabIndex = 1;
            this.Fine_show.Text = "Show details";
            this.Fine_show.UseVisualStyleBackColor = true;
            this.Fine_show.Click += new System.EventHandler(this.Fine_show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(189, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fine ID : ";
            // 
            // fines_box
            // 
            this.fines_box.FormattingEnabled = true;
            this.fines_box.Location = new System.Drawing.Point(314, 287);
            this.fines_box.Name = "fines_box";
            this.fines_box.Size = new System.Drawing.Size(162, 21);
            this.fines_box.TabIndex = 3;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(543, 391);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(80, 36);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(193, 391);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(100, 36);
            this.Back_btn.TabIndex = 5;
            this.Back_btn.Text = "Main Menu";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Info_txt
            // 
            this.Info_txt.AutoSize = true;
            this.Info_txt.BackColor = System.Drawing.Color.Transparent;
            this.Info_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_txt.ForeColor = System.Drawing.Color.Snow;
            this.Info_txt.Location = new System.Drawing.Point(12, 9);
            this.Info_txt.Name = "Info_txt";
            this.Info_txt.Size = new System.Drawing.Size(28, 16);
            this.Info_txt.TabIndex = 6;
            this.Info_txt.Text = "Info";
            // 
            // Car_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrafficSystem.Properties.Resources.raining_g0e9f21d87_1280;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Info_txt);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.fines_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fine_show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Car_info";
            this.Text = "Car_info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Car_info_FormClosed);
            this.Load += new System.EventHandler(this.Car_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Fine_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fines_box;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label Info_txt;
    }
}