using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagementSystem
{
 
        public delegate void ActionDelegate();
        class Club<T> : IEnumerable<T> where T : IPlayer
        {
            event ActionDelegate AttackEvent;
            event ActionDelegate DefenseEvent;
            public Dictionary<int, T> PlayerList = new Dictionary<int, T>();

            public void Add(T t)
            {
                Console.Write("Input name: ");
                t.Name = Console.ReadLine();
                while (true)
                {
                    Console.Write("Input age: ");
                    try
                    {
                        t.Age = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex) { Console.WriteLine("Wrong format!"); }
                }
                while (true)
                {
                    Console.Write("Input attack: ");
                    try
                    {
                        t.Attack = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex) { Console.WriteLine("Wrong format!"); }
                }
                while (true)
                {
                    Console.Write("Input defense: ");
                    try
                    {
                        t.Defense = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex) { Console.WriteLine("Wrong format!"); }
                }
                while (true)
                {
                    Console.Write("Input stamina: ");
                    try
                    {
                        t.Stamina = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex) { Console.WriteLine("Wrong format!"); }
                }
                while (true)
                {
                    Console.Write("Input speed: ");
                    try
                    {
                        t.Speed = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex) { Console.WriteLine("Wrong format!"); }
                }
                while (true)
                {
                    Console.Write("Input power: ");
                    try
                    {
                        t.Power = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex) { Console.WriteLine("Wrong format!"); }
                }
                PlayerList.Add(PlayerList.Count + 1, t);
                float avePoint = (t.Attack + t.Defense + t.Power + t.Speed + t.Stamina) / 5.0f;
                if (avePoint >= 80)
                {
                    AttackEvent += new ActionDelegate(t.GetInfo);
                }
                else if (60 <= avePoint && avePoint < 80)
                {
                    DefenseEvent += new ActionDelegate(t.GetInfo);
                }
            }

            public IEnumerator<T> GetEnumerator()
            {
                foreach (T t in PlayerList.Values)
                {
                    yield return t;
                }
            }

        public void RaiseAttackEvent()
            {
                if (AttackEvent != null)
                {
                    AttackEvent();
                }
                else
                {
                    Console.WriteLine("No players");
                }
            }

            public void RaiseDefenseEvent()
            {
                if (DefenseEvent != null)
                {
                    DefenseEvent();
                }
                else
                {
                    Console.WriteLine("No players");
                }
            }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    }

