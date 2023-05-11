using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FootballManagementSystem
{
    public delegate void ActionDelegate();

    class Club<T> : IEnumerable<T> where T : IPlayer
    {
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
        }
        public void DeletePlayer(T player)
        {
            int index = PlayerList.Values.ToList().IndexOf(player);
            if (index >= 0)
            {
                PlayerList.Remove(index + 1);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in PlayerList.Values)
            {
                yield return t;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
