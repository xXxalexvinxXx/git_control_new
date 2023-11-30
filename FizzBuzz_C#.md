for (int i = 1; i <= 100; i++)
 {
 	if (i % 3 == 0 && i % 5 == 0)
 	{
 		Console.WriteLine("FizzBuzz");
 		continue;
 	}
 	if (i % 3 == 0)
 	{
 		Console.WriteLine("Fizz");
 		continue;
 	}
 	if (i % 5 == 0)
 	{
 		Console.WriteLine("Buzz");
 		continue;
 	}
 	Console.WriteLine(i);
 }
 
 for(int x = 1; x <= 100; x++) 
 {

	string output = "";
	if(x%3 == 0) output += "Fizz";
	if(x%5 == 0) output += "Buzz";
	if(output == "") output = x.ToString();
	Console.WriteLine(output);

  } 

