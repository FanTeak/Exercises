using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    /// <summary>
    /// Exercise from https://www.exercisescsharp.com/
    /// </summary>
    class Program
    {
        static void CalculateValues()
        {
            int leftLimit, rightLimit, stepValue;

            Console.WriteLine("Enter left limit:");
            while (!int.TryParse(Console.ReadLine(), out leftLimit))
            {
                Console.WriteLine(leftLimit + " isn`t integer!");
            }
            Console.WriteLine("Enter right limit:");
            while (!int.TryParse(Console.ReadLine(), out rightLimit))
            {
                Console.WriteLine(rightLimit + " isn`t integer!");
            }
            Console.WriteLine("Enter step of X:");
            while (!int.TryParse(Console.ReadLine(), out stepValue))
            {
                Console.WriteLine(stepValue + " isn`t integer!");
            }

            Console.WriteLine("Your function:");
            do
            {
                double resultFunction = leftLimit * leftLimit - 2 * leftLimit + 1;
                Console.WriteLine("X: " + leftLimit + " Y: " + resultFunction);
                leftLimit += stepValue;
            } while (leftLimit <= rightLimit);
        }

        static void Triangle()
        {
            int heightTriangle;
            char symbolTriangle;

            Console.WriteLine("Enter triangle height:");
            while (!int.TryParse(Console.ReadLine(), out heightTriangle))
            {
                Console.WriteLine(heightTriangle + " isn`t integer!");
            }
            Console.WriteLine("Enter symbol:");
            while (!char.TryParse(Console.ReadLine(), out symbolTriangle))
            {
                Console.WriteLine(symbolTriangle + " isn`t symbol!");
            }

            for (int i = heightTriangle; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(symbolTriangle);
                }
                Console.WriteLine();
            }
        }

        static void TriangleNortheast()
        {
            int heightTriangle;
            char symbolTriangle;

            Console.WriteLine("Enter triangle height:");
            while (!int.TryParse(Console.ReadLine(), out heightTriangle))
            {
                Console.WriteLine(heightTriangle + " isn`t integer!");
            }
            Console.WriteLine("Enter symbol:");
            while (!char.TryParse(Console.ReadLine(), out symbolTriangle))
            {
                Console.WriteLine(symbolTriangle + " isn`t symbol!");
            }

            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = heightTriangle; k > i; k--)
                {
                    Console.Write(symbolTriangle);
                }
                Console.WriteLine();
            }
        }

        static void TriangleRight()
        {
            int heightTriangle;
            string strTriangle;

            Console.WriteLine("Enter triangle height:");
            while (!int.TryParse(Console.ReadLine(), out heightTriangle))
            {
                Console.WriteLine(heightTriangle + " isn`t integer!");
            }
            Console.WriteLine("Enter symbols:");
            strTriangle = Console.ReadLine();

            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(strTriangle[heightTriangle - j - 1]);
                }
                Console.WriteLine();
            }
        }

        static void TabulationGraphic()
        {
            int leftLimit, rightLimit, stepValue;

            Console.WriteLine("Enter left limit:");
            while (!int.TryParse(Console.ReadLine(), out leftLimit))
            {
                Console.WriteLine(leftLimit + " isn`t integer!");
            }
            Console.WriteLine("Enter right limit:");
            while (!int.TryParse(Console.ReadLine(), out rightLimit))
            {
                Console.WriteLine(rightLimit + " isn`t integer!");
            }
            Console.WriteLine("Enter step of X:");
            while (!int.TryParse(Console.ReadLine(), out stepValue))
            {
                Console.WriteLine(stepValue + " isn`t integer!");
            }

            Console.WriteLine("Your function:");
            for (; leftLimit <= rightLimit; leftLimit += stepValue)
            {
                int resultFunction = (leftLimit - 4) * (leftLimit - 4);
                for (int j = 0; j < resultFunction; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Multiples()
        {
            int leftLimit, rightLimit;

            Console.WriteLine("Enter left limit:");
            while (!int.TryParse(Console.ReadLine(), out leftLimit))
            {
                Console.WriteLine(leftLimit + " isn`t integer!");
            }
            Console.WriteLine("Enter right limit:");
            while (!int.TryParse(Console.ReadLine(), out rightLimit))
            {
                Console.WriteLine(rightLimit + " isn`t integer!");
            }

            Console.WriteLine("Numbers whitch are %3 and %5:");
            for (int i = leftLimit; i <= rightLimit; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Access()
        {
            int nickName, password;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your nckname:");
                while (!int.TryParse(Console.ReadLine(), out nickName))
                {
                    Console.WriteLine(nickName + " isn`t integer!");
                }
                Console.WriteLine("Enter your password:");
                while (!int.TryParse(Console.ReadLine(), out password))
                {
                    Console.WriteLine(password + " isn`t integer!");
                }

                if (nickName == 12 && password == 1234)
                {
                    Console.WriteLine("Loggined successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Loggined has failed");
                }
            }
        }

        static void InfiniteDivisoin()
        {
            int firstValue, secondValue;

            while (true)
            {
                Console.WriteLine("Enter first value:");
                while (!int.TryParse(Console.ReadLine(), out firstValue))
                {
                    Console.WriteLine(firstValue + " isn`t integer!");
                }
                if (firstValue == 0)
                {
                    break;
                }
                Console.WriteLine("Enter second value:");
                while (!int.TryParse(Console.ReadLine(), out secondValue))
                {
                    Console.WriteLine(secondValue + " isn`t integer!");
                }

                if (secondValue == 0)
                {
                    Console.WriteLine("You cannot divide by 0!");
                }
                else
                {
                    Console.WriteLine("The division is " + (firstValue / secondValue));
                    Console.WriteLine("The rest is " + (firstValue % secondValue));
                }
            }
        }

        static void RepetitiveStructures()
        {
            int leftLimit, rightLimit, stepValue;

            Console.WriteLine("Enter left limit:");
            while (!int.TryParse(Console.ReadLine(), out leftLimit))
            {
                Console.WriteLine(leftLimit + " isn`t integer!");
            }
            Console.WriteLine("Enter right limit:");
            while (!int.TryParse(Console.ReadLine(), out rightLimit))
            {
                Console.WriteLine(rightLimit + " isn`t integer!");
            }
            Console.WriteLine("Enter step:");
            while (!int.TryParse(Console.ReadLine(), out stepValue))
            {
                Console.WriteLine(stepValue + " isn`t integer!");
            }

            Console.WriteLine("For cycle:");
            for (int i = leftLimit; i <= rightLimit; i += stepValue)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("While cycle:");
            int temp = leftLimit;
            while (temp <= rightLimit)
            {
                Console.Write(temp + "\t");
                temp += stepValue;
            }
            Console.WriteLine();

            Console.WriteLine("Do-while cycle:");
            temp = leftLimit;
            do
            {
                Console.Write(temp + "\t");
                temp += stepValue;
            } while (temp <= rightLimit);
            Console.WriteLine();
        }

        static void MathStat()
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " number: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine(array[i] + " isn`t integer!");
                }
            }

            Console.WriteLine("Suma: " + array.Sum());
            Console.WriteLine("Average: " + array.Average());
            Console.WriteLine("Max: " + array.Max());
            Console.WriteLine("Min: " + array.Min());
        }

        static void Alphabet()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write(i + " ");
            }
        }

        static void GiveChange()
        {
            int PriceToPay, AmountMoney;

            Console.WriteLine("Enter value to pay:");
            while (!int.TryParse(Console.ReadLine(), out PriceToPay))
            {
                Console.WriteLine(PriceToPay + " isn`t integer!");
            }
            Console.WriteLine("Enter amount to pay:");
            while (!int.TryParse(Console.ReadLine(), out AmountMoney))
            {
                Console.WriteLine(AmountMoney + " isn`t integer!");
            }

            Console.WriteLine("Your change:");
            int[] changeValues = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int changeTotal = AmountMoney - PriceToPay;
            for (int i = 0; i < changeValues.Length; i++)
            {
                while (changeValues[i] <= changeTotal)
                {
                    changeTotal -= changeValues[i];
                    Console.Write(changeValues[i] + " ");
                }
                if (changeTotal == 0)
                {
                    break;
                }
            }
        }

        static void ConditionalOperator()
        {
            int firstValue, secondValue;

            Console.WriteLine("Enter first value:");
            while (!int.TryParse(Console.ReadLine(), out firstValue))
            {
                Console.WriteLine(firstValue + " isn`t integer!");
            }
            Console.WriteLine("Enter second value:");
            while (!int.TryParse(Console.ReadLine(), out secondValue))
            {
                Console.WriteLine(secondValue + " isn`t integer!");
            }

            Console.WriteLine((firstValue >= 0) ? "First value is positive." : "First value is negative.");
            Console.WriteLine((secondValue >= 0) ? "Second value is positive." : "Second value is negative.");
            Console.WriteLine(((firstValue >= 0) && (secondValue >= 0)) ? "Both value is positive." : "Both value is negative.");
        }

        static void ConditionalNested()
        {
            int firstValue, secondValue;

            Console.WriteLine("Enter first value:");
            while (!int.TryParse(Console.ReadLine(), out firstValue))
            {
                Console.WriteLine(firstValue + " isn`t integer!");
            }
            Console.WriteLine("Enter second value:");
            while (!int.TryParse(Console.ReadLine(), out secondValue))
            {
                Console.WriteLine(secondValue + " isn`t integer!");
            }

            int count = 0;
            count += (firstValue >= 0) ? 1 : 0;
            count += (secondValue >= 0) ? 1 : 0;
            Console.WriteLine("Amount of positive numbers: " + count);
        }

        static void DrawSquare()
        {
            int heightTriangle;
            char symbolTriangle;

            Console.WriteLine("Enter square height:");
            while (!int.TryParse(Console.ReadLine(), out heightTriangle))
            {
                Console.WriteLine(heightTriangle + " isn`t integer!");
            }
            Console.WriteLine("Enter symbol:");
            while (!char.TryParse(Console.ReadLine(), out symbolTriangle))
            {
                Console.WriteLine(symbolTriangle + " isn`t symbol!");
            }

            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = 0; j < heightTriangle; j++)
                {
                    if ((i == 0) || (i == heightTriangle - 1))
                    {
                        Console.Write(symbolTriangle);
                    }
                    else
                    {
                        if ((j == 0) || (j == heightTriangle - 1))
                        {
                            Console.Write(symbolTriangle);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawRectangle()
        {
            int heightTriangle;
            int widthTriangle;
            char symbolTriangle;

            Console.WriteLine("Enter rectangle height:");
            while (!int.TryParse(Console.ReadLine(), out heightTriangle))
            {
                Console.WriteLine(heightTriangle + " isn`t integer!");
            }
            Console.WriteLine("Enter rectangle width:");
            while (!int.TryParse(Console.ReadLine(), out widthTriangle))
            {
                Console.WriteLine(widthTriangle + " isn`t integer!");
            }
            Console.WriteLine("Enter symbol:");
            while (!char.TryParse(Console.ReadLine(), out symbolTriangle))
            {
                Console.WriteLine(symbolTriangle + " isn`t symbol!");
            }

            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = 0; j < widthTriangle; j++)
                {
                    if ((i == 0) || (i == heightTriangle - 1))
                    {
                        Console.Write(symbolTriangle);
                    }
                    else
                    {
                        if ((j == 0) || (j == widthTriangle - 1))
                        {
                            Console.Write(symbolTriangle);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawParallelogram()
        {
            int heightTriangle;
            int widthTriangle;
            char symbolTriangle;

            Console.WriteLine("Enter parallelogram height:");
            while (!int.TryParse(Console.ReadLine(), out heightTriangle))
            {
                Console.WriteLine(heightTriangle + " isn`t integer!");
            }
            Console.WriteLine("Enter parallelogram width:");
            while (!int.TryParse(Console.ReadLine(), out widthTriangle))
            {
                Console.WriteLine(widthTriangle + " isn`t integer!");
            }
            Console.WriteLine("Enter symbol:");
            while (!char.TryParse(Console.ReadLine(), out symbolTriangle))
            {
                Console.WriteLine(symbolTriangle + " isn`t symbol!");
            }

            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < widthTriangle; k++)
                {
                    Console.Write(symbolTriangle);
                }
                Console.WriteLine();
            }
        }

        static void DrawPyramid()
        {
            string strTriangle;

            Console.WriteLine("Enter string:");
            strTriangle = Console.ReadLine();

            for (int i = 0; i < (int)(strTriangle.Length / 2.0 + 0.5); i++)
            {
                int j;
                for (j = 0; j < (strTriangle.Length / 2 - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (i * 2 + 1); k++, j++)
                {
                    Console.Write(strTriangle[j]);
                }
                Console.WriteLine();
            }
        }

        static void PrimeFactors()
        {
            int value;

            Console.WriteLine("Enter value value:");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(value + " isn`t integer!");
            }

            Console.Write("Dividers of number:\n1");
            int divider = 2;
            while (value > 1)
            {
                if (value % divider == 0)
                {
                    value /= divider;
                    Console.Write("*" + divider);
                }
                else
                {
                    divider++;
                }
            }
            Console.WriteLine();
        }

        static void ConvertHexBin()
        {
            int value, temp;

            Console.WriteLine("Enter value value:");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(value + " isn`t integer!");
            }

            temp = value;
            Console.WriteLine("Binary code:");
            while (value >= 2)
            {
                Console.Write(value % 2 + " ");
                value /= 2;
            }
            Console.WriteLine(value % 2);

            value = temp;
            Console.WriteLine("Hexedecimal code:");
            while (value >= 16)
            {
                Console.Write(value % 16 + " ");
                value /= 16;
            }
            Console.WriteLine(value % 16);
        }

        static void HecedecimalTable()
        {
            Console.WriteLine("Hexedecimal table:");
            for (int k = 0, i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++, k++)
                {
                    if (k < 16)
                    {
                        Console.Write(0);
                    }
                    Console.Write(Convert.ToString(k, 16) + " ");
                }
                Console.WriteLine();
            }
        }

        static void ReverseOrder()
        {
            Console.WriteLine("Enter array size:");
            uint size;
            while (!uint.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine(size + " isn`t integer!");
            }

            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter {0} element:", i);
                int.TryParse(Console.ReadLine(), out array[i]);
            }

            Console.WriteLine("Entered array in reverse order:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Element {0} value {1}", i, array[i]);
            }
        }

        static void SearchArray()
        {
            Console.WriteLine("Enter array size:");
            uint size;
            while (!uint.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine(size + " isn`t integer!");
            }

            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }

            Console.WriteLine("Enter number to find or else to exit:");
            while (int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine("Consisting element in array:" + array.Contains(value));
            }
        }

        static void EvenNumber()
        {
            Console.WriteLine("Enter array size:");
            uint size;
            while (!uint.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine(size + " isn`t integer!");
            }

            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }

            Console.WriteLine("Even numbers:");
            array = array.Where(i => i % 2 == 0).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }

        static void AveragePosNeg()
        {
            Console.WriteLine("Enter array size:");
            uint size;
            while (!uint.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine(size + " isn`t integer!");
            }

            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }

            Console.WriteLine("Average positive numbers: " + array.Where(i => i >= 0).Average());
            Console.WriteLine("Average negative numbers:" + array.Where(i => i < 0).Average());
        }

        static void BunnerUnix()
        {
            bool[,,] arrayChars = new bool[3, 6, 6];
            for (int i = 0; i < arrayChars.GetLength(1); i++)
            {
                arrayChars[0, i, 0] = true;
                arrayChars[0, arrayChars.GetLength(1) - 1, i] = true;
            }

            for (int i = 0; i < arrayChars.GetLength(1); i++)
            {
                for (int j = 0; j < arrayChars.GetLength(2); j++)
                {
                    if ((i == 0) || (i == arrayChars.GetLength(1) - 1))
                    {
                        arrayChars[1, i, j] = true;
                    }
                    else
                    {
                        if ((j == 0) || (j == arrayChars.GetLength(2) - 1))
                        {
                            arrayChars[1, i, j] = true;
                        }
                    }
                }
            }

            for (int i = 0; i < arrayChars.GetLength(1); i++)
            {
                for (int j = 0; j < arrayChars.GetLength(2); j++)
                {
                    if (i == j || i + j == arrayChars.GetLength(1) - 1)
                    {
                        arrayChars[2, i, j] = true;
                    }
                }
            }

            for (int i = 0; i < arrayChars.GetLength(0); i++)
            {
                for (int j = 0; j < arrayChars.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayChars.GetLength(2); k++)
                    {
                        if (arrayChars[i, j, k])
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void BubbleSort()
        {
            Console.WriteLine("Enter array size:");
            uint size;
            while (!uint.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine(size + " isn`t integer!");
            }

            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }

            Console.WriteLine("Entered array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("\nSorted array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }

        static void AverageTwoArray()
        {
            uint sizeArrays;
            Console.WriteLine("Enter count of students in each group:");
            while (!uint.TryParse(Console.ReadLine(), out sizeArrays))
            {
                Console.WriteLine(sizeArrays + " isn`t integer!");
            }

            int[,] groups = new int[2, sizeArrays];
            Random rand = new Random();
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                for (int j = 0; j < groups.GetLength(1); j++)
                {
                    groups[i, j] = rand.Next(1, 12);
                }
            }

            Console.WriteLine("Students marks:");
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                for (int j = 0; j < groups.GetLength(1); j++)
                {
                    Console.WriteLine("Group " + (i + 1) + " student " + (j + 1) + " mark: " + groups[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < groups.GetLength(0); i++)
            {
                double average = 0;
                for (int j = 0; j < groups.GetLength(1); j++)
                {
                    average += groups[i, j];
                }
                Console.WriteLine("Group " + (i + 1) + " average mark: " + average / groups.GetLength(1));
            }
        }

        static void TwoArrayChar()
        {
            uint countArrays, sizeArrays;
            char symbolDraw;
            Console.WriteLine("Enter count arrays:");
            while (!uint.TryParse(Console.ReadLine(), out countArrays))
            {
                Console.WriteLine(countArrays + " isn`t integer!");
            }
            Console.WriteLine("Enter count of elements in each array:");
            while (!uint.TryParse(Console.ReadLine(), out sizeArrays))
            {
                Console.WriteLine(sizeArrays + " isn`t integer!");
            }
            Console.WriteLine("Enter symbol:");
            while (!char.TryParse(Console.ReadLine(), out symbolDraw))
            {
                Console.WriteLine(symbolDraw + " isn`t symbol!");
            }

            char[,] arrayChars = new char[countArrays, sizeArrays];
            for (int i = 0; i < arrayChars.GetLength(0); i++)
            {
                for (int j = 0; j < arrayChars.GetLength(1); j++)
                {
                    arrayChars[i, j] = symbolDraw;
                }
            }

            Console.WriteLine("Your rectangle:");
            for (int i = 0; i < arrayChars.GetLength(0); i++)
            {
                for (int j = 0; j < arrayChars.GetLength(1); j++)
                {
                    Console.Write(arrayChars[i, j]);
                }
                Console.WriteLine();
            }
        }

        public struct Car
        {
            public string markCar;
            public uint yearMade;
        };

        static void StructArray()
        {
            uint countCars;
            Console.WriteLine("Enter count of cars:");
            while (!uint.TryParse(Console.ReadLine(), out countCars))
            {
                Console.WriteLine(countCars + " isn`t integer!");
            }

            Car[] arrayCars = new Car[countCars];
            for (int i = 0; i < arrayCars.Length; i++)
            {
                Console.Write("Enter name of car: ");
                arrayCars[i].markCar = Console.ReadLine();
                Console.Write("Enter year of mading car: ");
                while (!uint.TryParse(Console.ReadLine(), out arrayCars[i].yearMade))
                {
                    Console.WriteLine(arrayCars[i].yearMade + " isn`t integer!");
                }
            }

            Console.WriteLine("Your cars:");
            for (int i = 0; i < arrayCars.Length; i++)
            {
                Console.WriteLine("Car name: " + arrayCars[i].markCar);
                Console.WriteLine("Car year mading: " + arrayCars[i].yearMade);
            }
        }

        static void MathStatSwitch()
        {
            int[] array = new int[0];
            while (true)
            {
                Console.WriteLine("Choose:\nAdd, Show, Search, Stat, Exit:");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "Add":
                        {
                            Console.Write("Enter new element: ");
                            int newValue = int.Parse(Console.ReadLine());
                            array = array.Append(newValue).ToArray();
                            break;
                        }
                    case "Show":
                        {
                            Console.WriteLine("Elements in array:");
                            for (int i = 0; i < array.Length; i++)
                            {
                                Console.Write(array[i] + "\t");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case "Search":
                        {
                            Console.Write("Enter element to search: ");
                            int searchValue = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is element in array: " + array.Contains(searchValue));
                            break;
                        }
                    case "Stat":
                        {
                            Console.WriteLine("Amount of elements in array: " + array.Length);
                            Console.WriteLine("Sum of elements in array: " + array.Sum());
                            Console.WriteLine("Average value in array: " + array.Average());
                            Console.WriteLine("Max value: " + array.Max() + ". Min value: " + array.Min());
                            break;
                        }
                    case "Exit":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Please choose correctly!");
                            break;
                        }
                }
            }
        }

        static void Circum()
        {
            double x, y;
            double radius;

            for (int i = 0; i < 360; i += 5)
            {
                radius = i * Math.PI / 180.0;

                x = 35 + 8 * Math.Cos(radius);
                y = 10 + 8 * Math.Sin(radius);

                Console.SetCursorPosition((int)x, (int)y);
                Console.Write("X");
            }

            Console.SetCursorPosition(1, 20);
        }

        static void ModifyCharecter(ref string str, char modifyChar, int position)
        {
            /*Console.WriteLine("Enter string to edit:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter char to edit: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine("\nEnter position to edit: ");
            int position;
            while (!int.TryParse(Console.ReadLine(), out position))
            {
                Console.WriteLine(position + " isn`t integer!");
            }
            ModifyCharecter(ref str, symbol, position);
            Console.WriteLine("New string: " + str);*/

            str = str.Remove(position);
            str = str.Insert(position, modifyChar.ToString());
        }

        static void AddDigits(string str)
        {
            /*Console.WriteLine("Enter string of numbers:");
            AddDigits(Console.ReadLine());*/

            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += int.Parse(str[i].ToString());
            }
            Console.WriteLine("Sum of numbers in string: " + sum);
        }

        static void InvertString(string str)
        {
            /*Console.WriteLine("Enter string to invert:");
            InvertString(Console.ReadLine());*/

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }

        static void SearchGreatestValue(int[] arr)
        {
            /*Console.WriteLine("Enter array size:");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine(size + " isn`t integer!");
            }
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
            }
            SearchGreatestValue(array);*/

            Console.WriteLine("Max value in array: " + arr.Max());
        }

        static void Power(int value, int power)
        {
            /*Console.WriteLine("Enter value to power:");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(value + " isn`t integer!");
            }
            Console.WriteLine("Enter power:");
            int power;
            while (!int.TryParse(Console.ReadLine(), out power))
            {
                Console.WriteLine(power + " isn`t integer!");
            }
            Power(value, power);*/

            Console.WriteLine("Value: {0} in power: {1} = {2}", value, power, Math.Pow(value, power));
        }

        static void WriteTitle(string str)
        {
            /*Console.WriteLine("Enter string for tiile format:");
            WriteTitle(Console.ReadLine());*/

            for (int i = 0; i < str.Length * 2 - 1; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(char.ToUpper(str[i]) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < str.Length * 2 - 1; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void CountSpaces(string str)
        {
            /*Console.WriteLine("Enter string to count spaces:");
            CountSpaces(Console.ReadLine());*/

            Console.WriteLine("Count of space in sentences: " + str.Where(i => i == ' ').Count());
        }

        static void WriteCenteredUnderline(string str)
        {
            /*Console.WriteLine("Enter string to write format text:");
            WriteCenteredUnderline(Console.ReadLine());*/

            for (int i = 0; i < 80 - str.Length; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(str);
            for (int i = 0; i < 80 - str.Length; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void AddNumbers(int[] array)
        {
            /*Console.WriteLine("Enter array size:");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine(size + " isn`t integer!");
            }
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
            }
            AddNumbers(array);*/

            Console.WriteLine("Sum of arrays: " + array.Sum());
        }

        static void DoubleValue(int value)
        {
            /*Console.WriteLine("Enter value to double:");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(value + " isn`t integer!");
            }
            DoubleValue(value);*/

            Console.WriteLine("Doubled value: " + value * 2);
        }

        static void DoubleValueRef(ref int value)
        {
            /*Console.WriteLine("Enter value to double:");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(value + " isn`t integer!");
            }
            DoubleValueRef(ref value);
            Console.WriteLine("Doubled value in main: " + value);*/

            Console.WriteLine("Doubled value in function: " + value * 2);
            value *= 2;
        }

        static void SwapValues(ref int firstValue, ref int secondValue)
        {
            /*int firstValue, secondValue;
            Console.WriteLine("Enter first value:");
            while (!int.TryParse(Console.ReadLine(), out firstValue))
            {
                Console.WriteLine(firstValue + " isn`t integer!");
            }
            Console.WriteLine("Enter second value:");
            while (!int.TryParse(Console.ReadLine(), out secondValue))
            {
                Console.WriteLine(secondValue + " isn`t integer!");
            }
            SwapValues(ref firstValue, ref secondValue);
            Console.WriteLine("First value: {0}, second value: {1}", firstValue, secondValue);*/

            int temp = secondValue;
            secondValue = firstValue;
            firstValue = temp;
        }

        static void IsAlphabetic(string str)
        {
            /*Console.WriteLine("Enter string to check for alphabet:");
            IsAlphabetic(Console.ReadLine());*/

            Console.WriteLine("Count of unletters: " + str.Where(i => !char.IsLetter(i)).Count());
        }

        static void IsNumber(string str)
        {
            /*Console.WriteLine("Enter string to check for numbers:");
            IsNumber(Console.ReadLine());*/

            Console.WriteLine("Count of unnumbers: " + str.Where(i => !char.IsDigit(i)).Count());
        }

        static void Calculator(int firstValue, int secondValue, char symbolAction)
        {
            /*int firstValue = int.Parse(args[0]);
            char symbolAction = char.Parse(args[1]);
            int secondValue = int.Parse(args[2]);

            Calculator(firstValue, secondValue, symbolAction);*/

            switch (symbolAction)
            {
                case '+':
                    {
                        Console.WriteLine("Sum: " + (firstValue + secondValue));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("Difference: " + (firstValue - secondValue));
                        break;
                    }
                case 'x':
                case 'X':
                case '*':
                    {
                        Console.WriteLine("Multiple: " + (firstValue * secondValue));
                        break;
                    }
                case '/':
                    {
                        if (secondValue == 0)
                        {
                            Console.WriteLine("Can`t divide by 0!");
                        }
                        else
                        {
                            Console.WriteLine("Divide: " + (firstValue / secondValue));
                        }
                        break;
                    }
                default:
                    Console.WriteLine("{0} isn`t action!", symbolAction);
                    break;
            }
        }

        static int CalculatorReturnMain(int firstValue, int secondValue, char symbolAction)
        {
            /*if (args.Length != 3)
            {
                return 1;
            }
            int firstValue, secondValue;
            char symbolAction;
            if (!int.TryParse(args[0], out firstValue) || !int.TryParse(args[2], out secondValue))
            {
                return 3;
            }
            if (!char.TryParse(args[1], out symbolAction))
            {
                return 2;
            }

            if (CalculatorReturnMain(firstValue, secondValue, symbolAction) == 2)
            {
                return 2;
            }

            return 0;*/

            switch (symbolAction)
            {
                case '+':
                    {
                        Console.WriteLine("Sum: " + (firstValue + secondValue));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("Difference: " + (firstValue - secondValue));
                        break;
                    }
                case 'x':
                case 'X':
                case '*':
                    {
                        Console.WriteLine("Multiple: " + (firstValue * secondValue));
                        break;
                    }
                case '/':
                    {
                        if (secondValue == 0)
                        {
                            Console.WriteLine("Can`t divide by 0!");
                        }
                        else
                        {
                            Console.WriteLine("Divide: " + (firstValue / secondValue));
                        }
                        break;
                    }
                default:
                    Console.WriteLine("{0} isn`t action!", symbolAction);
                    return 2;
            }
            return 0;
        }

        static void FindMinMax(double[] arr, out double maxValue, out double minValue)
        {
            /*Console.WriteLine("Enter array size:");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine(size + " isn`t integer!");
            }
            double[] array = new double[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }
            double maxValue, minValue;
            FindMinMax(array, out maxValue, out minValue);
            Console.WriteLine("Max value: {0}, min value: {1}", maxValue, minValue);*/

            maxValue = arr.Max();
            minValue = arr.Min();
        }

        static void Palindrome(string str)
        {
            /*Console.WriteLine("Enter string to check for palindrome:");
            Palindrome(Console.ReadLine());*/

            char[] arr = str.ToCharArray();
            arr.Reverse();
            if (str.Equals(new string(arr)))
            {
                Console.WriteLine("{0} is palindrome", str);
            }
            else
            {
                Console.WriteLine("{0} isn`t palindrome", str);
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
