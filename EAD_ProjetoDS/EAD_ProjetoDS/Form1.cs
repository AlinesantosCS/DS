using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_EAD_ProjetoDS;
using BLL_EAD_ProjetoDS;

namespace UI_EAD_ProjetoDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Login obj = new DTO_Login();
                obj.Usuario = textBox1.Text;
                obj.Senha = textBox2.Text;

               MessageBox.Show(BLL_Login.ValidarLogin(obj)); // Retorna uma string

                /*string resultado = BLL_Login.ValidarLogin(obj));
                if(resultado == "Sucesso")
                {
                    // Tela Usuário
                }
                else
                {
                    MessageBox.Show(resultado);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
