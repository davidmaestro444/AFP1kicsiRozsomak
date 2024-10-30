namespace User_Menu
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
            this.menu = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackgroundImage = global::User_Menu.Properties.Resources.menu;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.btn_exit);
            this.menu.Controls.Add(this.btn_start);
            this.menu.Location = new System.Drawing.Point(139, 30);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(298, 397);
            this.menu.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Image = global::User_Menu.Properties.Resources.start_normal;
            this.btn_start.Location = new System.Drawing.Point(45, 113);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(214, 111);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_start.TabIndex = 0;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::User_Menu.Properties.Resources.exit_normal;
            this.btn_exit.Location = new System.Drawing.Point(45, 230);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(214, 111);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "User_Menu";
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_start;
    }
}

