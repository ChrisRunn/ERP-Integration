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

        public DataSet GetAllEmployees()
        {
            return dal.GetAllEmployees();
        }


       /* public void InsertEmployee(string no, string name, string lastName)
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
        }*/
    }
}
