using System;
using System.Collections;
class Program
{
    class Pokemon
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }

        public Pokemon()
        {
        }

        public Pokemon(Pokemon original)
        {
            Nome = original.Nome;
            Tipo = original.Tipo;
            Vida = original.Vida;
            Ataque = original.Ataque;
            Defesa = original.Defesa;
        }
    }

    class DadosPokemon
    {
        private ArrayList CadastrarPokemon;

        public DadosPokemon()
        {
            CadastrarPokemon = new ArrayList();
        }

        public void CadastrarPokemons(Pokemon x)
        {
            CadastrarPokemon.Add(x);
        }

        public Pokemon ObterPokemon(int posicao)
        {
            return (Pokemon)CadastrarPokemon[posicao];
        }

        public void ListarPokemon()
        {
            Console.Clear();
            Console.WriteLine("Pokemons Cadastrados: ");
            foreach (Pokemon x in CadastrarPokemon)
            {
             
                Console.WriteLine($"Nome: {x.Nome}");
                Console.WriteLine($"Tipo: {x.Tipo}");
                Console.WriteLine($"Vida: {x.Vida}");
                Console.WriteLine($"Ataque: {x.Ataque}");
                Console.WriteLine($"Defesa: {x.Defesa}");
                Console.Write("\n\n");
            }
            Console.ReadKey();
        }

        public void ListarPokemonsBatalha()
        {
            for (int i = 0; i < CadastrarPokemon.Count; i++)
            {
                Pokemon x = (Pokemon)CadastrarPokemon[i];
                Console.WriteLine($"[{i}] {x.Nome}");
            }
        }
    }

    class Batalha
    {
        public void Vencedor(Pokemon x, Pokemon y)
        {
            int danoX = CalcularDano(x, y);
            y.Vida -= danoX;

            Console.WriteLine($"{x.Nome} atacou {y.Nome}!");
            Console.WriteLine($"Dano causado: {danoX}\n\n");
            

            if (y.Vida <= 0)
            {
                Console.WriteLine($"{y.Nome} foi derrotado!");
                Console.WriteLine($"{x.Nome} venceu a batalha!\n\n");
                return;
            }

            int danoY = CalcularDano(y, x);
            x.Vida -= danoY;

            Console.WriteLine($"{y.Nome} atacou {x.Nome}!");
            Console.WriteLine($"Dano causado: {danoY}\n\n");

            if (x.Vida <= 0)
            {
                Console.WriteLine($"{x.Nome} foi derrotado!");
                Console.WriteLine($"{y.Nome} venceu a batalha!\n\n");
                return;
            }

            if (x.Vida > y.Vida)
                Console.WriteLine($"O Pokemon {x.Nome} é o vencedor\n");
            else if (y.Vida > x.Vida)
                Console.WriteLine($"O Pokemon {y.Nome} é o vencedor\n");
            else
                Console.WriteLine("Empate!\n\n");
            Console.WriteLine($"Vida final de {x.Nome}: {x.Vida}\n");
            Console.WriteLine($"Vida final de {y.Nome}: {y.Vida}\n");
        }

        public int CalcularDano(Pokemon atacante, Pokemon defensor) 
        {
            if (atacante.Ataque > defensor.Defesa)
                return atacante.Ataque - defensor.Defesa;
            else
                return atacante.Ataque;
        }
    }

    static void Main(string[] args)
    {
        DadosPokemon dadosPokemon = new DadosPokemon();
        int op;
       
        do {

            Console.WriteLine("-------MENU-------");
            Console.WriteLine("1-Cadastrar Pokemon");
            Console.WriteLine("2-Listar Pokemons");
            Console.WriteLine("3-Realizar Batalha");
            Console.WriteLine("0-Sair");

            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();

                    Pokemon pokemon = new Pokemon();

                    Console.WriteLine("Digite o nome do Pokemon");
                    pokemon.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o tipo do Pokemon");
                    pokemon.Tipo = Console.ReadLine();

                    Console.WriteLine("Digite a vida do Pokemon");
                    pokemon.Vida = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o ataque do Pokemon");
                    pokemon.Ataque = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a defesa do Pokemon");
                    pokemon.Defesa = int.Parse(Console.ReadLine());

                    dadosPokemon.CadastrarPokemons(pokemon);

                    break;

                case 2:
                    dadosPokemon.ListarPokemon();
                    break;

                case 3:

                    Console.Clear();
                    Console.WriteLine("------BATALHA------");
                    dadosPokemon.ListarPokemonsBatalha();

                    Console.Write("\nEscolha o primeiro Pokemon: ");
                    int posicao1 = int.Parse(Console.ReadLine());

                    Console.Write("Escolha o segundo Pokemon: ");
                    int posicao2 = int.Parse(Console.ReadLine());

                    Pokemon pokemonOriginal1 = dadosPokemon.ObterPokemon(posicao1);
                    Pokemon pokemonOriginal2 = dadosPokemon.ObterPokemon(posicao2);

                    Pokemon pokemon1 = new Pokemon(pokemonOriginal1);
                    Pokemon pokemon2 = new Pokemon(pokemonOriginal2);

                    Batalha batalhaPokemons = new Batalha();
                    batalhaPokemons.Vencedor(pokemon1, pokemon2);

                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida...");
                    break;
            }
        } while(op != 0);
        Console.ReadKey();  
    }
}
