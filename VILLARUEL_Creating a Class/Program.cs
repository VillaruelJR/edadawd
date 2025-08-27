using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VILLARUEL_John123
{
   public class person
    {
        //PERSON1
        public string Name;
        public int Age;
        public string gender;
       
        //PERSON2
        public string Name2;
        public int Age2;
        public string gender2;   

        //PERSON3
        public string Name3;
        public int Age3;
        public string gender3;


        public void Greeting()
        {
            Console.Write("Person1: Hi, GoodMorning My name is " + Name + " and I am " + Age + " Years old" + ", My Gender is " + gender);
            Console.WriteLine();
        }
        public void Greeting2()
        {
            Console.Write("Person2: Hi, GoodAfternoon my name is " + Name2 + " and I am " + Age2 + " Years old" + ", My Gender is " + gender2);
            Console.WriteLine();
        }
        public void Greeting3()
        {
            Console.Write("Person3: Hi, GoodEvening my name is " + Name3 + " and I am " + Age3 + " Years old" + ", My Gender is " + gender3);
            Console.WriteLine();
        }


    class Program
    {
            static void Main(string[] args)
            {
                person person = new person();
                person.Name = "JOHN ROBERT";
                person.Age = 25;
                person.gender = "Male";


                person person2 = new person();
                person2.Name2 = "FRANCIS BAID";
                person2.Age2 = 20;
                person2.gender2 = "MALE";


                person person3 = new person();
                person3.Name3 = "NEIL VALENCIA";
                person3.Age3 = 22;
                person3.gender3 = "MALE";


                person.Greeting();
                Console.WriteLine();
                person2.Greeting2();
                Console.WriteLine();
                person3.Greeting3();
                Console.ReadKey();
            }
        }
    }
}

