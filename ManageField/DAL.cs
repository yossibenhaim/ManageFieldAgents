using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageField
{
    internal interface DAL
    {
        void addAgent(Agent agent);

        List<Agent> GetAllAgent();

        void UpdateAgentLocation(int id, string newLocation);

        void DeleteAgent(int id);




    }
}
