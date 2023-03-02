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

namespace NavigationAdo.net
{
    public partial class connecterFORM : Form
    {
        resource r = new resource();
        public connecterFORM()
        {
            InitializeComponent();
        }
         private void connecterFORM_Load(object sender, EventArgs e)
        {
            gridview();
        }
        public void gridview()
        {
            r.connecter();
            r.command = new SqlCommand("select * from users",r.connection);
            r.reader = r.command.ExecuteReader();
            r.dt = new DataTable();
            r.dt.Load(r.reader);
            dataGridView1.DataSource = r.dt;

            r.deconnecter();
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            r.connecter();

            r.command = new SqlCommand("update users set username = '"+txtusername.Text+"',password = '"+txtpass.Text+"' , post = '"+txtpost.Text+"' where userid = '"+txtid.Text+"'",r.connection);

            r.command.ExecuteNonQuery();
            MessageBox.Show("done mod");
            r.deconnecter();

        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            r.connecter();

            r.command = new SqlCommand("insert into users values('"+txtusername.Text+"','"+txtpass.Text+"','"+txtpost.Text+"')",r.connection);
            r.command.ExecuteNonQuery();
            MessageBox.Show("done ajt");
            r.deconnecter();
        }

        private void supprimerBTN_Click(object sender, EventArgs e)
        {
            r.connecter();
            r.command = new SqlCommand("delete from users where userid = '"+txtid.Text+"'",r.connection);
            r.command.ExecuteNonQuery();
            MessageBox.Show("done sup ");

            r.deconnecter();
        }

       
    }
}
