using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    interface IEnemy
    {
        enum ENEMY_TYPE { GOBLIN, BOSS, ORC }
        enum ATTACK_TYPE { RANGE, MELEE }
        long Id { get; set; }
        string Name { get; set; }
        ENEMY_TYPE Type { get; set; }
        int Health { get; set; }
        ATTACK_TYPE AttackType { get; set; }
        float Damage { set; }
        void ShowInfo();
    }
}