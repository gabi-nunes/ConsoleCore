using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
          public string Chuta()
        {
          return "esta Chutando\n";
        }

        public string Corre()
        {
          return " Correndo\n";
        }

        public string Passe()
        {
          return " Passando\n";
        }
    }
}