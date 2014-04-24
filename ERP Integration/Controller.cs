using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ERP_Integration.ERPIntegrationWSReference;

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

        public List<Employee> SearchEmployee(string searchString)
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

        //#region Uppgift A
        //public List<Employee> GetEmployeeAndMetadata()
        //{
        //    return dal.GetEmployeeAndMetadata();
        //}

        //public List<EmployeeRelative> GetEmployeeAndRelatives()
        //{
        //    return dal.GetEmployeeAndRelatives();
        //}

        //public List<EmployeeAbsence> GetSickEmployee()
        //{
        //    return dal.GetSickEmployee();
        //}

        //public List<EmployeeAbsence> GetMostSickEmployee()
        //{
        //    return dal.GetMostSickEmployee();
        //}

        #endregion Uppgift A

        #region Uppgift B
        public List<SysObject> GetAllKeys()
        {
            return dal.GetAllKeys();
        }

        public List<SysIndex> GetAllIndexes()
        {
            return dal.GetAllIndexes();
        }

        public List<SysConstraint> GetAllConstraints()
        {
            return dal.GetAllConstraints();
        }

        public List<SysObject> GetAllTables()
        {
            return dal.GetAllTables();
        }

        public List<SysTable> GetAllTables2()
        {
            return dal.GetAllTables2();
        }

        public List<SysColumn> GetColumnsEmployee()
        {
            return dal.GetColumnsEmployee();
        }

        public List<Information_Schema_Column> GetColumnsEmployee2()
        {
            return dal.GetColumnsEmployee2();
        }
        #endregion Uppgift B
    }
}
