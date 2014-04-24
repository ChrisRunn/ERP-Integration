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

        public DataSet SearchEmployee(string searchString)
        {
            List<Employee> myList = new List<Employee>(proxy.SearchEmployee(searchString)());
            return myList;
        }

        #endregion Select, Update, Delete, Insert

        #region Uppgift A
        //public List<Employee> GetEmployeeAndMetadata()
        //{
        //    List<Employee> myList = new List<Employee>(proxy.GetEmployeeAndMetaData());
        //    return myList;
        //}

        //public List<EmployeeRelative> GetEmployeeAndRelatives()
        //{
        //    List<EmployeeRelative> myList = new List<EmployeeRelative>(proxy.GetEmployeeAndRelatives());
        //    return myList;
        //}

        //public List<EmployeeAbsence> GetSickEmployee()
        //{
        //    List<EmployeeAbsence> myList = new List<EmployeeAbsence>(proxy.GetSickEmployee());
        //    return myList;
        //}

        //public List<EmployeeAbsence> GetMostSickEmployee()
        //{
        //    List<EmployeeAbsence> myList = new List<EmployeeAbsence>(proxy.GetMostSickEmployee());
        //    return myList;
        //}

        #endregion Uppgift A

        #region Uppgift B
        public List<SysObject> GetAllKeys()
        {
            List<SysObject> myList = new List<SysObject>(proxy.GetAllKeys());
            return myList;
        }

        public List<SysIndex> GetAllIndexes()
        {
             List<SysIndex> myList = new List<SysIndex>(proxy.GetAllIndexes());
            return myList;
        }

        public List<SysConstraint> GetAllConstraints()
        {
            List<SysConstraint> myList = new List<SysConstraint>(proxy.GetAllConstraints());
            return myList;
        }

        public List<SysObject> GetAllTables()
        {
            List<SysObject> myList = new List<SysObject>(proxy.GetAllTables());
            return myList;
        }

        public List<SysTable> GetAllTables2()
        {
            List<SysTable> myList = new List<SysTable>(proxy.GetAllTables2());
            return myList;
        }

        public List<SysColumn> GetColumnsEmployee()
        {
            List<SysColumn> myList = new List<SysColumn>(proxy.GetColumnsEmployee());
            return myList;
        }

        public List<Information_Schema_Column> GetColumnsEmployee2()
        {
            List<Information_Schema_Column> myList = new List<Information_Schema_Column>(proxy.GetColumnsEmployee2());
            return myList;
        }
        #endregion Uppgift B


    }
}
