using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ERP_Integration.ERPIntegrationWSReference;

namespace ERP_Integration
{
    class DataAccessLayer
    {

        ERPIntegrationWSSoapClient proxy = new ERPIntegrationWSSoapClient();
        
        #region Select, Update, Delete, Insert
        public void InsertEmployee(string no, string name)
        {
            proxy.InsertEmployee(no, name);
        }

        public void DeleteEmployee(string no)
        {
            proxy.DeleteEmployee(no);
        }

        public void UpdateEmployee(string no, string name, string lastName)
        {
            proxy.UpdateEmployee(no, name, lastName);
        }

        public DataSet SearchEmployee(String searchString)
        {
            return null; //proxy.SearchEmployee(searchString);
        }

        #endregion Select, Update, Delete, Insert

        #region Uppgift A
        public DataSet GetEmployeeAndMetadata()
        {
            return proxy.GetEmployeeAndMetaData();
        }

        public DataSet GetEmployeeAndRelatives()
        {
            return proxy.GetEmployeeAndRelatives();
        }

        public DataSet GetSickEmployee()
        {
            return proxy.GetSickEmployee();
        }

        public DataSet GetMostSickEmployee()
        {
            return proxy.GetMostSickEmployee();
        }

        #endregion Uppgift A

        #region Uppgift B
        public DataSet GetAllKeys()
        {
            return proxy.GetAllKeys();
        }

        public DataSet GetAllIndexes()
        {
            return proxy.GetAllIndexes();
        }

        public DataSet GetAllConstraints()
        {
            return proxy.GetAllConstraints();
        }

        public DataSet GetAllTables()
        {
            return proxy.GetAllTables();
        }

        public DataSet GetAllTables2()
        {
            return proxy.GetAllTables2();
        }

        public DataSet GetColumnsEmployee()
        {
            return proxy.GetColumnsEmployee();
        }

        public DataSet GetColumnsEmployee2()
        {
            return proxy.GetColumnsEmployee2();
        }
        #endregion Uppgift B


    }
}
