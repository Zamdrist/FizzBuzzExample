namespace FizzBuzzExample
{
    public class FizzBuzz
    {
	    public string FizzBuzzOutput { get; }

	    public FizzBuzz()
	    {
		    var fizzBuzz = string.Empty;
		    for (var i = 0; i <= 100; i++)
		    {
			    if (i % 15 == 0)
			    {
				    fizzBuzz += "FizzBuzz\n";
			    }
				else if (i % 5 == 0)
			    {
				    fizzBuzz += "Buzz\n";

			    }
				else if (i % 3 == 0)
			    {
				    fizzBuzz += "Fizz\n";
			    }
			    else
			    {
				    fizzBuzz += i + "\n";
			    }
		    }
		    this.FizzBuzzOutput = fizzBuzz;
	    }
    }
}
