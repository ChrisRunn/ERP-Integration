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

        public List<Employee> ShowAllEmployees()
        {
            return this.dal.ShowAllEmployees();
        }

        public void InsertEmployee(string no, string firstName, string lastName)
        {
            this.dal.InsertEmployee(no, firstName, lastName);
        }

        public void DeleteEmployee(string no)
        {
            this.dal.DeleteEmployee(no);
        }

        public void UpdateEmployee(string no, string firstName, string lastName)
        {
            this.dal.UpdateEmployee(no, firstName, lastName);
        }

        #endregion Select, Update, Delete, Insert

        #region Uppgift A
        public List<SysObject> GetEmployeeAndMetadata()
        {
            return dal.GetEmployeeAndMetadata();
        }

        public List<EmpRelativeQuery> GetEmployeeAndRelatives()
        {
            return dal.GetEmployeeAndRelatives();
        }

        public List<EmpSick> GetSickEmployee()
        {
            return dal.GetSickEmployee();
        }

        public List<EmpSick> GetMostSickEmployee()
        {
            return dal.GetMostSickEmployee();
        }

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
