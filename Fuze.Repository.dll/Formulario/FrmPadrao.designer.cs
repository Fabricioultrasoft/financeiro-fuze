﻿namespace Fuze.Repository.dll.Formulario
{
    partial class FrmPadrao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPadrao));
            this.pnlFormulario = new DevExpress.XtraEditors.PanelControl();
            this.PageFormulario = new DevExpress.XtraTab.XtraTabControl();
            this.TabConsulta = new DevExpress.XtraTab.XtraTabPage();
            this.pnlGrade = new DevExpress.XtraEditors.PanelControl();
            this.GradeControle = new DevExpress.XtraGrid.GridControl();
            this.GradeView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlFiltro = new DevExpress.XtraEditors.GroupControl();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.EdtTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.EdtTexto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BarraNavegacao = new DevExpress.XtraNavBar.NavBarControl();
            this.BarraAcao = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnIncluir = new DevExpress.XtraNavBar.NavBarItem();
            this.btnAlterar = new DevExpress.XtraNavBar.NavBarItem();
            this.btnExcluir = new DevExpress.XtraNavBar.NavBarItem();
            this.BarraOpcao = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnAgrupar = new DevExpress.XtraNavBar.NavBarItem();
            this.btnFiltro = new DevExpress.XtraNavBar.NavBarItem();
            this.btnSair = new DevExpress.XtraNavBar.NavBarItem();
            this.TabCadastro = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFormulario)).BeginInit();
            this.pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageFormulario)).BeginInit();
            this.PageFormulario.SuspendLayout();
            this.TabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrade)).BeginInit();
            this.pnlGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdtTexto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarraNavegacao)).BeginInit();
            this.TabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.pnlFormulario.Controls.Add(this.PageFormulario);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulario.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(625, 487);
            this.pnlFormulario.TabIndex = 0;
            // 
            // PageFormulario
            // 
            this.PageFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageFormulario.Font = new System.Drawing.Font("Tahoma", 10F);
            this.PageFormulario.Location = new System.Drawing.Point(2, 2);
            this.PageFormulario.Name = "PageFormulario";
            this.PageFormulario.SelectedTabPage = this.TabConsulta;
            this.PageFormulario.Size = new System.Drawing.Size(621, 483);
            this.PageFormulario.TabIndex = 0;
            this.PageFormulario.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabConsulta,
            this.TabCadastro});
            // 
            // TabConsulta
            // 
            this.TabConsulta.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabConsulta.Appearance.HeaderActive.ForeColor = System.Drawing.Color.Red;
            this.TabConsulta.Appearance.HeaderActive.Options.UseFont = true;
            this.TabConsulta.Appearance.HeaderActive.Options.UseForeColor = true;
            this.TabConsulta.Controls.Add(this.pnlGrade);
            this.TabConsulta.Controls.Add(this.BarraNavegacao);
            this.TabConsulta.Name = "TabConsulta";
            this.TabConsulta.Size = new System.Drawing.Size(615, 455);
            this.TabConsulta.Text = "Tela de Consulta";
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.GradeControle);
            this.pnlGrade.Controls.Add(this.pnlFiltro);
            this.pnlGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrade.Location = new System.Drawing.Point(135, 0);
            this.pnlGrade.Name = "pnlGrade";
            this.pnlGrade.Size = new System.Drawing.Size(480, 455);
            this.pnlGrade.TabIndex = 2;
            // 
            // GradeControle
            // 
            this.GradeControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradeControle.Location = new System.Drawing.Point(2, 74);
            this.GradeControle.MainView = this.GradeView;
            this.GradeControle.Name = "GradeControle";
            this.GradeControle.Size = new System.Drawing.Size(476, 379);
            this.GradeControle.TabIndex = 2;
            this.GradeControle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GradeView});
            // 
            // GradeView
            // 
            this.GradeView.GridControl = this.GradeControle;
            this.GradeView.Name = "GradeView";
            this.GradeView.OptionsView.ShowGroupPanel = false;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlFiltro.Appearance.BorderColor = System.Drawing.Color.Red;
            this.pnlFiltro.Appearance.Options.UseBackColor = true;
            this.pnlFiltro.Appearance.Options.UseBorderColor = true;
            this.pnlFiltro.Appearance.Options.UseFont = true;
            this.pnlFiltro.Controls.Add(this.btnConsultar);
            this.pnlFiltro.Controls.Add(this.EdtTipo);
            this.pnlFiltro.Controls.Add(this.labelControl2);
            this.pnlFiltro.Controls.Add(this.EdtTexto);
            this.pnlFiltro.Controls.Add(this.labelControl1);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(2, 2);
            this.pnlFiltro.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(476, 72);
            this.pnlFiltro.TabIndex = 1;
            this.pnlFiltro.Text = "Filtro de Consulta";
            this.pnlFiltro.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(400, 35);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(34, 30);
            this.btnConsultar.TabIndex = 5;
            // 
            // EdtTipo
            // 
            this.EdtTipo.EditValue = "Nome";
            this.EdtTipo.Location = new System.Drawing.Point(14, 43);
            this.EdtTipo.Name = "EdtTipo";
            this.EdtTipo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EdtTipo.Properties.Appearance.Options.UseFont = true;
            this.EdtTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EdtTipo.Properties.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "CPF",
            "RG"});
            this.EdtTipo.Size = new System.Drawing.Size(125, 22);
            this.EdtTipo.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(145, 27);
            this.labelControl2.LookAndFeel.UseWindowsXPTheme = true;
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 11);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Texto a ser consultado";
            // 
            // EdtTexto
            // 
            this.EdtTexto.Location = new System.Drawing.Point(145, 43);
            this.EdtTexto.Name = "EdtTexto";
            this.EdtTexto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EdtTexto.Properties.Appearance.Options.UseFont = true;
            this.EdtTexto.Size = new System.Drawing.Size(250, 22);
            this.EdtTexto.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(14, 27);
            this.labelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 11);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tipo de Consulta ";
            // 
            // BarraNavegacao
            // 
            this.BarraNavegacao.ActiveGroup = this.BarraAcao;
            this.BarraNavegacao.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraNavegacao.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.BarraAcao,
            this.BarraOpcao});
            this.BarraNavegacao.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnIncluir,
            this.btnAlterar,
            this.btnExcluir,
            this.btnFiltro,
            this.btnSair,
            this.btnAgrupar});
            this.BarraNavegacao.Location = new System.Drawing.Point(0, 0);
            this.BarraNavegacao.LookAndFeel.SkinName = "VS2010";
            this.BarraNavegacao.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.BarraNavegacao.LookAndFeel.UseWindowsXPTheme = true;
            this.BarraNavegacao.Name = "BarraNavegacao";
            this.BarraNavegacao.OptionsNavPane.ExpandedWidth = 135;
            this.BarraNavegacao.Size = new System.Drawing.Size(135, 455);
            this.BarraNavegacao.TabIndex = 0;
            this.BarraNavegacao.Text = "navBarControl1";
            this.BarraNavegacao.View = new DevExpress.XtraNavBar.ViewInfo.XPExplorerBarViewInfoRegistrator();
            this.BarraNavegacao.Click += new System.EventHandler(this.BarraNavegacao_Click);
            // 
            // BarraAcao
            // 
            this.BarraAcao.Caption = "Ações";
            this.BarraAcao.Expanded = true;
            this.BarraAcao.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnIncluir),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAlterar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnExcluir)});
            this.BarraAcao.LargeImage = ((System.Drawing.Image)(resources.GetObject("BarraAcao.LargeImage")));
            this.BarraAcao.Name = "BarraAcao";
            // 
            // btnIncluir
            // 
            this.btnIncluir.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnIncluir.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnIncluir.AppearancePressed.Options.UseFont = true;
            this.btnIncluir.AppearancePressed.Options.UseForeColor = true;
            this.btnIncluir.Caption = "Incluir";
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.SmallImageIndex = 0;
            this.btnIncluir.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnIncluir_LinkClicked);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Caption = "Alterar";
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.SmallImage")));
            this.btnAlterar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAlterar_LinkClicked);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Caption = "Excluir";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.SmallImage")));
            // 
            // BarraOpcao
            // 
            this.BarraOpcao.Caption = "Opções";
            this.BarraOpcao.Expanded = true;
            this.BarraOpcao.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAgrupar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnFiltro),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSair)});
            this.BarraOpcao.Name = "BarraOpcao";
            // 
            // btnAgrupar
            // 
            this.btnAgrupar.Caption = "Agrupar";
            this.btnAgrupar.Name = "btnAgrupar";
            this.btnAgrupar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAgrupar_LinkClicked);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Caption = "Filtro";
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFiltro.SmallImage")));
            this.btnFiltro.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnFiltro_LinkClicked);
            // 
            // btnSair
            // 
            this.btnSair.Caption = "Sair";
            this.btnSair.Name = "btnSair";
            this.btnSair.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSair.SmallImage")));
            this.btnSair.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnSair_LinkClicked);
            // 
            // TabCadastro
            // 
            this.TabCadastro.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabCadastro.Appearance.HeaderActive.ForeColor = System.Drawing.Color.Red;
            this.TabCadastro.Appearance.HeaderActive.Options.UseFont = true;
            this.TabCadastro.Appearance.HeaderActive.Options.UseForeColor = true;
            this.TabCadastro.Appearance.HeaderDisabled.ForeColor = System.Drawing.Color.Gray;
            this.TabCadastro.Appearance.HeaderDisabled.Options.UseForeColor = true;
            this.TabCadastro.Controls.Add(this.panelControl2);
            this.TabCadastro.Controls.Add(this.panelControl1);
            this.TabCadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabCadastro.Name = "TabCadastro";
            this.TabCadastro.PageEnabled = false;
            this.TabCadastro.PageVisible = false;
            this.TabCadastro.Size = new System.Drawing.Size(615, 455);
            this.TabCadastro.Text = "Cadastro";
            this.TabCadastro.TooltipIconType = DevExpress.Utils.ToolTipIconType.Asterisk;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.buttonEdit1);
            this.panelControl2.Controls.Add(this.textEdit3);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.textEdit1);
            this.panelControl2.Controls.Add(this.lblCodigo);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 44);
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(615, 411);
            this.panelControl2.TabIndex = 3;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(87, 60);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.buttonEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(414, 20);
            this.buttonEdit1.TabIndex = 6;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(87, 34);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Código:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Código:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(87, 8);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(43, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Appearance.Options.UseFont = true;
            this.panelControl1.Appearance.Options.UseForeColor = true;
            this.panelControl1.Appearance.Options.UseImage = true;
            this.panelControl1.Appearance.Options.UseTextOptions = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.BtnCancelar);
            this.panelControl1.Controls.Add(this.btnSalvar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(615, 44);
            this.panelControl1.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(105, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 38);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Appearance.Image")));
            this.btnSalvar.Appearance.Options.UseImage = true;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 38);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 487);
            this.Controls.Add(this.pnlFormulario);
            this.Name = "FrmPadrao";
            this.Text = "FrmPadrao";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFormulario)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PageFormulario)).EndInit();
            this.PageFormulario.ResumeLayout(false);
            this.TabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrade)).EndInit();
            this.pnlGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GradeControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdtTexto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarraNavegacao)).EndInit();
            this.TabCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlFormulario;
        private DevExpress.XtraTab.XtraTabControl PageFormulario;
        private DevExpress.XtraTab.XtraTabPage TabConsulta;
        private DevExpress.XtraNavBar.NavBarControl BarraNavegacao;
        private DevExpress.XtraNavBar.NavBarGroup BarraAcao;
        private DevExpress.XtraTab.XtraTabPage TabCadastro;
        private DevExpress.XtraNavBar.NavBarItem btnIncluir;
        private DevExpress.XtraNavBar.NavBarItem btnAlterar;
        private DevExpress.XtraNavBar.NavBarItem btnExcluir;
        private DevExpress.XtraNavBar.NavBarItem btnFiltro;
        private DevExpress.XtraNavBar.NavBarItem btnSair;
        private DevExpress.XtraNavBar.NavBarGroup BarraOpcao;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraNavBar.NavBarItem btnAgrupar;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl pnlGrade;
        private DevExpress.XtraEditors.GroupControl pnlFiltro;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
        private DevExpress.XtraEditors.ComboBoxEdit EdtTipo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit EdtTexto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl GradeControle;
        private DevExpress.XtraGrid.Views.Grid.GridView GradeView;
    }
}