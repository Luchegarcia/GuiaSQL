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
    public partial class Detalhes : Form
    {
        public Detalhes()
        {
            InitializeComponent();
        }

        private void Detalhes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificar mod = new Modificar(textBox1 , label2 , textBox2 , pictureBox1 ,label6 );

            mod.Show();

            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
