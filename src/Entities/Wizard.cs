namespace Prj_Rpg_Csharp.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard( string name, int level, string herotype)  : base(name, level, herotype)
        {
          
        }
                        
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }
        
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de "+ Bonus;
            }else{
                return this.Name + " Lançou Magia com força fraca com bonus de "+ Bonus;
            }
            
        }
    }
}