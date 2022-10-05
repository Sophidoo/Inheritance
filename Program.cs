using Array2;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = { 3, 5, 6, 8, 10, 12 };

            int SumOfArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(i % 2 != 0)
                {
                    SumOfArray += array[i];
                } 
            }
            Console.WriteLine(SumOfArray);*/


            /*INHERITANCE BEGINS*/
            /*Employee Sophie = new Employee(102, "Sophia", "Okosodo", 105.00);
            Console.WriteLine(Sophie.firstname);*/

            /*Overtime user = new Overtime(102, "Sophia", "Okosodo", 105.00, 3);
            user.display();
            user.getPay();*/

            Lecturer lecturer = new Lecturer(01, "Mrs", "Sophia", "Okosodo", 500.00);
            lecturer.ViewDetails();

            Student student = new Student(02, "Miss", "Michelle", "Ogbuja", 11, "JSS 1");
            student.ViewDetails();

            Parent parent = new Parent("Mr", "Samuel", "Didigu", 02);
            parent.ViewDetails();

        }

       
    }

}