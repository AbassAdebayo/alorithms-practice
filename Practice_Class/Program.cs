//Prime Number
// Console.Write("Enter integer number (1 < n < 100): ");
// int num = Convert.ToInt32(Console.ReadLine());
//
// int sqrt = (int)Math.Sqrt(num);
//
// if(num <= 1) 
// {
//     Console.WriteLine("The number must be greater than 1");
// }
// else if(num <= 3)
// {
//     Console.WriteLine($"{num} is a prime number");
// }
// else if(num > 100)
// {
//     Console.WriteLine($"Number shouldn't be greater than 100!");
// }
// else
// {
//     for(int i = 2; i <= sqrt; i++)
//     {
//         if(num % i == 0)
//         {
//             Console.WriteLine($"{num} is not a prime number");
//             return;
//         }
//     
//     }
//     Console.WriteLine($"{num} is a prime number");
//
// }


// string [] vowelsArray = { "a", "e", "i", "o", "u" };
// string [] consonantsArray = {"b", "c", "d",  "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };

// int vowelCount = 0;
// int consonantCount = 0;

// string words = "My name is Abass Adebayo";

// foreach (char letter in words)
// {
//     if (vowelsArray.Contains(letter.ToString()))
//     {
//         vowelCount++;
//     }

//     if (consonantsArray.Contains(letter.ToString()))
//     {
//         consonantCount++;
//     }
// }

// Console.WriteLine($"The counts of vowel letters in {words}: {vowelCount}");
// Console.WriteLine($"The counts of consonant letters: {consonantCount}");

// // Console.Write("Enter '1' to calculate area of Triangle and '2' to calculate area of Rectangle: ");
// // int choice = Convert.ToInt32(Console.ReadLine());
// //
// // switch (choice)
// // {
// //     case 1:
// //         Console.WriteLine("Area of Triangle........................ ");
// //         Console.Write("Enter the value of a: ");
// //         double a = Convert.ToDouble(Console.ReadLine());
// //         
// //         Console.Write("Enter the value of b: ");
// //         double b = Convert.ToDouble(Console.ReadLine());
// //
// //         double areaOfTriangle = a * b;
// //         Console.WriteLine($"The area of triangle is: {areaOfTriangle}");
// //         break;
// //     case 2:
// //         Console.WriteLine("Area of Rectangle............................ ");
// //         Console.Write("Enter the value of b: ");
// //         double baseValue = Convert.ToDouble(Console.ReadLine());
// //         
// //         Console.Write("Enter the value of h: ");
// //         double h = Convert.ToDouble(Console.ReadLine());
// //
// //         double areaOfRectangle = baseValue * h / 2;
// //         Console.WriteLine($"The area of Rectangle is: {areaOfRectangle}");
// //         break;
// //     default:
// //         Console.Write("You have entered an invalid choice!");
// //         break;
// // }


// string result = "";

// List<string> letters = new List<string> { "x", "x", "y", "y" };
// Console.Write("Enter target letter: ");
// string target = Console.ReadLine();

// letters.Distinct().ToList();
// string smallestLetter = letters.Max();



// for (int i = 0; i < letters.Count; i++)
// {
//     int check1 = string.Compare(target, letters[i], StringComparison.Ordinal);
//     int check2 = string.Compare(letters[i], smallestLetter, StringComparison.Ordinal);

//     if (check < 0)
//     {
//         result = smallestLetter;
//     }

//     else if (target.CompareTo(letters[i]) > 0 || target == letters[i])
//     {
//         result = letters[0];
//     }
//     else
//     {
//         if (target.CompareTo(letters[i]) < 0)
//         {
//             smallestLetter = letters.Min();
//             if(target.CompareTo(smallestLetter) < 0)
//             result = smallestLetter;
//         }
        
//     }
    
// }

// Console.WriteLine($"Output: {result}");

string name  = "Basit";
int result = name.Length;
Console.WriteLine(result);