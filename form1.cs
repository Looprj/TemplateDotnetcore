using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formu_Cad
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nomeusuario;
            DateTime dataNascimento;
            String email;
            int Senha;


            nomeusuario = textBox1.Text;
            dataNascimento = dateTimePicker1.Value;
            email = textBox2.Text;
            Senha = Convert.ToInt32(textBox3.Text);

            // Verifica se o e - mail termina com @mastercoin.com.br
            if (!email.EndsWith("@mastercoin.com.br"))
            {
                MessageBox.Show("O e-mail deve fazer parte do domínio @mastercoin.com.br.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Interrompe a execução do método se a validação falhar
            }




            MessageBox.Show("Nome:" + nomeusuario);
            MessageBox.Show("Nascimento:" + dataNascimento);
            MessageBox.Show("Email:" + email);
            MessageBox.Show("Senha:" + Senha);
        }
    }
}
