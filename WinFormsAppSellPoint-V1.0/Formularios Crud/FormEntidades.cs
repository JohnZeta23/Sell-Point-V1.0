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
using Layers.Framework.ADO.NET;
//using Layers.Framework.ADO.NET;

namespace WinFormsAppSellPoint_V1._0
{
    public partial class FormEntidades : Form
    {
        public FormEntidades()
        {
            InitializeComponent();
            CargarGrupoEntidades();
        }

        //FORMATO DEL CAMPO DE NUMERO DE DOCUMENTO

        private void comboBoxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassPresentation.FormatoMascara(comboBoxTipoDocumento.SelectedIndex);
            maskedTextBoxNumDocumento.Mask = ClassPresentation.mascara;

        }

        //RELACION DE COMBOBOX TIPO ENTIDAD Y GRUPO ENTIDAD

        public void CargarGrupoEntidades()
        {
            try
            {
                DataTable SQLdatatable = new DataTable();
                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select IdGrupoEntidad,Descripcion from GrupoEntidades",
                    CommandType.Text)).Fill(SQLdatatable);


                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();

                DataRow SQLDataRow = SQLdatatable.NewRow();
                SQLDataRow["Descripcion"] = "Selecciona un grupo de Entidad";
                SQLdatatable.Rows.InsertAt(SQLDataRow, 0);

                comboBoxGrupoEntidad.ValueMember = "IdGrupoEntidad";
                comboBoxGrupoEntidad.DisplayMember = "Descripcion";
                comboBoxGrupoEntidad.DataSource = SQLdatatable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarTipoEntidades(string IdGrupoEntidades)
        {
            try
            {
                DataTable SQLdatatable = new DataTable();

                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select IdTipoEntidad, Descripcion from TipoEntidades Where IdGrupoEntidad = '"
                    + IdGrupoEntidades + "'",
                    CommandType.Text)).Fill(SQLdatatable);


                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();

                DataRow SQLDataRow = SQLdatatable.NewRow();
                SQLDataRow["Descripcion"] = "Selecciona un tipo de Entidad";
                SQLdatatable.Rows.InsertAt(SQLDataRow,0);

                comboBoxTipoEntidad.ValueMember = "IdTipoEntidad";
                comboBoxTipoEntidad.DisplayMember = "Descripcion";
                comboBoxTipoEntidad.DataSource = SQLdatatable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxGrupoEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGrupoEntidad.SelectedValue.ToString() != null)
            {
                string IdGrupoEntidad = comboBoxGrupoEntidad.SelectedValue.ToString();

                CargarTipoEntidades(IdGrupoEntidad);
            }
        }


        //Codigo del crud del formulario

        //Codigo del INSERT
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (ClassBussiness.LimiteCreditoLimite(
                Convert.ToInt32(maskedTextBoxLimiteCredito.Text.ToString())) == true)
            {

                ClassData.RegistroEntidad(
                    textBoxNombreEntidad.Text.ToString(), textBoxDireccion.Text.ToString(),
                    textBoxLocalidad.Text.ToString(), comboBoxTipoEntidad.Text.ToString(),
                    comboBoxTipoDocumento.Text.ToString(), maskedTextBoxNumDocumento.Text.ToString(),
                    textBoxTelefono.Text.ToString(), textBoxURLPaginaWeb.Text.ToString(),
                    textBoxURLFacebook.Text.ToString(), textBoxURLInstagram.Text.ToString(),
                    textBoxURLTwitter.Text.ToString(), textBoxURLTikTok.Text.ToString(),
                    comboBoxGrupoEntidad.Text, comboBoxTipoEntidad.Text,
                    Convert.ToInt32(maskedTextBoxLimiteCredito.Text), textBoxUserName.Text.ToString(),
                    textBoxUserPassword.Text.ToString(), comboBoxRolUsuario.Text.ToString(),
                    textBoxComentario.Text.ToString(), comboBoxEstatus.Text.ToString(),
                    Convert.ToByte(comboBoxEliminable.SelectedIndex));

                MessageBox.Show("Datos introducidos existosamente");
            }

            if (ClassBussiness.LimiteCreditoLimite(
                Convert.ToInt32(maskedTextBoxLimiteCredito.Text.ToString())) == false)
            {
                MessageBox.Show("El Limite del Credito debe ser mayor o igual a 0.");
            }
        }

        //Codigo del UPDATE
        
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (ClassBussiness.LimiteCreditoLimite(
                Convert.ToInt32(maskedTextBoxLimiteCredito.Text.ToString())) == true)
            {

                ClassData.EditarEntidad(Convert.ToInt32(textBoxIdEntidad.Text),
        textBoxNombreEntidad.Text.ToString(), textBoxDireccion.Text.ToString(),
        textBoxLocalidad.Text.ToString(), comboBoxTipoEntidad.Text.ToString(),
        comboBoxTipoDocumento.Text.ToString(), maskedTextBoxNumDocumento.Text.ToString(),
        textBoxTelefono.Text.ToString(), textBoxURLPaginaWeb.Text.ToString(),
        textBoxURLFacebook.Text.ToString(), textBoxURLInstagram.Text.ToString(),
        textBoxURLTwitter.Text.ToString(), textBoxURLTikTok.Text.ToString(),
        comboBoxGrupoEntidad.Text, comboBoxTipoEntidad.Text,
        Convert.ToInt32(maskedTextBoxLimiteCredito.Text), textBoxUserName.Text.ToString(),
        textBoxUserPassword.Text.ToString(), comboBoxRolUsuario.Text.ToString(),
        textBoxComentario.Text.ToString(), comboBoxEstatus.Text.ToString(),
        Convert.ToByte(comboBoxEliminable.SelectedIndex));

                MessageBox.Show("Datos editados existosamente");
            }

            if (ClassBussiness.LimiteCreditoLimite(
                Convert.ToInt32(maskedTextBoxLimiteCredito.Text.ToString())) == false)
            {
                MessageBox.Show("El Limite del Credito debe ser mayor o igual a 0.");
            }
        }

        //Codigo para traer registros a los campos y luego poder editarlos
        private void buttonBuscarEntidad_Click(object sender, EventArgs e)
        {
            try
            {
                ClassData.LlenarEntidad(Convert.ToInt32(textBoxIdEntidad.Text));

                textBoxNombreEntidad.Text = ClassData.Descripcion;
                textBoxDireccion.Text = ClassData.Direccion;
                textBoxLocalidad.Text = ClassData.Localidad;
                comboBoxTipoDocumento.Text = String.Empty;
                comboBoxTipoDocumento.SelectedText = ClassData.TipoDocumento;
                maskedTextBoxNumDocumento.Text = ClassData.NumeroDocumento;
                textBoxTelefono.Text = ClassData.Teléfonos;
                textBoxURLPaginaWeb.Text = ClassData.URLPaginaWeb;
                textBoxURLFacebook.Text = ClassData.URLFacebook;
                textBoxURLInstagram.Text = ClassData.URLInstagram;
                textBoxURLTwitter.Text = ClassData.URLTwitter;
                textBoxURLTikTok.Text = ClassData.URLTikTok;
                comboBoxGrupoEntidad.Text = ClassData.GrupoEntidad;
                comboBoxTipoEntidad.Text = ClassData.TipoEntidad2;
                maskedTextBoxLimiteCredito.Text = ClassData.LimiteCredito.ToString();
                textBoxUserName.Text = ClassData.UserNameEntidad;
                textBoxUserPassword.Text = ClassData.PasswordEntidad;
                comboBoxRolUsuario.Text = ClassData.RolUserEntidad;
                textBoxComentario.Text = ClassData.Comentario;
                comboBoxEstatus.Text = ClassData.Status;
                comboBoxEliminable.SelectedIndex = ClassData.NoEliminable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         //Codigo para el SELECT
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable SQLdatatable = new DataTable();

                if (textBoxIdEntidadBuscar.Text.Trim() != "" || textBoxNombreEntidadBuscar.Text.Trim() != "") {
                    ClassData.SQLDataAdapter(
                        ClassData.sqlCommand("SpBuscarEntidad'"
                        + Convert.ToInt32(textBoxIdEntidadBuscar.Text) + "','" + textBoxNombreEntidadBuscar.Text + "'",
                        CommandType.Text)).Fill(SQLdatatable);
                }

                else {
                    ClassData.SQLDataAdapter(
                 ClassData.sqlCommand("SpBuscarEntidadSinParametros",
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

        //Codigo del DELETE
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ClassData.EliminarEntidad(Convert.ToInt32(textBoxIdEntidadBuscar.Text),
                textBoxNombreEntidadBuscar.Text);

            MessageBox.Show("Datos eliminados existosamente");
        }
    }
}