using Microsoft.EntityFrameworkCore;

class Modulos{ 

public static void Configuracion(){


bool continuar = true;
while(continuar){
    Console.Clear();
    Console.WriteLine(@"
     :
 '.  _  .'
-=  (~)  =-   
 .'  #  '.

Configuracion

p- Provincias.
v- Vacunas.
r- Regresar.
");
Console.Write(" Ingrese una opcion: ");
string opcion = Console.ReadLine()??"";
switch (opcion)
{
case "p":
Console.WriteLine("Provincias");
Modulos.Conf_Provincias();
break;

case "v":

Console.WriteLine("Vacunas");
Modulos.Conf_Vacunas();
 break;

case "r":
continuar = false;
break;
default:
Utils.MostrarMensajeError("Opcion no valida");
Utils.Pausa();
break;

}
}
} 
public static void Conf_Provincias(){
var db = new CovidContext();

bool continuar = true;
while(continuar){
Console.Clear();
Console.WriteLine(@"
Gestion de Provincias

   x
.-. _______|
|=|/     /  \
| |_____|_""_|
|_|_[X]_|____|

****************************
1- Agregar Provincia.
2- Editar Provincia.
3- Eliminar Provincia.
r- Regresar
****************************

");
Console.Write(" Ingrese una opcion: ");
string opcion = Console.ReadLine()??"";
switch (opcion){

case "1":
Console.WriteLine("Agregar provincia");
Console.Clear();
Console.WriteLine(@"Vamos a agregar una provincia ♥

                             ^
                _______     ^^^
               |xxxxxxx|  _^^^^^_
               |xxxxxxx| | [][]  |
            ______xxxxx| |[][][] |
           |++++++|xxxx| | [][][]|      
           |++++++|xxxx| |[][][] |
           |++++++|_________ [][]|
           |++++++|=|=|=|=|=| [] |
           |++++++|=|=|=|=|=|[][]|
___________|++HH++|  _HHHH__|   _________   _________  _________
         _______________   ______________      ______________
__________________  ___________    __________________    ____________

");


var p = new Provincia();
p.Nombre = Utils.Input("Ingrese el nombre de la provincia: ");
    db.Provincias.Add(p);
    db.SaveChanges();
    
    Utils.MostrarMensaje("Provincia agregada");
    Utils.Pausa();
break;

case "2":
Console.WriteLine("Editar privincia");
Console.Clear();
Console.WriteLine("Vamos a editar una provincia ☻");
Console.WriteLine(@"

 
 **********************************");


List<Provincia> provincias = db.Provincias.ToList();
foreach (var prov in provincias){
    Console.WriteLine($"{prov.Id} - {prov.Nombre}");
}
Console.WriteLine("**********************************");


Console.WriteLine("Ingrese el id de la provincia a editar: ");
var editar = db.Provincias.Find(int.Parse(Console.ReadLine()));
if(editar == null){
Utils.MostrarMensajeError("No se encontro la provincia");
Utils.Pausa();

}else{

Console.WriteLine($"Ingrese el nuevo nombre de la provincia: ({editar.Nombre})");
editar.Nombre = Console.ReadLine()??"";
db.SaveChanges();
Utils.MostrarMensaje("Provincia Editada ♥");
}
break;

case "3":
Console.Clear();
Console.WriteLine("Eliminar provincia");
List<Provincia> Provincias2 = db.Provincias.ToList();
foreach(var prov in Provincias2){
    Console.WriteLine($"{prov.Id} - {prov.Nombre}");

}
Console.WriteLine("Ingrese el id de la provincia a eliminar: ");
var eliminar = db.Provincias.Find(int.Parse(Console.ReadLine()));
if(eliminar == null){
Utils.MostrarMensajeError("No se encontro la provincia");
Utils.Pausa();
}else{

db.Provincias.Remove(eliminar);
db.SaveChanges();
Utils.MostrarMensaje("Provincia eliminada ♥");
}
Utils.Pausa();

break;

case "r":
continuar = false;
break;
default:
Utils.MostrarMensajeError("Opcion no valida");
Utils.Pausa();
break;


}


}
}
public static void Conf_Vacunas(){
var db = new CovidContext();
bool continuar = true;
while(continuar){
    Console.Clear();
    Console.WriteLine(@"
              _________
             {_________}
              )=======(
             /         \
            | _________ |
            ||   _     ||
            ||  |_)    ||
            ||  | \/   ||
      __    ||    /\   ||
 __  (_|)   |'---------'|
(_|)        `-.........-'
Gestion de vacunas
**************************************
1- Agregar vacunas.
2- Editar Vacuna.
r- Regresar.
**************************************
");

Console.Write(" Ingrese una opcion: ");
string opcion = Console.ReadLine()??"";
switch (opcion)
{
case "1":
Console.WriteLine("Agregar vacuna");
var v = new Vacuna();
v.Nombre = Utils.Input("Ingrese el nombre de la Vacuna: ");
    db.Vacunas.Add(v);
    db.SaveChanges();
    
    Utils.MostrarMensaje("Vacuna agregada");
    Utils.Pausa();

break;

case "2":

Console.WriteLine("Editar vacuna");

Console.Clear();
Console.WriteLine("Vamos a editar una vacuna ☻");
Console.WriteLine(@"

 
 **********************************");


List<Vacuna> vacunas = db.Vacunas.ToList();
foreach (var vac in vacunas){
    Console.WriteLine($"{vac.Id} - {vac.Nombre}");
}
Console.WriteLine("**********************************");


Console.WriteLine("Ingrese el id de la vacuna a editar: ");
var editar = db.Vacunas.Find(int.Parse(Console.ReadLine()));
if(editar == null){
Utils.MostrarMensajeError("No se encontro la vacuna");

}else{

Console.WriteLine($"Ingrese el nuevo nombre de la vacuna: ({editar.Nombre})");
editar.Nombre = Console.ReadLine()??"";
db.SaveChanges();
Utils.MostrarMensaje("Vacuna Editada ♥");

 break;
}
Utils.Pausa();
 break;
 case "3":
Console.Clear();
Console.WriteLine("Eliminar vacuna");
List<Vacuna> Vacunas2 = db.Vacunas.ToList();
foreach(var vac in Vacunas2){
    Console.WriteLine($"{vac.Id} - {vac.Nombre}");

}
Console.WriteLine("Ingrese el id de la vacuna a eliminar: ");
var eliminar = db.Vacunas.Find(int.Parse(Console.ReadLine()));
if(eliminar == null){
Utils.MostrarMensajeError("No se encontro la vacuna");
}else{

db.Vacunas.Remove(eliminar);
db.SaveChanges();
Utils.MostrarMensaje("Vacuna eliminada ♥");
}
Utils.Pausa();

break;

case "r":
continuar = false;
break;
default:
Utils.MostrarMensajeError("Opcion no valida");
Utils.Pausa();
break;

}
}
}

public static void Registrar_Vacunado(){
var db = new CovidContext();

Console.Clear();
Console.WriteLine("Registrar vacunado");
var p = new Persona ();
var proceso = new Proceso ();

var cedula = Utils.Input("Ingrese la cedula sin guiones");
p = db.Personas.Where(x=> x.cedula == cedula).FirstOrDefault();

//si la persona no existe 
if(p == null ){
    p = new Persona();
    p.cedula = cedula;

var PersonaCedula = new Persona_cedula();
PersonaCedula.ok = false;
try{
var url = "https://api.admix.net/apec/cedula/"+cedula;
var client = new HttpClient();
var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
 PersonaCedula = Newtonsoft.Json.JsonConvert.DeserializeObject<Persona_cedula>(response);
}

catch(Exception){ }

if(PersonaCedula.ok){
p.Nombre = PersonaCedula.Nombres;
p.Apellido = $"{PersonaCedula.Apellido1} {PersonaCedula.Apellido2}";
}else{
p.Nombre = Utils.Input("Ingrese el nombre: ");
p.Apellido = Utils.Input("Ingrese el apellido: ");
}
p.Telefono = Utils.Input("Ingrese el numero telefonico: ");
db.Personas.Add(p);

}

proceso.Persona = p;
proceso.Fecha = DateTime.Now;


while(proceso.Vacuna == null){

Console.WriteLine(@"

 
 **********************************");
var listadoVacunas = db.Vacunas.ToList();
foreach (var vac in listadoVacunas){
    Console.WriteLine($"{vac.Id} - {vac.Nombre}");


}
Console.WriteLine("**********************************");

Console.WriteLine(" Ingrese el id de la vacuna: ");
var vacuna = db.Vacunas.Find(int.Parse(Console.ReadLine()));
if(vacuna== null){

Utils.MostrarMensajeError("No se encontro la vacuna :( ");
}
else{

    proceso.Vacuna = vacuna;
}

}



while(proceso.Provincia == null){

Console.WriteLine(@"

 
 **********************************");
var listadoProvincias = db.Provincias.ToList();
foreach (var prov in listadoProvincias){
    Console.WriteLine($"{prov.Id} - {prov.Nombre}");


}
Console.WriteLine("**********************************");

Console.WriteLine(" Ingrese el id de la provincia: ");
var provincia = db.Provincias.Find(int.Parse(Console.ReadLine()));
if(provincia== null){

Utils.MostrarMensajeError("No se encontro la provincia :( ");
}
else{

    proceso.Provincia = provincia;
}
}
db.Pocesos.Add(proceso);
db.SaveChanges();
Utils.MostrarMensaje("Vacunado registrado");
Utils.Pausa();


}

public static void Exportar(){
var db = new CovidContext();

Console.Clear();
Console.WriteLine("Vamos a exportar una tarjeta");
Persona persona = null;
while(persona == null);
{
var cedula = Utils.Input("Ingrese la cedula sin guiones o x para ver el listado de las personas");


Console.WriteLine(@"

 
 **********************************");
 if(cedula.ToLower().Trim() =="x"){
var listadoPersonas = db.Personas.ToList();
foreach (var p in listadoPersonas){
    Console.WriteLine($"{p.Id}){p.cedula} - {p.Nombre} {p.Apellido}");
}



        if(cedula.ToLower().Trim() == "x"){
            var ListPersona = db.Personas.ToList();
            foreach(var p in ListPersona){
                Console.WriteLine($"{p.cedula} - {p.Id} - {p.Nombre} - {p.Apellido}");
            }
            cedula = Utils.Input("Digite el ID de  la persona: ");
            persona= db.Personas.Find(int.Parse(cedula));
         }else{
            persona= db.Personas.Where(x => x.cedula == cedula).FirstOrDefault();
         }
        }
        var ListProcesos = db.Pocesos.Where(x => x.Persona.cedula == persona.cedula)
        .Include(x => x.Vacuna).Include(x => x.Provincia ).ToList();

        Console.WriteLine($"{persona.Nombre}{persona.Apellido}");
        var detalle = "";
        foreach(var Procesos in ListProcesos){
            Console.WriteLine($"{Procesos.Id} {Procesos.Vacuna.Nombre} - {Procesos.Provincia.Nombre} {Procesos.Fecha.ToShortDateString()}");
            detalle += @$"

                <tr>
                    <td>{Procesos.Fecha.ToShortDateString()}</td>
                    <td>{Procesos.Vacuna.Nombre}</td>
                    <td>{Procesos.Provincia.Nombre}</td>
                </tr>
            ";
        }
var html = @$"
            <html>
                <head>
                    <title> Tarteja de {persona.Nombre} {persona.Apellido}</title>
                        <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css%27%3E
                </head>
                <body>
                    <div class='container'> 
                        <img style= 'max-width:200px' src='https://api.adamix.net/apec/foto2/%7Bpeople.IdCard%7D' alt='logo' class='logo'>
                        <h1>Tarteja de {persona.Nombre} {persona.Apellido}</h1>
                        <h3>Cedula {persona.cedula}</h3>
                        <h3>telefono {persona.Telefono}</h3>

                        <h4>Procesos aplicados</h4>
                        <table>
                            <head>
                                <tr>
                                    <th>Fecha</th>
                                    <th>Vacuna</th>
                                </tr>
                            </head>
                            <tbody>
                                {detalle}
                            </tbody>
                        </table>

                    </div>
                </body>
            </html>

        ";
        System.IO.File.WriteAllText("Tarjeta.html", html);
        Console.WriteLine("Tarjeta generada");
        var uri = "Tarjeta.html";
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = uri;
        System.Diagnostics.Process.Start(psi);

        Utils.Pausa();

    }

}


}

