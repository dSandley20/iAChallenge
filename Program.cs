// See https://aka.ms/new-console-template for more information

bool Running = true;
while (Running)
{
	Console.WriteLine("1. Find Closet Mill In Memory \n 2. Find Closest Mill With SQL \n  3. Generate New Data \n 4. Exit");
    var input = Convert.ToInt32(Console.ReadLine());
	switch (input)
	{
		case 1:
			InMemorySearch();
			break;
		case 2:
			SqlSearch();	
			break;
		case 3:
			GenerateNewData();
			break;
		case 4:
			Running = false;
			break;
		default:
			Console.WriteLine("Invalid Choice, Please Select From the List Above");
			break;
	}
}


 void InMemorySearch()
{
	bool RunningInMem = true;
	while (RunningInMem)
	{
        Console.WriteLine("1. Find Mill \n 2. Go Back");
        var input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
				break;
			case 2:
				RunningInMem = false;
				break;
			default:
				Console.WriteLine("Please Select A Valid Option");
                break;
        }
    }
}

void SqlSearch()
{
	bool RunningSqlSearch = true;
	while (RunningSqlSearch)
	{
		Console.WriteLine("1. Find Mill \n 2. Go Back");
		var input = Convert.ToInt32(Console.ReadLine());
		switch (input)
		{
			case 1:
				break;
			case 2:
				RunningSqlSearch = false;
				break;			
			default:
                Console.WriteLine("Please Select A Valid Option");
                break;
		}
	}
}


void GenerateNewData()
{

}