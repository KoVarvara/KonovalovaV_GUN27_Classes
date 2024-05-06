using System;


namespace ClassesHomework
{
    public class Unit
    {
        public string Name { get; }
        public float Health { get; private set;  }
        public Weapon СurrentWeapon { get; private set; }

        public Helm CurrentHelm { get; private set; }
        public Shell CurrentShell { get; private set; }
        public Boots CurrentBoots { get; private set; }

        private float damage;
        public float Damage
        {
            get
            {
                damage = СurrentWeapon.Damage + 5f;
                if (СurrentWeapon == null)
                {
                    return 5f;
                }
                else if (damage > 30f)
                {
                    return 30f;
                }
                else
                {
                    return damage;                   
                }
            }        
        }

        private float armor;
        public float Armor
        {
            get 
            {
                armor = CurrentBoots.Armor + CurrentShell.Armor + CurrentHelm.Armor;
                if (armor < 0f)
                {
                    return 0f;
                }
                else if (armor > 1f)
                {
                    return 1f;
                }
                else
                {
                    return CurrentBoots.Armor + CurrentShell.Armor + CurrentHelm.Armor;
                }
            }
        }       

        public Unit() : this("Unknown Unit", 0)
        {

        }

        public Unit(string name, float health) 
        {
            Name = name;
            Health = health;
        }

        public float RealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(float value)
        {
            Health -= value * Armor;
            if (Health <= 0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EquipWeapon(Weapon weapon)
        {
            СurrentWeapon = weapon;
            Console.WriteLine(weapon.Name + " is equipped");
        }

        public void EquipHelm(Helm helm)
        {
            CurrentHelm = helm;
            Console.WriteLine(helm.Name + " is equipped");
        }

        public void EquipShell(Shell shell)
        {
            CurrentShell = shell;
            Console.WriteLine(shell.Name + " is equipped");
        }

        public void EquipBoots(Boots boots)
        {
            CurrentBoots = boots;
            Console.WriteLine(boots.Name + " are equipped");
        }
    }
}
