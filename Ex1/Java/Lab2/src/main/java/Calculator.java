 public class Calculator
 {
	public static double Add(double a, double b)
	{
		return a + b;
	}

	public static double Subtract(double a, double b)
	{
		return a - b;
	}

	public static double Multiply(double a, double b)
	{
		return a * b;
	}

	public static double Devide(double a, double b)
	{
		if( b == 0)
		{
			System.out.println("[Multiply] b=0.");
			return 0;
		}

		return a / b;
	}
	
	public void main(){
		System.out.println("Hello");
	}
}