namespace EFCore.WebAPI.Model
{
    public class Heroi
    {
        public int Id{ get; set; }
        public string Nome { get; set; }
        //public Batalha Batalha{ get; set; }//aqui é a referencia direta da propriedade batalha       //foram retirados por que não estou referenciando herois a apenas uma batalha
        // public int BatalhaId { get; set; }//indice de qual batalha participou 
        public List<HeroiBatalha> HeroisBatalhas{ get; set; }
        public List<Arma> Armas { get; set; } 
        public IdentidadeSecreta Identidade { get; set; }//isso aqui é o suficiente para o entityframe work entender que tem um relacionamento entre heroi e identidade secreta e nem sempre um heroi tem uma identidade secreta
    }
}
