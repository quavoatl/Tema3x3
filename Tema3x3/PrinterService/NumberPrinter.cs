using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tema3x3.BaseComponents;
using Tema3x3.ConcreteComponents.CachingService;
using Tema3x3.Helpers;

namespace Tema3x3.PrinterService
{
    public class NumberPrinter : IDisplayable
    {
        private List<int> intList = new List<int>();

        private Dictionary<int, NumberCacheStorage.Number> _intDictionary =
            new Dictionary<int, NumberCacheStorage.Number>()
            {
                {0, NumberCacheStorage.Number.Zero},
                {1, NumberCacheStorage.Number.One},
                {2, NumberCacheStorage.Number.Two},
                {3, NumberCacheStorage.Number.Three},
                {4, NumberCacheStorage.Number.Four},
                {5, NumberCacheStorage.Number.Five},
                {6, NumberCacheStorage.Number.Six},
                {7, NumberCacheStorage.Number.Seven},
                {8, NumberCacheStorage.Number.Eight},
                {9, NumberCacheStorage.Number.Nine},
            };

        public string GetRepresentation(string userInput)
        {
            string[,] array = BuildArray(userInput);
            return ConvertArray(array);
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

        private string[,] BuildArray(string userInput)
        {
            if (VerifyInput(userInput))
            {
                string[,] array2D = new string[intList.Count, 3];

                for (int i = 0; i <= intList.Count - 1; i++)
                {
                    WriteNode(array2D, i, NumberCacheStorage.GetConcreteNumber(_intDictionary[intList[i]]));
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

        private string ConvertArray(string[,] array)
        {
            StringBuilder sb = new StringBuilder();

            if (array.Length == 0) return string.Empty;

            if (intList.Count.Equals(1))
            {
                for (int i = 0; i < 3; i++)
                {
                    sb.Append(array[0, i]);
                    sb.Append("\n");
                }
            }

            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j <= intList.Count - 1; j++)
                    {
                        sb.Append(array[j, i]);

                    }
                    sb.Append("\n");
                }
            }

            return sb.ToString();
        }
    }
}