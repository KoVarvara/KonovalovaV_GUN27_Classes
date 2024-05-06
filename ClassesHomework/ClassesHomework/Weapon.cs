using System;

namespace ClassesHomework
{
    public class Weapon
    {
        public string Name { get; }
 

        public Interval interval;
        private float _damage;
        public float Damage => _damage;

        public Weapon(string name)
        {
            Name = name;
        }

        public Weapon(string name, float minDamage, float maxDamage) : this(name)
        {
            interval = new Interval(minDamage, maxDamage);
            _damage = interval.Average;
        }
    }
}
