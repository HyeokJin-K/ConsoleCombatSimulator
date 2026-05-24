using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Combat_Simulator
{
    public class Player : Character
    {
        public Player(string name, float maxHp, float attackPower, int speed) : base(name, maxHp, attackPower, speed)
        {
        }

        public override void Die()
        {
            base.Die();
            Console.WriteLine($"{Name}이(가) 죽었습니다.");
            Console.WriteLine("플레이어 패배..");
        }

        public override void DoAttack(Character target)
        {
            base.DoAttack(target);
        }

        public override void TakeDamage(float attackPower)
        {
            base.TakeDamage(attackPower);
            Console.WriteLine($"{attackPower}피해를 입었습니다.");
        }
    }
}
