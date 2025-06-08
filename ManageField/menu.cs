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
        public Program program = new Program();
        public AgentDAL agentDAL = new AgentDAL();
        public void startMenu()
        {
            bool run = true;
            string choiceStr = Console.ReadLine();

            while (run)
            {
                Console.WriteLine("menu");
                while (true)
                {
                    if (char.IsDigit(choiceStr[0]))
                    {
                        break;
                    }
                    else
                    {
                        choiceStr = Console.ReadLine();
                    }

                }int choice = Convert.ToInt32(choiceStr);
                switch (choice)
                {
                    case 1:
                        agentDAL.addAgent(program.createAgent());
                        break;
                    case 2:
                        agentDAL.UpdateAgentLocation(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
                        break;
                    case 3:
                        agentDAL.DeleteAgent(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
               
            }

        }   
    }
}
