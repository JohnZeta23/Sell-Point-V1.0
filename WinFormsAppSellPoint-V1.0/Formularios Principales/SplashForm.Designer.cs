namespace WinFormsAppSellPoint_V1._0
{
    partial class SplashForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBarSplashForm = new System.Windows.Forms.ProgressBar();
            this.timerSplashForm = new System.Windows.Forms.Timer(this.components);
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarSplashForm
            // 
            this.progressBarSplashForm.Location = new System.Drawing.Point(197, 374);
            this.progressBarSplashForm.Name = "progressBarSplashForm";
            this.progressBarSplashForm.Size = new System.Drawing.Size(404, 23);
            this.progressBarSplashForm.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSplashForm.TabIndex = 1;
            // 
            // timerSplashForm
            // 
            this.timerSplashForm.Enabled = true;
            this.timerSplashForm.Tick += new System.EventHandler(this.timerSplashForm_Tick);
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar.Location = new System.Drawing.Point(607, 374);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(0, 21);
            this.labelProgressBar.TabIndex = 2;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.progressBarSplashForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarSplashForm;
        private System.Windows.Forms.Timer timerSplashForm;
        private System.Windows.Forms.Label labelProgressBar;
    }
}

