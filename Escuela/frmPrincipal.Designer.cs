
namespace Escuela
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.msAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.msAltaAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.msConsultaAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.msModAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.msMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.msMateriaAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.msMateriaAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAlumno,
            this.msMateria,
            this.msMateriaAlumno});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // msAlumno
            // 
            this.msAlumno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAltaAlumno,
            this.msConsultaAlumno,
            this.msModAlumno});
            this.msAlumno.Name = "msAlumno";
            resources.ApplyResources(this.msAlumno, "msAlumno");
            // 
            // msAltaAlumno
            // 
            this.msAltaAlumno.Name = "msAltaAlumno";
            resources.ApplyResources(this.msAltaAlumno, "msAltaAlumno");
            this.msAltaAlumno.Click += new System.EventHandler(this.msAltaAlumno_Click);
            // 
            // msConsultaAlumno
            // 
            this.msConsultaAlumno.Name = "msConsultaAlumno";
            resources.ApplyResources(this.msConsultaAlumno, "msConsultaAlumno");
            this.msConsultaAlumno.Click += new System.EventHandler(this.msConsultaAlumno_Click);
            // 
            // msModAlumno
            // 
            this.msModAlumno.Name = "msModAlumno";
            resources.ApplyResources(this.msModAlumno, "msModAlumno");
            this.msModAlumno.Click += new System.EventHandler(this.msModAlumno_Click);
            // 
            // msMateria
            // 
            this.msMateria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMateriaAlta});
            this.msMateria.Name = "msMateria";
            resources.ApplyResources(this.msMateria, "msMateria");
            // 
            // msMateriaAlta
            // 
            this.msMateriaAlta.Name = "msMateriaAlta";
            resources.ApplyResources(this.msMateriaAlta, "msMateriaAlta");
            this.msMateriaAlta.Click += new System.EventHandler(this.msMateriaAlta_Click);
            // 
            // msMateriaAlumno
            // 
            this.msMateriaAlumno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem1,
            this.modificarToolStripMenuItem});
            this.msMateriaAlumno.Name = "msMateriaAlumno";
            resources.ApplyResources(this.msMateriaAlumno, "msMateriaAlumno");
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            resources.ApplyResources(this.consultaToolStripMenuItem1, "consultaToolStripMenuItem1");
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            resources.ApplyResources(this.modificarToolStripMenuItem, "modificarToolStripMenuItem");
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem msAlumno;
        private System.Windows.Forms.ToolStripMenuItem msAltaAlumno;
        private System.Windows.Forms.ToolStripMenuItem msConsultaAlumno;
        private System.Windows.Forms.ToolStripMenuItem msMateria;
        private System.Windows.Forms.ToolStripMenuItem msMateriaAlta;
        private System.Windows.Forms.ToolStripMenuItem msMateriaAlumno;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msModAlumno;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}

