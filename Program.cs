using iAChallenge.Entities;

bool Running = true;
FactoryFloor factory = new FactoryFloor();

while (Running)
{
	try
	{
        Console.WriteLine("1. Search Mill via Loops \n2. Search Mill via Dictionary  \n3. Generate New Data \n4. Exit");
        var input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Enter a pair of X,Y coordinates:");
                var inputViaLoop = Console.ReadLine();
                factory.RetreiveFillUnsorted(inputViaLoop);
                PauseConsole();
                break;
            case 2:
                Console.WriteLine("Enter a pair of X,Y coordinates:");
                var inputViaDictionary = Console.ReadLine();
                factory.RevtreiveFillStored(inputViaDictionary);
                PauseConsole();
                break;
            case 3:
                factory.GenerateWorld();
                PauseConsole(); 
                break;
            case 4:
                Running = false;
                break;
            default:
                Console.WriteLine("Invalid Choice, Please Select From the List below");
                break;
        }
    }
	catch (Exception)
	{
        Console.WriteLine("Invalid Input, Please try again");
	}
}


void PauseConsole()
{
	Console.WriteLine("Press enter to continue...");
	Console.ReadLine();
	Console.Clear();
}