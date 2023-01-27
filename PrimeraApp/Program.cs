using System;
using System.Runtime.CompilerServices;



//Este es un espacio donde podemos escribir nuestras clases, pueden haber dos clases llamadas igual en dons nameSpaces diferentes
namespace PrimeraApp
{
    class Program
    {

        static void Mensaje(int number = 0)
        {
            Console.WriteLine($"El numero elegido es {number}");
        }

      
        static void Main(string[] args)
        {


            // CON SWITCH SOLO PODEMOS EVALUAR INT CHAR STRING
                //PARA FLOAT y DOBLE UTILIZAMOS IF
                //SE PUEDE USAR TRUE O RETURN EN LUGAR DE BREAK

                


            int NUMBER = int.Parse(Console.ReadLine());
            switch (NUMBER) {

                case 2:
                    Mensaje(NUMBER);
                    break;

                case 3:
                    Mensaje(NUMBER);
                    break;


                default:
                    Console.WriteLine("EJECUCIÓN POR DEFECTO");
                    break;
            
            }
            

        }


    }

}



// Asi se crea un nuevo espacio
//namespace PrimeraAppSegunda
//{ 
//    class Data{

//    }
//}


//COMENTATIOS EN C#

//Comentario de una linea ===> //

//Comentarios de varia lineas

/*
 COMENTARIO DE VARIAS LINEAS 
*/

/* 
 *TIPOS DE DATOS
 *
 *- Por valor
 *
 *-- Primitivos
 *--- Enteros
 *--- Reales 
 *--- Booleanos
 *
 *-- Estructuras
 *-- Enumerados
 *
 *- Por referencia 
 *--- Objetos
 *
 *
 *EN C# NO SE PUEDE USAR UNA VARIABLE SIN INICIALIZAR
 */


/*

VALORES NUMERICOS
-  Si una operación entre dos valores numericos enteros tiene decimales, C# nos devolverá el valor entero, para ver el resultado exacto debemos operar dos decimales

 
 
 */

/*
 
            //INICIALIZAR VARIABLES MULTIPLES

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;

            edadPersona1 = edadPersona2 = edadPersona3 = 12;
            Console.WriteLine(edadPersona1);
            Console.WriteLine(edadPersona2);
            Console.WriteLine(edadPersona3);

            // DECLARACION IMPLICITA DE VARIABLES
            // Las variables infieren el tipo de dato
            var name = "Daniel";
            var age = 12;

            Console.WriteLine(name);
            Console.WriteLine(age);


            // Conversion explicita || Casting 
            double temperatura = 34.9;
            int temperaturaMedellin;
            temperaturaMedellin = (int)temperatura;

            Console.WriteLine(temperatura);
            Console.WriteLine(temperaturaMedellin);

            // Conversión implicita (se convierte sin la necesidad de castear)
            int habitantes = 199;
            long habitantesMedellin = habitantes;

            Console.WriteLine(habitantesMedellin);
            Console.WriteLine(habitantes);
 
 
 
 */


/*
 
    
            //CONVERSIÓN DE DATA

            Console.WriteLine("Introduce el primer valor numerico");
            int data = int.Parse(Console.ReadLine());
            Console.WriteLine("ESCRIBISTE " + data);


 
 
 */

/*
 
                //CONSTANTE (VALOR QUE NO CAMBIA) || debe inicializarse en la misma linea
            const int DATA = 12;
            const int DATADOS = 14;
            Console.WriteLine("Valor de : {1}", DATA,DATADOS);

            double calculo = Math.Cos(DATA);
            Console.WriteLine(calculo);
 
 */

/*
 
 
 
            //METODO #1
                // En C# los metodos deben de ir declarados siempre dentro de una clase
                // Siempre se debe tipar parametros y el return
                // METODO y FUNCIÓN en C# es exactamente lo mismo
             
            int suma(int n1, int n2) {
                return n1 + n2;
            }

            void metodoQueNoDevuelveNada()
            {
                Console.WriteLine("DATA");
            }

            metodoQueNoDevuelveNada();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(suma(number1, number2));
 
 
 
 
 */


/*
 
 
    
            // LLAMAR A UN METODO ESTATICO
                // Podemos llamar un metodo las veces que sean necesarias
            MensajeEnPanta();

            SumarNumeros(12, 2);

            static void MensajeEnPanta()
            {
                Console.WriteLine("test");
            }

            static void SumarNumeros(int num1, int num2) {
                Console.WriteLine($"DATA:{num1+num2}");
            }
 
 
 
 */


/*
 
         
        // CONTEXTO AMBITO Y ALCANCE SON LO MISMO (SCOPE)



        void PrimerMetodo()
        {   

            //ALCANCE LOCAL
            Console.WriteLine(numero1 + numero2);
        }

        void SegundoMetodo()
        {
            Console.WriteLine(numero1+numero2);
        }


        //SOBRECARGA DE METODOS
        // DOS O MAS METODOS CON EL MISMO NOMBRE

 
 */


/*
 
   //VARIABLES COMPARTIDAS || ES DENOMINADA AMBITO DE CLASE
        int numero1 = 3; 
        int numero2 = 5;

        // CUALQUIER APLICATIVO EN C# EMPIEZA SU EJECUCIÓN POR EL METODO MAIN (ES EL PUNTO DE ENTRADA DE LA APLICACIÓN
 
 
 
 */


/*
 
        //SOBRE CARGA Y RETURNO EXPLICITO
            // Para hacer sobrecarga el metodo debe de recibir diferente tipo paraetros o diferente numero de parameros
            // EL retorno explicito es llamado lambda en C#

        static int Suma(int num1, int num2) => num1 + num2;

        static int Suma(int num1, int num2, int num3) => num1 + num2 + num3;

        static int Suma(int num1, int num2, int num3, int num4) => num1 + num2 + num3 + num4;
 
 
 */



/*
 
 
         // Siempre se llama al metodo que se adapte mejor al numero de parametros 
        private static int Suma(int v1, int v2, int v3 = 0)=> v1 + v2 + v3;
 
 
 */


/*
 
 
    OPERADORES DE COMPORACIÓN

        - ==
        - !=
        - <
        - <=
        - >
        - >=



    OPERADORES DE COMPARACIÓN

        - &&
        - ||
 
 
 
 */