
namespace OnTapDotNet251121
{
    partial class FrmBC_SV
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
            this.CRV_SV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_SV
            // 
            this.CRV_SV.ActiveViewIndex = -1;
            this.CRV_SV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_SV.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_SV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_SV.Location = new System.Drawing.Point(0, 0);
            this.CRV_SV.Name = "CRV_SV";
            this.CRV_SV.Size = new System.Drawing.Size(800, 450);
            this.CRV_SV.TabIndex = 0;
            // 
            // FrmBC_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRV_SV);
            this.Name = "FrmBC_SV";
            this.Text = "FrmBC_SV";
            this.Load += new System.EventHandler(this.FrmBC_SV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_SV;
    }
}