using System.Diagnostics;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ingresa la cantidad en minutos para apagar la computadora:  ");
        int minutos;
        if (!int.TryParse(Console.ReadLine(), out minutos))
        {
            Console.WriteLine("Entrda invalidad. debe ingresar un numero entero.");
            return;
        }

        int segundos = minutos * 60;
        Console.WriteLine($"la computadora se apagara en {minutos} minutos. ");

        //ejecutar el comando para apagar la computadora en una terminal MS-DOS
        Process.Start("cmd.exe ", $"/C shutdown /s /t {segundos}");

        Console.WriteLine("desea detener el apagado de la computadora! (Y/N):");
        string respuesta = Console.ReadLine().ToLower();

        if (respuesta == "Y" || respuesta == "yes")
        {
            //ejecutar el comando para cancelar el apagado en una terminal de ma-dos
            Process.Start("cmd.exe", "/C shutdown /a");
            Console.WriteLine("apagado de computadora cancelado.");
        }
        else
        {
            Console.WriteLine("no se detubo el apagado de la computadora.");

        }

        Console.ReadKey();


    }
}

