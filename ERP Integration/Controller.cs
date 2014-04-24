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

        public List<> SearchEmployee(String searchString)
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
        public List<> GetEmployeeAndMetadata()
        {
            return dal.GetEmployeeAndMetadata();
        }

        public List<> GetEmployeeAndRelatives()
        {
            return dal.GetEmployeeAndRelatives();
        }

        public List<> GetSickEmployee()
        {
            return dal.GetSickEmployee();
        }

        public List<> GetMostSickEmployee()
        {
            return dal.GetMostSickEmployee();
        }

        #endregion Uppgift A

        #region Uppgift B
        public List<> GetAllKeys()
        {
            return dal.GetAllKeys();
        }

        public List<> GetAllIndexes()
        {
            return dal.GetAllIndexes();
        }

        public List<> GetAllConstraints()
        {
            return dal.GetAllConstraints();
        }

        public List<> GetAllTables()
        {
            return dal.GetAllTables();
        }

        public List<> GetAllTables2()
        {
            return dal.GetAllTables2();
        }

        public List<> GetColumnsEmployee()
        {
            return dal.GetColumnsEmployee();
        }

        public List<> GetColumnsEmployee2()
        {
            return dal.GetColumnsEmployee2();
        }
        #endregion Uppgift B
    }
}
