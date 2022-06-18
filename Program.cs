using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Console.WriteLine("Enter firstName");
         string firstName = Console.ReadLine();
         //Console.WriteLine("firstName is:" + firstName);
         Console.WriteLine("Enter lastName");
         string lastName = Console.ReadLine();
         //Console.WriteLine("lastName is:" + lastName);
         Console.WriteLine("Enter Age");
         int age = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter Favorite Color");
         string FavoriteColor = Console.ReadLine();
         //Console.WriteLine("Favorite color is:" + FavoriteColor);
         Console.WriteLine("Enter Favorite Food");
         string FavoriteFood = Console.ReadLine();
         //Console.WriteLine("Fvorite Food is:" + FavoriteFood);
         Console.WriteLine("Enter State Of Origin");
         string StateOfOrigin = Console.ReadLine();
         //Console.WriteLine("State Of Origin is" + StateOfOrigin);

         //Console.Write("My name is " + firstName  +  lastName + " from " + StateOfOrigin); //string concatenation
         Console.Write(". I am " + age + " years old ");
         Console.Write(". My favorite food is " + FavoriteFood + " and my favorite color is " + FavoriteColor);
         
         Console.WriteLine($"My name is {firstName} - {lastName.ToUpper()} from {StateOfOrigin}. I am {age} years old.My favorite food is {FavoriteFood} and my favorite color is {FavoriteColor}.");*/
         
         /*char g = '0';
         int f = g;
         Console.Write(f);*/
         //MatExpression
         /*int r = (150 - 2) / 2 + 5;
         double perimeter = 2 * Math.PI * r;
         Console.WriteLine(perimeter);*/
         
         /*var check = ( 2 < 3) && (7 > 10);
         var check2 = (!( 2 < 3) || (7 > 10));
         Console.WriteLine(check);
         Console.WriteLine(check2);*/

         //CLASS WORK
         /*int num = 10; 
           if num is divided by 2 without remainder;
         if (num % 2 == 0 );
         Console.Write(num);

         /*var check = ((r / 2 == 0 rem 0) {Even} 
         "else" {Odd});
         Console.Write(check);*/
         
         //Question 4
         /*Console.WriteLine("Enter the weight");
         double weight = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine($"The weight of the man on the moon with {weight} on the earth is: {weight * (17/100)}");

         //Question 5
         /*Console.Write("Enter a four digit number");
         var num = Console.ReadLine();
         int first = Convert.ToInt32(num [0]);
         int second = Convert.ToInt32(num [1]);
         int third = Convert.ToInt32(num [2]);
         int forth = Convert.ToInt32(num [3]);
         Console.WriteLine($"The sum of the of all the four number is: {first + second + third + forth}");
         Console.WriteLine($"The reverse of all the digit is: {forth}{third}{second}{first}");
         Console.WriteLine($"The last digit in the first position is: {forth}{first}{second}{third}");
         Console.WritLine($"The exchange of the second and the third digits is: {first}{third}{second}{forth}");*/     

       //CLASSWORK REDO
       /*Console.WriteLine("=======\n write an expression that checks whether an integer is odd or even");
       Console.Write(" Enter the number");
       int number = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine($" the number: {number} is odd? {number % 2 != 0}");
       Console.WriteLine($" the number: {number} is even? {number % 2 == 0}");
       Console.WriteLine();*/

       Console.WriteLine("QUESTION 2");
       Console.WriteLine("Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder");
       Console.Write("Enter the Number ");
       int numberb = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine($"the number: {numberb} is divisible by 5 and 7 is? {numberb % 5 == 0 && numberb % 7 ==0}");
       Console.WriteLine();


       




         
         



        }
    }
}
   