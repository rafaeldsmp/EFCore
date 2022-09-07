namespace EFCore.WebAPI.Model
{
    public class Arma //arma tem a relação 1 para 1
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Heroi Heroi { get; set; }
        public int HeroiId{ get; set; }
    }
}
