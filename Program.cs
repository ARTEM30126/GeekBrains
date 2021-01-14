using System;

class Program
{
    static void Main(string[] args)
    {
        #region Неверно
            //
            //FirstQuestion();
            //SecondQuestion();
            #endregion
        #region Верно
            Question("Как дела?", "Круто,что у вас все ");
            Question("Какой сегодня день?", "Точно! Сегодня ");
            #endregion
        Console.ReadLine();
    }
    #region Неверно
        static void FirstQuestion()
        {
            Console.WriteLine("Какой сегодня день недели?");
            string useranswer = Console.ReadLine();
            Console.Write("Точно! Сегодня " + useranswer.ToLower());
        }
        static void SecondQuestion()
        {
            Console.WriteLine("\n\nКакой месяц сейчас идет?");
            string useranswer = Console.ReadLine();
            Console.Write("Точно! Сейчас " + useranswer.ToLower());
        }
        #endregion
    #region Верно
        static void Question(string quest,string program_answer) 
        {
            
            Console.WriteLine($"\n{quest}");
            Console.WriteLine(program_answer + Console.ReadLine().ToLower());
        }
        #endregion
}

