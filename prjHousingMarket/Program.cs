namespace prjHousingMarket
{
    internal class Program
    {
        private static List<Agent> AgentList = new List<Agent>();
        static void Main(string[] args)
        {
            AgentList.Add(new Agent(1, "Bob", "Smith",
                false, "Black"));
            AgentList.Add(new Agent(2, "Sand", "Bra",
                            true, "Not from here"));
            AgentList.Add(new Agent(3, "Jane", "Bra",
                            false, "Maybe from here"));
            bool bStop = false;

            while (bStop != true) 
            {
                Menu();
                Console.WriteLine("Are you finished ? Press S to stop");
                String strInput = Console.ReadLine();
                if(strInput.Equals("S"))
                {
                    bStop = true;
                }
            }
        }
        private static void Menu()
        {
            Console.WriteLine("Welcome to Marli Agents");
            Console.WriteLine("******************");
            Console.WriteLine("Please select what you want todo");
            Console.WriteLine("Enter 1 to view all agents (1) ");
            Console.WriteLine("Enter 2 to add new ages (2) ");

            String userInput = Console.ReadLine();

            if (userInput == "")
            {
                Console.WriteLine("Can you not type ?");
            }
            else if (userInput.Equals("1"))
            {
                PrintAgents();
            }
            else if (userInput.Equals("2"))
            {
                AddAgent();
            }
        }

        private static void PrintAgents()
        {
            foreach (Agent agent in AgentList)
            {
                Console.WriteLine(agent.ToString());
            }
        }
        private static void AddAgent()
        {
            Console.Write("Please enter agent no: ");
            String No = Console.ReadLine();
            Console.Write("Please enter agent name: ");
            String agentName = Console.ReadLine();
            Console.Write("Please enter agent surname: ");
            String agentsurname = Console.ReadLine();
            Console.Write("Do they have their drivers? Yes or no ");
            String Drivers = Console.ReadLine();
            Console.Write("Please enter your race: ");
            String Race = Console.ReadLine();
            bool bDrivers = false;
            if (Drivers.ToUpper().Equals("YES"))
            {
                bDrivers = true;
            }
            AgentList.Add(new Agent(Convert.ToInt32(No), agentName,
                agentsurname, bDrivers, Race));
        }
    }
}
