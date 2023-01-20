
namespace Escuela
{
    partial class frmModAlumno
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
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbldir = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDir
            // 
            this.txtDir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDir.Location = new System.Drawing.Point(215, 248);
            this.txtDir.Margin = new System.Windows.Forms.Padding(1);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(185, 20);
            this.txtDir.TabIndex = 15;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTel.Location = new System.Drawing.Point(215, 191);
            this.txtTel.Margin = new System.Windows.Forms.Padding(1);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 20);
            this.txtTel.TabIndex = 14;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtEdad.Location = new System.Drawing.Point(215, 134);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(1);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(185, 20);
            this.txtEdad.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtName.Location = new System.Drawing.Point(215, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 12;
            // 
            // lbldir
            // 
            this.lbldir.AutoSize = true;
            this.lbldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldir.Location = new System.Drawing.Point(69, 235);
            this.lbldir.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldir.Name = "lbldir";
            this.lbldir.Size = new System.Drawing.Size(135, 31);
            this.lbldir.TabIndex = 11;
            this.lbldir.Text = "Direccion ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(69, 177);
            this.lblTel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(120, 31);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Telefono";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(69, 120);
            this.lbledad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(77, 31);
            this.lbledad.TabIndex = 9;
            this.lbledad.Text = "Edad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(69, 62);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 31);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Busqueda";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "ID",
            "Nombre"});
            this.cmbBuscar.Location = new System.Drawing.Point(181, 23);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(73, 21);
            this.cmbBuscar.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "por:";
            // 
            // txBusqueda
            // 
            this.txBusqueda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txBusqueda.Location = new System.Drawing.Point(268, 24);
            this.txBusqueda.Margin = new System.Windows.Forms.Padding(1);
            this.txBusqueda.Name = "txBusqueda";
            this.txBusqueda.Size = new System.Drawing.Size(132, 20);
            this.txBusqueda.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.btnBuscar.Location = new System.Drawing.Point(404, 21);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 25);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(418, 277);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 25);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFGuardar
            // 
            this.btnFGuardar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnFGuardar.Location = new System.Drawing.Point(342, 277);
            this.btnFGuardar.Margin = new System.Windows.Forms.Padding(1);
            this.btnFGuardar.Name = "btnFGuardar";
            this.btnFGuardar.Size = new System.Drawing.Size(58, 25);
            this.btnFGuardar.TabIndex = 22;
            this.btnFGuardar.Text = "Guardar";
            this.btnFGuardar.UseVisualStyleBackColor = false;
            this.btnFGuardar.Click += new System.EventHandler(this.btnFGuardar_Click);
            // 
            // frmModAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnFGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbldir);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmModAlumno";
            this.Text = "frmModAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbldir;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFGuardar;
    }
}