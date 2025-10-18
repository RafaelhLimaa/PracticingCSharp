namespace PracticingCSharp
{
    internal class GradesClassification
    {
        public void Classify()
        {
            Console.WriteLine("Let's classify the student by your grades!");
            Console.WriteLine("Please, Enter the medium grade of the year!");
            _ = decimal.TryParse(Console.ReadLine(), out decimal grade);

            if (grade >= 9)
            {
                Console.WriteLine("Your final grade is 'A'. You are aproved with the best grade!!"); 
            }
            else if (grade >= 7 && grade < 9)
            {
                Console.WriteLine("Your final grade is 'B'. You are aproved with a medium grade!!");
            }
            else if (grade >= 5  && grade < 7)
            {
                Console.WriteLine("Your final grade is 'C'. You need to study more and do the exams again!!");
            }
            else
            {
                Console.WriteLine("Your final grade is 'D'. You are reproved, you need to repeat the year!!");
            }
        }
    }
}
