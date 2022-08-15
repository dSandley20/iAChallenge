# How to run the program
To run the program you must first have .NET 6.0 installed from there you can either open the project in Visual Studio and run the project. Or, you can cd into the directory and run `dotnet run`

Once you the program is running you will be prompted by a menu of 4 options
1. Search Mil via Loops (this is the original solution I came up with and is the least efficent)
2. Search Mill via Dictionary (this is the updated solution I came up and would reccomend using)
3. Generate New Data (This generates new medication prices for each Central Fill Facility in the world)
4. Exit
# Assumptions Made
1. Any data structure can be used to form the grid
2. Each cell can hold only one Central Fill facility
3. Each Central Fill facility will have Medications A, B and C with different prices randomly generated
4. Prices can range from $1.XX - $1000.XX
5. The distance between the selected Central Fill and all other fills should be calculated using the Manhattan Distance
# Thought Process For Solutions

## Original Solution
My original solution (choice #1 in the program selection screen) was to loop over 2 for loops and comparing all the results to the selected central fill then updating variables I had in place with the locations of Fills that had a lower medication price. This was similiar to how I solved the original problem during the interview. However due to the conversation we had I now know that this is the least efficent way to solve this problem. I still kept this solution in the program due to wanting to compare speeds and ease of implementing compared to my other solution that I developed (Although I recognize that this is bad practice and never should stay in a production enviroment I wanted to showcase that I have learned from previous mistakes).

## Updated Solution
The updated solution (choice #2 in the program selection screen) was to leverage the world creation and compare prices of medications to the previously generated mill or the original mill. This allowed me to skip searching for the cheapest prices of each medication and directly return the results. I believe this was one of the solutions that you told me about for the coding question during the interview.

# Supporting Multiple Central Fills at the Same Location

To support multiple Central Fills at the same location I would need to change the data structure of the Floor class. 
I would still use a dictionary to form the grid however I would create another data structure to be the value within the dictionary. This data structure would contain a List of Fills rather than a dictionary since we only care about the Central Fills within the tile rather than their position within said tile. Within that class would exist a function that would return a list of results (tile: 'X,Y', cheapestFills: [1,2,3]) of 3 Central Fills that would have the lowest prices for medications A, B, and C. I would then assign those results to the placeholder variables to keep track of the position in the grid as well as the price and medication name. I still believe keeping track of the results as the world is being generated is the best way to handle getting quick and direct results.

# Supporting A Much Larger World Size

Supporting a larger world size I think, a large rewrite of the program would be required. I would start using SQL queries to store and retrieve the results. Using tables for Central Fills, Medications, and Prices we would be able to select the lowest prices of each unique medication and find out which Central Fill they are located at. Assuming that the Central Fill table has a field for the location or the X and Y values respectively we would be able to calculate the results directly within the SQL query or we could loop over the results and then calculate the distance to the user selected Central Fill.


# Thank You Note
I just wanted to say thank you for the time and consideration you put into the interview as well as the coding challenge. I had a lot of fun with both and got to learn and experience new things outside of what I normally work on. I'm going to keep on learning more about algorithims, Big O Notation, and brushing up on my soft skills. Innovation Associates looks like a great company to work for where developers are constantly challenged and learning. Learning what assumptions to make during this challenge turned out to be a key part of development and made it much easier once those assumptions were in place. I look forward to learning more and any critques you might have about my solutions so I can improve more. Thank you for you time, Daniel Sandley.
