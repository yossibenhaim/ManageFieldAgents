using ManageField.DAL_;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ManageField
{
    class AgentDAL : IAgentRepository
    {
        private string _cunnStr = "server=localhost;userName=root;password=;database=menageragents";
        MySqlConnection conn = null;

        public AgentDAL()
        {
            conn = new MySqlConnection(this._cunnStr);            
        }
       
        public List<Agent> GetAllAgents()
        {
            conn.Open();
            string query = $"SELECT * FROM agent ;";
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                return AgentMapper.MapFromReader(reader);
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"err:{e.Message}");
                return new List<Agent>();
            }
            finally
            {
                conn.Close();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            conn.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"err:{e.Message}");
            }
            finally
            {
                conn.Close();
            }
        }


        public void addAgent(Agent agent)
        {
            string query = $"INSERT INTO agent (nameCode,name,location, status, missionsCompleted) VALUES ('{agent.nameCode}','{agent.name}','{agent.location}','{agent.status}','{agent.missionsCompleted}');";
            ExecuteNonQuery(query);
        }

        public void UpdateAgentLocation(int id, string newLocation)
        {
            string query = $"UPDATE agent SET location = '{newLocation}' WHERE id = {id};";
            ExecuteNonQuery(query);

        }
        public void DeleteAgent(int id)
        {
            string query = $"DELETE FROM agent WHERE id = {id};";
            ExecuteNonQuery(query);

        }


    }
}
