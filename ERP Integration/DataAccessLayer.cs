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

        //#region Uppgift A
        //public List<Employee> GetEmployeeAndMetadata()
        //{
        //    return proxy.GetEmployeeAndMetaData();
        //}

        //public List<EmployeeRelatives> GetEmployeeAndRelatives()
        //{
        //    return proxy.GetEmployeeAndRelatives();
        //}

        //public List<EmployeeAbsence> GetSickEmployee()
        //{
        //    return proxy.GetSickEmployee();
        //}

        //public List<EmployeeAbsence> GetMostSickEmployee()
        //{
        //    return proxy.GetMostSickEmployee();
        //}

        //#endregion Uppgift A

        #region Uppgift B
        public List<SysObject> GetAllKeys()
        {
            return proxy.GetAllKeys();

        }

        //public List<SysIndex> GetAllIndexes()
        //{
        //    return proxy.GetAllIndexes();
        //}

        //public List<SysConstraint> GetAllConstraints()
        //{
        //    return proxy.GetAllConstraints();
        //}

        //public List<SysObject> GetAllTables()
        //{
        //    return proxy.GetAllTables();
        //}

        //public List<SysTable> GetAllTables2()
        //{
        //    return proxy.GetAllTables2();
        //}

        //public List<SysColumn> GetColumnsEmployee()
        //{
        //    return proxy.GetColumnsEmployee();
        //}

        //public List<Information_Schema_Column> GetColumnsEmployee2()
        //{
        //    return proxy.GetColumnsEmployee2();
        //}
        #endregion Uppgift B


    }
}
