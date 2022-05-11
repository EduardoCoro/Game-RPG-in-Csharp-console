namespace Prj_Rpg_Csharp.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string herotype) : base(name, level, herotype)
        {
            
        }

        public string Attack(int critical)
        {
            if (critical > 8)
            {
                return this.Name + " Ataque Super Crítico: "+ critical + "%";
            }else{
                return this.Name + " Ataque com falha no Crítico ";
            }
        }
        
    }
}