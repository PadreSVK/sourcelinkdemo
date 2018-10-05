using System;
using System.Collections.Generic;

namespace NetStandardPackage
{
    public class MagicStandardClass
    {
        private readonly string _readOnlyField;
		private int test;

        public MagicStandardClass()
        {
            _readOnlyField = "readOnly field";
            SuperHeroName = "karol";
        }

        public int Age { get; set; }
        public string SuperHeroName { get; set; }
        public static string DoSomeMagic() => "This is magic string!";

        public static IEnumerable<int> GetFibonacciNumbersStatic()
        {
            var result = 0;
            var lastNumber = 1;
            yield return result;
            while (true)
            {
                var temp = result;
                result = lastNumber;
                lastNumber += temp;
                yield return result;
            }
        }

        public IEnumerable<int> GetFibonacciNumbers()
        {
            var result = 0;
            var lastNumber = 1;
            yield return result;
            while (true)
            {
                var temp = result;
                result = lastNumber;
                lastNumber += temp;
                yield return result;
            }
        }

        public void SomeUseFullMethod(int age, string name)
        {
            if (age < 20)
            {
                SpecialMethodWithBug();
            }
			

            var test = 5;
            var modulo = Modulo(test);

            Console.WriteLine($"Name is {name}. This is all what I know...");
            Console.WriteLine($"{nameof(SuperHeroName)} is {SuperHeroName} and age is {Age}.");
        }

        public SecondClass CreateSecondClass() 
		{ 
			test = 5;
			return new SecondClass(5);
		}
		public void DoSomethingWithSecondClass(SecondClass secondClass){
			secondClass.TestName = "changed name";
		}
		
        private int Modulo(int number) => number % 2;


        private void SpecialMethodWithBug()
        {
            throw new NotImplementedException("Patrik is too lazy to implement this feature...");
        }
    }
}