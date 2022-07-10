namespace TrafficSystem
{
    partial class Officer_Mode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Officer_Mode));
            this.Type_box = new System.Windows.Forms.ComboBox();
            this.Edt_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Log_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Type_box
            // 
            this.Type_box.FormattingEnabled = true;
            this.Type_box.Location = new System.Drawing.Point(386, 213);
            this.Type_box.Name = "Type_box";
            this.Type_box.Size = new System.Drawing.Size(200, 21);
            this.Type_box.TabIndex = 0;
            // 
            // Edt_btn
            // 
            this.Edt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edt_btn.Location = new System.Drawing.Point(347, 298);
            this.Edt_btn.Name = "Edt_btn";
            this.Edt_btn.Size = new System.Drawing.Size(80, 36);
            this.Edt_btn.TabIndex = 1;
            this.Edt_btn.Text = "Edit";
            this.Edt_btn.UseVisualStyleBackColor = true;
            this.Edt_btn.Click += new System.EventHandler(this.Edt_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(544, 393);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(80, 36);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Log_btn
            // 
            this.Log_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_btn.Location = new System.Drawing.Point(203, 393);
            this.Log_btn.Name = "Log_btn";
            this.Log_btn.Size = new System.Drawing.Size(80, 36);
            this.Log_btn.TabIndex = 3;
            this.Log_btn.Text = "Log out";
            this.Log_btn.UseVisualStyleBackColor = true;
            this.Log_btn.Click += new System.EventHandler(this.Log_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose what to edit :";
            // 
            // Officer_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrafficSystem.Properties.Resources.highway_g962400c1b_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Edt_btn);
            this.Controls.Add(this.Type_box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Officer_Mode";
            this.Text = "Officer_Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Officer_Mode_FormClosed);
            this.Load += new System.EventHandler(this.Officer_Mode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Type_box;
        private System.Windows.Forms.Button Edt_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Log_btn;
        private System.Windows.Forms.Label label1;
    }
}