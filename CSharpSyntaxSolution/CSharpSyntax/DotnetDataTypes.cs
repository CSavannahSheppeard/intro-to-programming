using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    public class DotnetDataTypes
    {
        [Fact]

        public void AliasesToTypes()
        {
            // Type Identifier [initializer]
            int age = 3;
            Int32 yourAge = 30;

            string myName = "Savannah";
            String yourName = "Sue";

            Assert.Equal(12, age);
        }

        [Fact]
        public void SomeExampleLiterals()
        {
            int age = 22;
            double pay = 3.144;
            decimal yourPay = 21.01M;

            string myName = "Savannah"; string story = "Chapter 1\n It was a dark stormy night\t\t";
            string configFile = "c:\\testdata\\newstuff\\demo";        // verbatim string        
            string configFile2 = @"c:\testdata\newstuff\demo";
            Assert.Equal(configFile, configFile2);

            string story2 = @"Chapter 1

It was          DARK AND STORMY NIGHT. His name was ""Tiger""";

            string aboutMe = "The name is " + myName + " And the age is " + age;
            Assert.Equal("The name is Savannah And the age is 22", aboutMe);

            string aboutMe2 = string.Format("The name is {0} And the Age is {1}", myName, age);
            Assert.Equal("The name is Savannah And the Age is 22", aboutMe2);

            string aboutMe3 = $"The name is {myName} And the Age is {age}";
            Assert.Equal("The name is Savannah And the Age is 22", aboutMe3);

            decimal hourlyRate = 123.45M;

            Assert.Equal("My pay is $123.45", $"My pay is {hourlyRate:c}");
        }

        [Fact]

        public void Chars()
        {
            char mi = 'M';
        }

        [Fact]

        public void ImplictlyTypedLocalVariables()
        {
            //implictly typed variable
            var myAge = 22; // MUST initialize it

            var yourPet = newDog();
            Dog myPet = new();
            //myAge = "old"
    
        }

        public class Dog
        {
            
        }
    }
}


