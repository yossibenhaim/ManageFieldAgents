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
            menu menu = new menu();
            menu.startMenu();
        }
    }
}
