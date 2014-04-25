﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERP_Integration.ERPIntegrationWSReference;

namespace ERP_Integration
{
    public partial class ErpGui : Form
    {
        Controller c = new Controller();

        public ErpGui()
        {
            InitializeComponent();

            String[] options1 = { "Innehållet och metadata i Employee och relaterade tabeller", "Information om Personal och deras släktingar", "Information om anställda som har varit borta pga sjukdom år 2004", "First name på anstallda som har varit mest sjuka" };
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
                    listView.Clear();
                    List<SysObject> employees = c.GetEmployeeAndMetadata();
                    listView.Columns.Add("Name");
                    listView.Columns.Add("Id");
                    listView.Columns.Add("XType");
                    listView.Columns.Add("Uid");

                    foreach (SysObject so in employees)
                    {
                        
                        ListViewItem lvi = new ListViewItem(so.Name);
                        lvi.SubItems.Add(so.Id);
                        lvi.SubItems.Add(so.Xtype);
                        listView.Items.Add(lvi);

                    }    
                    break;
                    
                case 1:
                    listView.Clear();
                    List<EmpRelativeQuery> employeesRelatives = c.GetEmployeeAndRelatives();
                    listView.Columns.Add("First Name");
                    listView.Columns.Add("Last Name");
                    listView.Columns.Add("Relative Code");
                    listView.Columns.Add("First Name");

                    foreach (EmpRelativeQuery er in employeesRelatives)
                    {

                        ListViewItem lvi = new ListViewItem(er.EmpFirstName);
                        lvi.SubItems.Add(er.EmpLastName);
                        lvi.SubItems.Add(er.RelativeCode);
                        lvi.SubItems.Add(er.RelFirstName);
                        listView.Items.Add(lvi);

                    }    
                    break;

                case 2:
                    listView.Clear();
                    List<EmpSick> employeesSick = c.GetSickEmployee();
                    listView.Columns.Add("First Name");
                    listView.Columns.Add("Last Name");

                    foreach (EmpSick es in employeesSick)
                    {

                        ListViewItem lvi = new ListViewItem(es.FirstName);
                        lvi.SubItems.Add(es.LastName);
                        listView.Items.Add(lvi);

                    }   
                    break;

                case 3:

                    listView.Clear();
                    List<EmpSick> employeeMostSick = c.GetMostSickEmployee();
                    listView.Columns.Add("First Name");
                    listView.Columns.Add("Last Name");

                    foreach (EmpSick ems in employeeMostSick)
                    {

                        ListViewItem lvi = new ListViewItem(ems.FirstName);
                        lvi.SubItems.Add(ems.LastName);
                        listView.Items.Add(lvi);

                    }  
                    
                    break;
            }
        }

        private void cbOptions2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            switch (cbOptions2.SelectedIndex)
            {

                case 0:
                    listView.Clear();
                    List<SysObject> keys = c.GetAllKeys();
                    listView.Columns.Add("Id");
                    listView.Columns.Add("Xtype");
                    listView.Columns.Add("Name");

                    foreach (SysObject k in keys)
                    {
                        ListViewItem lvi = new ListViewItem(k.Id);
                        lvi.SubItems.Add(k.Xtype);
                        lvi.SubItems.Add(k.Name);
                        listView.Items.Add(lvi);
                    }

                    break;              

                case 1:
                    listView.Clear();
                    List<SysIndex> index = c.GetAllIndexes();
                    listView.Columns.Add("Id");
                    listView.Columns.Add("Status");

                    foreach (SysIndex k in index)
                    {
                        ListViewItem lvi = new ListViewItem(k.Id);
                        lvi.SubItems.Add(k.Status);
                        listView.Items.Add(lvi);
                    } 
                    break;

                case 2:
                     listView.Clear();
                     List<SysConstraint> constraints = c.GetAllConstraints();
                    listView.Columns.Add("Constid");
                    listView.Columns.Add("Id");

                    foreach (SysConstraint k in constraints)
                    {
                        ListViewItem lvi = new ListViewItem(k.Constid);
                        lvi.SubItems.Add(k.Id);
                        listView.Items.Add(lvi);
                    }
                    break;

                case 3:
                     listView.Clear();
                     List<SysObject> sysObjects = c.GetAllTables();
                    listView.Columns.Add("name");

                    foreach (SysObject k in sysObjects)
                    {
                        ListViewItem lvi = new ListViewItem(k.Name);
                        listView.Items.Add(lvi);
                    }
                    break;

                case 4:
                    listView.Clear();
                    List<SysTable> sysTable = c.GetAllTables2();
                    listView.Columns.Add("Name");

                    foreach (SysTable k in sysTable)
                    {
                        ListViewItem lvi = new ListViewItem(k.Name);
                        listView.Items.Add(lvi);
                    }
                    break;

                case 5:
                      listView.Clear();
                    List<SysColumn> sysColumns = c.GetColumnsEmployee();
                    listView.Columns.Add("Name");
                    listView.Columns.Add("Id");
                    listView.Columns.Add("Xtype");

                    foreach (SysColumn k in sysColumns)
                    {
                        ListViewItem lvi = new ListViewItem(k.Name);
                        lvi.SubItems.Add(k.Id);
                        lvi.SubItems.Add(k.Xtype);
                        listView.Items.Add(lvi);
                    }
                    break;

                case 6:
                     listView.Clear();
                     List<Information_Schema_Column> columnInfo = c.GetColumnsEmployee2();
                    listView.Columns.Add("Column Name");

                    foreach (Information_Schema_Column k in columnInfo)
                    {
                       ListViewItem lvi = new ListViewItem(k.COLUMN_NAME1);
                        listView.Items.Add(lvi);
                    }
                    break;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            string firstName = txtBoxName.Text;
            string lastName = txtBoxLastName.Text;
            c.InsertEmployee(no, firstName, lastName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            c.DeleteEmployee(no);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            string firstName = txtBoxName.Text;
            string lastName = txtBoxLastName.Text;

            c.UpdateEmployee(no, firstName, lastName);
        }

        private void gbQueries_Enter(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            listView.Clear();
            List<Employee> keys = c.ShowAllEmployees();
            listView.Columns.Add("No_");
            listView.Columns.Add("First Name");
            listView.Columns.Add("Last Name");

            foreach (Employee k in keys)
            {
                ListViewItem lvi = new ListViewItem(k.EmployeeNo);
                lvi.SubItems.Add(k.FirstName);
                lvi.SubItems.Add(k.LastName);
                listView.Items.Add(lvi);
            }

        }


    }

}
