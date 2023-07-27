using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    class Enemy : IEnemy
    {
        public enum ENEMY_TYPE { GOBLIN, BOSS, ORC }
        public enum ATTACK_TYPE { RANGE, MELEE }
        public long Id { get; set; }
        public string Name { get; set; }
        public ENEMY_TYPE Type { get; set; }
        public int Health { get; set; }
        public ATTACK_TYPE AttackType { get; set; }
        public float Damage
        {
            get { return CalDamage(); }
            set { }
        }
        IEnemy.ENEMY_TYPE IEnemy.Type { get; set; }
        IEnemy.ATTACK_TYPE IEnemy.AttackType { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine(Id + ". " + Name + " - " + Type + " - " + Health + " - " + AttackType + " - " + Damage);
        }

        public Dictionary<long, float> DamageList = new Dictionary<long, float>();
        public float this[long index]
        {
            get { return DamageList[index]; }
            set { DamageList[index] = value; }
        }
        public float CalDamage()
        {
            float max = DamageList[0];
            foreach (var key in DamageList.Keys)
            { if (DamageList[key] > max) DamageList[key] = max; }
            return max;
        }
    }
}
