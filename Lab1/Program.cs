// See https://aka.ms/new-console-template for more information
//1. (A) Write a program to print your name, address, contact number & city.

//String name = "John Doe";
//String address = "123 Main St, Springfield";
//String contactNumber = "123-456-7890";
//String city = "Springfield";
//Console.WriteLine("Name: " + name);
//Console.WriteLine("Address: " + address);
//Console.WriteLine("Contact Number: " + contactNumber);
//Console.WriteLine("City: " + city);

//2. (A) Write a program to get two numbers from user and print those two numbers.

//Console.Write("Enter first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("First number: " + num1 +"\nSecond Number: "+num2); 

//3. (A) Write program to prompt a user to input his/her name and country name and then output will be shown as given: Hello from
//country

//Console.Write("Enter your name: ");
//string name = Console.ReadLine();

//Console.Write("Enter your country name: ");
//string country = Console.ReadLine();

//Console.WriteLine($"Hello {name} from {country}");

//4. (A) Write a program to calculate the size of the area in square-feet based on Speci􀆒ed length and width.

//Console.Write("Enter Length(Ft.): ");
//int l = int.Parse(Console.ReadLine());

//Console.Write("Enter Width(Ft.): ");
//int w = int.Parse(Console.ReadLine());

//int area = l * w;

//Console.WriteLine("Area In Sq.Feet is "+area);

//5. (A) Write a program to calculate area of Square, Rectangle and Circle.

//Console.WriteLine("Enter 1 - Area of Square\nEnter 2 - Area of Rectangular\nEnter 3 - Area of Circle\nEnter 4 - Exit");
//int n = int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        Console.Write("Enter the length of a side: ");
//        double side = double.Parse(Console.ReadLine());
//        double squareArea = side * side;
//        Console.WriteLine("Area of Square: " + squareArea);
//        break;
//    case 2:
//        Console.Write("Enter the length: ");
//        double length = double.Parse(Console.ReadLine());
//        Console.Write("Enter the width: ");
//        double width = double.Parse(Console.ReadLine());
//        double rectangleArea = length * width;
//        Console.WriteLine("Area of Rectangle: " + rectangleArea);
//        break;
//    case 3:
//        Console.Write("Enter the radius: ");
//        double radius = double.Parse(Console.ReadLine());
//        double circleArea = Math.PI * radius * radius;
//        Console.WriteLine("Area of Circle: " + circleArea);
//        break;
//    case 4:
//        Console.WriteLine("Exiting...");
//        break;
//    default:
//        Console.WriteLine("Invalid option.");
//        break;
//}

//6. (B) Write a program to calculate Celsius to Fahrenheit and vice-versa using function.

//static void Main(string[] args)
//{
//    Console.WriteLine("Enter 1 - Celsius to Fahrenheit\nEnter 2 - Fahrenheit to Celsius\nEnter 3 - Exit");
//    int choice = int.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            Console.Write("Enter temperature in Celsius: ");
//            double celsius = double.Parse(Console.ReadLine());
//            double fahrenheit = (celsius * 9 / 5) + 32;
//            Console.WriteLine($"{celsius}°C is {fahrenheit}°F");
//            break;
//        case 2:
//            Console.Write("Enter temperature in Fahrenheit: ");
//            double fahrenheitInput = double.Parse(Console.ReadLine());
//            double celsiusResult = (fahrenheitInput - 32) * 5 / 9;
//            Console.WriteLine($"{fahrenheitInput}°F is {celsiusResult}°C");
//            break;
//        case 3:
//            Console.WriteLine("Exiting...");
//            break;
//        default:
//            Console.WriteLine("Invalid option.");
//            break;
//    }
//}

//7. (B) Write a program to 􀆒nd out Simple Interest using function. (I = PRN / 100)

//static double CalculateSimpleInterest(double principal, double rate, double time)
//{
//    return (principal * rate * time) / 100;
//}

//Console.Write("Enter Principal Amount (P): ");
//double principal = double.Parse(Console.ReadLine());
//Console.Write("Enter Rate of Interest (R): ");
//double rate = double.Parse(Console.ReadLine());
//Console.Write("Enter Time in Years (N): ");
//double time = double.Parse(Console.ReadLine());
//double simpleInterest = CalculateSimpleInterest(principal, rate, time);
//Console.WriteLine($"Simple Interest is: {simpleInterest}");

//8. (B) Write a program to create a Simple Calculator for two numbers (Addition, Multiplication, Subtraction, Division) [Also using
//if…else &Switch Case]

//class SimpleCalculator
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter first number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Enter second number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Choose an operation:");
//        Console.WriteLine("1. Addition");
//        Console.WriteLine("2. Subtraction");
//        Console.WriteLine("3. Multiplication");
//        Console.WriteLine("4. Division");
//        int choice = Convert.ToInt32(Console.ReadLine());

//        switch (choice)
//        {
//            case 1:
//                Console.WriteLine($"Result: {num1 + num2}");
//                break;
//            case 2:
//                Console.WriteLine($"Result: {num1 - num2}");
//                break;
//            case 3:
//                Console.WriteLine($"Result: {num1 * num2}");
//                break;
//            case 4:
//                if (num2 != 0)
//                    Console.WriteLine($"Result: {num1 / num2}");
//                else
//                    Console.WriteLine("Error: Division by zero is not allowed.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice.");
//                break;
//        }
//    }
//}

//9. (C) Write a program to Swapping without using third variable.

//Console.Write("Enter first number: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number: ");
//int b = Convert.ToInt32(Console.ReadLine());
//a = a + b;
//b = a - b;
//a = a - b;
//Console.WriteLine($"After swapping: First number = {a}, Second number = {b}");

//10. (C)Write a program to find maximum numbers from given 3 numbers using ternary operator.

Console.Write("Enter first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

//(n1 > n2 && n1 > n3) ? Console.WriteLine($"{n1} is largest") : ((n2 > n3) ? Console.WriteLine($"{n2} is largest") : Console.WriteLine($"{n3} is largest"));

Console.WriteLine((n1 > n2 && n1 > n3) ? $"{n1} is largest" : ((n2 > n3) ? $"{n2} is largest" : $"{n3} is largest"));

