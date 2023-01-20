
namespace Escuela
{
    partial class frmModAluMat
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCalif = new System.Windows.Forms.TextBox();
            this.cmbMat = new System.Windows.Forms.ComboBox();
            this.cmbAlu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(271, 233);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.btnBuscar.Location = new System.Drawing.Point(282, 177);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCalif
            // 
            this.txtCalif.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCalif.Location = new System.Drawing.Point(171, 177);
            this.txtCalif.Margin = new System.Windows.Forms.Padding(1);
            this.txtCalif.Name = "txtCalif";
            this.txtCalif.Size = new System.Drawing.Size(82, 20);
            this.txtCalif.TabIndex = 13;
            // 
            // cmbMat
            // 
            this.cmbMat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbMat.FormattingEnabled = true;
            this.cmbMat.Location = new System.Drawing.Point(171, 128);
            this.cmbMat.Margin = new System.Windows.Forms.Padding(1);
            this.cmbMat.Name = "cmbMat";
            this.cmbMat.Size = new System.Drawing.Size(187, 21);
            this.cmbMat.TabIndex = 12;
            // 
            // cmbAlu
            // 
            this.cmbAlu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbAlu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAlu.FormattingEnabled = true;
            this.cmbAlu.Location = new System.Drawing.Point(171, 76);
            this.cmbAlu.Margin = new System.Windows.Forms.Padding(1);
            this.cmbAlu.Name = "cmbAlu";
            this.cmbAlu.Size = new System.Drawing.Size(187, 21);
            this.cmbAlu.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Calificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lavender;
            this.btnOK.Location = new System.Drawing.Point(177, 233);
            this.btnOK.Margin = new System.Windows.Forms.Padding(1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "CREAR";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancel.Location = new System.Drawing.Point(427, 279);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmModAluMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCalif);
            this.Controls.Add(this.cmbMat);
            this.Controls.Add(this.cmbAlu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmModAluMat";
            this.Text = "frmModAluMat";
            this.Load += new System.EventHandler(this.frmModAluMat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCalif;
        private System.Windows.Forms.ComboBox cmbMat;
        private System.Windows.Forms.ComboBox cmbAlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}