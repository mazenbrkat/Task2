using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List <int> numbers = new List<int>();
            int number;
            while (true)
            {
                Console.WriteLine("menu options: ");
                Console.WriteLine("/////////////////////////////////// ");
                Console.WriteLine("P - Print numbers ");
                Console.WriteLine("A - Add a number ");
                Console.WriteLine("M - Display mean of the numbers ");
                Console.WriteLine("S - Display the smallest number ");
                Console.WriteLine("L - Display the largest number ");
                Console.WriteLine("H - Search for a number in the list ");
                Console.WriteLine("V - How many Even or Odd numbers in list ");
                Console.WriteLine("C - make empty list again ");
                Console.WriteLine("Q - Quit ");
                Console.WriteLine("/////////////////////////////////// ");
                Console.WriteLine("Enter your choice: ");
                char choice = Convert.ToChar(Console.ReadLine());

                //when user choices q,Q
                if (choice == 'Q' || choice == 'q')
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

                //when user choices p,P
                if (choice == 'P' || choice == 'p')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else if (numbers.Count != 0)
                    {
                        Console.Write("[ ");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        Console.WriteLine(" ]");
                    }
                }

                //when user choices A,a  && don't allow duplicate entries
                if (choice == 'A' || choice == 'a')
                {
                    Console.WriteLine("Enter number: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    bool found = false;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == number)
                        {
                            found = true;
                            break;

                        }
                    }
                    if (found)
                    {
                        Console.WriteLine("This number already exists!");
                    }
                    else
                    {
                        numbers.Add(number);
                        Console.WriteLine($"{number} added");
                    }
                
                     
                }

                //when user choices M,m
                if (choice == 'M' || choice == 'm')
                {
                    double mean;
                    int sum = 0;
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum = sum + numbers[i];
                        }
                        mean = (double)sum / numbers.Count;
                        Console.WriteLine($"Mean= {mean}");
                    }

                }

                //when user choices S,s
                if (choice == 'S' || choice == 's')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int min = numbers[0];
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            if (numbers[i] < min)
                            {
                                min = numbers[i];
                                
                            }
                            
                        }
                        Console.WriteLine($"The smallest number is {min}");
                    }
                }

                //when user choices L,l
                if (choice == 'L' || choice == 'l')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int max = numbers[0];
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            if (numbers[i] > max)
                            {
                                max = numbers[i];

                            }

                        }
                        Console.WriteLine($"The largest number is {max}");
                    }
                }

                ////////////////////////////////////////////////////////

                //Additional functionality

                //when user choices H,h
                if (choice == 'H' || choice == 'h')
                {
                    Console.WriteLine("Enter number to search in list: ");
                    int SearchNumber=Convert.ToInt32( Console.ReadLine());
                    bool found = false;
                    int Index = 0;
                        for (int i = 0; i < numbers.Count; i++)
                      { 
                         if(numbers[i] == SearchNumber)
                         {
                            Index = i;
                            found = true;
                            break;

                         }
                      }
                    if (found)
                    {
                        Console.WriteLine("Index: "+Index);
                    }
                    else
                    {
                        Console.WriteLine("Number not found");
                    }
                }

                

                /////////////////////////////////////////////////////////////////////////

                //when user choices C,c

                if (choice == 'C' || choice == 'c')
                { 
                        numbers.Clear() ;
                        Console.WriteLine("Clear all numbers done!");
                }

                //check if characters that there are in menu options or no that if you enter another character is unknow


                if (choice != 'P' && choice != 'p' &&
                    choice != 'A' && choice != 'a' &&
                    choice != 'M' && choice != 'm' &&
                    choice != 'S' && choice != 's' &&
                    choice != 'L' && choice != 'l' &&
                    choice != 'H' && choice != 'h' &&
                    choice != 'C' && choice != 'c' &&
                    choice != 'Q' && choice != 'q' &&
                    choice != 'V' && choice != 'v')
                {
                    Console.WriteLine("Unknown selection, please try again");
                }

                /////////////////////////////////////////////////////////////////////

                //come up with your own ideas!

                int EvenNumber = 0;
                int OddNumber = 0;
               
                if (choice == 'V' || choice == 'v')
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            EvenNumber++;
                        }
                        else
                        {
                            OddNumber++;
                        }
                       
                    }
                    Console.WriteLine("Even Numbers= " + EvenNumber);
                    Console.WriteLine("Odd Numbers= " + OddNumber);
                    

                }

            }
        }
    }
}
