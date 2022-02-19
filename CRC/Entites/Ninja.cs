namespace DIO_DesafioJogo.CRC.Entites
{
    public class Ninja : Hero
    {
         public Ninja(string Name,int Level,string HeroType) 
        {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
          
        }   

        public new string Attack()
        {
            return this.Name + " Atacou com sua Katana ";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
            return this.Name + " Cortou com ataques precisos " + Bonus;
            }
            else
            {
             return this.Name + " Atacou com Golpes inferior " + Bonus;   
            }
        }

        
        
    }
}