using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amusement_Park_App.classes;
using MySql.Data.MySqlClient;

namespace Amusement_Park_App.classes
{


    class Customers : frmLogin
    {
        User usr = new User();
        
        public string UNam { get; set; }
        public string UPass { get; set; }
        public string ID { get; set; }
        public string EAdd { get; set; }
        public string PNum { get; set; }




            
    }
}
