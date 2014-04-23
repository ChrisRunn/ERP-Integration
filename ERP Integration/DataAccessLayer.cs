using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ERP_Integration.ServiceReference1;

namespace ERP_Integration
{
    class DataAccessLayer
    {
        Service1SoapClient proxy = new Service1SoapClient();

        #region Select, Update, Delete, Insert
        public void InsertEmployee(string no, string name, string lastName)
        {
            return proxy.InsertEmployee(no, name, lastName);
        }

        public string DeleteEmployee(string no)
        {
            return proxy.DeleteEmployee(no);
        }

        public string UpdateEmployee(string no, string name, string lastName)
        {
            return proxy.UpdateEmployee(no, name, lastName);
        }

        public DataSet GetAllEmployees()
        {
            return proxy.GetAllEmployees();
        }

        #endregion Select, Update, Delete, Insert

        #region Uppgift A
        public DataSet GetEmployeeAndMetadata()
        {
            return proxy.GetEmployeeAndMetadata();
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
