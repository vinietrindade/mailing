using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Enviar classe = new Enviar();
            classe.email(txtDestinarario.Text, txtAssunto.Text, txtMensagem.Text, txtAnexo.Text);

            if(Enviar.teste == true)
            {
                MessageBox.Show("email enviado com sucesso!!");
            }
            else
            {
                MessageBox.Show("email nao foi enviado!!");
            }
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtAnexo.Text = open.FileName;
            }
        }
    }
}
