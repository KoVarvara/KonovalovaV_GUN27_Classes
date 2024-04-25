using System;

namespace ClassesHomework
{
    public class Weapon
    {
        public string Name { get; }
        public float MinDamage { get; private set; }
        public float MaxDamage { get; private set; }

        public float Damage { get; private set; }

        public Weapon(string name)
        {
            Name = name;
        }

        public Weapon(string name, float minDamage, float maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }

        public void SetDamageParams(float minDamage, float maxDamage)
        {
            if (minDamage > maxDamage)
            {
                MinDamage = maxDamage;
                MaxDamage = minDamage;
                Console.WriteLine("Минимальное значение должно быть меньше максимального");
            }

            if (minDamage < 1f)
            {
                minDamage = 1f;
                Console.WriteLine("Минимальное значение должно быть не меньше 1");
            }

            if (maxDamage <= 1f)
            {
                maxDamage = 10f;
                Console.WriteLine("Максимальное значение урона не должно быть меньше или равно 1");
            }
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public float GetDamage()
        {
            Damage = (MinDamage + MaxDamage) / 2f;
            return Damage;
        }
    }
}
