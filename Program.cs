// See https://aka.ms/new-console-template for more information

bool running = true;
while (running)
{
	Console.WriteLine("1. Find Closet Mill In Memory \n 2. Find Closest Mill With SQL \n 3. Exit");
    var input = Convert.ToInt32(Console.ReadLine());
	switch (input)
	{
		case 1:
			break;
		case 2:
			break;
		case 3:
			running = false;
			break;
		default:
			Console.WriteLine("Invalid Choice, Please Select From the List Above");
			break;
	}
}