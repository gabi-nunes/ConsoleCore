using GameTop.Interface;

namespace GameTop.Lib
{
    class Jogador1cs : iJogador
    { 
        public readonly string _Nome;

        public Jogador1cs(string nome = "Gabi"){

               _Nome = nome; 

        }


        //chutar
        public string Chuta()
         {
             return ($"{_Nome} esta chutando\n");
         }
        //corre
        public string Corre()
        {
        return ($"{_Nome} esta correndo\n");
         }

        //passe
        public string Passe()
        {
            return($"{_Nome} esta passando\n");
        }


    }
}