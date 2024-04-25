using System;

namespace ClassesHomework
{
    public class Helm
    {
        public string Name { get; }

        private float armor;
        public float Armor
        {
            get { return armor; }
            set
            {
                if (value < 0f)
                {
                    armor = 0f;
                    Console.WriteLine("Некорректно задан показатель брони, значение составляет " + armor);
                }
                else if (value > 1f)
                {
                    armor = 1f;
                    Console.WriteLine("Некорректно задан показатель брони, значение составляет " + armor);
                }
                else
                {
                    armor = value;
                }
            }
        }

        public Helm(string name)
        {
            Name = name;
        }

        public Helm() : this("Helm")
        {

        }
    }

    public class Shell
    {
        public string Name { get; }
        private float armor;
        public float Armor
        {
            get { return armor; }
            set
            {
                if (value < 0f)
                {
                    armor = 0f;
                    Console.WriteLine("Некорректно задан показатель брони, значение составляет " + armor);
                }
                else if (value > 1f)
                {
                    armor = 1f;
                    Console.WriteLine("Некорректно задан показатель брони, значение составляет " + armor);
                }
                else
                {
                    armor = value;
                }
            }
        }

        public Shell(string name)
        {
            Name = name;
        }

        public Shell(): this("Shell")
        {

        }
    }

    public class Boots
    {
        public string Name { get; }
        private float armor;
        public float Armor
        {
            get { return armor; }
            set
            {
                if (value < 0f)
                {
                    armor = 0f;
                    Console.WriteLine("Некорректно задан показатель брони, значение составляет " + armor);
                }
                else if (value > 1f)
                {
                    armor = 1f;
                    Console.WriteLine("Некорректно задан показатель брони, значение составляет " + armor);
                }
                else
                {
                    armor = value;
                }
            }
        }

        public Boots(string name)
        {
            Name = name;
        }

        public Boots() : this("Boots")
        {

        }
    }
}
