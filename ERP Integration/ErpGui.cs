using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP_Integration
{

 
    public partial class ErpGui : Form
    {
        Controller c = new Controller();

        public ErpGui()
        {
            InitializeComponent();

            String[] options1 = { "Innehållet och metadata i Employee (Personal) och relaterade tabeller", "Information om Personal och deras släktingar (Personalanhörig)", "Information om anställda som har varit borta pga sjukdom år 2004 (Personalfrånvaro)", "First name på anstallda som har varit mest sjuka" };
            for (int i = 0; i < options1.Length; i++)
            {
                cbOptions.Items.Add(options1[i]);
            }

            String[] options2 = { "Alla nycklar", "Alla indexes", "Alla table_constraints ", "Alla tabeller i databasen lösning 1", "Alla tabeller i databasen lösning 2", "Alla kolumner i tabellen Employee lösning 1", "Alla kolumner i tabellen Employee lösning 2"  };
            for (int i = 0; i < options2.Length; i++)
            {
                cbOptions2.Items.Add(options2[i]);
            }
        }



        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOptions.SelectedIndex)
            {

                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;

            } 
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            string name = txtBoxName.Text;
            string lastName = txtBoxLastName.Text;

            //c.InsertEmployee(no, name, lastName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            //c.DeleteEmployee(no);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            string name = txtBoxName.Text;
            string lastName = txtBoxLastName.Text;

           // c.UpdateEmployee(no, name, lastName);
        }

       private void btnSelect_Click(object sender, EventArgs e)
        {
           
           DataSet ds = c.GetAllEmployees();
           DataTable dt = ds.Tables[0];
           dataGridView1.DataSource = dt;
        }


    }

}
