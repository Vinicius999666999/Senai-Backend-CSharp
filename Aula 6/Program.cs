using System;

namespace Aula_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamamos nossa primeiro função
            Console.WriteLine( Bomdia() );

            //Chamamos a função do tipo VOID (sem retorno)
            ImprimiDataHora();

            // chamamos nossa função que calcula a média
            double[] numeros = { 2, 5, 2, 8, 9, 5};
            Console.WriteLine( CalculaMedia(numeros) );

            //chamamos a função de soma
            Console.WriteLine( CalculaVetor (numeros) );
        }

            /// <summary>
            /// Funçao que escreve bom dia para o usúario
            /// </summary>
            /// <returns>Retorna Óla! bom dia </returns>
            
            //returns é oque aparece para o usuario
            static string Bomdia(){
                return "Olá Bom dia! :) ";
            }

            /// <summary>
            /// Retorna função que mostra uma saudação de acordo com o horario atual
            /// </summary>
            /// <param name="Saudacao">Texto qualque (Sobre carga de método)</param>
            /// <returns> Saudação de acordo com o horário </returns>




            static string Bomdia(string Saudacao){

                int hora = DateTime.Now.Hour;

                if(hora <= 12){
                    Saudacao = "Bom Dia";
                }else if(hora >= 12 && hora <= 18){
                    Saudacao = "Bom Tarde";
                }else{
                    Saudacao = "Bom Noite";
                }

                return Saudacao;
            }

            /// <summary>
            /// retorna um número - teste de sobrecarga
            /// </summary>
            /// <param name="numero">um número inteiro qualquer</param>
            /// <returns>número passado como parâmetro </returns>

            static int BomDia(int numero){
                return numero;
            }

            /// <summary>
            /// Retorna Data e Hora atuais
            /// </summary>

            static void ImprimiDataHora(){
                Console.WriteLine(DateTime.Now.Hour.ToString());
                Console.WriteLine(DateTime.Now.ToShortDateString());
            }


            /// <summary>
            /// funçaõ que calcula media do vetor
            /// </summary>
            /// <param name="valores">vetor com valores</param>
            /// <returns>média dos valores</returns>

            static double CalculaMedia(double[] valores){

                double resultado = 0;

                for(int i = 0 ; i <= valores.Length ; i++){
                resultado += valores[i]; 
                }

                resultado = resultado / valores.Length;

                return resultado;

            }


            /// <summary>
            /// Função que calcula
            /// </summary>
            /// <param name="valores">vetor com valores</param>
            /// <returns>média dos valores</returns>
        static double CalculaVetor(double[] valores){

        double resultado = 0;

        for(int i = 0 ; i <= valores.Length ; i++){
            resultado += valores[i];
        }

        resultado = resultado + valores.Length;

        return resultado;

        }

    }
}
