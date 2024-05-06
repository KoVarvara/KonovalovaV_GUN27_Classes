using System;

namespace ClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подготовка к бою:");
            Console.WriteLine("Введите имя первого бойца:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Введите начальное здоровье бойца (10-100):");
            Int32.TryParse(Console.ReadLine(), out int startHealthFirst);
            if (startHealthFirst > 100)
            {
                startHealthFirst = 100;
            }
          

            Console.WriteLine("Введите значение брони шлема от 0 до 1:");
            var helm1 = new Helm();
            float.TryParse(Console.ReadLine(), out float helmArmor1);
            helm1.Armor = helmArmor1;

            Console.WriteLine("Введите значение брони кирасы от 0 до 1:");
            var shell1 = new Shell();
            float.TryParse(Console.ReadLine(), out float shellArmor1);
            shell1.Armor = shellArmor1;

            Console.WriteLine("Введите значение брони сапог от 0 до 1:");
            var boots1 = new Boots();
            float.TryParse(Console.ReadLine(), out float bootsArmor1);
            boots1.Armor = bootsArmor1;

            Console.WriteLine("Введите название оружия");
            string weaponName1 = Console.ReadLine();

            Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            float.TryParse(Console.ReadLine(), out float min1);

            Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            float.TryParse(Console.ReadLine(), out float max1);

            var weapon1 = new Weapon(weaponName1, min1, max1);

            var unit1 = new Unit(name1, startHealthFirst);
            unit1.EquipWeapon(weapon1);
            unit1.EquipBoots(boots1);
            unit1.EquipHelm(helm1);
            unit1.EquipShell(shell1);

            Console.WriteLine("Общий показатель брони первого бойца равен: " + unit1.Armor);
            Console.WriteLine("Фактическое значение здоровья первого бойца равно: " + unit1.RealHealth());

            Console.WriteLine();

            Console.WriteLine("Введите имя второго бойца:");
            string name2 = Console.ReadLine();


            Console.WriteLine("Введите начальное здоровье бойца (10-100):");
            Int32.TryParse(Console.ReadLine(), out int startHealth2);
            if (startHealth2 > 100)
            {
                startHealth2 = 100;
            }

            Console.WriteLine("Введите значение брони шлема от 0 до 1:");
            var helm2 = new Helm();
            float.TryParse(Console.ReadLine(), out float helmArmor2);
            helm2.Armor = helmArmor2;

            Console.WriteLine("Введите значение брони кирасы от 0 до 1:");
            var shell2 = new Shell();
            float.TryParse(Console.ReadLine(), out float shellArmor2);
            shell2.Armor = shellArmor2;

            Console.WriteLine("Введите значение брони сапог от 0 до 1:");
            var boots2 = new Boots();
            float.TryParse(Console.ReadLine(), out float bootsArmor2);
            boots2.Armor = bootsArmor2;

            Console.WriteLine("Введите название оружия");
            string weaponName2 = Console.ReadLine();

            Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            float.TryParse(Console.ReadLine(), out float min2);

            Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            float.TryParse(Console.ReadLine(), out float max2);

            var weapon2 = new Weapon(weaponName2, min2, max2);

            var unit2 = new Unit(name2, startHealth2);
            unit2.EquipWeapon(weapon2);
            unit2.EquipBoots(boots2);
            unit2.EquipHelm(helm2);
            unit2.EquipShell(shell2);

            Console.WriteLine("Общий показатель брони второго бойца равен: " + unit2.Armor);
            Console.WriteLine("Фактическое значение здоровья второго бойца равно: " + unit2.RealHealth());

            var combat = new Combat();
            Console.WriteLine("Поединок начался");
            combat.StartCombat(unit1, unit2);

            Console.WriteLine("Поединок завершился");

            combat.ShowResults();

            Console.ReadLine();
        }
    }
}
