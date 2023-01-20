
namespace Escuela
{
    partial class frmAltaAlumno
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
            this.gbAlumno = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbldir = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlumno
            // 
            this.gbAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAlumno.Controls.Add(this.btnCancel);
            this.gbAlumno.Controls.Add(this.btnOK);
            this.gbAlumno.Controls.Add(this.txtDir);
            this.gbAlumno.Controls.Add(this.txtTel);
            this.gbAlumno.Controls.Add(this.txtEdad);
            this.gbAlumno.Controls.Add(this.txtName);
            this.gbAlumno.Controls.Add(this.lbldir);
            this.gbAlumno.Controls.Add(this.lblTel);
            this.gbAlumno.Controls.Add(this.lbledad);
            this.gbAlumno.Controls.Add(this.lblName);
            this.gbAlumno.Location = new System.Drawing.Point(8, -1);
            this.gbAlumno.Margin = new System.Windows.Forms.Padding(1);
            this.gbAlumno.Name = "gbAlumno";
            this.gbAlumno.Padding = new System.Windows.Forms.Padding(1);
            this.gbAlumno.Size = new System.Drawing.Size(566, 352);
            this.gbAlumno.TabIndex = 0;
            this.gbAlumno.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(242, 276);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Info;
            this.btnOK.Location = new System.Drawing.Point(124, 276);
            this.btnOK.Margin = new System.Windows.Forms.Padding(1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 25);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "ACEPTAR";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDir
            // 
            this.txtDir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDir.Location = new System.Drawing.Point(221, 222);
            this.txtDir.Margin = new System.Windows.Forms.Padding(1);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(185, 20);
            this.txtDir.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTel.Location = new System.Drawing.Point(221, 161);
            this.txtTel.Margin = new System.Windows.Forms.Padding(1);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 20);
            this.txtTel.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtEdad.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEdad.Location = new System.Drawing.Point(221, 97);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(1);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(185, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtName.Location = new System.Drawing.Point(221, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 4;
            // 
            // lbldir
            // 
            this.lbldir.AutoSize = true;
            this.lbldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldir.Location = new System.Drawing.Point(60, 210);
            this.lbldir.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldir.Name = "lbldir";
            this.lbldir.Size = new System.Drawing.Size(135, 31);
            this.lbldir.TabIndex = 3;
            this.lbldir.Text = "Direccion ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(75, 149);
            this.lblTel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(120, 31);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telefono";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(118, 86);
            this.lbledad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(77, 31);
            this.lbledad.TabIndex = 1;
            this.lbledad.Text = "Edad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(84, 27);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // frmAltaAlumno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.gbAlumno);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmAltaAlumno";
            this.Text = "frmAltaAlumno";
            this.gbAlumno.ResumeLayout(false);
            this.gbAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlumno;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbldir;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblName;
    }
}