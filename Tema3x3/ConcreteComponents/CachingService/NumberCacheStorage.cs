using System;
using System.Collections.Generic;
using System.Text;
using Tema3x3.BaseComponents;
using Tema3x3.ConcreteComponents.Numbers;

namespace Tema3x3.ConcreteComponents.CachingService
{
    public class NumberCacheStorage
    {
        public enum Number
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine
        }

        private static Dictionary<Enum, RepresentationBase> _cacheStorage = new Dictionary<Enum, RepresentationBase>();

        private static void SaveToDictionary(Number numberEnum, RepresentationBase representation)
        {
            _cacheStorage[numberEnum] = representation;
        }

        private static RepresentationBase RetrieveFromDict(Number numberEnum, RepresentationBase representation)
        {
            try
            {
                return _cacheStorage[numberEnum];
            }
            catch (KeyNotFoundException)
            {
                SaveToDictionary(numberEnum, representation);
                return RetrieveFromDict(numberEnum, representation);
            }
        }

        public static RepresentationBase GetConcreteNumber(Number number)
        {
            switch (number)
            {
                case Number.Zero:
                    return RetrieveFromDict(number, Zero.GetInstance());
                case Number.One:
                    return RetrieveFromDict(number, One.GetInstance());
                case Number.Two:
                    return RetrieveFromDict(number, Two.GetInstance());
                case Number.Three:
                    return RetrieveFromDict(number, Three.GetInstance());
                case Number.Four:
                    return RetrieveFromDict(number, Four.GetInstance());
                case Number.Five:
                    return RetrieveFromDict(number, Five.GetInstance());
                case Number.Six:
                    return RetrieveFromDict(number, Six.GetInstance());
                case Number.Seven:
                    return RetrieveFromDict(number, Seven.GetInstance());
                case Number.Eight:
                    return RetrieveFromDict(number, Eight.GetInstance());
                case Number.Nine:
                    return RetrieveFromDict(number, Nine.GetInstance());

                default: return null;
            }
        }

    }

}
