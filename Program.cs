using Examen02.Clases;
using Examen02.Interfaces;

List<EmpleadoBase> empleados = new List<EmpleadoBase>();

Gerente gerente = new Gerente { 
    IdEmpleado = 202401,
    Nombre = "Ernesto Guevara",
    Puesto = "Gerente"    
};

Desarrollador desarrollador = new Desarrollador
{
    IdEmpleado = 202405,
    Nombre = "Raúl Castro",
    Puesto = "Desarrollador Senior"
};

GerenteRRHH gerenteRRHH = new GerenteRRHH
{
    IdEmpleado = 202402,
    Nombre = "Lidia Quispe",
    Puesto = "Gerente RR.HH."
};

ConsultorExterno consultorExterno = new ConsultorExterno
{
    IdEmpleado = 202491,
    Nombre = "Juan Condori",
    Puesto = "Consultor Externo"
};

empleados.Add(gerente);
empleados.Add(desarrollador);
empleados.Add(gerenteRRHH);
empleados.Add(consultorExterno);


Console.WriteLine("PERSONAL INICIAL SIN MENÚ");
Console.WriteLine("=========================");
Console.WriteLine("\n");

SinMenu();



void SinMenu()
{
    decimal TotalPlanilla = 0;

    foreach (var empleado in empleados)
    {

        Console.WriteLine("Detalles");
        empleado.MostrarDetalles();


        if (empleado is ISueldoBonificable empleadoBonificable)
        {
            Console.WriteLine($"Bonificacion = {empleadoBonificable.CalcularBonificacion()}");
        }

        if (empleado is IDescuentoImpuesto empleadoDescuento)
        {
            Console.WriteLine($"Descuento = {empleadoDescuento.DescontarSueldo()}");
        }

        Console.WriteLine($"Sueldo = {empleado.CalcularSueldo()}");

        TotalPlanilla = TotalPlanilla + empleado.CalcularSueldo();
    }

    Console.WriteLine("\n");
    Console.WriteLine("-----------------------------------------");    
    Console.WriteLine("Total Empleados : " + empleados.Count());
    Console.WriteLine("Total Empleados : " + TotalPlanilla);
}

Console.WriteLine("\n");

try
{

    string opcion = "";
    do
    {
        Console.WriteLine("* MENU *");
        Console.WriteLine("========");
        Console.WriteLine("1. Ingresar Empleado");
        Console.WriteLine("2. Mostrar Listado de Empleado");
        Console.WriteLine("3. Salir");

        opcion = Console.ReadLine();

        Console.WriteLine("\n");

        switch (opcion)
        {
            case "1":
                string tipo = "";
                
                Console.WriteLine("Ingrese Tipo Empleado : ");
                Console.WriteLine("1. Gerente");
                Console.WriteLine("2. Gerente RR.HH.");
                Console.WriteLine("3. Desarrollador");
                Console.WriteLine("4. Consultor Externo");
                Console.WriteLine("--------------------");
                Console.WriteLine("5. Cancelar");
                tipo = Console.ReadLine();
                
                if (Convert.ToInt32(tipo) >= 1 && Convert.ToInt32(tipo) <= 4) IngresarEmpleado(tipo);
                break;

            case "2":
                SinMenu();



                break;
            case "3":
                Console.WriteLine("Gracias por participar...");
                break;
        }
    } while (opcion != "3");




    void IngresarEmpleado(string TipoEmpleado)
    {
        Console.WriteLine("IdEmpleado");
        int IdEmpleadoX = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nombre");
        string NombreX = Console.ReadLine();
        Console.WriteLine("Puesto");
        string PuestoX = Console.ReadLine();

        switch (TipoEmpleado)
        {
            case "1":
                Gerente gerente1 = new Gerente();
                gerente1.ObtenerDatos(IdEmpleadoX, NombreX, PuestoX);
                empleados.Add(gerente1);
                break;
            case "2":
                GerenteRRHH gerenteRRHH1 = new GerenteRRHH();
                gerenteRRHH1.ObtenerDatos(IdEmpleadoX, NombreX, PuestoX);
                empleados.Add(gerenteRRHH1);
                break;
            case "3":
                Desarrollador desarrollador1 = new Desarrollador();
                desarrollador1.ObtenerDatos(IdEmpleadoX, NombreX, PuestoX);
                empleados.Add(desarrollador1);
                break;
            case "4":
                ConsultorExterno consultorExterno1 = new ConsultorExterno();
                consultorExterno1.ObtenerDatos(IdEmpleadoX, NombreX, PuestoX);
                empleados.Add(consultorExterno1);
                break;
        }
    }
}
catch(FormatException e)
{
    Console.WriteLine("Error: El valor ingresado no es un número válido.");
    Console.WriteLine("Detalles del error: " + e.Message);
}
catch(Exception e)
{
    Console.WriteLine("Error, por favor contactarse con el administrador");
    Console.WriteLine("Detalles del error: " + e.Message);
}

Console.Read();