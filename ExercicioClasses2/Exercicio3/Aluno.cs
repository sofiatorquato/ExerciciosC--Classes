using System.Globalization;

namespace ExercicioClasses2.Exercicio3
{
    internal class Aluno
    {

        public string Nome;
        public double N1,N2,N3;

        public double TotalNota()
        {
            return N1 + N2 + N3;
        }

        public double Pontos()
        {

            if (TotalNota() < 60.0)
            {
                return 60.0 - TotalNota();
            }
            return 0.0;

        }


        public override string ToString()
        {
          
            return "NOTA FINAL = " + (N1+N2+N3).ToString("F2", CultureInfo.InvariantCulture);
            
        }

        
        

   }
}
