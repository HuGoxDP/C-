﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;


namespace NwClass
{
    static class Program
    {
        static void Main(string[] args)
        {

            Adress add1 = new Adress("Ukraine", "Kherson", "ilicha", 91);
            Human one = new Human("Oleksandr", "Maidanika",Gender.Male, 18, 1.69, 70, false,"erflowE@gmail.com", Nation.Ukranian, add1);
            Human two = new Human("Alex", "Ker", Gender.Male, 19, 1.84, 100, true,"ealexE@gmail.com", Nation.Polish, new Adress("Polish", "Jahj", "Thgg", 5));
            Human three = new Human("Antony", "admant", Gender.Male, 17, 1.86, 89, false,"Antony213@gmail.com", Nation.French, new Adress("French", "Oves", "Almat", 1));
            Human four = new Human("Kiril", "Scroll", Gender.Male, 23, 1.74, 75, true,"KirScr@gmail.com", Nation.Ukranian, new Adress("Ukranian", "Oda", "Thu", 4));

            ListHuman list = new ListHuman();
            list.Add(one);
            list.Add(two);
            list.Add(three);
            list.Add(four);

            list.TextsWriter("E:\\Github_rep\\CSharp\\NwClass\\Humans.txt");
            Student st_one = new Student("Rick", "Oda", Gender.Male, 20, 1.75, 78, true,"rikota@gmail.com", Nation.French, new Adress("Frenche", "Paris", "Brokoli", 3), 241, 2500, Key.csharp);
            Student st_two = new Student("Rita", "Ora",Gender.Female, 21, 1.65, 56, true,"RitOR@gmail.com", Nation.French, new Adress("Frenche", "Paris", "Aserai", 5), 241, 3400, Key.java);
            ListStudent listStudent = new ListStudent();
            listStudent.Add(st_one);
            listStudent.Add(st_two);
			listStudent.Save_json();
            listStudent.TextsWriter("E:\\Github_rep\\CSharp\\NwClass\\Students.txt");

            ListTeacher listTeacher = new ListTeacher();
            Teacher th_one = new Teacher("Rise", "Dora",Gender.Female, 26, 1.85, 79, true,"Dorira@gmail.com", Nation.French, new Adress("Frenche", "Paris", "Sturgia", 2), 16000, "FKNFM", 2,  KeyWords.java);
            th_one.Add(st_one);
			th_one.Add(st_two);
            th_one.Show();
            listTeacher.Add(th_one);
			listTeacher.Save_json();
            listTeacher.TextsWriter("E:\\Github_rep\\CSharp\\NwClass\\Teaters.txt");

            /**Console.WriteLine("Выберите действие ");
            Console.WriteLine("1 - распечатать все объекты");
            Console.WriteLine("2 - найти объект по имени");
            Console.WriteLine("3 - средний возраст");
            Console.WriteLine("4 - сортировка по ...");
            Console.WriteLine("5 - создать новый объект и добавить в список");
            Console.WriteLine("6 - Удалить человека ");

            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    list.Show();
                    break;
                case 2:
                    Console.WriteLine("Введите имя ");
                    string name = Console.ReadLine();
                    list.FindName(name);
                    break;
                case 3:
                    list.Average_age();
                    break;
                case 4:
                    Console.WriteLine(" 1 - Возраст \n 2 - вес \n 3 - рост");
                    int ij = int.Parse(Console.ReadLine());
                    switch (ij)
                    {
                        case 1:
                            list.Age_weight_height_sort(1);
                            break;
                        case 2:
                            list.Age_weight_height_sort(2);
                            break;
                        case 3:
                            list.Age_weight_height_sort(3);
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверный номер!");
                            break;
                    }

                    break;
                case 5:
                    Human.InputInfo(list);
                    Console.WriteLine("Теперь наш список выглядит так: ");
                    list.Show();
                    break;
                case 6:
                    list.Show();
                    Console.WriteLine("\nУ Вас " + list.Counts() + " человек(а) \n Введите от 1 до " + list.Counts() + "\n");
                    list.delete(int.Parse(Console.ReadLine()));
                    list.Show();
                    break;

                default:
                    Console.WriteLine("Вы ввели неверный номер!");
                    break;
            }**/
        }
    }
}
