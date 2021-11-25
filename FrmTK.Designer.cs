
namespace OnTapDotNet251121
{
    partial class FrmTK
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
            this.DataGrid_LOP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.radioTenLop = new System.Windows.Forms.RadioButton();
            this.radioMaLop = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_LOP)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_LOP
            // 
            this.DataGrid_LOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_LOP.Location = new System.Drawing.Point(103, 278);
            this.DataGrid_LOP.Name = "DataGrid_LOP";
            this.DataGrid_LOP.RowHeadersWidth = 51;
            this.DataGrid_LOP.RowTemplate.Height = 24;
            this.DataGrid_LOP.Size = new System.Drawing.Size(595, 142);
            this.DataGrid_LOP.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(446, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(152, 210);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(195, 43);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(347, 145);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(351, 34);
            this.txtTenLop.TabIndex = 10;
            // 
            // cboMaLop
            // 
            this.cboMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(347, 89);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(351, 37);
            this.cboMaLop.TabIndex = 9;
            // 
            // radioTenLop
            // 
            this.radioTenLop.AutoSize = true;
            this.radioTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTenLop.Location = new System.Drawing.Point(102, 145);
            this.radioTenLop.Name = "radioTenLop";
            this.radioTenLop.Size = new System.Drawing.Size(117, 33);
            this.radioTenLop.TabIndex = 7;
            this.radioTenLop.TabStop = true;
            this.radioTenLop.Text = "Tên lớp";
            this.radioTenLop.UseVisualStyleBackColor = true;
            this.radioTenLop.CheckedChanged += new System.EventHandler(this.radioTenLop_CheckedChanged);
            // 
            // radioMaLop
            // 
            this.radioMaLop.AutoSize = true;
            this.radioMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMaLop.Location = new System.Drawing.Point(102, 93);
            this.radioMaLop.Name = "radioMaLop";
            this.radioMaLop.Size = new System.Drawing.Size(107, 33);
            this.radioMaLop.TabIndex = 8;
            this.radioMaLop.TabStop = true;
            this.radioMaLop.Text = "Mã lớp";
            this.radioMaLop.UseVisualStyleBackColor = true;
            this.radioMaLop.CheckedChanged += new System.EventHandler(this.radioMaLop_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "TÌM KIẾM LỚP";
            // 
            // FrmTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid_LOP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.radioTenLop);
            this.Controls.Add(this.radioMaLop);
            this.Controls.Add(this.label1);
            this.Name = "FrmTK";
            this.Text = "FrmTK";
            this.Load += new System.EventHandler(this.FrmTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_LOP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_LOP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.RadioButton radioTenLop;
        private System.Windows.Forms.RadioButton radioMaLop;
        private System.Windows.Forms.Label label1;
    }
}