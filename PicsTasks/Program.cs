using System;
using System.Reflection.Metadata.Ecma335;

//namespace File1
//{
// class Task1
// {
//     static void Main(string[] args)
//     {
//         string fullName = "Grigor Avagyan";
//         string favLanguage = "My favorite programming language is C#. ";
//         Console.WriteLine($"My name is {fullName}.\n{favLanguage}\nThe current year is {DateTime.Now.Year}");
//     }
// }

// class Task2
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the person's age");
//         int personAge = int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the price of a book");
//         double bookPrice = double.Parse(Console.ReadLine());
//         Console.WriteLine("Is it a student?(True/False)");
//         bool boolAnswer = bool.Parse(Console.ReadLine());
//         Console.WriteLine("Enter a single character");
//         char charCharacter = char.Parse(Console.ReadLine());

//         Console.WriteLine($"Person's age: {personAge}\nPrice of a book: {bookPrice}\nBool answer: {boolAnswer}\nChar character: {charCharacter}");
//     }
// }

// class Task3
// {
//     static void Main(string[] args)
//     {
//         int[] array = new int[5];
//         for(int i = 0; i < 5; ++i)
//         {
//             Console.Write($"Enter the {i} element of array: ");
//             array[i] = int.Parse(Console.ReadLine());
//         }

//         int sumofElements = 0;
//         for(int i = 0; i < 5; ++i)
//         {
//             sumofElements += array[i];
//         }

//         Console.WriteLine($"Sum of elements: {sumofElements}");
//     }
// }

// class Task4
// {
//     static void Main(string[] args)
//     {
//         Console.Write("First name: ");
//         string firstName = Console.ReadLine();
//         Console.Write("Last name: ");
//         string lastName = Console.ReadLine();

//         string fullName = firstName + " " + lastName;
//         fullName = fullName.ToUpper();
//         Console.WriteLine($"Full name: {fullName}\nCharacter count: {fullName.Length}");
//     } 
// }

// class Task5
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the string and i will check if it is palindrome: ");
//         string wordtoCheck = Console.ReadLine();
//         if(wordtoCheck.SequenceEqual(wordtoCheck.Reverse()))
//         {
//             Console.WriteLine($"{wordtoCheck} is palindrome.");
//         }
//         else 
//         {
//             Console.WriteLine($"{wordtoCheck} is not palindrome");
//         }

//     }
// }

// class Task6
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the first number: ");
//         int num1 = int.Parse(Console.ReadLine());
//         Console.Write("Enter the second number: ");
//         int num2 = int.Parse(Console.ReadLine());
//         bool isGreater = (num1 > num2);
//         Console.WriteLine($"Sum: {num1+num2}\nDifference: {num1-num2}\nProduct: {num1*num2}\nQuotient: {num1/num2}\nIs first number greater: {isGreater} ");
//     }
// }

// class Task7
// {
//     static void Main(string[] args)
//     {
//         int[] array = new int[5];
//         for(int i = 0; i < 5; ++i)
//         {
//             Console.Write($"Enter the {i} number of array: ");
//             array[i] = int.Parse(Console.ReadLine());
//         }  

//         int maxNumber = array[0];
//         for(int i=1; i < 5; ++i)
//         {
//             if(maxNumber < array[i])
//                 maxNumber = array[i];
//         }

//         Console.WriteLine("The largest number in the array is: {0}", maxNumber);
//     }
// }

// class Task8
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the number: ");
//         int number = int.Parse(Console.ReadLine());
//         string result = ((number % 2) == 0) ? $"{number} is even" : $"{number} is odd";
//         Console.WriteLine(result);
//     } 
// }

// class Task9
// {
//     static void Main(string[] args)
//     {
//         int[] array = new int[5];
//         for(int i = 0; i < 5; ++i)
//         {
//             Console.Write("Enter the {0} element of array: ", i);
//             array[i] = int.Parse(Console.ReadLine());
//         }

//         for(int i = 0; i < 5; ++i)
//         {
//             Console.Write($"{array[4-i]} ");
//         }
//         Console.WriteLine();
//     }
// }

//  class Task10
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter number 1: ");
//         int Number1 = int.Parse(Console.ReadLine());
//         Console.Write("Enter number 2: ");
//         int Number2 = int.Parse(Console.ReadLine());
//         Console.Write("Enter operator: ");
//         char Operator = char.Parse(Console.ReadLine());
//         switch (Operator)
//         {
//             case '+':
//                 Console.WriteLine($"Result: {Number1+Number2}");
//                 break;
//             case '-':
//                 Console.WriteLine($"Result: {Number1-Number2}");
//                 break;
//             case '*':
//                 Console.WriteLine($"Result: {Number1*Number2}");
//                 break;
//             case '/':
//                 Console.WriteLine($"Result: {Number1/Number2}");
//                 break;
//             default:
//                 Console.WriteLine("Invalid Input");
//                 break;
//         }

//     }
// }

// class Task11
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Input your integer: ");
//         int number = int.Parse(Console.ReadLine());
//         if(number > 0)
//         {
//             Console.WriteLine("Your integer is positive.");
//         }
//         else if(number < 0)
//         {
//             Console.WriteLine("Your integer is negative.");
//         }
//         else 
//         {
//             Console.WriteLine("Your integer is zero.");
//         }
//     }
// }

// class Task12
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter year: ");
//         int year = int.Parse(Console.ReadLine());
//         string res = (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)) ? "It's a leap year." : "It's not a leap year.";
//         Console.WriteLine(res);
//     }
// }
//}
//namespace File2
//{
// class Task1
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Write index of Fibonacci: ");
//         int n = int.Parse(Console.ReadLine());
//         int n1 = 0;
//         int fibnum = 1;
//         int tmp;
//         if(n == 0)
//         {
//             fibnum = 0;
//             Console.WriteLine($"{fibnum}");
//             return;
//         }
//         if(n==1)
//         {
//             Console.WriteLine($"{fibnum}");
//             return;
//         }
//         --n;
//         while( n > 0 )
//         {   
//             tmp = fibnum;
//             fibnum += n1;
//             n1 = tmp;
//             --n;
//         }
//         Console.WriteLine($"{fibnum}");
//     }
// }

// class Task2
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter number to reverse: ");
//         int number = int.Parse(Console.ReadLine());
//         int reversedNumber = 0;
//         while(number > 0)
//         {
//             reversedNumber += number % 10;
//             number /= 10;
//             if(number > 0)
//             {
//                 reversedNumber *= 10;
//             }
//         } 
//         Console.WriteLine($"Reversed number: {reversedNumber}");
//     }
// }

// class Task3
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter number to count sum of digits: ");
//         int number = int.Parse(Console.ReadLine());
//         int digitsSum = 0;
//         while (number > 0)
//         {
//             digitsSum += number % 10;
//             number /= 10;
//         }
//         Console.WriteLine("Sum of digits: {0}", digitsSum);
//     }
// }

// class Task4
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter number to print it's multiplication table: ");
//         int number = int.Parse(Console.ReadLine());
//         for(int i = 1; i < 10; ++i)
//         {
//             Console.WriteLine($"{i} * {number} = {number*i} ");
//         }
//     }
// }

// class Task5
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter number to check if it i prime: ");
//         int number = int.Parse(Console.ReadLine());
//         for (int i = 2; i < number/2; ++i)
//         {
//             if(number%i == 0)
//             {
//                 Console.WriteLine("Number is not prime.");
//                 return;
//             }
//         }
//         Console.WriteLine("Number is prime.");
//     }
// }

// class Task6
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter number for Collatz Conjecture: ");
//         int number = int.Parse(Console.ReadLine());
//         int count = 0;
//         while(number != 1)
//         {
//             if(number%2 == 0)
//             {
//                 number /= 2;
//             }
//             else
//             {
//                 number = number*3 + 1;
//             }
//             ++count;
//         }
//         Console.WriteLine("Steps taked to reach 1: {0}", count);
//     }
// }

// class Task7
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter number for Pyramid: ");
//         int number = int.Parse(Console.ReadLine());
//         for(int i = 1; i <= number; ++i)
//         {
//             for(int j=0; j<i; ++j)
//                 Console.Write($"{i}");
//             Console.WriteLine();
//         }
//     }
// }

// class Task8
// {
//     static void Main(string[] args)
//     {
//         Random rndGenerate = new Random();
//         string[] password = new string[8];
//         char rndNumber;

//         while(true){
//             Console.WriteLine("Enter A for generation and Q for exit");
//             string? input = Console.ReadLine();
//             if(input == "A"){
//             for(int i = 0; i < 8; ++i)
//             {
//                 int rangeChoice = rndGenerate.Next(0, 4);
//                 if (rangeChoice == 0)
//                 {
//                     rndNumber = (char)rndGenerate.Next(65, 90);
//                     password[i] = rndNumber.ToString();
//                 }
//                 else if (rangeChoice == 1)
//                 {
//                     rndNumber = (char)rndGenerate.Next(97, 122);
//                     password[i] = rndNumber.ToString();
//                 }
//                 else if(rangeChoice == 2)
//                 {
//                     rndNumber = (char)rndGenerate.Next(35, 38);
//                     password[i] = rndNumber.ToString(); 
//                 }
//                 else
//                 {
//                     int number = rndGenerate.Next(0,9);
//                     password[i] = number.ToString();
//                 }
//             }
//                 string result = string.Join("",password);
//                 Console.WriteLine($"Generated password: {result}");
//                 password = new string[8];
//             }
//             else if(input == "Q")
//             {
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid command!");
//             }
//         }
//     }
// }

// class Task9
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter your sentence here: ");
//         string? sentence = Console.ReadLine();
//         string[] words = sentence.Split();
//         int longestWord = words[0].Length;
//         int index = 0;
//         for(int i = 1; i < words.Length; ++i)
//         {
//             if(words[i].Length > longestWord)
//             {
//                 longestWord = words[i].Length;
//                 index = i;
//             }
//         }
//         Console.WriteLine($"Longest word: {words[index]}");
//     }
// }

// class Task10
// {
//     static void Main(string[] args)
//     {
//         Random rndGenerator = new Random();
//         int i = rndGenerator.Next(0, 10);
//         int j = rndGenerator.Next(0, 10);
//         char[,] matrix = new char[10, 10];
//         matrix[i, j] = 'X';
//         for(int k=0; k<10; k++)
//         {
//             for(int q=0; q<10; ++q)
//             {
//                 if(matrix[k, q] == 'X')
//                 {
//                     Console.WriteLine($"Found at {k},{q}");
//                     return;
//                 }
//             }
//         }
//         Console.WriteLine("There are not X in matrix");
//     }
// }


//}

namespace File3
{
    // class Task1
    // {
    //     string Name;
    //     int PhoneNumber;
    //     string Email;
    //     public Task1(string Name, int PhoneNumber, string Email)
    //     {
    //         this.Name = Name;
    //         this.PhoneNumber = PhoneNumber;
    //         this.Email = Email;
    //     }
    //     public void DisplayInfo()
    //     {
    //         Console.WriteLine($"Name: {Name}\nPhoneNumber: {PhoneNumber}\nEmail: {Email}");
    //     }
    // }

    // class Task2
    // {
    //     string Name;
    //     int Age;
    //     int Grade;
    //     public Task2(string Name, int Age, int Grade)
    //     {
    //         this.Name = Name;
    //         this.Age = Age;
    //         this.Grade = Grade;
    //     }
    //     public void DisplayDetails()
    //     {
    //         Console.WriteLine($"Name: {Name}\nAge: {Age}\nGrade: {Grade}");
    //     }
    // }

    // class Task3
    // {
    //     int AccountNumber;
    //     string? HolderName;
    //     int Balance;

    //     public Task3(int AccountNumber, string HolderName)
    //     {
    //         this.AccountNumber = AccountNumber;
    //         this.HolderName = HolderName;
    //         this.Balance = 0;
    //     }

    //     public void Deposit(int depositMoney)
    //     {
    //         Balance += depositMoney;
    //     }

    //     public int Withdraw(int Amount)
    //     {
    //         if(Balance < Amount)
    //         {
    //             Console.WriteLine("Insufficient funds!!!");
    //             return -1;
    //         }
    //         else
    //         {
    //             Balance -= Amount;
    //             return Amount;
    //         }
    //     }

    //     public void DisplayDetails()
    //     {
    //         Console.WriteLine($"AccountNumber: {AccountNumber}\nHolderName: {HolderName}\nBalance: {Balance}");
    //     }
    // }

    // class Task4
    // {
    //     string Title;
    //     string Author;
    //     bool IsAvailable;
    //     public Task4(string Title, string Author)
    //     {
    //         this.Title = Title;
    //         this.Author = Author;
    //         this.IsAvailable = true;
    //     }
    //     public void BorrowBook()
    //     {
    //         if(this.IsAvailable)
    //         {
    //             this.IsAvailable = false;
    //             Console.WriteLine($"You borrowed {Title} book of {Author} succesfully.");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Book is not available!");
    //         }
    //     }
    //     public void ReturnBook()
    //     {
    //         if(IsAvailable)
    //         {
    //             Console.WriteLine("You didn't borrow book from us!");
    //         }
    //         else
    //         {
    //             IsAvailable = true;
    //             Console.WriteLine($"You returned {Title} of {Author} succesfully.");
    //         }
    //     }

    // }

    // class Task5
    // {
    //     string Name;
    //     int Price;
    //     int Quantity;
    //     public Task5(string Name, int Price, int Quantity)
    //     {
    //         this.Name = Name;
    //         this.Price = Price;
    //         this.Quantity = Quantity;
    //     }
    //     public int TotalPrice()
    //     {
    //         return Price*Quantity;
    //     }

    // }

//     class Task6
//     {
//         string Name;
//         string Position;
//         int SalaryPerHour;
//         int HoursWorked;
//         public Task6(string Name, string Position, int SalaryPerHour, int HoursWorked)
//         {
//             this.Name = Name;
//             this.Position = Position;
//             this.SalaryPerHour = SalaryPerHour;
//             this.HoursWorked = HoursWorked;
//         }
//         public int CalculateSalary()
//         {
//             return SalaryPerHour * HoursWorked;
//         }
//     }

//     class Task7
//     {
//         string MovieName;
//         int SeatNumber;
//         bool IsBooked;
//         public Task7(string MovieName, int SeatNumber)
//         {
//             this.MovieName = MovieName;
//             this.SeatNumber = SeatNumber;
//             bool IsBooked = false;
//         }
//         public void BookTicket()
//         {
//             if(IsBooked == false)
//             {
//                 IsBooked = true;
//                 Console.WriteLine($"You booked ticket for {MovieName} movie in {SeatNumber} seat succesfully.");
//             }
//             else
//             {
//                 Console.WriteLine($"Seat for {MovieName} movie in {SeatNumber} seat is already booked.");
//             }
//         }
//     }

// namespace  Task8
// {
//     class Student
//     {
//         string Name;
//         int Age;
//         int Grade;
//         public Student(string Name, int Age, int Grade)
//         {
//             this.Name = Name;
//             this.Age = Age;
//             this.Grade = Grade;
//         }
//     }
//     class Teacher
//     {
//         string Name;
//         string Subject;
//         int YearsOfExperience;
//         public Teacher(string Name, string Subject, int YearsOfExperience)
//         {
//             this.Name = Name;
//             this.Subject = Subject;
//             this.YearsOfExperience = YearsOfExperience;
//         }
//     }
//     class School
//     {
//         object[] Students;
//         object[] Teachers;
//         public School(object[] Students, object[] Teachers)
//         {
//             this.Students = Students;
//             this.Teachers = Teachers;
//         }
        

//     }
// }

//     class MainClass
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Title: ");
//             string? Title = Console.ReadLine();
//             Console.Write("Author: ");
//             string? Author = Console.ReadLine();
//             Task4 Contact1 = new Task4(Title,Author);
//             Contact1.BorrowBook();
//             Contact1.BorrowBook();
//             Contact1.ReturnBook();
//             Contact1.ReturnBook();
    
//         }
//     }

}