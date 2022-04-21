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
        

        //Metodo para llamar formularios dentro de paneles

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

        //Evento para llamar el Formulario GrupoEntidades
        private void toolStripMenuItemGrupoEntidad_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Formularios_Crud.FormGrupoEntidades());
        }

        //Evento para llamar el Formulario TipoEntidades
        private void toolStripMenuItemTipoEntidad_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Formularios_Crud.FormTipoEntidades());
        }

        //Evento para salir del programa
        private void toolStripMenuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento para llamar el Formulario Entidades
        private void toolStripMenuItemEntidad_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormEntidades());
        }

        //Evento para llamar el Formulario Acerca De...
        private void toolStripMenuItemAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Formularios_Principales.FormAcercaDe());
        }

        //Evento para llamar el Formulario Login y volver a loguearse
        private void toolStripMenuItemLogin_Click(object sender, EventArgs e)
        {
            ConfirmarLogin();            
        }

        //Metodo para confirmar el login nuevamente y cambiar el nombre de usuario activo
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

        //Evento para mostrar la fecha y hora actuales
        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
