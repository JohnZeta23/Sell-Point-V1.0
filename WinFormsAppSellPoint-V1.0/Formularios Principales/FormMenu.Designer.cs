namespace WinFormsAppSellPoint_V1._0
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.stsinfo = new System.Windows.Forms.StatusStrip();
            this.fechayhora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbldia = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGrupoEntidad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTipoEntidad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEntidad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCrud = new System.Windows.Forms.Panel();
            this.toolStripStatusLabelUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.stsinfo.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsinfo
            // 
            this.stsinfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.stsinfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsinfo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stsinfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechayhora,
            this.lbldia,
            this.toolStripStatusLabelUserName,
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelTime});
            this.stsinfo.Location = new System.Drawing.Point(0, 523);
            this.stsinfo.Name = "stsinfo";
            this.stsinfo.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.stsinfo.Size = new System.Drawing.Size(829, 22);
            this.stsinfo.TabIndex = 1;
            this.stsinfo.Text = "statusStrip1";
            // 
            // fechayhora
            // 
            this.fechayhora.Name = "fechayhora";
            this.fechayhora.Size = new System.Drawing.Size(0, 17);
            // 
            // lbldia
            // 
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(10, 17);
            this.lbldia.Text = ".";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(829, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGrupoEntidad,
            this.toolStripMenuItemTipoEntidad,
            this.toolStripMenuItemEntidad});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 22);
            this.toolStripMenuItem1.Text = "Archivos";
            // 
            // toolStripMenuItemGrupoEntidad
            // 
            this.toolStripMenuItemGrupoEntidad.Name = "toolStripMenuItemGrupoEntidad";
            this.toolStripMenuItemGrupoEntidad.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemGrupoEntidad.Text = "Grupos Entidades";
            this.toolStripMenuItemGrupoEntidad.Click += new System.EventHandler(this.toolStripMenuItemGrupoEntidad_Click);
            // 
            // toolStripMenuItemTipoEntidad
            // 
            this.toolStripMenuItemTipoEntidad.Name = "toolStripMenuItemTipoEntidad";
            this.toolStripMenuItemTipoEntidad.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemTipoEntidad.Text = "Tipos Entidades";
            this.toolStripMenuItemTipoEntidad.Click += new System.EventHandler(this.toolStripMenuItemTipoEntidad_Click);
            // 
            // toolStripMenuItemEntidad
            // 
            this.toolStripMenuItemEntidad.Name = "toolStripMenuItemEntidad";
            this.toolStripMenuItemEntidad.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemEntidad.Text = "Entidades";
            this.toolStripMenuItemEntidad.Click += new System.EventHandler(this.toolStripMenuItemEntidad_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItemLogin,
            this.toolStripMenuItemSalir});
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(64, 22);
            this.toolStripMenuItem5.Text = "Sistema";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem6.Text = "Acerca de..";
            // 
            // toolStripMenuItemLogin
            // 
            this.toolStripMenuItemLogin.Name = "toolStripMenuItemLogin";
            this.toolStripMenuItemLogin.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemLogin.Text = "Login";
            this.toolStripMenuItemLogin.Click += new System.EventHandler(this.toolStripMenuItemLogin_Click);
            // 
            // toolStripMenuItemSalir
            // 
            this.toolStripMenuItemSalir.Name = "toolStripMenuItemSalir";
            this.toolStripMenuItemSalir.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemSalir.Text = "Salir";
            this.toolStripMenuItemSalir.Click += new System.EventHandler(this.toolStripMenuItemSalir_Click);
            // 
            // panelCrud
            // 
            this.panelCrud.Location = new System.Drawing.Point(0, 21);
            this.panelCrud.Margin = new System.Windows.Forms.Padding(2);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(825, 505);
            this.panelCrud.TabIndex = 3;
            // 
            // toolStripStatusLabelUserName
            // 
            this.toolStripStatusLabelUserName.Name = "toolStripStatusLabelUserName";
            this.toolStripStatusLabelUserName.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelUserName.Text = "Empty";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabelDate.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabelTime.Text = "toolStripStatusLabel1";
            // 
            // timerHoraFecha
            // 
            this.timerHoraFecha.Enabled = true;
            this.timerHoraFecha.Tick += new System.EventHandler(this.timerHoraFecha_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 545);
            this.ControlBox = false;
            this.Controls.Add(this.panelCrud);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.stsinfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.stsinfo.ResumeLayout(false);
            this.stsinfo.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsinfo;
        private System.Windows.Forms.ToolStripStatusLabel fechayhora;
        private System.Windows.Forms.ToolStripStatusLabel lbldia;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGrupoEntidad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTipoEntidad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEntidad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSalir;
        private System.Windows.Forms.Panel panelCrud;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timerHoraFecha;
    }
}