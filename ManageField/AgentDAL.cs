using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageField
{
    internal class AgentDAL
    {
        private string _cunnStr = "server=localhost;userName=root;password=;database=menageragents"
        MySqlConnection conn = null;

        public AgentDAL()
        {
            conn = new MySqlConnection(this._cunnStr);
        }

        public object sendToDatabase(string query)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

            }
        }
    }


}
