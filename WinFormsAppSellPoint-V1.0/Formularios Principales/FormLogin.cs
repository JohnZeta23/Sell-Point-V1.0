using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Layers.Framework.ADO.NET.Data;

namespace WinFormsAppSellPoint_V1._0
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        } 
        private void ButtonAceptar_Click(object sender, EventArgs e) 
        {
            if(ClassData.SQLDatareader(ClassData.sqlCommand("select * from Entidades " +
                "where UserNameEntidad = '"+txtUserName.Text+"' " +
                "and PasswordEntidad = '"+txtpassword.Text+"'",CommandType.Text)).HasRows)
                {
                    Program.boolUserAuthenticated = true;
                    Program.stringUserName = txtUserName.Text;
                        ClassData.OpenDBSQLServer().Close();
                        ClassData.OpenDBSQLServer().Dispose();
                    MessageBox.Show("Credenciales correctas");
                        this.DialogResult = DialogResult.OK;
                if (Program.LoginConfirm == true)
                {
                    this.Close();
                }
            }
                 else
                 {
                    MessageBox.Show("Credenciales incorrectas");
                 }             
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelClearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtpassword.Text = "";
        }
    }
}
