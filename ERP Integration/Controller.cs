using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ERP_Integration
{
    class Controller
    {
        DataAccessLayer dal;

        public Controller()
        {
            dal = new DataAccessLayer();
        }

        #region Select, Update, Delete, Insert

        public DataSet GetAllEmployees()
        {
            return dal.GetAllEmployees();
        }

        public void InsertEmployee(string no, string name, string lastName)
        {
            this.dal.InsertEmployee(no, name, lastName);
        }

        public string DeleteEmployee(string no)
        {
            return this.dal.DeleteEmployee(no);
        }

        public string UpdateEmployee(string no, string name, string lastName)
        {
            return this.dal.UpdateEmployee(no, name, lastName);
        }

        #endregion Select, Update, Delete, Insert

        #region Uppgift A
        public DataSet GetEmployeeAndMetadata()
        {
            return dal.GetEmployeeAndMetadata();
        }

        public DataSet GetEmployeeAndRelatives()
        {
            return dal.GetEmployeeAndRelatives();
        }

        public DataSet GetSickEmployee()
        {
            return dal.GetSickEmployee();
        }

        public DataSet GetMostSickEmployee()
        {
            return dal.GetMostSickEmployee();
        }

        #endregion Uppgift A

        #region Uppgift B
        public DataSet GetAllKeys()
        {
            return dal.GetAllKeys();
        }

        public DataSet GetAllIndexes()
        {
            return dal.GetAllIndexes();
        }

        public DataSet GetAllConstraints()
        {
            return dal.GetAllConstraints();
        }

        public DataSet GetAllTables()
        {
            return dal.GetAllTables();
        }

        public DataSet GetAllTables2()
        {
            return dal.GetAllTables2();
        }

        public DataSet GetColumnsEmployee()
        {
            return dal.GetColumnsEmployee();
        }

        public DataSet GetColumnsEmployee2()
        {
            return dal.GetColumnsEmployee2();
        }
        #endregion Uppgift B
    }
}
