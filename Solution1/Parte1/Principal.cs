using System;

namespace Parte1
{
    public class Principal
    {
        static void Main(string[] args)
        {
            new Preguntas().Ejecutar();
        }

        class Preguntas
        {
            public Preguntas() { }
            public bool Ejecutar()
            {
                try
                {
                    Console.Write("\nPara escriba pulse salir \nDigite el # de Pregunta y dar Enter para dar el resultado: ");
                    string opcion = Console.ReadLine();
                    if (opcion.Equals("salir")) return false;
                    Console.WriteLine();

                    switch (opcion)
                    {
                        case "1":
                            ChangeString cs = new ChangeString();

                            string prueba = "123 abcd*3";
                            Console.WriteLine("Para '123 abcd*3':\n" + cs.build(ref prueba));

                            prueba = @"**Casa 52";
                            Console.WriteLine("Para '**Casa 52':\n" + cs.build(ref prueba));
                            break;
                        case "2":
                            CompleteRange cr = new CompleteRange();

                            int[] arr1 = new int[] { 2, 1, 4, 5 };
                            Console.Write("Para { 2, 1, 4, 5 }:\n");
                            for (int i = 0; i < cr.build(arr1).Length; i++)
                                Console.Write(string.Format("{0},", cr.build(arr1)[i]));
                            Console.WriteLine();

                            int[] arr2 = new int[] { 4, 2, 9 };
                            Console.Write("Para { 4, 2, 9 }:\n");
                            for (int i = 0; i < cr.build(arr2).Length; i++)
                                Console.Write(string.Format("{0},", cr.build(arr2)[i]));
                            Console.WriteLine();

                            int[] arr3 = new int[] { 58, 60, 55 };
                            Console.Write("Para { 58, 60, 55 }:\n");
                            for (int i = 0; i < cr.build(arr3).Length; i++)
                                Console.Write(string.Format("{0},", cr.build(arr3)[i]));

                            Console.WriteLine();
                            break;
                        case "3":
                            MoneyParts mp = new MoneyParts();
                            Console.WriteLine("Para 0,5:\n" + mp.build("0,5"));
                            Console.WriteLine();
                            Console.WriteLine("Para 0,1:\n" + mp.build("0,1"));
                            Console.WriteLine();
                            Console.WriteLine("Para 10,5:\n" + mp.build("10,5"));
                            break;
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return new Preguntas().Ejecutar();
            }
        }
    }
}
