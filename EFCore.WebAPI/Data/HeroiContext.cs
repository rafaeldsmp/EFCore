using EFCore.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext : DbContext //esse contexto(context) é o que vai encapsular todas as nossas entidades
    {
        public DbSet<Heroi> Herois { get; set; }//o dbset tem um objeto que irá passar como parametro que é meus objetos 
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> Identidade { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity =>    //explicar para o entity o que tem que fazer no banco de dados, que é considerar que as duas chaves a batalha e o heroi dentro de heroibatalha é minha chave composta
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId});
                //entidade tem chave dado a chave que tem, ela é composta por e.batalhaid e e.HeroiId
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//optionsBuilder
        {
            optionsBuilder.UseSqlServer("Password=;Persist Security Info=True;User ID=;Initial Catalog=HeroApp;Data Source=LBR-CP4GDM3");//modificaremos o Catalog que será o nome do banco de dados
            //vamos copiar criando um arquivo novo e de texto e adicionando a extenção .udl começando com password
            //necessário instalar Microsoft.EntityFrameworkCore.SqlServer para usar 
            //base.OnConfiguring(optionsBuilder);não foi necessário criou automaticamente
        }

        //estamos usando a abordagem codefirst
        //ficou como uma convenção que quando cria uma classe ou entidade lista ela fica no plural, que já identifica que é uma lista, outro motivo é que quando
    }
}
