using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" HERENCIA ");
            PrintPerson(new Student());

            Console.WriteLine(" STUDENTC ");
            PrintStudent(new StudentC(new Person()));

            Console.ReadKey();


    }

    public static void PrintPerson(Student student){
                
         Console.Write(student.FormatIdAndName(" John ", 9));
              }
        public static void PrintStudent(StudentC student)
        {

            Console.Write(student.FormatIdAndName(" Pablo ", 3));
        }
    }
}
