using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        // Beispiel Animal mit Interface
        static void Main(string[] args)
        {
            Dog doggy = new Dog("Doggy");
            doggy.Describe();
        }
        interface IAnimal
        {
            // werden Propertys und Methoden definiert
            string Describe();

            string Name
            {
                get;
                set;
            }
        }

        class Dog : IAnimal
        {
            private string name;

            public Dog(string name)
            {
                this.Name = name;
            }
            // hier werden die Methoden und Propertys implementierts
            public string Describe()
            {
                return "Hello, I'm a dog and my name is " + this.Name;
            }

            public int CompareTo(object obj)
            {
                if (obj is IAnimal)
                    return this.Name.CompareTo((obj as IAnimal).Name);
                return 0;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        // Beispiel Erstellung eines Interface
        interface ISampleInterface
        {
            void SampleMethod();
        }

        class ImplementationClass : ISampleInterface
        {
            // Explicit interface member implementation:
            public void SampleMethod()
            {
                // Method implementation.
            }
        }
    }
}
