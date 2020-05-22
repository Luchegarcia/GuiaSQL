using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLCadastrar cadastrar = new SQLCadastrar();
            cadastrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLVisualizar visualizar = new SQLVisualizar();
            visualizar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sobre Sobre = new sobre();
            Sobre.Show();
        }
    }
}
