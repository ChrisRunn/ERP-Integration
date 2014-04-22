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
        
        
        public DataSet GetAllEmployees(){
            return proxy.GetAllEmployees();
        }



    }
}
