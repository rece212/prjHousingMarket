using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjHousingMarket
{
    public class AgentDB
    {
        private static List<Agent> AgentList = new List<Agent>();

        public AgentDB()
        {
            if (AgentList.Count < 0)
            {
                AgentList.Add(new Agent(1, "Bob", "Smith",
                false, "Black"));
                AgentList.Add(new Agent(2, "Sand", "Bra",
                                true, "Not from here"));
                AgentList.Add(new Agent(3, "Jane", "Bra",
                                false, "Maybe from here"));
            }
        }

        public void AddAgent(Agent newAgent)
        {
            AgentList.Add(newAgent);
        }
        public String PrintAll()
        {
            String strOutput = "";
            foreach (Agent agent in AgentList)
            {
                strOutput+=agent.ToString();
                strOutput += "++++++++++++++++++++";
            }
            return strOutput;
        }

    }
}
