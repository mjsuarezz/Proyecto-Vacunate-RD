class Utils{
public static string LeerString(string mensaje){

Console.Write(mensaje);
return Console.ReadLine();

}

public static string Input(string mensaje)
{
Console.Write(mensaje);
return Console.ReadLine();
}
public static double LeerDouble(string mensaje){

Console.Write(mensaje);
double num = 0;
while(!double.TryParse(Console.ReadLine(), out  num)){
     MostrarMensaje("Ingrese un numero valido", ConsoleColor.Blue);
}
     return num;

}

public static void MostrarMensajeError(string mensaje){

MostrarMensaje(mensaje, ConsoleColor.Red);

}

public static void MostrarMensaje(string mensaje){
     MostrarMensaje(mensaje, ConsoleColor.Magenta);

}
public static void MostrarMensaje(string mensaje, ConsoleColor color){
Console.ForegroundColor =color;
Console.WriteLine(mensaje);
Console.ResetColor();
Console.WriteLine("Presiona cualquier tecla para continuar...");
Console.ReadKey();
}
public static void Pausa(){
     Console.WriteLine("Presiona cualquier tecla para continuar...");
     Console.ReadLine();
}

}