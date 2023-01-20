
namespace Escuela
{
    partial class frmConsultaalumno
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
            this.gbCAlumnos = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gbCAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCAlumnos
            // 
            this.gbCAlumnos.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.gbCAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCAlumnos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCAlumnos.Controls.Add(this.btnCancel);
            this.gbCAlumnos.Controls.Add(this.dgvAlumnos);
            this.gbCAlumnos.Controls.Add(this.btnBuscar);
            this.gbCAlumnos.Controls.Add(this.txtBuscar);
            this.gbCAlumnos.Controls.Add(this.lblBuscar);
            this.gbCAlumnos.Location = new System.Drawing.Point(0, 0);
            this.gbCAlumnos.Margin = new System.Windows.Forms.Padding(1);
            this.gbCAlumnos.Name = "gbCAlumnos";
            this.gbCAlumnos.Padding = new System.Windows.Forms.Padding(1);
            this.gbCAlumnos.Size = new System.Drawing.Size(587, 362);
            this.gbCAlumnos.TabIndex = 0;
            this.gbCAlumnos.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancel.Location = new System.Drawing.Point(426, 39);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(13, 75);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(1);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 102;
            this.dgvAlumnos.RowTemplate.Height = 40;
            this.dgvAlumnos.Size = new System.Drawing.Size(489, 252);
            this.dgvAlumnos.TabIndex = 3;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.btnBuscar.Location = new System.Drawing.Point(350, 40);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 21);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(103, 38);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(231, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(20, 36);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(83, 24);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Consulta";
            // 
            // frmConsultaalumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.gbCAlumnos);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmConsultaalumno";
            this.Text = "frmConsultaalumno";
            this.gbCAlumnos.ResumeLayout(false);
            this.gbCAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCAlumnos;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancel;
    }
}