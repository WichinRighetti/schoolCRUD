
namespace Escuela
{
    partial class FrmConsultaAluMat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvAluMat = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluMat)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtro";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "alumno",
            "materia"});
            this.cmbFiltro.Location = new System.Drawing.Point(65, 21);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(1);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(95, 21);
            this.cmbFiltro.TabIndex = 7;
            // 
            // dgvAluMat
            // 
            this.dgvAluMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluMat.Location = new System.Drawing.Point(20, 55);
            this.dgvAluMat.Margin = new System.Windows.Forms.Padding(1);
            this.dgvAluMat.Name = "dgvAluMat";
            this.dgvAluMat.RowHeadersWidth = 102;
            this.dgvAluMat.RowTemplate.Height = 40;
            this.dgvAluMat.Size = new System.Drawing.Size(500, 290);
            this.dgvAluMat.TabIndex = 9;
            this.dgvAluMat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluMat_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.btnBuscar.Location = new System.Drawing.Point(357, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDato
            // 
            this.txtDato.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDato.Location = new System.Drawing.Point(212, 23);
            this.txtDato.Margin = new System.Windows.Forms.Padding(1);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(127, 20);
            this.txtDato.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancel.Location = new System.Drawing.Point(431, 19);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmConsultaAluMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvAluMat);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmConsultaAluMat";
            this.Text = "FrmConsultaAluMat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.DataGridView dgvAluMat;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnCancel;
    }
}