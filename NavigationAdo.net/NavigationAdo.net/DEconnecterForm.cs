using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationAdo.net
{
    public partial class DEconnecterForm : Form
    {
        resource r = new resource(); 

        public DEconnecterForm()
        {
            InitializeComponent();
            gridfill();
        }



       public void gridfill()
        {
            r.connecter();
            r.adapter = new SqlDataAdapter("select * from users",r.connection);
         
            r.adapter.Fill(r.set,"users");
            dataGridView1.DataSource = r.set.Tables["users"];

            r.deconnecter();

        }



        private void ajouterBtn_Click(object sender, EventArgs e)
        {

            r.ligne = r.set.Tables["users"].NewRow();
        
            r.ligne[1] = txtusername.Text;
            r.ligne[2] = txtpass.Text;
            r.ligne[3] = txtpost.Text;




            for (int i = 0; i < r.set.Tables["users"].Rows.Count; i++)
            {
                if (txtusername.Text  == r.set.Tables["users"].Rows[i][1].ToString())
                {
                    MessageBox.Show("deja exist ");
                }
                
            }

            r.set.Tables["users"].Rows.Add(r.ligne);
            MessageBox.Show("bien cree ");
            dataGridView1.DataSource = r.set.Tables["users"];

  
        }

        private void supprimerBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < r.set.Tables["users"].Rows.Count; i++)
            {

                if (txtid.Text == r.set.Tables["users"].Rows[i][0].ToString())
                {
                      r.set.Tables["users"].Rows[i].Delete();
                        MessageBox.Show("bien supprimer ");
                       dataGridView1.DataSource = r.set.Tables["users"];

                }

            }

        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {


             for (int i = 0; i < r.set.Tables["users"].Rows.Count; i++)
            {

                if (txtid.Text == r.set.Tables["users"].Rows[i][0].ToString())
                {
                      r.set.Tables["users"].Rows[i][1] = txtusername.Text;
                      r.set.Tables["users"].Rows[i][2] = txtpass.Text;
                      r.set.Tables["users"].Rows[i][3] = txtpost.Text;
  

                        MessageBox.Show("bien modifier ");
                       dataGridView1.DataSource = r.set.Tables["users"];

                }

            }


        }
    }
}
