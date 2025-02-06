using System;
using System.Collections.Generic;

public class Program
{
    public class Friend
    {
        public string name;
        public string bd;
        public int age;
        public string nn;

        public Friend(string name, string bd, int age, string nn)
        {
            this.name = name;
            this.bd = bd;
            this.age = age;
            this.nn = nn;
        }
    }

    public static void Main(string[] args)
    {
        List<Friend> friends = new List<Friend>();

        Console.Write("SURNAME: ");
        string surname = Console.ReadLine().ToUpper();

        for (int i = 0; i < 2; i++)
        {
            try
            {
                Console.WriteLine("Person " + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine().Trim().ToUpper();
                Console.Write("Birthdate (yyyy-mm-dd): ");
                string bd = Console.ReadLine().Trim().ToUpper();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Nickname: ");
                string nn = Console.ReadLine().Trim().ToUpper();

                Console.Write("Type 0 to save: ");
                int repeat = int.Parse(Console.ReadLine());

                friends.Add(new Friend(name, bd, age, nn));
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Try again");
                i--;
            }
            Console.WriteLine();
        }


        Console.WriteLine($"CREATE DATABASE INFOMNGT_PRELIMS_TP03_{surname};");
        Console.WriteLine($"USE INFOMNGT_PRELIMS_TP03_{surname};");
        Console.WriteLine($"CREATE TABLE MY_FB_FRIENDS_{surname}(fb_friend_number INT PRIMARY KEY, " +
                          "full_name VARCHAR(50) NOT NULL, " +
                          "birth_date DATE NOT NULL, " +
                          "age_friend SMALLINT, " +
                          "nickname_friend VARCHAR(25));");

        for (int i = 0; i < friends.Count; i++)
        {
            Console.WriteLine($"INSERT INTO MY_FB_FRIENDS_{surname} " +
                              $"VALUES({i + 1}, '{friends[i].name}', '{friends[i].bd}', {friends[i].age}, '{friends[i].nn}');");
        }
    }
}
