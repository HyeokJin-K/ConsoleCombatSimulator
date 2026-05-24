using System.Diagnostics;

namespace Console_Combat_Simulator
{
    public abstract class Character : IDamageable
    {
        public virtual string Name { get; }
        public virtual float MaxHp { get;}
        public virtual float CurrentHp { get; set; }
        public virtual float AttackPower { get; }
        public virtual int Speed { get;}
        

        public Character(string name, float maxHp, float attackPower, int speed)
        {
            Name = name;
            MaxHp = maxHp;
            CurrentHp = maxHp;
            AttackPower = attackPower;
            Speed = speed;
        }

        public virtual void TakeDamage(float attackPower)
        {
            CurrentHp -= attackPower;
            if (CurrentHp <= 0f)
            {
                Die();
            }
        }

        public virtual void DoAttack(Character target)
        {
            if (!IsAlive()) return;            

            Console.WriteLine($"{Name}이(가) {target.Name}을 공격했습니다.");

            target.TakeDamage(AttackPower);
        }
        public virtual void Die()
        {            
        }

        public bool IsAlive()
        {
            return CurrentHp > 0f ? true : false;
        }
    }
}
