using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageField
{
    public static class AgentMapper
    {
        public static List<Agent> MapFromReader(MySqlDataReader reader)
        {
            List<Agent> agents = new List<Agent>();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string nameCode = reader.GetString("nameCode");
                string name = reader.GetString("name");
                string location = reader.GetString("location");
                string status = reader.GetString("status");
                int missionsCompleted = reader.GetInt32("missionsCompleted");

                Agent newAgent = new Agent(id, nameCode, name, location, status, missionsCompleted);
                agents.Add(newAgent);
            }
            return agents;
        }


    }
}
