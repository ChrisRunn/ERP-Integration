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

        public DataSet SearchEmployee(String searchString)
        {
            return dal.SearchEmployee(searchString);
        }

        public void InsertEmployee(string no, string name)
        {
            this.dal.InsertEmployee(no, name);
        }

        public void DeleteEmployee(string no)
        {
            this.dal.DeleteEmployee(no);
        }

        public void UpdateEmployee(string no, string name, string lastName)
        {
            this.dal.UpdateEmployee(no, name, lastName);
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
