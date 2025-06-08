using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace ManageField
{
    internal class menuHelper
    {
        public Agent createAgent()
        {
            Console.WriteLine("Enter ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name Code:");
            string nameCode = Console.ReadLine();

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Location:");
            string locasion = Console.ReadLine();

            Console.WriteLine("Enter Status:");
            string status = Console.ReadLine();

            Console.WriteLine("Enter Number of Missions Completed:");
            int missionsCompleted = Convert.ToInt32(Console.ReadLine());


            Agent newAgent = new Agent(id, nameCode, name, locasion, status, missionsCompleted);
            return newAgent;
        }

       

        public void printAgent(List<Agent> agents)
        {
            foreach (Agent agent in agents)
            {
                Console.WriteLine($"ID: {agent.id}, Name Code: {agent.nameCode}, Name: {agent.name}, Location: {agent.location}, Status: {agent.status}, Missions Completed: {agent.missionsCompleted}");
            }
        }

        public void printMenu()
        {
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1 - Add Agent");
            Console.WriteLine("2 - Update Agent Location");
            Console.WriteLine("3 - Delete Agent");
            Console.WriteLine("4 - Show All Agents");
            Console.WriteLine("5 - Exit");
            Console.Write("Enter your choice: ");
        }


    }
}
