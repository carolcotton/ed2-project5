using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ed2_project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();

        private void button1_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listSenhas.Items.Clear();

            foreach (Senha senha in senhas.FilaSenhas)
            {
                listSenhas.Items.Add(senha.dadosParciais());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());
            labelnumGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(textBox1.Text) - 1;
                if (!guiches.ListaGuiches[index].chamar(senhas.FilaSenhas))
                    MessageBox.Show("Não há senhas.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Revise a numeração do Guichê");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Guichê inexistente");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBoxSenhasTotal.Items.Clear();

            try
            {
                int index = int.Parse(textBox1.Text) - 1;
                foreach (Senha senha in guiches.ListaGuiches[index].Atendimentos)
                {
                    listBoxSenhasTotal.Items.Add(senha.dadosCompletos());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Revise a numeração do Guichê");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Guichê inexistente");
            }
        }
    }
}
