
namespace ClassesHomework
{
    public struct Rate
    {
        public Unit DamagingUnit { get; }

        public int Damage { get; set; }

        public float Health { get; set; }

        public Rate(ref Unit unit, int damage, float enemyHealth)
        {
            DamagingUnit = unit;
            Damage = damage;
            Health = enemyHealth;
        }
    }
}
