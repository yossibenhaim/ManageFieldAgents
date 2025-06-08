using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageField
{
    internal class Program
    {
        public Agent createAgent()
        {
            int id = 5;
            string nameCode = "svjknl";
            string name = "zb";
            string locasion = "SB";
            string status = "Zdbz";
            int missionsCompleted = 4;

            Agent newAgent = new Agent(id, nameCode, name, locasion, status, missionsCompleted);
            return newAgent;

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            AgentDAL agentDAL = new AgentDAL();
            Agent agent = program.createAgent();
            agentDAL.addAgent(agent);
            agentDAL.addAgent(agent);
            agentDAL.addAgent(agent);

            List<Agent> agents = agentDAL.GetAllAgents();
            if (agents.Count > 0)
            {

                foreach (Agent a in agents)
                {
                    Console.WriteLine($"id = {a.id} nameCode = {a.nameCode}, name = {a.name}");
                }
            }
        }
    }
}
