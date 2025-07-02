using System;
using System.Collections.Generic;

//Создание класса о данных о человеке
public class Program { 
    public double Height { get; set; } 
    public int Age { get; set; }       
    public double Weight { get; set; } 

    public static List<Program> AllChelovek = new List<Program>();

    public Program(double height, int age, double weight)
    {
        Height = height;
        Age = age;
        Weight = weight;
        AllChelovek.Add(this);
    }
    //Рассчёт Q исходя из данной по заданию формулы
    public virtual double CalculateQ()
    {
        return (Height * 1.8) - (Age * 4.7) + (Weight * 9.6) + 1255;
    }
    //Вывод информации о человеке в консоль
    public void Print()
    {
        Console.WriteLine($"Рост: {Height} см, Возраст: {Age}, Вес: {Weight} кг, Q: {CalculateQ():F2}");
    }
    //Удаление людей
    public static void RemoveHumans(params Program[] humans)
    {
        foreach (var h in humans)
        {
            AllChelovek.Remove(h);
        }
    }
}

