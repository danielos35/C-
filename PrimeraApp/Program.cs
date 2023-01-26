using System;



//Este es un espacio donde podemos escribir nuestras clases, pueden haber dos clases llamadas igual en dons nameSpaces diferentes
namespace PrimeraApp
{
    class Program
    {
        static void Main(string[] args)
        {

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

