using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A44Eval1
{
    //toutes les class et methode sont public : OK
    public class Program
    {


        //retourne un double du chiffre entrée
        public static Double RacineCarree(int x)
        {
            return Math.Sqrt(x);
        }



        //Fonction qui retourne un tableau des résultats de la racine du premier tableau
        public static double[] RacineCarreTableau(int[] tableau)
        {
            //si tableau est vide
            if (tableau.Length == 0)
                throw new ArgumentException("Un tableau paramètre est vide !");
            //sinon:
            //int racine = 1;

            //int[] nombres = new int[NB_NOMBRES];
            //Déclaration du tableau de retour de la meme taille que le tableau recu
            double[] tableau2= new double [tableau.Length];
            //Pour chaque valeur du tableau 1 calculer la Racine carré et mettre son résultat dans le tableau de sortie
            for (int i = 0; i < tableau.Length; i++) {
                //Si un nombre négatif est détecté:
                if (tableau[i] < 0)
                    throw new ArgumentException("Une valeur du tableau paramètre est négatif!");

                tableau2[i] = Math.Sqrt(tableau[i]);
            
            }
            //Retourne le tableau des résultats des racines carrées
            return tableau2;
        }




        static void Main(string[] args)
        {
        }
    }
}
