using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageField.DAL_
{
    internal interface IAgentRepository
    {

        List<Agent> GetAllAgents();

        void addAgent(Agent agent);

        void UpdateAgentLocation(int id, string newLocation);

        void DeleteAgent(int id);




    }
}
