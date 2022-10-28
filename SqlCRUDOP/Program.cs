using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCRUDOP
{
    internal class Program
    {
       
                static void Main(string[] args)
        {
            CRUD Create = new CRUD();
           Create.Createuser();
            //CRUD read_Data = new CRUD();
            //read_Data.Readdata();
            //CRUD Update = new CRUD();
            //Update.updatedata();
            //CRUD delete = new CRUD();
            //delete.DeleteData();

        }
    }
}
