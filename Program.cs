using System;
public class Exercise6
{
  public static void Main()
  {
    int num1, num2, num3, num4, num5; //initializes the vars that'll be used
     
    Console.Write("Input the first number to multiply: "); //takes user input for num1
    num1 = Convert.ToInt32(Console.ReadLine()); //and assigns it to the num1 var
     
    Console.Write("Input the second number to multiply: ");
    num2 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Input the third number to multiply: ");
    num3 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input the fourth number to multiply: ");
    num4 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input the fifth number to multiply: ");
    num5 = Convert.ToInt32(Console.ReadLine());
     
    int result = num1 * num2 * num3 * num4 * num5; //multiplies the vars
    Console.WriteLine("Output: {0} x {1} x {2} x {3} x {4} = {5}", //formats the string output
                        num1, num2, num3, num4, num5, result); //gives the values for fill-ins in the string
  }
}