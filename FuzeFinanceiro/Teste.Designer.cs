namespace FuzeFinanceiro
{
    partial class Teste
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
            this.btnGravar = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.cleroVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleroVOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(122, 193);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cleroVOBindingSource, "Descricao", true));
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cleroVOBindingSource, "Descricao", true));
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cleroVOBindingSource, "Descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(56, 42);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(217, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // cleroVOBindingSource
            // 
            this.cleroVOBindingSource.DataSource = typeof(Fuze.Domain.dll.Model.VO.CleroVO);
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 262);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnGravar);
            this.Name = "Teste";
            this.Text = "Teste";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleroVOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGravar;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private System.Windows.Forms.BindingSource cleroVOBindingSource;
    }
}