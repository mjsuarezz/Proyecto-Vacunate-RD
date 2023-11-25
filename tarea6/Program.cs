

bool continuar = true;
{
    Console.Clear();
    Console.WriteLine(@"
  
  Bienvenidos al sistema de vacuacion  ♥");
    ConsoleColor colorOriginal = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@"
                                    _           __    ___   
 /\   /\__ _  ___ _   _ _ __   __ _| |_ ___    /__\  /   \  
 \ \ / / _` |/ __| | | | '_ \ / _` | __/ _ \  / \// / /\ /  
  \ V / (_| | (__| |_| | | | | (_| | ||  __/ / _  \/ /_//_  
   \_/ \__,_|\___|\__,_|_| |_|\__,_|\__\___| \/ \_/___,'(_) 
                                                      
                    ");

    ConsoleColor colorOoriginal = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(@"

                              +-+-+-+-+
                              |M|e|n|u|
                              +-+-+-+-+
                                
                    ********************************
                    1-Registrar Vacunado.
                    2-Exportar.
                    3-Configuracion.
                    x - Salir
                    ********************************

  ");

Console.WriteLine("Ingrese una opcion: ");
string opcion = Console.ReadLine()??"";
switch (opcion)
{

case "1":
Modulos.Registrar_Vacunado();

 break;

case "2":

Console.WriteLine("Exportar tarjeta de vacunacion. ");
Modulos.Exportar();

 break;

case "3":

Console.WriteLine("Configuracion. ");
Modulos.Configuracion();
break;

case "x":

continuar = false;
Utils.MostrarMensaje("Gracias por ayudar a salvar la humanidad");

break;

default:

Utils.MostrarMensajeError("Opcion no valida :( ");
  break;



}
}