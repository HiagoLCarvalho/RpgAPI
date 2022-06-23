using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Models.Enuns;
using RpgApi.Utils;

namespace RpgApi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
        public DbSet<PersonagemHabilidade> PersonagemHabilidades { get; set; }
        public DbSet<Disputa> Disputas { get; set; }

        // Durante a criação do modelo de banco de dados, os seguintes dados são adicionados
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().HasData
            (   
                new Personagem() { Id = 1, Nome = "Frodo", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = ClasseEnum.Cavaleiro},
                new Personagem() { Id = 2, Nome = "Sam", PontosVida = 100, Forca = 15, Defesa = 25, Inteligencia = 30, Classe = ClasseEnum.Cavaleiro},
                new Personagem() { Id = 3, Nome = "Galadriel", PontosVida = 100, Forca = 18, Defesa = 21, Inteligencia = 35, Classe = ClasseEnum.Clerigo},
                new Personagem() { Id = 4, Nome = "Gandalf", PontosVida = 100, Forca = 18, Defesa = 18, Inteligencia = 37, Classe = ClasseEnum.Mago},
                new Personagem() { Id = 5, Nome = "Hobbit", PontosVida = 100, Forca = 20, Defesa = 17, Inteligencia = 31, Classe = ClasseEnum.Cavaleiro},
                new Personagem() { Id = 6, Nome = "Celeborn", PontosVida = 100, Forca = 21, Defesa = 13, Inteligencia = 34, Classe = ClasseEnum.Clerigo},
                new Personagem() { Id = 7, Nome = "Ragadast", PontosVida = 100, Forca = 25, Defesa = 11, Inteligencia = 35, Classe = ClasseEnum.Mago}
            );

            //Inicio da criação do usuário padrão
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id= 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = "string.Empty";
            user.PasswordHash = hash;
            user.PasswordSalt = salt;

            modelBuilder.Entity<Usuario>().HasData(user);
            //Fim da criação do usuário padrão

            //Alimentação da classe Armas
            modelBuilder.Entity<Arma>().HasData
            (                  
                new Arma() { Id = 1, Nome="Arco e Flecha", Dano=35,PersonagemId=1 }, 
                new Arma() { Id = 2, Nome="Espada", Dano=33,PersonagemId=2},     
                new Arma() { Id = 3, Nome="Machado", Dano=31,PersonagemId=3 }                
            );
            //Fim criação armas

            //Criação chave estrangeira
            modelBuilder.Entity<PersonagemHabilidade>()
                .HasKey(ph => new {ph.PersonagemId, ph.HabilidadeId });


            //Alimentação classe Habilidades
            modelBuilder.Entity<Habilidade>().HasData
            (
                new Habilidade(){Id=1, Nome="Adormecer", Dano=39},
                new Habilidade(){Id=2, Nome="Congelar", Dano=41},
                new Habilidade(){Id=3, Nome="Hipnotizar", Dano=37}
            );

            //Sempre que um Usuário for salvo sem identificação de Perfil, por padrão a descrição do perfil será de jogador.
            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasDefaultValue("Jogador");

            //Alimentação classe PersonagemHabilidades
            modelBuilder.Entity<PersonagemHabilidade>().HasData
            (                  
                new PersonagemHabilidade() { PersonagemId = 1, HabilidadeId =1 }, 
                new PersonagemHabilidade() { PersonagemId = 1, HabilidadeId =2 }, 
                new PersonagemHabilidade() { PersonagemId = 2, HabilidadeId =2 }, 
                new PersonagemHabilidade() { PersonagemId = 3, HabilidadeId =2 }, 
                new PersonagemHabilidade() { PersonagemId = 3, HabilidadeId =3 }, 
                new PersonagemHabilidade() { PersonagemId = 4, HabilidadeId =3 }, 
                new PersonagemHabilidade() { PersonagemId = 5, HabilidadeId =1 }, 
                new PersonagemHabilidade() { PersonagemId = 6, HabilidadeId =2 }, 
                new PersonagemHabilidade() { PersonagemId = 7, HabilidadeId =3 }                               
            );


        }
    }

}