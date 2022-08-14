// See https://aka.ms/new-console-template for more information

bool running = true;
while (running)
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
			running = false;
			break;
		default:
			Console.WriteLine("Invalid Choice, Please Select From the List Above");
			break;
	}
}


 void InMemorySearch()
{

}

void SqlSearch()
{

}


void GenerateNewData()
{

}