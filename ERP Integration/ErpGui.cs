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

            String[] options2 = { "Alla nycklar", "Alla indexes", "Alla table_constraints ", "Alla tabeller i databasen lösning 1", "Alla tabeller i databasen lösning 2", "Alla kolumner i tabellen Employee lösning 1", "Alla kolumner i tabellen Employee lösning 2"};
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
                    DataSet ds = c.GetEmployeeAndMetadata();
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    break;
                    
                case 1:
                    DataSet dsRelative = c.GetEmployeeAndRelatives();
                    DataTable dtRelative = dsRelative.Tables[0];
                    dataGridView1.DataSource = dtRelative;
                    break;
                case 2:
                    DataSet dsSick = c.GetSickEmployee();
                    DataTable dtSick = dsSick.Tables[0];
                    dataGridView1.DataSource = dtSick;
                    break;
                case 3:
                    DataSet dsMostSick = c.GetMostSickEmployee();
                    DataTable dtMostSick = dsMostSick.Tables[0];
                    dataGridView1.DataSource = dtMostSick;
                    break;
            }
        }

        private void cbOptions2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            switch (cbOptions2.SelectedIndex)
            {

                case 0:
                    DataSet ds = c.GetAllKeys();
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    break;
                case 1:
                    DataSet dsIndex = c.GetAllIndexes();
                    DataTable dtIndex = dsIndex.Tables[0];
                    dataGridView1.DataSource = dtIndex;
                    break;
                case 2:
                    DataSet dsConstraint = c.GetAllConstraints();
                    DataTable dtConstraint = dsConstraint.Tables[0];
                    dataGridView1.DataSource = dtConstraint;
                    break;
                case 3:
                    DataSet dsTablesFirst = c.GetAllTables();
                    DataTable dtTablesFirst = dsTablesFirst.Tables[0];
                    dataGridView1.DataSource = dtTablesFirst;
                    break;
                case 4:
                    DataSet dsTablesSecond = c.GetAllTables2();
                    DataTable dtTablesSecond = dsTablesSecond.Tables[0];
                    dataGridView1.DataSource = dtTablesSecond;
                    break;
                case 5:
                    DataSet dsEmpColumn = c.GetColumnsEmployee();
                    DataTable dtEmpColumn = dsEmpColumn.Tables[0];
                    dataGridView1.DataSource = dtEmpColumn;
                    break;
                case 6:
                    DataSet dsEmpColumn2 = c.GetColumnsEmployee2();
                    DataTable dtEmpColumn2 = dsEmpColumn2.Tables[0];
                    dataGridView1.DataSource = dtEmpColumn2;
                    break;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            string name = txtBoxName.Text;
            c.InsertEmployee(no, name);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            c.DeleteEmployee(no);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            string name = txtBoxName.Text;
            string lastName = txtBoxLastName.Text;

            c.UpdateEmployee(no, name, lastName);
        }

        private void gbQueries_Enter(object sender, EventArgs e)
        {

        }


    }

}
