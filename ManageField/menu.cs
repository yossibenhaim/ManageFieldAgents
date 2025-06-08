using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageField
{
    internal class menu
    {
        public menuHelper menuHelper = new menuHelper();
        public AgentDAL agentDAL = new AgentDAL();
        public void startMenu()
        {
            bool run = true;

            menuHelper.printMenu();
            string choiceStr;

            while (run)
            {
                choiceStr = Console.ReadLine();
                menuHelper.printMenu();

                Console.WriteLine("menu");
                while (true)
                {

                    if (char.IsDigit(choiceStr[0]))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Please enter a number: ");
                        choiceStr = Console.ReadLine();
                    }
                }

                int choice = Convert.ToInt32(choiceStr);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You chose: Add Agent");
                        agentDAL.addAgent(menuHelper.createAgent());
                        break;
                    case 2:
                        Console.WriteLine("You chose: Update Agent Location");
                        Console.Write("Enter Agent ID: ");
                        agentDAL.UpdateAgentLocation(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You chose: Delete Agent");
                        Console.Write("Enter Agent ID: ");
                        agentDAL.DeleteAgent(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("You chose: Show All Agents");
                        menuHelper.printAgent(agentDAL.GetAllAgents());
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

    }
}   
    