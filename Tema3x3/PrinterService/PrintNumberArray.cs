using System;
using System.Collections.Generic;
using System.Linq;
using Tema3x3.BaseComponents;
using Tema3x3.ConcreteComponents.Numbers;
using Tema3x3.Helpers;

namespace Tema3x3.PrinterService
{
    public class PrintNumberArray : IDisplayable
    {
        private static List<int> intList = new List<int>();

        public void Print(string userInput)
        {
            string[,] array = BuildArray(userInput);
            PrintArray(array);
        }

        public bool VerifyInput(string userInput)
        {
            bool isNumber = true;
            foreach (var val in userInput.ToCharArray())
            {
                int response = Convert.ToInt32(Char.GetNumericValue(val));

                if (response != -1) intList.Add(response);
                else
                {
                    isNumber = false;
                    break;
                }
            }
            return isNumber;
        }

        public string[,] BuildArray(string userInput)
        {
            if (VerifyInput(userInput))
            {
                string[,] array2D = new string[intList.Count, 3];

                for (int i = 0; i <= intList.Count - 1; i++)
                {
                    switch (intList[i]) 
                    {
                        case 0:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.Zero));
                            break;
                        case 1:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.One));
                            break;
                        case 2:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.Two));
                            break;
                        case 3:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.Three));
                            break;
                        case 4:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.Four));
                            break;
                        case 5:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.Five));
                            break;
                        case 6:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.Six));
                            break;
                        case 7:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.Seven));
                            break;
                        case 8:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.Eight));
                            break;
                        case 9:
                            WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(NumberCacheStorage.Number.Nine));
                            break;
                    }
                }
                return array2D;
            }

            Console.WriteLine($"{userInput} is not a valid integer");
            return new string[,] { };
        }

        private void WriteNode(string[,] array2D, int i, RepresentationBase representation)
        {
            for (int j = 0; j <= 2; j++)
            {
                if (j == 0) array2D[i, j] = representation.Head;
                else if (j == 1) array2D[i, j] = representation.Body;
                else array2D[i, j] = representation.Footer;
            }
        }

        private void PrintArray(string[,] array)
        {
            if (array.Length == 0) return;

            if (intList.Count.Equals(1))
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(array[0, i]);
                    Console.Write("\n");
                }
            }

            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j <= intList.Count - 1; j++)
                    {
                        Console.Write(array[j, i]);

                    }
                    Console.Write("\n");
                }
            }
        }
    }
}