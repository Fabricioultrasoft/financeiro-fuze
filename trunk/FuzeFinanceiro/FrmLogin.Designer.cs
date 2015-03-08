namespace FuzeFinanceiro
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FuzeFinanceiro.Properties.Resources.WA_LoginScreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnEntrar.ImageIndex = 69;
            this.btnEntrar.ImageList = this.ribbonImageCollection;
            this.btnEntrar.Location = new System.Drawing.Point(185, 321);
            this.btnEntrar.LookAndFeel.SkinName = "Office 2010 Silver";
            this.btnEntrar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(88, 29);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(15, "Bloqueio - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(16, "Caixa - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(17, "calendar.png");
            this.ribbonImageCollection.Images.SetKeyName(18, "Cartao Banco - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(19, "chart.png");
            this.ribbonImageCollection.Images.SetKeyName(20, "Chave - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(21, "Chave - 02.png");
            this.ribbonImageCollection.Images.SetKeyName(22, "Cofre - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(23, "column-chart.png");
            this.ribbonImageCollection.Images.SetKeyName(24, "Dinheiro - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(25, "Dinheiro - 02.png");
            this.ribbonImageCollection.Images.SetKeyName(26, "Dinheiro - 03.png");
            this.ribbonImageCollection.Images.SetKeyName(27, "Dinheiro - 04.png");
            this.ribbonImageCollection.Images.SetKeyName(28, "Dinheiro - 05.png");
            this.ribbonImageCollection.Images.SetKeyName(29, "hand_money.png");
            this.ribbonImageCollection.Images.SetKeyName(30, "hand_offer.png");
            this.ribbonImageCollection.Images.SetKeyName(31, "hand_paper.png");
            this.ribbonImageCollection.Images.SetKeyName(32, "hand_point.png");
            this.ribbonImageCollection.Images.SetKeyName(33, "hand_point_disk.png");
            this.ribbonImageCollection.Images.SetKeyName(34, "hand_point_find.png");
            this.ribbonImageCollection.Images.SetKeyName(35, "hand_point2.png");
            this.ribbonImageCollection.Images.SetKeyName(36, "hand_red_card.png");
            this.ribbonImageCollection.Images.SetKeyName(37, "hand_stop.png");
            this.ribbonImageCollection.Images.SetKeyName(38, "hand_yellow_card.png");
            this.ribbonImageCollection.Images.SetKeyName(39, "handshake.png");
            this.ribbonImageCollection.Images.SetKeyName(40, "id_card.png");
            this.ribbonImageCollection.Images.SetKeyName(41, "Imprimir - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(42, "Imprimir - 02.png");
            this.ribbonImageCollection.Images.SetKeyName(43, "Imprimir - 03.png");
            this.ribbonImageCollection.Images.SetKeyName(44, "index.png");
            this.ribbonImageCollection.Images.SetKeyName(45, "link.png");
            this.ribbonImageCollection.Images.SetKeyName(46, "lock_open.png");
            this.ribbonImageCollection.Images.SetKeyName(47, "lock2.png");
            this.ribbonImageCollection.Images.SetKeyName(48, "percent.png");
            this.ribbonImageCollection.Images.SetKeyName(49, "Pessoa - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(50, "Pessoa - 02.png");
            this.ribbonImageCollection.Images.SetKeyName(51, "Pessoa - 03.png");
            this.ribbonImageCollection.Images.SetKeyName(52, "pie-chart.png");
            this.ribbonImageCollection.Images.SetKeyName(53, "preferences.png");
            this.ribbonImageCollection.Images.SetKeyName(54, "Produto - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(55, "Produto - 02.png");
            this.ribbonImageCollection.Images.SetKeyName(56, "Produto - 03.png");
            this.ribbonImageCollection.Images.SetKeyName(57, "Transferencia - 01.png");
            this.ribbonImageCollection.Images.SetKeyName(58, "Transferencia - 2.png");
            this.ribbonImageCollection.Images.SetKeyName(59, "Transferencia - 3.png");
            this.ribbonImageCollection.Images.SetKeyName(60, "001 Incluir.png");
            this.ribbonImageCollection.Images.SetKeyName(61, "001.1 Incluir.png");
            this.ribbonImageCollection.Images.SetKeyName(62, "002 Alterar.png");
            this.ribbonImageCollection.Images.SetKeyName(63, "003 Excluir.png");
            this.ribbonImageCollection.Images.SetKeyName(64, "004 Salvar e Novo.png");
            this.ribbonImageCollection.Images.SetKeyName(65, "004 Salvar.png");
            this.ribbonImageCollection.Images.SetKeyName(66, "004.2 Salvar.png");
            this.ribbonImageCollection.Images.SetKeyName(67, "004.3 Salvar.png");
            this.ribbonImageCollection.Images.SetKeyName(68, "005 Cancelar.png");
            this.ribbonImageCollection.Images.SetKeyName(69, "006 Ok.png");
            this.ribbonImageCollection.Images.SetKeyName(70, "007 Filtrar.png");
            this.ribbonImageCollection.Images.SetKeyName(71, "008 Sair.png");
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageIndex = 68;
            this.simpleButton2.ImageList = this.ribbonImageCollection;
            this.simpleButton2.Location = new System.Drawing.Point(279, 321);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(88, 29);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(9, "001 Incluir.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(10, "001.1 Incluir.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(11, "002 Alterar.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(12, "003 Excluir.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(13, "004 Salvar e Novo.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(14, "004 Salvar.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(15, "004.2 Salvar.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(16, "004.3 Salvar.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(17, "005 Cancelar.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(18, "006 Ok.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(19, "007 Filtrar.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(20, "008 Sair.png");
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 400);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;

    }
}