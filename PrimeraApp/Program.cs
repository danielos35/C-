﻿using System;



//Este es un espacio donde podemos escribir nuestras clases, pueden haber dos clases llamadas igual en dons nameSpaces diferentes
namespace PrimeraApp
{
    class Program
    {

        // CUALQUIER APLICATIVO EN C# EMPIEZA SU EJECUCIÓN POR EL METODO MAIN
        static void Main(string[] args)
        {


            //METODO
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