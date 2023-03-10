//Este es un espacio donde podemos escribir nuestras clases, pueden haber dos clases llamadas igual en dons nameSpaces diferentes
namespace PrimeraApp
{
    class Program
    {



        static void Main(string[] args)
        {

            AlmacenObjetos_ archivos = new AlmacenObjetos_(4);
            archivos.agregar("Juan");
            archivos.agregar("Daniel");
            archivos.agregar("Felipe");
            String nombrePersona = (String)archivos.getElemento(2);
            Console.WriteLine(nombrePersona);


            //CLASE GENERICA
            AlmacenObjetos<int> archivos_ = new AlmacenObjetos<int>(5);
            archivos_.agregar(12);
            int nombrePersona_ = archivos_.getElemento(12);

            // RESTRICCIONS


            

        }

        /*
         
         PROGRAMACIÓN GENERICA
            - Se tiene mayor sencilles en el codigo
            - Comprobación de error en tiempo de compilación 
            - Se debe de indicar el tipo de dato que va a ser usado en este caso para un generico usamos T
         
         */


        // FORMA 1.

        class AlmacenObjetos_
        {


            private Object[] datosElemento;
            private int i = 9;
            public AlmacenObjetos_(int z)
            {
                datosElemento= new Object[z];
            }

            public void agregar(Object obj)
            {
                datosElemento[i] = obj;
                i++;
            }

            public Object getElemento(int i)
            {
                return datosElemento[i];
            }

        }


        //Forma 2

        //Por convensión se utiliza T para identificar los genericos, y significa que la clase va almacenar cualquier tipo de objeto
        class AlmacenObjetos<T>
        {


            private T[] datosElemento;
            private int i = 9;
            public AlmacenObjetos(int z)
            {
                datosElemento = new T[z];
            }

            public void agregar(T obj)
            {
                datosElemento[i] = obj;
                i++;
            }

            public T getElemento(int i)
            {
                return datosElemento[i];
            }

        }


        //FORMA 3 Clases genericas con restricciones

        interface IAlmacen
        {
            public int getInventario();
        }

        class Almacen_res<T> where T: IAlmacen
        {
             public Almacen_res(int data)
            {

            }
        }

        class Almacen_1 : IAlmacen
        {
            public int getInventario()
            {
                return 0;
            }
        }

        class Almacen_2
        {
            public int getInventario__()
            {
                return 0;
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


/*

    SWITCH


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

            static void Mensaje(int number = 0)
        {
            Console.WriteLine($"El numero elegido es {number}");
        }


 */


/*

                /*

                TIPO DE BUCLES

                - Determinados: Sabemos las veces que se va a repetir (FOR | FOR EACH)
                - Indeterminados: NO sabemos el numero de veces que se va repetir (WHILE DO WHILE)

             */

//VAriable Random

/*
    Random random = new Random();
    int numero = random.Next(0, 100);
    int numeroIngresado = 0;

    int i = 0;
            while(numeroIngresado != numero)
            {
                numeroIngresado = int.Parse(Console.ReadLine());
                if(numeroIngresado > numero) {
                    Console.WriteLine("Es MENOR");
                }

    if (numeroIngresado < numero)
    {
        Console.WriteLine("Es MAYOR");
    }
    i++;
                }

                Console.WriteLine("LO CONSEGUISTE");

            }


*/

/*
 
          // DO WHILE 
            // SE EJECUTA AL MENOR UNA VEZ 

            int z = 10;

            do
            {
                z++;
            }
            while (z < 10); 
 
 
 */


/*
 
      /*
             
                EXCEPCIONES (Causas)
                - Memoria corrupta
                - Desbordamiento de pila
                - Sectores de disco duro defectuosos
                - Acceso a ficheros inexistentes
                - Conexiones a BBDD interrumpidas
                - ETC
                - Intentar capturar las excepciones puntuales (NO GENERALIZAR)
             
             */

/*

    EXCEPCIÓN (Herencia de excepción)
    - La herencia de herencias nos permite capturar errores generico
    - la clase padre es Excepción


 */

/*

int number = 0;
while (true)
{
    try
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine($"Este es el numero{input}");
        number++;
    }

    // LAS CAPTURAS CONCRETAS DEBEN DE IR ANTES DE LA CAPTURA GENERA
    catch (FormatException)
    {
        Console.WriteLine("SE HA INTRODUCIDO UN FORMATO INADECUADO");
    }


    // EXCEPCIONES CON FILTROS

    catch (Exception err) when (err.GetType() != typeof(OverflowException))
    {
        Console.WriteLine("ESTO NO ES UN NUMERO PA");
        Console.WriteLine(err.Message);
    }

    catch (OverflowException)
    {
        Console.WriteLine("TE PASASTE CON EL NUMERO");
    }
}



*/


/*
 
    EXCEPCIONES

    
            //EL COMPILADOR ASUME QUE HAY UN ERROR PERO NO LO CAPTURA POR TEMAS DE RENDIMIENTO
                //Para capturar ese error usamos checked
                // SOLO FUNCIONA PARA PRIMITIVOS INT Y LONG

                /*
                    El compilador puede se exhaustivo para validar todos los errores
                    -  Se va a la configuración del proyecto>propiedades>build || compilación>advance > habilitar compilación aritmetica avanzada>
                    - Este comportamiento se da solo para desbordamiento         

                */

//FORMA #1

/*
checked
{

    int numero = int.MaxValue;
    numero = numero + 20;
    Console.WriteLine(numero);
}

//FORMA 2
int numeroMayor = int.MaxValue;
numeroMayor = checked(numeroMayor + 20);


//Deshabilitar en caso de estar habilitado el checkeo por defecto
int numeroMayor2 = int.MaxValue;
numeroMayor2 = unchecked(numeroMayor2 + 20);


// CONFIGURACIÓN DE EXCEPCIONES
//debun>windows>settings>excepcion settings

*/


/*
 
-  EXCEPCIÓN DEL CODIGO CUSTOM
            //DEVOLVER EXCEPCIÓN
            int number =int.Parse(Console.ReadLine());
            if(number == 0) {

                throw new ArgumentOutOfRangeException();

            
            }
 
 */


/*
    
//FINALLy
 
            try
            {

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                // BLOQUE QUE SIEMPRE SE VA A EJECUTAR
                Console.WriteLine("SIEMPRE ME EJECUTO");
            }

 
 
 */

/*
 
    
            /*
             PARADIGMAS:
             - Programación orientada a procedimientos
                -- Fortran
                -- Cobol
                -- Basic
                -- Poco reutilizable
                -- un solo fallo termina la ejecución del programa
             
             - Programación orientada a objetos:
                -- Trasladar la programación a los objetos de la vida real
                -- los objetos tienes caracteristicas
                -- Partes, trozos, modulos o clases
                -- herencia
                -- El programa no cae por completo
                -- Encapsulamiento
                -- Modificadores de acceso (Hay mas que en otros lenguages)
                    - pulbic (se puede acceder desde cualquier parte)
                    - Private (Solo se puede acceder desde la propia clase)
                    - protected (Accesible desde la clase derivada)
                    - internal (Accesible desde el mismo ensamblado)
                    - Protected internal 
                    - etc

            - Vocabulario:
                - Clase
                - Objeto
                - Ejemplar de la clase
                - Modularización
                - Encapsulamiento
                - Herencia
                - Poliformismo

            - Clase
                - Plantilla donde se definen las caracteristicas
            
            - Objeto
                - Instancia de la clase, se tiene definino ya las caracteristicas indicadas en la clase

            NOTAS
            -   Pseudocodigo: mitad codigo de programación y codigo humano

             */

/*
 
     {
        //Propiedad de tipo privada
        private const double pi = 3.1416;

        //Propiedad de tipo publica
        public double calculoArea(int radio)
        { 
            return pi * radio * radio; 
        }

        
        /*
         
         NOTAS
            - Siempre usar encapsuladores (Modificadores de acceso)
            - ¿Cuando encapsular? En las constantes
        

        //CONVENCIONES
            - Los metodos Public se recomienda que comiencen en mayuscula (PascalCase)
            - los identificadores NO public deben iniciar con camelCase
            - Los datos se deben de cambiar desde modificadores de acceso Getter || Setters
         */


/*

//CLASE
partial class Coche
{
    private int ruedas;
    private int largo;
    private int ancho;
    private bool esDeportivo;
    private string tapiceria;

    /*
        - El constructor debe tener el mismo nombre de la clase
        - Dar estado incial al coche
        - Si no indicamos constructor, la clase toma un contructor por defecto
     */

/*
public Coche()
{
    ruedas = 0;
    largo = 0;
    ancho = 0;
    esDeportivo = false;
}

/*
    Sobre carga de constructor:
        - Se da cuando se tiene mas de un constructor
        - Se llama al constructor que contenga los parametros que se necesitan
 */

/*
public Coche(int ruedas_, int largo_)
{
    ruedas = ruedas_;
    largo = largo_;
}



//Metodos de acceso

public int getRueadas()
{
    return ruedas;
}

public String getDataCoche()
{
    return $"Este es un coche de {ruedas} ruedas y de {ancho} metros de ancho";
}


//SETTER

public void SetEsDeportivo(bool esDeportivo)
{

    //Cuando hay problema de ambiguedad al tener un nombre igual en los argumento y en lo propiedades
    //USAMOS THIS para diferenciar a un campo de clase de un parametro
    this.esDeportivo = esDeportivo;
}

    
    }


    // PODEMOS DIVIDIR LA CLASE EN DOS TROZOS MEDIANTE PARTIAL
    partial class Coche
{


}


*/

/*
 
        static void realizarTarea()
        {   
                

            Punto origen = new Punto(12,1);
            Punto destino = new Punto(12,45);
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine(distancia);

        }
 
 
 */



/*
 
STATIC METODOS
    
    class Program
    {



        static void Main(string[] args)
        {

            Auto honda = new Auto();
            Auto mazda = new Auto();
            Auto ford = new Auto();
            Auto chevrolet = new Auto();
            Auto redbull = new Auto();
            Console.WriteLine(Auto.getNumeroAutos());
            Console.WriteLine(Auto.numeroConstante);
        }

        // METODO Y VARIABLES STATIC
            // Las variables static son globales para todos los objetos por eso son llamadas variables de clase
            // Para usarla de debe de llamar a la clase mas no al objeto por ejemplo CLase.contador
            // Utilizar public para acceder a las variables static
            // const: todas las contantes en C# se asumen que son static "sin necesidad de agregar la clase static"


    }


    class Auto 
    {

        static int numerDeAutos = 0;
        public const int numeroConstante = 12;

        public Auto() {
            numerDeAutos ++;
        }

        public static int getNumeroAutos()
        {
            return numerDeAutos;
        }
    
    }


     


 
 
 
 
 
 */

/*


****** IMPORTAR CLASES  PARA LLAMAR DIRECTAMENTE A SUS PROPIEDADES O METODOS *************************



 using System;
using System.Runtime.CompilerServices;


// IMPORTAR TODOS LOS METODOS DE UNA CLASE
    // No se recomienda pues confunde bastante a los programadores que van a revisar el codigo
using static System.Math;


//Este es un espacio donde podemos escribir nuestras clases, pueden haber dos clases llamadas igual en dons nameSpaces diferentes
namespace PrimeraApp
{
    class Program
    {



        static void Main(string[] args)
        {

            // AL IMPORTAR UNA CLASE PODEMOS LLAMAR DIRECTAMENTE SUS METODOS

            double raiz = Sqrt(9);
            double potencia = Pow(3, 4);
            Console.WriteLine( potencia );
            Console.WriteLine( raiz );

        }



    }


    // CLASES ANONIMAS
        // No suelen tener nombre
        // Se utiliza para realizar querys a base de datos
        //

}
 
 
 
 
 
 */

/*
 
 
    CLASES ANONIMAS

            static void Main(string[] args)
        {

            // CLASES ANONIMAS
                // El tipo de dato de cada atributo , el compilador determina el tipo de variable

            var miObjeto = new
            {
                nombre = "Daniel",
                edad = 19
            };

            Console.WriteLine(miObjeto.edad);

            var miOtraVariable =  new 
            { 
                nombre = "Ana", 
                edad = 18 
            };

            // DOS OBJETOS CON LAS MISMOS TIPOS DEDATOS PUEDEN SER ASIGNADAS ENTRE ELLAS

            miObjeto = miOtraVariable;


            // RESTRICCIONES
                // Solo pueden contener campos publicos
                // Todos los campos deben estar iniciados
                // Los campos no pueden ser static
                // NO se pueden definir metodo


        }
 
 
 
 */

/*
 
 
            // ARREGLOS

                //Tipo de arreglo |  nombre del arreglo =  inicializar el arreglo [numero de valores que se van almacenar]
                    //No se guarda en memoria hasta que se inicializa
            int[] numeros = new int[4];
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;


                //Esta es la manera de inicializar arreglos con todos sus valores
            int[] edades = new int[5] { 1, 2, 3, 4, 5 };

                //Si yo no inicializo un arreglo toma por defecto los valores por defecto del tipo de dato
            int[] data = { };
                
                //si le asigno un valor a una posición que no existe tendremos un error

            Console.WriteLine(numeros);



            //ARRAY IMPLICITO

            //ERROR dado que hay varios tipos de datos var datos = new[] { "test", 1, "test", null};
            var datos = new[] { "test","", "test", "test" };



            // ARRAY DE OBJETOS
            Empleado[] arrayEmpleados = new Empleado[2];
            arrayEmpleados[0] = new Empleado(12, "Daniel");
            arrayEmpleados[1] = new Empleado(124, "Daniel M");


            //ARRAY CLASES ANONIMAS

            var Personas = new[] 
                { 

                    //Todos tienen que ser del mismo tipo, y contener los mismos datos || NO es posible almacenar diferente tipo de datos
                    new {Nombre="Daniel", edad =12},
                    new {Nombre="Felipa", edad =1243},
                    new {Nombre="Marquez", edad =143},
                };


            // ARRAY DE VARIAS DIMENSIONES
            int[,] edadesBidimensiona = new int[4, 2];
            edadesBidimensiona[0,0] = 2;


            // BUCLE FOR 
            for( int i = 0; i <= Personas.Length; i++)
            {
          
            }


            //FOR EACH
                //Solo permite ver la info, no permite modificar los datos
            
            foreach(var numero in numeros)
            {
                Console.WriteLine(numero);
            }


 
 
 
 */


/*
 ARRAY

        static void RecorrerArreglo(int[] datos)
        {
            foreach(int dato in datos)
            {
                Console.WriteLine(dato);
            }
        }


        class Empleado {

            String nombre;
            int edad;
            public Empleado(int edad, String nombre)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
        
        }
 
 
 */

/*
 * 
 * 
 * HERENCIA
 
         static void Main(string[] args)
        {
            
            
            // TODOS ESTOS OBJETOS COMPARTEN LAS MISMAS CARACTERISTICAS DE LA CLASE PADRE
            
            Caballo horse = new Caballo("Cab_1");
            Humano Daniel = new Humano("Hum_2");
            Gorila Mico = new Gorila("Gor_1");


            // PRINCIPIO DE SUSTITUTCIÓN
            Mamiferos caballo_2 = new Caballo("Caballo");

                //Pues siempre un caballo será un mamifero
                //En este caso tendremos todos los metodos de MAMIFERO mas no los de CABALLOl

            // SUSTITUCIÓN | Ejemplo #2
            Caballo caballo_3 = new Caballo("Caballo#2");

            //Asignamos un objeto de tipo caballo a un mamifero
            caballo_2 = caballo_3;


            //SUSTITUCIÓN CON EL METODO OBJECT
            Object animal_object = new Gorila("Test_nombre");
            // El Object abarca a todos los demas objetos

            //POR EJEMPLO EN UN ARRAY DE MAMIFEROS PODEMOS ALMACENAR OBJETOS QUE HEREDEN DE ESTA MISMA CLASE

            Mamiferos[] animales_mamiferos = new Mamiferos[3];
            animales_mamiferos[0] = Mico;
            animales_mamiferos[1] = Daniel;
            animales_mamiferos[2] = horse;


        }


        //Herencia
            // Es el mismo concepto de la herencia en la vida real
            // Principio "es-un" : un jefe "es un" empleado? | si la respuesta es si, debe de existir herencia

        //OBJECT
            // TOdos las clases herarám de la clase Object (Por eso es llamada superclase cosmica)

        //PRINCIO DE SUSTITUCION
            // Sustituir un ejemplo por otro

        //POLIMORFISMO
            // Si una clases tienen un metodo con un mismo nombre que la clase de la que hereda, esta clase anulará el metodo de la clase "Padre" y solo tendrá el declarado en la clase actual, en caso de que uno de sus metodos tenga diferentes parametros, tendriamos sobre carga de metodos
            //Capacidad de un objeto para comportarse de diferente forma o a tener diferente forma dependiendo del contexto
    
 
  class Mamiferos
    {

        private String nombreSerVivo;

        public Mamiferos(String nombre)
        {
            this.nombreSerVivo = nombre;
        }

        // Virtual abre la posibilidad de modificar el metodo en las diferentes subclases desde la que heredamos
        public virtual void pensar() 
        {
            Console.WriteLine("Pensamiento básico institivo");
        }

        public void respirar()
        {
            Console.WriteLine("RESPIRAMOS");
        }


        public void cuidarCrias()
        {
            Console.WriteLine("CUIDAMOS DE LAS CRIAS");
        }    
    }


    //APLICAR LA HERENCIA A UNA CLASE
    class Caballo: Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
          public void galopar()
        {
            Console.WriteLine("Galopar");
        }
    }

    class Humano: Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }

        // Para que sea una sobre-escritura del metodo utilizamos la palabra reservada override | el new oculta el metodo anterior 
        public override void pensar()
        {
            Console.WriteLine("Pienso");
        }
    }

    class Gorila : Mamiferos
    { 

        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("TREPO");
        }

        public override void pensar()
        {
            Console.WriteLine("Pienso como un gorila");
        }

    }













    // CLASES ANONIMAS
    // No suelen tener nombre
    // Se utiliza para realizar querys a base de datos
    //
 


       //Herencia
            // Es el mismo concepto de la herencia en la vida real
            // Principio "es-un" : un jefe "es un" empleado? | si la respuesta es si, debe de existir herencia

        //OBJECT
            // TOdos las clases herarám de la clase Object (Por eso es llamada superclase cosmica)

        //PRINCIO DE SUSTITUCION
            // Sustituir un ejemplo por otro

        //POLIMORFISMO
            // Si una clases tienen un metodo con un mismo nombre que la clase de la que hereda, esta clase anulará el metodo de la clase "Padre" y solo tendrá el declarado en la clase actual, en caso de que uno de sus metodos tenga diferentes parametros, tendriamos sobre carga de metodos
            //Capacidad de un objeto para comportarse de diferente forma o a tener diferente forma dependiendo del contexto
 
 */



/*


    //MODIFICADORES DE ACCESO
        // Public, podemos acceder desde cualquier clase (No es recomendable declarar las variables como public, la información fluye normalmente por medio de set y get)
        // Private, accesible solo desde la clase mamifero (Encapsulamiento)
        // protected, es accesible desde la clase en donde se declare y de aquellas clases que hereden
        //
  


 
 
 
 */


/*
 
  class Program
    {



        static void Main(string[] args)
        {

            ComidaRapida papas = new ComidaRapida();

            // Llamar metodo com ambiguedad
            IComida Ipapas = papas;
            Ipapas.comeArroz();
            

        }


        //INTERFACES
            // Los nombres de las interfaces en C# se acostumbra iniciar por I mayuscula
            // No debe de contar con modificador de acceso
            // Las interfaces en C# solo contienen metodos y eventos
            // Su funcionamiento es similar a typeScript a diferencia de que en este caso solo se pueden colcar metodos NO propiedades
            // Las interfaces nos obligan a implementar un metodo en particular
            // Podemos usar varias interfaces para una sola clase

        //RESTRICCIONES
            // No se permite definir variables
            // No se puede definir destructores
            // No se pueden especificar modificadores de acceso en métodos (Todos son public de forma implícita)
            // No se pueden anidar clases ni otro tipo de estructuras

         
    
    }
    interface IComida
    {
        public int Calcularcalorias();
        public bool comeArroz();
    }

    interface IEsSaludable
    {
        public int CalcularcaloriasSaludables();
        public bool comeArroz();
    }
    class Comida{
        int data;
        Comida(int data) {
        this.data = data;
        }
    
    }


    class ComidaRapida: IComida, IEsSaludable
    {
         public int Calcularcalorias()
        {
            return 12;
        }
            

        //Cuando tenemos una ambiguedad (Dos interfaces que tienen un mismo metodo) podemos indentificar el metodo, quitando el modificador de acceso y anteponiendo el nombre de la interface
        bool IComida.comeArroz()
        {
            return true;
        }

        bool IEsSaludable.comeArroz()
        {
            return true;
        }


        public int CalcularcaloriasSaludables()
        {
            return 1;
        }
    }

 
 
 
 
 */


/*
 * 
 * 
 * 
 * CLASE ABSTRACTA
 
         static void Main(string[] args)
        {

            Lagartija Juan = new Lagartija();
            Juan.respirar();
        }

        // CLASES ABSTRACTAS
        // Una clase que hace menos, cosas o que es capaz de hacer menos cosas en la aplicación
        // Cuando tenemos al menos un metedo abstracto, la clase debe de ser abstracta

        // METODO ABSTRACTO
        // Un metodo que no está desarrollado y que solo tiene una declaración


        //DECLARACIÓN
        abstract class Animales
        { 
            public void respirar()
            {
                Console.WriteLine("Soy capaz de respirar");
            }


            //Hobliga a todas las clases que hereden esta clase a utilizar el metodo getNombre
            public abstract void getNombre();


        }


        class Mamiferos : Animales {

            public override void getNombre()
            {
                Console.WriteLine("Nombre de un mamifero");
            }

        }


        class Lagartija : Animales
        {
            public override void getNombre()
            {
                Console.WriteLine("Soy una lagartija");
            }
        }

 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */


/*
 CLASES SELLADAS



        static void Main(string[] args)
        {

        }

        //CLASES SELLADAS (Sealed)
        // Clase de la cual no se va a poder herdar
        // Al usar selead No permite heredar la clase

        //METODOS SELLADOS (Sealed)
        // Al igual que las clases evitan la psoibilidad de herencia


        /*
        sealed class Mamiferos 
        {
     
            public Mamiferos(int numero)
            {
                Console.WriteLine(numero);
            }
            public  void getNombre()
            {
                Console.WriteLine("Nombre de un mamifero");
            }

        }

        */

/*
class Animal
{

    public virtual void getNombre()
    {

    }
}


class Mamiferos : Animal
{

    public Mamiferos(int numero)
    {
        Console.WriteLine(numero);
    }


    // Los saled metodos NO pueden ser sobreescritos
    public sealed override void getNombre()
    {
        Console.WriteLine("Nombre de un mamifero");
    }

}


class Humano : Mamiferos
{

    public Humano(int numero) : base(numero)
    {
        Console.WriteLine(numero);
    }


}


*/

/*
 
  class Program
    {



        static void Main(string[] args)
        {

        }


    }


    class Empleado
    {
        //CREACIÓN DE PROPIEDADES
        private double salario;
        private string nombre = string.Empty;
        private double evaluarSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }
        public double SALARIO
        { 
               get { return this.salario;  }
               set { this.salario = evaluarSalario(value); } 
        }

        //Otra sintaxis
        public double _salario
        {
            get => this.salario;
            set =>  this.salario = evaluarSalario(value);
        }


    }
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */

/*
 
     class Program
    {



        static void Main(string[] args)
        {

        }


    }


    /*
     
     
     MEMORIA
        - STACK: Almacena clases primitivas y referencias a objetos "De acceso rapido"
        - HEAP: Guarda al objeto, de acceso "lento"

     
     
     */

//STRUCT
// - Se utiliza de la misma manera que las clases, pero varía su ubicación en memoria
// - Cada cambio a las estructuras genera una nueva copia de la misma, NO una modificación por referencia
// - No herendan de otras clases pero SI de interfaces
// - El compilador no inicia los campos, puedes iniciarlos en el constructor
// - NO puede haber sobrecarga de constructores
//¿CUANDO LO USAMOS? Cuando necesitamos almacenar una cantidad muy alta de datos en memoria

/*

struct Empleado
{
    string nombre;
    public Empleado(string nombre)
    {
        this.nombre = nombre;
    }


}

*/


/*
 * 
 * 
 *  ENUM
 
     class Program
    {



        static void Main(string[] args)
        {
            Estaciones cerca = Estaciones.Estadio;
        }


    }

    // ENUM
        // SON VALORES FIJOS, CONSTANTES
        // AUTOMATICAMENTE SE ASIGNAN DE 0 en adelante
        // SOLO PUEDEN SER INT LOS DATOS ALMACENADOS

    class ENUM_CLASS {
    
    }


    enum Estaciones { Sta_lucia = 100, Floresta = 200, Estadio = 300 };
    enum Nombres { Nombre ("Daniel"),}
 
 
 
 
 
 
 
 
 
 
 
 */


/*
    static void Main(string[] args)
        {

            var metodo = new ManejoDeArchivos();
        }


        /*
         
            Garbage Collection
                -  Ver objeto que no se utilizarán mas.
                -  Elimina los recursos que no utilizamos.
                -  Automaticamente el lenguaje limpia los recursos

            DESTRUCTORES
                - Cada vez que se elimina un recuros
                - Conexiones con bases de datos
                - Cerrar ficheros externos     
                - Solo se usan en clases
                - Cada clase solo puede tener un destructor
                - Los destructores no se heredan ni se sobrecargan
                - NO tienen modificadores de acceso NI parametros
         
         */

/*
class ManejoDeArchivos
{

    StreamReader archivo = null;
    int contador = 0;
    string linea;
    public ManejoDeArchivos()
    {
        this.archivo = new StreamReader(@"c:\HOLA_MUNDO.txt");
        while ((linea = archivo.ReadLine()) != null)
        {
            Console.WriteLine(linea);
            contador++;
        }
    }

    //DESTRUCTOR (ICONO SE CREA CON alt+126)
    ~ManejoDeArchivos()
    {
        archivo.Close();
        Console.WriteLine("Se cerró la lectura")
            }


 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */