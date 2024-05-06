using System;
using System.Collections.Generic;

namespace ClassesHomework
{
    public class Combat
    {
        List<Rate> rateList;
        public Combat()
        {
            rateList = new List<Rate>();
        }

        public void StartCombat(Unit unit1, Unit unit2)
        {
            var rand = new Random();
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                var number = rand.Next(1, 10);
                if (number % 2 == 0)
                {
                    unit1.SetDamage(unit2.Damage);
                    var attack = new Rate(ref unit2, (int)unit2.Damage, unit1.Health);
                    rateList.Add(attack);
                }
                else
                {
                    unit2.SetDamage(unit1.Damage);
                    var attack = new Rate(ref unit1, (int)unit1.Damage, unit2.Health);
                    rateList.Add(attack);
                }
            }
        }

        public void ShowResults()
        {
            for (int i = 0; i < rateList.Count; i++)
            {
                Console.WriteLine("Боец {0} нанес урон {1} и оставил {2} здоровья", rateList[i].DamagingUnit.Name, rateList[i].Damage, rateList[i].Health);
            }
            Console.ReadLine();
        }
    }
}
