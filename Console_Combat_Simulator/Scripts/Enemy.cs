using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Combat_Simulator
{
    internal class Enemy : Character
    {
        public Enemy(string name, float maxHp, float attackPower, int speed) : base(name, maxHp, attackPower, speed)
        {
        }
        public override void Die()
        {
            base.Die();

            Console.WriteLine($"{Name}이(가) 죽었습니다.");
            Console.WriteLine($"플레이어 승리!");           
        }

        public override void DoAttack(Character target)
        {
            base.DoAttack(target);
        }

        public override void TakeDamage(float attackPower)
        {
            Console.WriteLine($"{Name}에게 {AttackPower} 피해를 입혔습니다.");
            base.TakeDamage(attackPower);            
        }
    }
}
