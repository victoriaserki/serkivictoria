using System.Globalization;

namespace MediCare_Labs
{
    //int[,] representa un arreglo bidimencional
    internal class Program
    {
        //desde cualquier funcion 
        const int PAC = 3;
        const int PRU = 2;
        static void Main(string[] args)
        {

            
            int[,] Resultados = new int[PAC,PRU];  //matriz bidimencional
            int[] MaximoPrueba = new int[PRU] { 20, 30 };   // 40, 70, 80, 90, 100, 150 };
            int[] MinimoPrueba = new int[PRU] { 20, 30 };  // 40, 70, 80, 90, 100, 150 };
            Console.WriteLine("Medi Care Labs");
            IngresarResultadosPruebas(Resultados);
            ContarPacientesAlto(Resultados,MaximoPrueba);
            CalcularPromedioPruebaEspecifica(Resultados);
            BuscarValorMinimoMaximoDePacientes(Resultados);
            PorcentajeResultadosAnormales(Resultados);
            


           


        }
        //definicion de funciones
        public static void IngresarResultadosPruebas(int[,] Resultados)
        {
            int ResultadoAnalisi;
            for (int i = 0; i < PAC; i++)
            {
                for (int j = 0; j < PRU; j++)
                {
                    do
                    {
                        Console.Write($"ingrese el resultado de la prueba {j + 1}");
                        ResultadoAnalisi = Convert.ToInt32(Console.ReadLine());  //int.parse convierte en entero//Convert.To convierte al que quiero


                    } while (ResultadoAnalisi < 0);
                    Resultados[i, j] = ResultadoAnalisi;
                }
            }
            Console.ReadKey();
            for (int i = 0; i < PAC; i++)
            {
                Console.WriteLine($"paciente:{i + 1}");
                for (int j = 0; j < PRU; j++)
                {
                    Console.WriteLine($"ingrese el resultado de la prueba {j + 1}:{Resultados[i, j]}");
                }
            }
        }
            
        public static void ContarPacientesAlto(int[,] Resultados, int[]MaximoPrueba) 
        {
            //contar 
            int cuentaAltos;
            int[] pacienteAltos = new int[PAC];
            int[] pacienteNumero = new int[PAC];
            int auxiliar;
            for(int i=0;i<PAC;i++)
            {
                cuentaAltos = 0;
                Console.WriteLine($"paciente:{i + 1}");
                for(int j=0;j<PRU;j++)
                {
                    if (Resultados[i, j] > MaximoPrueba[j])
                    {
                        cuentaAltos++;
                    }
                }
                pacienteAltos[i] = cuentaAltos;           
            }
            //ordenar
            for(int i=0;i<PAC-1;i++)
            {
                for (int j=i+1;j<PAC;j++)
                {
                    if (pacienteAltos[i] > pacienteAltos[j])
                    {
                        auxiliar = pacienteAltos[i];
                        pacienteAltos[i] = pacienteAltos[j];
                        pacienteAltos[j] = auxiliar;


                        auxiliar = pacienteNumero[i];
                        pacienteNumero[i] = pacienteNumero[j];
                        pacienteNumero[j] = auxiliar;
                    

                    }
                }
                
            }

            //mostrar
            for(int i=0;i<PAC;i++)
            {
                Console.WriteLine($"PACIENTE: {pacienteNumero[i]} CANTIDAD: {pacienteAltos[i]}");
            }

        }


        public static void CalcularPromedioPruebaEspecifica(int[,] Resultados)
        {

        }

        public static void BuscarValorMinimoMaximoDePacientes(int[,]Resultados)
        {

        }

        public static void PorcentajeResultadosAnormales(int[,]Resultados)
        {

        }

    }
}
