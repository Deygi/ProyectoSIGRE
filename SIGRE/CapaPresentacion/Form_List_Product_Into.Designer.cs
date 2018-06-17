namespace CapaPresentacion
{
    partial class Form_List_Product_Into
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
            this.label8 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntBefore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dGridListProducts = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridListProducts)).BeginInit();
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
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 100);
            this.panel1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(33, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(669, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "INVESTIGACION DE PRECIOS EN MERCADOS MINORISTAS DE  CUIDADES DEL INTERIOR DEL PAI" +
    "S";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProduct.Location = new System.Drawing.Point(466, 134);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(158, 20);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "LISTA DE PRODUCTOS";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::CapaPresentacion.Properties.Resources.close__2_;
            this.btnClose.Location = new System.Drawing.Point(1079, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dGridListProducts);
            this.panel2.Controls.Add(this.bntBefore);
            this.panel2.Location = new System.Drawing.Point(55, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 467);
            this.panel2.TabIndex = 8;
            // 
            // bntBefore
            // 
            this.bntBefore.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.bntBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.bntBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntBefore.BorderRadius = 0;
            this.bntBefore.ButtonText = "Anterior";
            this.bntBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntBefore.DisabledColor = System.Drawing.Color.Gray;
            this.bntBefore.Font = new System.Drawing.Font("SegoeUISymbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBefore.Iconcolor = System.Drawing.Color.Transparent;
            this.bntBefore.Iconimage = null;
            this.bntBefore.Iconimage_right = null;
            this.bntBefore.Iconimage_right_Selected = null;
            this.bntBefore.Iconimage_Selected = null;
            this.bntBefore.IconMarginLeft = 0;
            this.bntBefore.IconMarginRight = 0;
            this.bntBefore.IconRightVisible = true;
            this.bntBefore.IconRightZoom = 0D;
            this.bntBefore.IconVisible = true;
            this.bntBefore.IconZoom = 90D;
            this.bntBefore.IsTab = false;
            this.bntBefore.Location = new System.Drawing.Point(814, 416);
            this.bntBefore.Margin = new System.Windows.Forms.Padding(0);
            this.bntBefore.Name = "bntBefore";
            this.bntBefore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.bntBefore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.bntBefore.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntBefore.Padding = new System.Windows.Forms.Padding(1);
            this.bntBefore.selected = false;
            this.bntBefore.Size = new System.Drawing.Size(187, 32);
            this.bntBefore.TabIndex = 26;
            this.bntBefore.Text = "Anterior";
            this.bntBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntBefore.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntBefore.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBefore.Click += new System.EventHandler(this.bntBefore_Click);
            // 
            // dGridListProducts
            // 
            this.dGridListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridListProducts.Location = new System.Drawing.Point(11, 15);
            this.dGridListProducts.Name = "dGridListProducts";
            this.dGridListProducts.Size = new System.Drawing.Size(1001, 385);
            this.dGridListProducts.TabIndex = 27;
            // 
            // Form_List_Product_Into
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_List_Product_Into";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_List_Product_Into";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridListProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton bntBefore;
        private System.Windows.Forms.DataGridView dGridListProducts;
    }
}