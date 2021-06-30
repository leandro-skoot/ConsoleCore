using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradora estas  pateando \n";
        }

        public string Corre()
        {
            return "Maradora esta corriendo \n";
        }

        public string Passe()
        {
            return "Maradora esta pasando \n";
        }
    }
}