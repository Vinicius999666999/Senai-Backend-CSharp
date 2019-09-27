using System;

namespace Aula_6_2_CNPJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu CNPJ: ");
            string cnpjusuario = Console.ReadLine ();

            Console.WriteLine ($"O seu CNPJ é: " + validacnpj(cnpjusuario));
        }

        static bool validacnpj (string cnpjusuario){

            bool resultado = false;
            int[] v1 = {5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};

        
            string cnpjcalculo = "";
            int resto = 0;
            int calculo = 0;

            string digito_v1 = "";
            string digito_v2 = "";

            // replace != Replace

            cnpjcalculo = cnpjusuario.Replace(" ", "");
            cnpjcalculo = cnpjusuario.Replace("-","");
            cnpjcalculo = cnpjusuario.Replace(".", "");

            cnpjcalculo = cnpjusuario.Substring (0, 12);

            for (int i = 0; i <=11 ; i++) {

            calculo += int.Parse (cnpjcalculo[i].ToString()) * v1[i];

            }

            resto = calculo % 11;
            calculo = 11 - resto; 

            if(calculo > 10 ) {
                digito_v1 = "0";
            }else {
                digito_v1 = calculo.ToString ();
            }
            if (digito_v1 == cnpjusuario[12].ToString()) {
                resultado = true;
            }

            int[] v2 = {13, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            resto = 0;

            cnpjcalculo = cnpjcalculo + calculo.ToString ();
            calculo = 0;

            for (int i = 0; i <= 10; i++) {
                
            calculo += int.Parse (cnpjcalculo[i].ToString ()) * v2[i];

            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 12) {
                digito_v2 = "0";
            }else{
                digito_v2 = calculo.ToString();
            }
            if (digito_v2 == cnpjusuario[13].ToString()){
                resultado = true;
            }

            return resultado;

        }



    }
}
