using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSQL
{
    public partial class SQLCadastrar : Form
    {
        string connetionString;
        OleDbConnection connection;

        DataSet ds = new DataSet();
        string Sql;
        public SQLCadastrar()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SQLData.mdb";
            string image = pictureBox1.ImageLocation.ToString();
            
            connection = new OleDbConnection(connetionString);

            Sql = "INSERT INTO [SQL] ( TipoConceito,Definicao,Sintaxe,Imagem) VALUES ('"+comboBox1.Text+ "','" + textBox1.Text + "','" + textBox2.Text + "','" + image+ "')";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Sql, connetionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[SQL]");
            MessageBox.Show("Registro efetuado");
        }
    }
}
