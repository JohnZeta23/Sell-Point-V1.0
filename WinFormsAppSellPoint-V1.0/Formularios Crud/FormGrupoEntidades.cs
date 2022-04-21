using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Layers.Framework.ADO.NET.Presentation;
using Layers.Framework.ADO.NET.Data;

namespace WinFormsAppSellPoint_V1._0.Formularios_Crud
{
    public partial class FormGrupoEntidades : Form
    {
        public FormGrupoEntidades()
        {
            InitializeComponent();
        }

        //Codigo del crud del formulario

        //Evento del INSERT
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            ClassData.RegistroGrupoEntidad(
                    textBoxNombreGrupoEntidad.Text.ToString(),
                    textBoxComentario.Text.ToString(), comboBoxEstatus.Text.ToString(),
                    Convert.ToByte(comboBoxEliminable.SelectedIndex));

            MessageBox.Show("Datos introducidos existosamente");
        }

        //Evento del SELECT
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable SQLdatatable = new DataTable();

                if (textBoxIdGrupoEntidadesBuscar.Text.Trim() != "" || textBoxNombreGrupoEntidadBuscar.Text.Trim() != "")
                {
                    ClassData.SQLDataAdapter(
                        ClassData.sqlCommand("SpBuscarGrupoEntidad'"
                        + Convert.ToInt32(textBoxIdGrupoEntidadesBuscar.Text) + "'," +
                        "'" + textBoxNombreGrupoEntidadBuscar.Text + "'",
                        CommandType.Text)).Fill(SQLdatatable);
                }

                else
                {
                    ClassData.SQLDataAdapter(
                 ClassData.sqlCommand("SpBuscarGrupoEntidadSinParametros",
                 CommandType.Text)).Fill(SQLdatatable);
                }

                dataGridView1.DataSource = SQLdatatable;
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Evento del UPDATE
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            ClassData.EditarGrupoEntidad(Convert.ToInt32(textBoxIdGrupoEntidad.Text),
                textBoxNombreGrupoEntidad.Text.ToString(), textBoxComentario.Text.ToString(),
                comboBoxEstatus.Text.ToString(), comboBoxEliminable.SelectedIndex);

            MessageBox.Show("Datos editados existosamente");
        }

        //Evento del DELETE
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ClassData.EliminarGrupoEntidad(Convert.ToInt32(textBoxIdGrupoEntidadesBuscar.Text), textBoxNombreGrupoEntidadBuscar.Text.ToString());

            MessageBox.Show("Datos eliminados existosamente");
        }

        //Evento para traer registros a los campos y luego poder editarlos
        private void buttonBuscarEntidad_Click(object sender, EventArgs e)
        {
            ClassData.LlenarGrupoEntidad(Convert.ToInt32(textBoxIdGrupoEntidad.Text));

            textBoxNombreGrupoEntidad.Text = ClassData.Descripcion;
            textBoxComentario.Text = ClassData.Comentario;
            comboBoxEstatus.Text = ClassData.Status;
            comboBoxEliminable.SelectedIndex = ClassData.NoEliminable;
        }
    }
}
