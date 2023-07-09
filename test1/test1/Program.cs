﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Enemy
    {
        public int Id;
        public string Name;
        public double Health;
        public double MinDamage;
        public double MaxDamage;
        public List<double> damageArray=new List<double>();
        public static double calculateDamage(List<double> damageArray)
        {
            Random a = new Random();
            Orderup(damageArray);
            return (a.Next(Convert.ToInt32(Max(damageArray)),
                Convert.ToInt32(Min(damageArray)))*1.0+a.NextDouble());
        }
    }
    public static void Orderup(List<double> damageArray)
    {
        for (int i = 0; i < damageArray.Count(); i++)
            {
                for (int j = i; j < damageArray.Count()-1; i++)
                {
                    if (damageArray[j] > damageArray[j + 1])
                        (damageArray[j], damageArray[j + 1])
                        = (damageArray[j + 1], damageArray[j]);
                }
            }
    }
    public static double Max(List<double> damageArray)
    {
        int max=new int();
        max=damageArray[0];
      for (int i = 1; i < damageArray.Count(); i++)
            {
               if(damageArray[i]>max)
               max=damageArray[i];
            }
            return max;
    }
    public static double Min(List<double> damageArray)
    {
        int min=new int();
        min=damageArray[0];
      for (int i = 1; i < damageArray.Count(); i++)
            {
               if(damageArray[i]>min)
               min=damageArray[i];
            }
            return min;
    }

    class TestEnemy
    {
        public static void InputInfo(List<Enemy> enemy)
        {
            Console.WriteLine("Enter the number of enemies:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                try
                {   Enemy enemy1 = new Enemy();
                    Console.WriteLine("Enter id:");
                    enemy1.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name:");
                    enemy1.Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter health:");
                    enemy1.Health = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter number of damages:");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < number1; j++)
                    {
                        Console.WriteLine("Enter damage:");
                        var damage = Convert.ToDouble(Console.ReadLine());
                        enemy1.damageArray.Add(damage) ;
                    }
                    List<double> damageArray1 = new List<double>();

                    enemy1.MinDamage = Min(damageArray1);
                    enemy1.MaxDamage = Max(damageArray1);

                    if (enemy1.Name != "" &&
                        enemy1.MinDamage < enemy1.MaxDamage &&
                        enemy1.MinDamage > 0 &&
                        enemy1.MaxDamage < 100)
                    { enemy.Add(enemy1); }
                    else { Console.WriteLine("Wrong Input!"); }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void SearchEnemyName(List<Enemy> enemy)
        {
            Console.WriteLine("Enter name:");
            string name = Convert.ToString(Console.ReadLine());
            foreach (var a in enemy)
            {
                if (a.Name == name)
                    Console.WriteLine
                        (
                        "Id:" + a.Id + " " +
                        "Name:" + a.Name + " " +
                        "Health:" + a.Health + " " +
                        "Mindamage:" + a.MinDamage + " " +
                        "Maxdamage:" + a.MaxDamage + " "
                        );
                foreach (var b in a.damageArray)
                {
                    Console.Write("Damage:" + b + " ");
                }
            }
        }
        public static void ChangeEnemyInfo(List<Enemy> enemy)
        {
            Console.WriteLine("Choose what you want to change:Id(1),Name(2),Health(3),damageArray(4)");
            int choose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter old one:");
            var oldone = Console.ReadLine();
            Console.WriteLine("Enter new one:");
            var newone = Console.ReadLine();
            if (choose == 1)
            {
                foreach (var a in enemy)
                {
                    if (Convert.ToInt32(oldone) == a.Id)
                    {
                        a.Id = Convert.ToInt32(newone);
                        Console.WriteLine("Success");
                    }
                }
            }
            if (choose == 2)
            {
                foreach (var a in enemy)
                {
                    if (Convert.ToString(oldone) == a.Name)
                    {
                        a.Name = Convert.ToString(newone);
                        Console.WriteLine("Success");
                    }
                }
            }
            if (choose == 3)
            {
                foreach (var a in enemy)
                {
                    if (Convert.ToDouble(oldone) == a.Health)
                    {
                        a.Health = Convert.ToDouble(newone);
                        Console.WriteLine("Success");
                    }
                }
            }
            if (choose == 4)
            {
                for(int j = 0; j < enemy.Count(); j++) 
                { 
                for (int i = 0; i < enemy[j].damageArray.Count(); i++)
                {
                    if (Convert.ToDouble(oldone) == enemy[i].damageArray[i])
                    {
                        enemy[i].damageArray[i] = Convert.ToDouble(newone);
                        Console.WriteLine("Success");
                    }
                }
                }
            }
        }
        public static void Display(List<Enemy> enemy)
        {
            if (enemy.Count == 0)
            {
                Console.WriteLine("No enemy");
            }
            else
            {
                for(int i=0;i<enemy.Count();i++)
                {
                    Console.WriteLine
                            (
                            "Id:" + enemy[i].Id + " " +
                            "Name:" + enemy[i].Name + " " +
                            "Health:" + enemy[i].Health + " " +
                            "Mindamage:" + enemy[i].MinDamage + " " +
                            "Maxdamage:" + enemy[i].MaxDamage + " "
                            );
                    foreach (var b in enemy[i].damageArray)
                    {
                        Console.Write("Damage:" + b + " ");
                    }
                    Console.WriteLine("");
                }
            }
        }
        public static void DeleteInfo(List<Enemy> enemy)
        {
            Console.WriteLine("Enter enemy's id:");
            int id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < enemy.Count; i++)
            {
                if (enemy[i].Id == id)
                {
                    enemy.Remove(enemy[i]);
                    Console.WriteLine("Success");
                }
            }
        }
        public static void AscendingDamageAVG(List<Enemy> enemy)
        {
            List<double> damageAVG = new List<double>();
            double totaldamage = new double();

            for(int i=0;i<enemy.Count();i++)
            {
                for(int j=0;j<enemy[i].damageArray.Count();j++)
                {
                    totaldamage = totaldamage + enemy[i].damageArray[j];
                }
                damageAVG.Add((totaldamage / enemy[i].damageArray.Count()));
            }

            Enemy subenemy = new Enemy();

            for(int i=0;i<enemy.Count();i++)
            { 
                for(int j=i;j<enemy.Count()-1;j++)
                {
                    if (damageAVG[j] > damageAVG[j + 1])
                    {
                        (damageAVG[j], damageAVG[j + 1]) = (damageAVG[j + 1], damageAVG[j]);
                        subenemy = enemy[j+1];
                        enemy[j + 1] = enemy[j];
                        enemy[j] = subenemy;
                    }
                }
            }
            TestEnemy.Display(enemy);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Nhập thông tin Enemy.");
            Console.WriteLine("2. Sắp xếp danh sách Enemy theo sát thương trung bình.");
            Console.WriteLine("3. Hiển thị tất cả các Enemy.");
            Console.WriteLine("4. Tìm kiếm Enemy theo tên.");
            Console.WriteLine("5. Xoá Enemy theo Id.");
            Console.WriteLine("6. Thoát chương trình.");
            /*Console.WriteLine("7.Change enemy's information:");*/
            List<Enemy> enemy = new List<Enemy>();
            List<double> damageArray = new List<double>();
            if (1 > 0)
            {
            Label: Console.WriteLine("Option:");
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                    TestEnemy.InputInfo(enemy);
                    goto Label;
                }
                if (choose == 2)
                {
                    TestEnemy.AscendingDamageAVG(enemy);
                    goto Label;
                }
                if (choose == 3)
                {
                    TestEnemy.Display(enemy);
                    goto Label;
                }
                if (choose == 4)
                {
                    TestEnemy.SearchEnemyName(enemy);
                    goto Label;
                }
                if (choose == 5)
                {
                    TestEnemy.DeleteInfo(enemy);
                    goto Label;
                }
                if (choose == 6)
                {
                    Console.WriteLine("Exit program.");
                }
                /*if (choose == 7)
                {
                    TestEnemy.ChangeEnemyInfo(enemy);
                    goto Label;
                }*/

            }
        }
    }
}
