using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppSellPoint_V1._0
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            toolStripStatusLabelUserName.Text = Program.stringUserName.ToString();
        }
        
        private Form formActivado = null;
        private void AbrirFormularios(Form FormHijo)
        {
            if (formActivado != null)
            
                formActivado.Close();
                formActivado = FormHijo;
                FormHijo.TopLevel = false;
                FormHijo.Dock = DockStyle.Fill;

                panelCrud.Controls.Add(FormHijo);
                panelCrud.Tag = FormHijo;
                FormHijo.BringToFront();
                FormHijo.Show();
        }
        private void toolStripMenuItemGrupoEntidad_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Formularios_Crud.FormGrupoEntidades());
        }

        private void toolStripMenuItemTipoEntidad_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Formularios_Crud.FormTipoEntidades());
        }

        private void toolStripMenuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemEntidad_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormEntidades());
        }

        private void toolStripMenuItemLogin_Click(object sender, EventArgs e)
        {
            ConfirmarLogin();            
        }

        public void ConfirmarLogin()
        {
            this.Hide();
            if (Program.LoginConfirm == true)
            
                Program.LoginConfirm = false;
                DialogResult resultado = new DialogResult();
                Form mensaje = new FormLogin();

                resultado = mensaje.ShowDialog();
                mensaje.Close();

                if (resultado == DialogResult.OK)
                {

                this.Show();
                toolStripStatusLabelUserName.Text = Program.stringUserName.ToString();
                }
        }

        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
