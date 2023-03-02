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
    public partial class linq : Form
    {

        DataClasses1DataContext dc = new DataClasses1DataContext();
        

        public void gridfi()
        {
            var fill = from item in dc.emps select item;
            dataGridView1.DataSource = fill;
        }

        public void ajt()
        {
            emp e = new emp();
            e.email = txtnom.Text;

            dc.emps.InsertOnSubmit(e);
            dc.SubmitChanges();


        }

        public void sup()
        {
            var ss = dc.emps.SingleOrDefault(item => item.N_DEPT == int.Parse(txtlieu.Text));
            dc.emps.DeleteOnSubmit(ss);
            dc.SubmitChanges();

        } 


        public linq()
        {
            InitializeComponent();

        }
        int compt;

        private void linq_Load(object sender, EventArgs e)
        {
            gridfilla();
            textload();

        }
        int cmp;
        public void textload()
        {
            var tx = from item in dc.depts select item;
            compt = tx.Count();

            foreach (var item in tx)
            {
                for (int i = 0; i < compt; i++)
                {
                    i++;
                    txtnum.Text = item.N_DEPT.ToString();
                    txtnom.Text = item.NOM.ToString();
                    txtlieu.Text = item.LIEU.ToString();

                }
             
            }
                    

        }
        public void gridfilla()
        {


            var gridfill = from item in dc.depts select item;

            dataGridView1.DataSource = gridfill;


        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void suivantBTN_Click(object sender, EventArgs e)
        {

            var presone = dc.depts.SingleOrDefault(item => item.N_DEPT == int.Parse(txtnum.Text));
            presone.NOM = txtnom.Text;
            presone.LIEU = txtlieu.Text;
            dc.SubmitChanges();
            gridfilla();


        }

        private void ajouterBTN_Click(object sender, EventArgs e)
        {

            dept dp = new dept();
            dp.N_DEPT = int.Parse(txtnum.Text);
            dp.NOM = txtnom.Text;
            dp.LIEU = txtlieu.Text;

            dc.depts.InsertOnSubmit(dp);
            dc.SubmitChanges();
            gridfilla();

        }

        private void precedentBTN_Click(object sender, EventArgs e)
        {
            var presone = dc.depts.SingleOrDefault(item => item.N_DEPT == int.Parse(txtnum.Text));

            dc.depts.DeleteOnSubmit(presone);
            dc.SubmitChanges();
            gridfilla();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
