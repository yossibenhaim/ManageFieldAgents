using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageField
{
    public class Agent
    {
        public int id;
        public string nameCode;
        public string name;
        public string location;
        public string status;
        public int missionsCompleted = 0;

        public Agent(int id, string nameCode, string name, string location, string status, int missionsCompleted)
        {
            this.id = id;
            this.nameCode = nameCode;
            this.name = name;
            this.location = location;
            this.status = status;
            this.missionsCompleted = missionsCompleted;
        }
    }
}
