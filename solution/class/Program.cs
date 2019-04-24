using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {

        

        static void Main(string[] args)
        {

            Group newGroup = new Group();
            Console.WriteLine("Enter your group !");
            newGroup.setCodegroup(Console.ReadLine());
            Student newStudent = new Student();
            newStudent.setGroup(newGroup.getCodegroup());
            Console.WriteLine("Enter your name !");
            newStudent.setName(Console.ReadLine());
            Console.WriteLine("Enter your surname");
            newStudent.setSurname(Console.ReadLine());
            Console.WriteLine("Salam {0} {1}.Sizin qrupunuz: {2}", newStudent.getName(), newStudent.getSurname(), newStudent.getGroup());

            Console.ReadLine();

        }
    }


    class Group
    {
         static string codegroup;

        public string getCodegroup()
        {
            return codegroup;
        }
        public void setCodegroup(string alo)
        {
            codegroup = alo;
        }
    }


    class Student
    {
        string name;
        string surname;
        string group;


        
        public string getName()
        {
            return name;
        }
        public void setName(string Name)
        {
            name = Name;

        }
        public string getSurname()
        {
            return surname;
        }
        public void setSurname(string Surname)
        {
            surname = Surname;
        }

        public string getGroup()
        {
            return group;
        }
        public void setGroup( string CodeGroup)
        {
            group = CodeGroup;
        }


       


    }
}
