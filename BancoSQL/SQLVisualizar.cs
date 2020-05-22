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
    public partial class SQLVisualizar : Form
    {
        string connetionString;
        OleDbConnection connection;
       
        DataSet ds = new DataSet();
        string Sql;

        public SQLVisualizar()
        {
            InitializeComponent();
            connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SQLData.mdb";
           
            connection = new OleDbConnection(connetionString);
            
            Sql = "SELECT ID,TipoConceito,Definicao FROM [SQL]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Sql, connetionString);
            DataSet ds = new DataSet();
           dataAdapter.Fill(ds, "[SQL]");
           dataGridView1.DataSource = ds.Tables[0].DefaultView;
           
           

        }

    
        
        private void SQLVisualizar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sQLDataDataSet1.SQL' table. You can move, or remove it, as needed.


            // TODO: This line of code loads data into the 'sQLDataDataSet.SQL' table. You can move, or remove it, as needed.
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sql = "SELECT ID,TipoConceito,Definicao FROM [SQL] WHERE [Definicao] Like '%" + textBox1.Text + "%'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Sql, connetionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[SQL]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sql = "SELECT ID,TipoConceito,Definicao FROM [SQL] WHERE [TipoConceito]='"+comboBox1.Text+"'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Sql, connetionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[SQL]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Detalhes detalhe = new Detalhes();
            detalhe.Show();
            String id;

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            Sql = "SELECT * FROM [SQL] WHERE ID=" + id;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Sql, connetionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[SQL]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            String def,img;

            def = Convert.ToString(ds.Tables[0].Rows[0]["Definicao"]);
            img = Convert.ToString(ds.Tables[0].Rows[0]["Imagem"]);

            detalhe.label6.Text = id; 
            detalhe.label2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            detalhe.textBox1.Text = def;
            detalhe.textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            detalhe.pictureBox1.ImageLocation = img;

            this.Close();

        }
    }
}
