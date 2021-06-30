using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        //Chuta
        public string Chuta()
        {
            return $"{_Nome} esta Chutando \n";
        } 
        //Corre
        public string Corre()
        {
            return $"{_Nome} esta Correndo \n";
        }
        //Passe
        public string Passe()
        {
            return $"{_Nome} esta Passando \n";
        }
    }    
}