using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShugurovAY_01_08
{
    public class Chelovekgoal : Program
    {
        public string Goal { get; set; }

        public Chelovekgoal(double height, int age, double weight, string goal)
            : base(height, age, weight)
        {
            Goal = goal;
        }
        //поиск по fit или fat и либо вычитании из формулы, лиюо добавление
        public override double CalculateQ()
        {
            double baseQ = base.CalculateQ();
            return Goal == "fit" ? baseQ - 600 : baseQ + 900;
        }
        //Вывод в консоль информацию о человеке
        public new void Print()
        {
            Console.WriteLine($"Рост: {Height} см, Возраст: {Age}, Вес: {Weight} кг, Цель: {Goal}, Q: {CalculateQ():F2}");
        }
    }
}
