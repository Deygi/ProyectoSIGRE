namespace CapaPresentacion
{
    partial class Form_Into_Sample_Product
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTypeProduct = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtMuestra_Moy1 = new System.Windows.Forms.TextBox();
            this.txtMuestraCons1 = new System.Windows.Forms.TextBox();
            this.txtMuestraCons2 = new System.Windows.Forms.TextBox();
            this.txtMuestra_Moy2 = new System.Windows.Forms.TextBox();
            this.txtMuestraCons4 = new System.Windows.Forms.TextBox();
            this.txtMuestra_Moy4 = new System.Windows.Forms.TextBox();
            this.txtMuestraCons3 = new System.Windows.Forms.TextBox();
            this.txtMuestra_Moy3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSeeList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntClearDataInto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntSaveData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(23, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(669, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "INVESTIGACION DE PRECIOS EN MERCADOS MINORISTAS DE  CUIDADES DEL INTERIOR DEL PAI" +
    "S";
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
            this.panel1.TabIndex = 1;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProduct.Location = new System.Drawing.Point(497, 135);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(87, 20);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "PRODUCTO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bntSaveData);
            this.panel2.Controls.Add(this.bntClearDataInto);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSeeList);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMuestraCons4);
            this.panel2.Controls.Add(this.txtMuestra_Moy4);
            this.panel2.Controls.Add(this.txtMuestraCons3);
            this.panel2.Controls.Add(this.txtMuestra_Moy3);
            this.panel2.Controls.Add(this.txtMuestraCons2);
            this.panel2.Controls.Add(this.txtMuestra_Moy2);
            this.panel2.Controls.Add(this.txtMuestraCons1);
            this.panel2.Controls.Add(this.txtMuestra_Moy1);
            this.panel2.Controls.Add(this.cmbProduct);
            this.panel2.Controls.Add(this.cmbTypeProduct);
            this.panel2.Location = new System.Drawing.Point(58, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 461);
            this.panel2.TabIndex = 0;
            // 
            // cmbTypeProduct
            // 
            this.cmbTypeProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeProduct.FormattingEnabled = true;
            this.cmbTypeProduct.Items.AddRange(new object[] {
            "Tuberculos"});
            this.cmbTypeProduct.Location = new System.Drawing.Point(61, 62);
            this.cmbTypeProduct.Name = "cmbTypeProduct";
            this.cmbTypeProduct.Size = new System.Drawing.Size(376, 21);
            this.cmbTypeProduct.TabIndex = 6;
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "Camote Amarillo"});
            this.cmbProduct.Location = new System.Drawing.Point(573, 62);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(376, 21);
            this.cmbProduct.TabIndex = 7;
            // 
            // txtMuestra_Moy1
            // 
            this.txtMuestra_Moy1.ForeColor = System.Drawing.Color.Red;
            this.txtMuestra_Moy1.Location = new System.Drawing.Point(61, 172);
            this.txtMuestra_Moy1.Multiline = true;
            this.txtMuestra_Moy1.Name = "txtMuestra_Moy1";
            this.txtMuestra_Moy1.Size = new System.Drawing.Size(135, 37);
            this.txtMuestra_Moy1.TabIndex = 8;
            this.txtMuestra_Moy1.Text = "precio mayorista";
            this.txtMuestra_Moy1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMuestraCons1
            // 
            this.txtMuestraCons1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtMuestraCons1.Location = new System.Drawing.Point(61, 251);
            this.txtMuestraCons1.Multiline = true;
            this.txtMuestraCons1.Name = "txtMuestraCons1";
            this.txtMuestraCons1.Size = new System.Drawing.Size(135, 37);
            this.txtMuestraCons1.TabIndex = 9;
            this.txtMuestraCons1.Text = "precio consumidor";
            this.txtMuestraCons1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMuestraCons2
            // 
            this.txtMuestraCons2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtMuestraCons2.Location = new System.Drawing.Point(302, 251);
            this.txtMuestraCons2.Multiline = true;
            this.txtMuestraCons2.Name = "txtMuestraCons2";
            this.txtMuestraCons2.Size = new System.Drawing.Size(135, 37);
            this.txtMuestraCons2.TabIndex = 11;
            this.txtMuestraCons2.Text = "precio consumidor";
            this.txtMuestraCons2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMuestra_Moy2
            // 
            this.txtMuestra_Moy2.ForeColor = System.Drawing.Color.Red;
            this.txtMuestra_Moy2.Location = new System.Drawing.Point(302, 172);
            this.txtMuestra_Moy2.Multiline = true;
            this.txtMuestra_Moy2.Name = "txtMuestra_Moy2";
            this.txtMuestra_Moy2.Size = new System.Drawing.Size(135, 37);
            this.txtMuestra_Moy2.TabIndex = 10;
            this.txtMuestra_Moy2.Text = "precio mayorista";
            this.txtMuestra_Moy2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMuestraCons4
            // 
            this.txtMuestraCons4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtMuestraCons4.Location = new System.Drawing.Point(814, 251);
            this.txtMuestraCons4.Multiline = true;
            this.txtMuestraCons4.Name = "txtMuestraCons4";
            this.txtMuestraCons4.Size = new System.Drawing.Size(135, 37);
            this.txtMuestraCons4.TabIndex = 15;
            this.txtMuestraCons4.Text = "precio consumidor";
            this.txtMuestraCons4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMuestra_Moy4
            // 
            this.txtMuestra_Moy4.ForeColor = System.Drawing.Color.Red;
            this.txtMuestra_Moy4.Location = new System.Drawing.Point(814, 172);
            this.txtMuestra_Moy4.Multiline = true;
            this.txtMuestra_Moy4.Name = "txtMuestra_Moy4";
            this.txtMuestra_Moy4.Size = new System.Drawing.Size(135, 37);
            this.txtMuestra_Moy4.TabIndex = 14;
            this.txtMuestra_Moy4.Text = "precio mayorista";
            this.txtMuestra_Moy4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMuestraCons3
            // 
            this.txtMuestraCons3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtMuestraCons3.Location = new System.Drawing.Point(554, 251);
            this.txtMuestraCons3.Multiline = true;
            this.txtMuestraCons3.Name = "txtMuestraCons3";
            this.txtMuestraCons3.Size = new System.Drawing.Size(135, 37);
            this.txtMuestraCons3.TabIndex = 13;
            this.txtMuestraCons3.Text = "precio consumidor";
            this.txtMuestraCons3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMuestra_Moy3
            // 
            this.txtMuestra_Moy3.ForeColor = System.Drawing.Color.Red;
            this.txtMuestra_Moy3.Location = new System.Drawing.Point(554, 172);
            this.txtMuestra_Moy3.Multiline = true;
            this.txtMuestra_Moy3.Name = "txtMuestra_Moy3";
            this.txtMuestra_Moy3.Size = new System.Drawing.Size(135, 37);
            this.txtMuestra_Moy3.TabIndex = 12;
            this.txtMuestra_Moy3.Text = "precio mayorista";
            this.txtMuestra_Moy3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(58, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo de producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(570, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(94, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Muestra 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(336, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Muestra 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(585, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Muestra 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(839, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Muestra 4";
            // 
            // btnSeeList
            // 
            this.btnSeeList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.btnSeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.btnSeeList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeeList.BorderRadius = 0;
            this.btnSeeList.ButtonText = "Ver lista";
            this.btnSeeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeList.DisabledColor = System.Drawing.Color.Gray;
            this.btnSeeList.Font = new System.Drawing.Font("SegoeUISymbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSeeList.Iconimage = null;
            this.btnSeeList.Iconimage_right = null;
            this.btnSeeList.Iconimage_right_Selected = null;
            this.btnSeeList.Iconimage_Selected = null;
            this.btnSeeList.IconMarginLeft = 0;
            this.btnSeeList.IconMarginRight = 0;
            this.btnSeeList.IconRightVisible = true;
            this.btnSeeList.IconRightZoom = 0D;
            this.btnSeeList.IconVisible = true;
            this.btnSeeList.IconZoom = 90D;
            this.btnSeeList.IsTab = false;
            this.btnSeeList.Location = new System.Drawing.Point(61, 391);
            this.btnSeeList.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeeList.Name = "btnSeeList";
            this.btnSeeList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.btnSeeList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.btnSeeList.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeeList.Padding = new System.Windows.Forms.Padding(1);
            this.btnSeeList.selected = false;
            this.btnSeeList.Size = new System.Drawing.Size(187, 32);
            this.btnSeeList.TabIndex = 22;
            this.btnSeeList.Text = "Ver lista";
            this.btnSeeList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeeList.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeeList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeList.Click += new System.EventHandler(this.btnSeeList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Actualizarr";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("SegoeUISymbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(291, 391);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(1);
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(187, 32);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Actualizarr";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bntClearDataInto
            // 
            this.bntClearDataInto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.bntClearDataInto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.bntClearDataInto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntClearDataInto.BorderRadius = 0;
            this.bntClearDataInto.ButtonText = "Limpiar muestra";
            this.bntClearDataInto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntClearDataInto.DisabledColor = System.Drawing.Color.Gray;
            this.bntClearDataInto.Font = new System.Drawing.Font("SegoeUISymbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClearDataInto.Iconcolor = System.Drawing.Color.Transparent;
            this.bntClearDataInto.Iconimage = null;
            this.bntClearDataInto.Iconimage_right = null;
            this.bntClearDataInto.Iconimage_right_Selected = null;
            this.bntClearDataInto.Iconimage_Selected = null;
            this.bntClearDataInto.IconMarginLeft = 0;
            this.bntClearDataInto.IconMarginRight = 0;
            this.bntClearDataInto.IconRightVisible = true;
            this.bntClearDataInto.IconRightZoom = 0D;
            this.bntClearDataInto.IconVisible = true;
            this.bntClearDataInto.IconZoom = 90D;
            this.bntClearDataInto.IsTab = false;
            this.bntClearDataInto.Location = new System.Drawing.Point(524, 391);
            this.bntClearDataInto.Margin = new System.Windows.Forms.Padding(0);
            this.bntClearDataInto.Name = "bntClearDataInto";
            this.bntClearDataInto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.bntClearDataInto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.bntClearDataInto.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntClearDataInto.Padding = new System.Windows.Forms.Padding(1);
            this.bntClearDataInto.selected = false;
            this.bntClearDataInto.Size = new System.Drawing.Size(187, 32);
            this.bntClearDataInto.TabIndex = 24;
            this.bntClearDataInto.Text = "Limpiar muestra";
            this.bntClearDataInto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntClearDataInto.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntClearDataInto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bntSaveData
            // 
            this.bntSaveData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.bntSaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.bntSaveData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntSaveData.BorderRadius = 0;
            this.bntSaveData.ButtonText = "Guardar";
            this.bntSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSaveData.DisabledColor = System.Drawing.Color.Gray;
            this.bntSaveData.Font = new System.Drawing.Font("SegoeUISymbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSaveData.Iconcolor = System.Drawing.Color.Transparent;
            this.bntSaveData.Iconimage = null;
            this.bntSaveData.Iconimage_right = null;
            this.bntSaveData.Iconimage_right_Selected = null;
            this.bntSaveData.Iconimage_Selected = null;
            this.bntSaveData.IconMarginLeft = 0;
            this.bntSaveData.IconMarginRight = 0;
            this.bntSaveData.IconRightVisible = true;
            this.bntSaveData.IconRightZoom = 0D;
            this.bntSaveData.IconVisible = true;
            this.bntSaveData.IconZoom = 90D;
            this.bntSaveData.IsTab = false;
            this.bntSaveData.Location = new System.Drawing.Point(762, 391);
            this.bntSaveData.Margin = new System.Windows.Forms.Padding(0);
            this.bntSaveData.Name = "bntSaveData";
            this.bntSaveData.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.bntSaveData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.bntSaveData.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntSaveData.Padding = new System.Windows.Forms.Padding(1);
            this.bntSaveData.selected = false;
            this.bntSaveData.Size = new System.Drawing.Size(187, 32);
            this.bntSaveData.TabIndex = 25;
            this.bntSaveData.Text = "Guardar";
            this.bntSaveData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntSaveData.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntSaveData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnClose
            // 
            this.btnClose.Image = global::CapaPresentacion.Properties.Resources.close__2_;
            this.btnClose.Location = new System.Drawing.Point(1072, 33);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_Into_Sample_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Into_Sample_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Into_Sample_Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbTypeProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtMuestraCons4;
        private System.Windows.Forms.TextBox txtMuestra_Moy4;
        private System.Windows.Forms.TextBox txtMuestraCons3;
        private System.Windows.Forms.TextBox txtMuestra_Moy3;
        private System.Windows.Forms.TextBox txtMuestraCons2;
        private System.Windows.Forms.TextBox txtMuestra_Moy2;
        private System.Windows.Forms.TextBox txtMuestraCons1;
        private System.Windows.Forms.TextBox txtMuestra_Moy1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bntSaveData;
        private Bunifu.Framework.UI.BunifuFlatButton bntClearDataInto;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnSeeList;
    }
}