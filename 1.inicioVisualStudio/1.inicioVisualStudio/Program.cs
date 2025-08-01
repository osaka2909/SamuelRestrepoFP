namespace _1.inicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración e inicialización de una variable
            string nombre = "Samuel";
            const string iva = "19%";

            Console.Write("Hola, " + nombre + "\n");
            Console.Write("\tBienvenido a la clase de programación");
            nombre = "Alejandro";
            Console.Write("\n" + nombre);
            //iva = "20%"; no se puede cambiar el valor de una constante

            //Tipos de datos
            byte dato1 = 255;
            int dato2 = 202321;
            long dato3 = 9202125235;
            double dato4 = 326.625;
            char dato5 = 'A';//almacena un solo caracter
            bool dato6 = false;//almacena true or false
            object dato7 = new Program;
        }
    }
}
