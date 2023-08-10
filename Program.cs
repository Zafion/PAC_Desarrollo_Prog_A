using System;

namespace Actividad_1_de_desarrollo__UF1_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  ALUMNO: José Luis Montañana Llopis.
                
                ACTIVIDAD 1 DE DESARROLLO - UNIDAD FORMATIVA 1 - PROGRAMACIÓN.

                ENUNCIADO:                
             
             El programa consiste en trabajar con una variable que contiene la información: “ilerna online programacion a 2º semestre 2022”
             Se pide:
             Imprimir por consola la variable en mayúsculas sin espacios
             Imprimir por consola el total de consonantes de la variable
             Imprimir por consola el total de números que tiene la variable
             Imprimir por consola solo las consonantes y en el orden que las va encontrando.
             
             No se corregirán proyectos entregados por otros medios, como los adjuntos de los comentarios de la tarea o los mensajes privados
             El alumno o alumna es responsable y conocedor de estas normas en el momento de la entrega del ejercicio.
             Cualquier código detectado por plagio es SUSPENSO para ambas partes.
             La solución del ejercicio debe realizarse mediante programación secuencial (queda prohibido usar funciones o procedimientos). 
             No se admitirán soluciones en las no se aplique esta solución.
             Cuidado con no inicializar las variables
             Aseguraros al 100% que se muestra por consola la información que se pide en el enunciado.
             Se recomienda usar bucles y condicionales
             Se recomienda usar estas variables (a elección del alumno usarlas):
             String consonantes = "bcdfghjklmnñpqrstvwxyz"; 
             String numeros = "0123456789"; */

            // Antes de empezar los ejercicios propiamente dichos, declaramos las variables que nos indica el enunciado:

            String Original = "ilerna online programacion a 2º semestre 2022";
            String consonantes = "bcdfghjklmnñpqrstvwxyz";
            String numeros = "0123456789";

            /* ------------ primer ejercicio ----------------
            Primero, quitamos espacios - podríamos usar la función Replace:
                  string SinEsp = Original.Replace(" ", String.Empty);
            Pero como para esta actividad se recomienda usar bucles y condicionales lo hacemos sin esa función:
            Creamos un vector char con el metodo ToCharArray, definimos un char con el espacio y otro vacío '/0' con Char.MinValue
            Combinamos un bucle for con un if para recorrer el Array y sustituir los espacios por '/0                        */

            char[] SinEsp = Original.ToCharArray();
            char espacio = ' ';
            char vacio = Char.MinValue;

            for (int i = 0; i < SinEsp.Length; i++)
            {
                if (SinEsp[i] == espacio)
                {
                    SinEsp[i] = vacio;
                }
            }

            /* Después pasamos a mayúsculas - Podríamos usar la función ToUpper:            
                  string MayuscSinEsp = SinEsp.ToUpper(); 
            Pero como para esta actividad se recomienda usar bucles y condicionales lo hacemos sin esa función:
            Declaramos 2 variables con el abecedario en mayusculas y minúsculas.                          */

            String minusculas = "abcdefghijklmnñopqrstuvwxyz";
            String mayusculas = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

            // Combinando 2 bucles for, sustituimos las mayúsculas por minúsculas.

            for (int i = 0; i < SinEsp.Length; i++)
            {
                for (int j = 0; j < minusculas.Length; j++)
                {
                    if (SinEsp[i] == minusculas[j])
                    {
                        SinEsp[i] = mayusculas[j];
                    }
                }
            }

            // Por último imprimimos por consola cada letra del vector usando un bucle for.

            for (int i = 0; i < SinEsp.Length; i++)
            {
                Console.Write(SinEsp[i]);
            }

            /* Antes de empezar el siguiente ejercicio, añadimos con Console.WriteLine(); un salto de línea.
            Lo necesitamos para que la respuesta al ejercicio 1 no se junte con la del ejercicio 2.           */

            Console.WriteLine();

            /* ------------ Segundo ejercicio ----------------
            Contamos consonantes combinando 2 bucles for y un if. De seguido imprimimos por consola con Console.WriteLine.*/

            int CuentaConsonantes = 0;

            for (int i = 0; i < Original.Length; i++)
            {
                for (int j = 0; j < consonantes.Length; j++)
                {
                    if (Original[i] == consonantes[j])
                    {
                        CuentaConsonantes++;
                    }
                }
            }
            Console.WriteLine(CuentaConsonantes);

            /* ------------ Tercer ejercicio ----------------
            Contamos numeros combinando 2 bucles for y un if. De seguido imprimimos por consola con Console.WriteLine.   */

            int Cuentanumeros = 0;

            for (int i = 0; i < Original.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (Original[i] == numeros[j])
                    {
                        Cuentanumeros++;
                    }
                }
            }
            Console.WriteLine(Cuentanumeros);

            /* ------------ Cuarto ejercicio ----------------
            Comprobamos si cada carácter es consonante combinando 2 bucles for.
            Si lo respuesta es true, imprimimos por consola con Console.Write.   */

            for (int i = 0; i < Original.Length; i++)
            {
                for (int j = 0; j < consonantes.Length; j++)
                {
                    if (Original[i] == consonantes[j])
                    {
                        Console.Write(Original[i]);
                    }
                }
            }

        }

    }
    
}
