namespace EFCore.WebAPI.Model
{
    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public int NomeReal { get; set; }
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }//relação com heroi aqui também 
    }
}
