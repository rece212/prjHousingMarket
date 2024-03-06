namespace prjHousingMarket
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            AgentDB DB = new AgentDB();
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
            AgentDB DB = new AgentDB();
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
                Console.WriteLine(DB.PrintAll());
            }
            else if (userInput.Equals("2"))
            {
                AddAgent();
            }
        }
        private static void AddAgent()
        {
            AgentDB DB = new AgentDB();
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
            DB.AddAgent(new Agent(Convert.ToInt32(No), agentName,
                agentsurname, bDrivers, Race));
        }
    }
}
