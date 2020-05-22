using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSQL
{
    public partial class Modificar : Form
    {
        string connetionString;
        OleDbConnection connection;

        DataSet ds = new DataSet();
        string Sql;
        
        public Modificar(TextBox textBox1 , Label label2 , TextBox textBox2, PictureBox pictureBox1, Label label6 )
        {
            InitializeComponent();
            String comboValor = label2.Text;
            ConceitoBox.Text = comboValor;

            DefinicaoBox.Text = textBox1.Text;
            SintaxeBox.Text = textBox2.Text;

            Imagem.Image = pictureBox1.Image;

            label1.Text = label6.Text;

        }
       
        private void Modificar_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog ArqImg = new OpenFileDialog();
                
               Imagem.ImageLocation = openFileDialog.FileName.ToString();
                Imagem.Refresh();
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja sobrescrever os dados?", "Ação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String id2;

                id2 = label1.Text;

                connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SQLData.mdb";
                string image = Imagem.ImageLocation.ToString();

                connection = new OleDbConnection(connetionString);

                Sql = "Update [SQL] SET [TipoConceito]='" + ConceitoBox.Text + "',[Definicao]='" + DefinicaoBox.Text + "',[Sintaxe]='" + SintaxeBox.Text + "',Imagem='" + image + "' WHERE ID ="+ id2;
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Sql, connetionString);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "[SQL]");
                MessageBox.Show("Registro efetuado");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
           
        }
    }
}
