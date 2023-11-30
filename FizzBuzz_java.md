
public class Test 
  {
	  public static void main(String[] args)	
	  {
	    String buzz =  "buzz", fizz = "fizz"; //initialise the string variables
	    for (int i = 1; i <= 100; i++)
	    {
	      if (i % 15 == 0) //check if number in position i is divisable by 15, if so don't check other 2 conditions - we don't want a double print
	    {
	     System.out.println(buzz + fizz + " " + i));
	    }
	  else if (i % 3  == 0 )
	   {
	    System.out.println(buzz + " " + i);
	    }
	  else if (i % 5== 0)
	    {
	    System.out.println(fizz + " "+ i);
	    }
	   }
	  }
  }



       'Another simple Java Solution' *

		 boolean flag = true;


		for(int i=0;i<16;i++){
			if(i%3==0){
				System.out.print("Fizz");
				flag=false;
			}


			if(i%5==0){
				System.out.print("Buzz");
				flag=false;
			}


			if (flag)
				System.out.print(i);


			System.out.print(",");


			flag = true;


		}

