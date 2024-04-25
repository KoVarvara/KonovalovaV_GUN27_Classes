using System;

namespace ClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подготовка к бою:");
            Console.WriteLine("Введите имя бойца:");
            string name = Console.ReadLine();
            

            Console.WriteLine("Введите начальное здоровье бойца (10-100):");
            Int32.TryParse(Console.ReadLine(), out int startHealth);

            Console.WriteLine("Введите значение брони шлема от 0 до 1:");
            var helm = new Helm();
            float.TryParse(Console.ReadLine(), out float helmArmor);
            helm.Armor = helmArmor;

            Console.WriteLine("Введите значение брони кирасы от 0 до 1:");
            var shell = new Shell();
            float.TryParse(Console.ReadLine(), out float shellArmor);
            shell.Armor = shellArmor;

            Console.WriteLine("Введите значение брони сапог от 0 до 1:");
            var boots = new Boots();
            float.TryParse(Console.ReadLine(), out float bootsArmor);
            boots.Armor = bootsArmor;

            Console.WriteLine("Введите название оружия");
            string weaponName = Console.ReadLine();

            Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            float.TryParse(Console.ReadLine(), out float min);

            Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            float.TryParse(Console.ReadLine(), out float max);

            var weapon = new Weapon(weaponName, min, max);
            Console.WriteLine(weapon.GetDamage());
            

            var unit = new Unit(name, startHealth);
            unit.EquipWeapon(weapon);
            unit.EquipBoots(boots);
            unit.EquipHelm(helm);
            unit.EquipShell(shell);

            Console.WriteLine("Общий показатель брони равен: " + unit.Armor);
            Console.WriteLine("Фактическое значение здоровья равно: " + unit.RealHealth());

            Console.ReadLine();

        }
    }
}
