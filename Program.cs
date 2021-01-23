using System;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Names the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            
            Console.WriteLine("Can you give me an integer?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great! Now type in another and I will tell you if they are equal.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1==num2)
                 Console.WriteLine("Those two integers are equal to each other.");
            else Console.WriteLine("Those integers are not equal to each other.");
         
            

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            Console.WriteLine("Can you type out a number? I will tell you if it is even or odd.");
            int numoe = Convert.ToInt32(Console.ReadLine());
            if (numoe%2 == 0)
                Console.WriteLine("That number is even.");
            else Console.WriteLine("That number is odd.");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Give me a letter and I will tell you if it is a vowel or a consonant.");
                string userletter = Console.ReadLine();
            string userletterl = userletter.ToLower();
            if (userletterl.Equals("a"))
            { Console.WriteLine("That is a vowel."); }
            else if (userletterl.Equals("e"))
            { Console.WriteLine("That is a vowel."); }
            else if (userletterl.Equals("i"))
            { Console.WriteLine("That is a vowel."); }
            else if (userletterl.Equals("o"))
            { Console.WriteLine("That is a vowel."); }
            else if (userletterl.Equals("u"))
            { Console.WriteLine("That is a vowel."); }
            else if (userletterl.Equals("y"))
            { Console.WriteLine("That is sometimes a vowel."); }
            else
            { Console.WriteLine("That is a consonant."); }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.WriteLine("Please give me a number");
            int unum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great! Now give me a second number and I will tell you if it is greater or less than the first.");
            int unum2 = Convert.ToInt32(Console.ReadLine());
            if (unum2 > unum1)
            { Console.WriteLine(unum2 + " is greater than " + unum1 +"."); }
            else if (unum2 < unum1)
            { Console.WriteLine(unum2 + " is less than " + unum1 + "."); }
            else
                Console.WriteLine("Those are equal.");



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.WriteLine("Please give me a number, and I will tell you if it is divisible by 3.");
            int divnum = Convert.ToInt32(Console.ReadLine());
            if (divnum % 3 == 0)
            { Console.WriteLine("That number is divisible by 3."); }
            else
                Console.WriteLine("That number is not divisible by 3.");



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here

            // define number of diners
            Console.WriteLine("How many diners are at the table?");
            int numdiner = Convert.ToInt32(Console.ReadLine());
            // define cost per diner
            Console.WriteLine("How much is everyone paying if everyone pays the same amount?");
            Console.Write("$"); int numpay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You're bill is $" + (numdiner * numpay));
            int billtotal = numdiner * numpay;
            // if bill is over $50 then give a 10% discount
            if (billtotal > 50)
            {
                Console.WriteLine("Your bill is over $50! Because of Customer Appreciation Week, you get 10% off!");
                Console.WriteLine("You're new bill is $" + (billtotal - (billtotal * .10)));
            }
            // if bill is not, then give a 5% discount
            else
            {
                Console.WriteLine("It is Customer Appreciation week! Customers get a 10% discount for orders of $50 and above!");
                Console.WriteLine("Since your bill was $" + billtotal + ", you get 5% off! Your new bill is $" + (billtotal - (billtotal * .05)) + "!");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
                    // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here
            Console.WriteLine("Please enter the subject's aget and we will determine which demographic they fit into.");
            Console.Write("Age: "); int ageosub = Convert.ToInt32(Console.ReadLine());
         
            if (ageosub >= 0 && ageosub <= 2)
            { Console.WriteLine("Still in Mama's Arms"); }
            else if (ageosub >= 3 && ageosub <= 4)
            { Console.WriteLine("Preschool Maniac"); }
            else if (ageosub >= 5 && ageosub <= 11)
            { Console.WriteLine("Elementary School"); }
            else if (ageosub >= 12 && ageosub <=14) { Console.WriteLine("Middle School"); }
            else if (ageosub >= 15 && ageosub <= 18) { Console.WriteLine("High School"); }
            else if (ageosub >= 19 && ageosub <= 22) { Console.WriteLine("College"); }
            else if (ageosub >= 23 && ageosub <= 65) { Console.WriteLine("Woking for the Man"); }
            else if (ageosub >= 66 && ageosub <= 100) { Console.WriteLine("The Golden Years"); }
            else { Console.WriteLine("This program is for humans."); }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
