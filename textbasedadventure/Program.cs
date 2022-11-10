using System;
namespace tba
{
    class program
    {
        static void Main(string[] args)
        {
            string[] enemy = { "skeleton", "knight" };
            Random rand = new Random();
            int hp = 125;
            int res = 10;
            int dmg = 5;
            int ehp;
            int eres;
            int edmg;
            while (hp > 0)
            {
                switch (enemy[rand.Next(enemy.Length)])
                {
                    case "skeleton":
                        ehp = rand.Next(10, 21);
                        eres = rand.Next(5, 14);
                        edmg = rand.Next(5, 11);
                        Console.Clear();
                        while (ehp > 0 && hp > 0)
                        {
                            Console.WriteLine($"Skeleton:\nHp: {ehp}\nRes: {eres}\nDmg: {edmg}-{edmg + 5}\n\nYou:Hp: {hp}\nRes: {res}\nDmg:{dmg}");
                            Console.WriteLine("1. attack\n2. defend\n3. run");
                            int hedmg = rand.Next(edmg, edmg + 5);//wanted to show how much dmg the enemy did to u. btw i did it outside the switch-case because i't less work.
                            int cho = int.Parse(Console.ReadLine());//wanted the player to see how much dmg they did before clearing.
                            Console.Clear();//read 
                            switch (cho)//
                            {
                                case 1://ReadLine is string so i did this [:).
                                    int hdmg = rand.Next(dmg, dmg + 5);//wanted to show how much dmg u did to the enemy.
                                    ehp -= hdmg;
                                    Console.WriteLine($"You delt {hdmg} dmg to the Skeleton\n");
                                    hp-= hdmg;
                                    Console.WriteLine($"The Skeletpn delt {hedmg} dmg to you\n");
                                    break;
                                case 2://still work in progress.
                                    if (res/1.1 > hedmg)
                                    {
                                        Console.WriteLine("You doged the attack\n");
                                    }
                                    else
                                    {
                                        hp -= hedmg;
                                        Console.WriteLine($"you took {hedmg} dmg from the enemy\n");
                                    }
                                    break;
                                case 3:
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "knight":
                        break;
                    default:
                        break;

                }
                Console.WriteLine("You died dumbass");
            }
        }
    }
}
