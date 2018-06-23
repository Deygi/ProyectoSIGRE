namespace CapaPresentacion
{
    partial class Form_Login
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.bntLoggin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.bntLoggin);
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 362);
            this.panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 136);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 40);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(96, 68);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(256, 40);
            this.txtUser.TabIndex = 1;
            // 
            // bntLoggin
            // 
            this.bntLoggin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(187)))), ((int)(((byte)(206)))));
            this.bntLoggin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.bntLoggin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntLoggin.BorderRadius = 0;
            this.bntLoggin.ButtonText = "Ingresar";
            this.bntLoggin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLoggin.DisabledColor = System.Drawing.Color.Gray;
            this.bntLoggin.Font = new System.Drawing.Font("SegoeUISymbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLoggin.Iconcolor = System.Drawing.Color.Transparent;
            this.bntLoggin.Iconimage = null;
            this.bntLoggin.Iconimage_right = null;
            this.bntLoggin.Iconimage_right_Selected = null;
            this.bntLoggin.Iconimage_Selected = null;
            this.bntLoggin.IconMarginLeft = 0;
            this.bntLoggin.IconMarginRight = 0;
            this.bntLoggin.IconRightVisible = true;
            this.bntLoggin.IconRightZoom = 0D;
            this.bntLoggin.IconVisible = true;
            this.bntLoggin.IconZoom = 90D;
            this.bntLoggin.IsTab = false;
            this.bntLoggin.Location = new System.Drawing.Point(96, 200);
            this.bntLoggin.Margin = new System.Windows.Forms.Padding(0);
            this.bntLoggin.Name = "bntLoggin";
            this.bntLoggin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.bntLoggin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.bntLoggin.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntLoggin.Padding = new System.Windows.Forms.Padding(1);
            this.bntLoggin.selected = false;
            this.bntLoggin.Size = new System.Drawing.Size(256, 48);
            this.bntLoggin.TabIndex = 3;
            this.bntLoggin.Text = "Ingresar";
            this.bntLoggin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntLoggin.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntLoggin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLoggin.Click += new System.EventHandler(this.bntLoggin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.girl__2_;
            this.pictureBox1.Location = new System.Drawing.Point(96, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.Empty;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "Cancelar";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("SegoeUISymbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = null;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(96, 266);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.btnExit.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Padding = new System.Windows.Forms.Padding(1);
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(256, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Cancelar";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bntLoggin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}