namespace RoleplayGame
{
    public class Armor : IItemDefense
    {
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }
        public int AttackValue
        {
            get
            {
                return 0;
            }
        }
    }
}