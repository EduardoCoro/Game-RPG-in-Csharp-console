namespace Prj_Rpg_Csharp.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int level, string Herotype)
        {
            this.Name = Name;
            this.Level = level;
            this.Herotype = Herotype;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        
        public string Herotype { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Herotype;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }

    }
}