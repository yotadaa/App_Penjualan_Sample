using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI_Form.Kelas
{
    class CRUD : User
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public CRUD() 
        {
            conn = new MySqlConnection(User.conString);
            cmd = new MySqlCommand();
        }

        public void insert()
        {
        }

    }
}
