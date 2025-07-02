using System;

class Chelovek 
{
    static void Main()
    {
        Console.WriteLine("Программа расчета качества человека");

        //Добавление нескольких персон
        var person1 = new Program(175, 30, 70);
        var person2 = new Program(160, 25, 55);

       
        var person3 = new Chelovekgoal(180, 35, 80, "fit");
        var person4 = new Chelovekgoal(170, 40, 90, "fat");

       //Вывод в консоль всех выше сохданных людей
        Console.WriteLine("\nВсе люди в системе:");
        foreach (var h in Program.AllChelovek)
        {
            h.Print();
        }

        //удаление пару персонажей
        Program.RemoveHumans(person2, person4);

        //Вывод в консоль оставшихся людей после удаления
        Console.WriteLine("\nОставшиеся люди после удаления:");
        foreach (var h in Program.AllChelovek)
        {
            h.Print();
            
        }
        //Выход из программмы
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}