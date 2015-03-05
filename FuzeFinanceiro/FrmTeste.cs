using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzeFinanceiro
{
    class FrmTeste : Fuze.Repository.dll.Formulario.FrmPadrao
    {
    
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // FrmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(625, 487);
            this.Name = "FrmTeste";
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        private void panelControl2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
