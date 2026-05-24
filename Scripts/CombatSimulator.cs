using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Combat_Simulator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Enemy enemy = new Enemy("고블린", 10f, 1f, 1);
            Player player = new Player("용사", 15f, 2f, 2);

            Console.WriteLine("전투 시뮬레이션 시작.");
            Console.WriteLine("");

            // 어느 한 개체가 죽으면 루프 종료
            //
            while (enemy.IsAlive() && player.IsAlive())
            {                
                DeclineCharaterBehaviorOrder(enemy, player);
                Console.WriteLine("");
            }

            Console.WriteLine("전투 시뮬레이션 종료.");
        }

        private static void DeclineCharaterBehaviorOrder(Character ch1, Character ch2)
        {
            if (ch1.Speed > ch2.Speed)
            {
                ch1.DoAttack(ch2);
                ch2.DoAttack(ch1);
            }
            else if (ch2.Speed > ch1.Speed)
            {
                ch2.DoAttack(ch1);
                ch1.DoAttack(ch2);
            }
            else
            {
                Random rnd = new Random();
                int rndValue = rnd.Next(0, 2);

                if(rndValue == 0)
                {
                    ch1.DoAttack(ch2);
                    ch2.DoAttack(ch1);
                }
                else
                {
                    ch2.DoAttack(ch1);
                    ch1.DoAttack(ch2);
                }
            }
        }
    }
}
