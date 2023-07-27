using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    class EnemyManagementsystem
    {
        public bool IsRunning;
        public Dictionary<long, Enemy> EnemyList = new Dictionary<long, Enemy>();
        public void Input()
        {
            Enemy enemy = new Enemy();
            Console.WriteLine("Input new enemy...");
            Console.WriteLine("Input enemy Id:");
            enemy.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input enemy name:");
            enemy.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input enemy type:");
            var type = Console.ReadLine();
            enemy.Type = (Enemy.ENEMY_TYPE) Enum.Parse<IEnemy.ENEMY_TYPE>(type);
            Console.WriteLine("Input enemy health:");
            enemy.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input enemy AttackType:");
            var attacktype = Console.ReadLine();
            enemy.AttackType = (Enemy.ATTACK_TYPE)Enum.Parse<IEnemy.ATTACK_TYPE>(attacktype);
            Console.WriteLine("Input damage list count:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Input damage {0}" , i);
                float damage = Convert.ToInt32(Console.ReadLine());
                enemy.DamageList.Add(i - 1, damage);
            }
            EnemyList.Add(enemy.Id, enemy);
        }
        public void Display()
        {
            foreach (var key in EnemyList.Keys)
                EnemyList[key].ShowInfo();
        }
        public void DisplayAndCalDamage()
        {
            foreach (var key in EnemyList.Keys)
            {
                EnemyList[key].CalDamage();
                EnemyList[key].ShowInfo();
            }
        }
        public void FindEnemyById()
        {
            Console.WriteLine("Enter id:");
            long id = Convert.ToInt64(Console.ReadLine());
            if (EnemyList.ContainsKey(id))
                EnemyList[id].ShowInfo();
        }
        public void FindEnemyByHealth()
        {
            List<Enemy> EnemyList1 = new List<Enemy>();
            foreach (var key in EnemyList.Keys)
                if (EnemyList[key].Health < 50)
                    EnemyList1.Add(EnemyList[key]);
            EnemyList1.Sort((x, y) => String.Compare(x.Name, y.Name));
        }
        public void FindEnemyByDamage()
        {
            List<Enemy> EnemyList1 = new List<Enemy>();
            foreach (var key in EnemyList.Keys)
                if (EnemyList[key].Damage < 100 && EnemyList[key].Damage > 30)
                    EnemyList1.Add(EnemyList[key]);
            EnemyList1.Sort((x, y) => String.Compare(x.Name, y.Name));
        }
        public void FindEnemyByEnum()
        {
            List<Enemy> EnemyList1 = new List<Enemy>();
            foreach (var key in EnemyList.Keys)
                if (EnemyList[key].Type != Enemy.ENEMY_TYPE.BOSS && EnemyList[key].AttackType != Enemy.ATTACK_TYPE.MELEE)
                    EnemyList1.Add(EnemyList[key]);
            EnemyList1.Sort((x, y) => String.Compare(x.Name, y.Name));
        }
        public void FindEnemy()
        {
            Console.WriteLine("Enter id(1)/Health(2)/Damage(3)/Type And Attack(4)");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1) FindEnemyById();
            if (choose == 2) FindEnemyByHealth();
            if (choose == 3) FindEnemyByDamage();
            if (choose == 4) FindEnemyByEnum();
        }
        public bool QuitProgram()
        {
            Console.WriteLine("Exit.");
            IsRunning = false;
            return IsRunning;
        }
        public void Run()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1.Insert new enemy...");
            Console.WriteLine("2.Display all the enemy list...");
            Console.WriteLine("3.Calculate the enemy damage...");
            Console.WriteLine("4.Find enemy...");
            Console.WriteLine("5.Exit");
            Console.WriteLine("-------------------------------------------------------");
            Label:Console.WriteLine("Option:");
            if (1 > 0)
            {
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1) { Input(); goto Label; }
                if (choose == 2) { Display(); goto Label; }
                if (choose == 3) { DisplayAndCalDamage(); goto Label; }
                if (choose == 4) { FindEnemy(); goto Label; }
                if (choose == 5) QuitProgram();
            }
        }
    }
}
