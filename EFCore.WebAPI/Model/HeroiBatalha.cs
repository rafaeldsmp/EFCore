using System.Diagnostics;

namespace EFCore.WebAPI.Model
{
    public class HeroiBatalha
    {
        //muitos herois podem participar de muitas batalhas
        public int HeroiId { get; set; }//vou ter o id do heroi e embaixo terei o objeto
        public Heroi Heroi { get; set; }//primeiro relacionamento que eu tenho, uma tabela key heroi  
        public int BatalhaId { get; set; } 
        public Batalha Batalha { get; set; }//outra relação, outra tabela key de batalha

    }
}
