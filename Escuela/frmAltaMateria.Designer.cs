
namespace Escuela
{
    partial class frmAltaMateria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de nateria ";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(317, 26);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(825, 38);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Info;
            this.btnAceptar.Location = new System.Drawing.Point(883, 651);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(213, 79);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancelar.Location = new System.Drawing.Point(1112, 651);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(213, 79);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvMateria
            // 
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Location = new System.Drawing.Point(27, 83);
            this.dgvMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.RowHeadersWidth = 102;
            this.dgvMateria.RowTemplate.Height = 40;
            this.dgvMateria.Size = new System.Drawing.Size(1304, 558);
            this.dgvMateria.TabIndex = 4;
            this.dgvMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateria_CellClick);
            // 
            // frmAltaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1515, 744);
            this.Controls.Add(this.dgvMateria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(1547, 832);
            this.MinimumSize = new System.Drawing.Size(1547, 832);
            this.Name = "frmAltaMateria";
            this.Text = "frmAltaMateria";
            this.Load += new System.EventHandler(this.frmAltaMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvMateria;
    }
}