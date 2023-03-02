using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http.Headers;
using System.Globalization;

namespace NavigationAdo.net
{
    public partial class Form1 : Form
    {
        resource r = new resource();
        public static int compt;

        public Form1()
        {
            InitializeComponent();
            r.dt = new DataTable();
        }

        DataSet sst = new DataSet();
        public void xmla()
        {
            r.connecter();
            r.command = new SqlCommand("select * from dept ",r.connection);
            r.reader = r.command.ExecuteReader();
            sst.Tables.Add("aa");
            sst.Tables["aa"].Load(r.reader);

            string chemin = "";
            saveFileDialog1.Filter = "XML FILES |.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                  chemin = saveFileDialog1.FileName;
            }
            sst.WriteXml(chemin);
            MessageBox.Show("xml bien eregistre");

            r.deconnecter();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            gridview();
            showintxt();
            ajoutercolumn();
            combofill();

        }

        DataSet st = new DataSet();
        public void exportxml()
        {

            r.connecter();
            r.command = new SqlCommand("select * from dept",r.connection);
            r.reader = r.command.ExecuteReader();
            st.Tables.Add("as");
            st.Tables["as"].Load(r.reader);
            string chemin = "";

            saveFileDialog1.Filter = "XML FILES |.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chemin = saveFileDialog1.FileName;

            }

            st.WriteXml(chemin);
            MessageBox.Show("xml file is created");

            r.deconnecter();
        }

        public void combofill()
        {
            r.connecter();
            r.adapter = new SqlDataAdapter("select n_dept,nom from dept  ",r.connection);
            r.set = new DataSet();
            r.adapter.Fill(r.set,"dept");
            comboBox1.DataSource = r.set.Tables["dept"];
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "n_dept";

            r.deconnecter();

        }
        public void ajoutercolumn()
        {

            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.Name = "suppression";
            dataGridView1.Columns.Add(check);

        }
        public void suppression()
        {
            foreach ( DataGridViewRow item in dataGridView1.Rows)
            {

                if (Convert.ToBoolean( item.Cells["suppression"].Value) == true)
                {
                    r.connecter();

                    r.command = new SqlCommand(" delete from emp where num = '"+item.Cells["num"].Value.ToString()+"'",r.connection);
                    r.command.ExecuteNonQuery();
                    r.deconnecter();

                }
            }
            MessageBox.Show("bien supprimer");
            gridview();

        }

        public void gridview()
        {
            r.connecter();
            r.command = new SqlCommand("select num,nom,fonction,salaire,n_dept from emp ", r.connection);
            r.reader = r.command.ExecuteReader();
            r.dt.Load(r.reader);
            dataGridView1.DataSource = r.dt;
            r.reader.Close();
            r.deconnecter();
        }
        public void showintxt()
        {
            txtnom.Text = r.dt.Rows[compt][0].ToString();
            txtfonction.Text = r.dt.Rows[compt][1].ToString();
            txtsalaire.Text = r.dt.Rows[compt][2].ToString();
           comboBox1.Text = r.dt.Rows[compt][3].ToString();

        }

        private void premierBTN_Click(object sender, EventArgs e)
        {
            compt = 0;
            showintxt();
        }

        private void dernierbtn_Click(object sender, EventArgs e)
        {
            compt = r.dt.Rows.Count - 1;
            showintxt();
        }

        private void suivantBTN_Click(object sender, EventArgs e)
        {
           
            if (compt == r.dt.Rows.Count-1)
            {
                compt = 0;
            
                showintxt();
            }
            else
            {
                compt++;
                showintxt();


            }

        }

        private void precedentBTN_Click(object sender, EventArgs e)
        {
            if (compt == 0)
            {
              compt = r.dt.Rows.Count - 1;

             
                showintxt();
            }
            else
            {
                compt--;
                showintxt();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suppression();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exportxml();
            xmla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet aa = new DataSet();
            
            string ch = "";
       
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                ch = openFileDialog1.FileName;
            }

            aa.ReadXml(ch);
            dataGridView1.DataSource = aa.Tables[0];



        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            string a = "";
            saveFileDialog1.Filter = "text files |*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                a = saveFileDialog1.FileName;
            }

            StreamWriter st = new StreamWriter(a);


            for (int i = 0; i < r.dt.Rows.Count; i++)
            {
                st.WriteLine(r.dt.Rows[i][0].ToString() + r.dt.Rows[i][1].ToString());
            }
            

            MessageBox.Show("bien engestrer ");

        }
    }
}
