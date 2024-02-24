try {
int num1, num2, num3, mayor,paso;

Console.WriteLine("VAMOS A CANCULAR EL MAYOR DE TRES NUMERO ENTEROS ");
Console.WriteLine("Introduzca el primer número:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca el segundo número:");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca el tercer número:");
num3 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        mayor = num1;
    }
    else
    {
        mayor = num3;
    }
}
else
{
    if (num2 > num3)
    {
        mayor = num2;
    }
    else
    {
        mayor = num3;
    }
}


Console.WriteLine("El mayor de los tres números es: {0} ", mayor);
Console.WriteLine("parte 2#");


Console.WriteLine("HAHORA VAMOS HACER UNA VALIDACION PARA UN CLUB LOS CUALES TIENE QUE TENER CIERTO REQUISITOS");
Console.WriteLine("COMO LA EDAD QUE SEA MAYOR DE 18 AÑOR");
int edad;
 edad=Convert.ToInt32(Console.ReadLine());
if (edad >= 18)
{
    Console.WriteLine("bienvenido al club");

}
else {
    Console.WriteLine("no admitido regrese cuando tenga la edad sufieciente gracias");

}
const double num4 = 10d;
double num5,num6,num7;

Console.WriteLine("parte 3#");
Console.WriteLine("VAMOS A CALCULAR LE PRECIO FINAL DE UN PRODUCTO CON EL DESCUENTO DEL 10% CUANDO PASE DE 100");
Console.WriteLine("ingrese el precio del producto ");
num5 = Convert.ToDouble(Console.ReadLine());
if (num5 > 100)
{
    num6 = (num4 / num5) * 100;
    num7 = num5 - num6;
    Console.WriteLine("el precio con descuento es :{0} ", num7);
}
else
{
    Console.WriteLine("precio normal no aplica descuento es:{0}",num5);
}

Console.WriteLine("parte 4#");
Console.WriteLine("VAMOS HACER UNA VALIDACION DE USUARIO Y CONTRASEÑA");
Console.WriteLine("el usuario es ALAN y la contraseña es hola");
string nombre;
string contra;
string usuario = "ALAN";
string contraseña1 = "hola";
Console.WriteLine("ingrese su nombre");
nombre = Convert.ToString(Console.ReadLine());
Console.WriteLine("ingrese la contraseña");
contra = Convert.ToString(Console.ReadLine());
if (nombre == usuario && contra == contraseña1)
{
    Console.WriteLine("usuario y contraseña admintos bienvenido");
}
else
{
    Console.WriteLine("contraseña y usuario incorrectos");
        }
Console.WriteLine("parte5#");
Console.WriteLine("VAMOS A CALCULAR SI UN NUMERO ES PAR O IMPAR ");
Console.WriteLine("ingres un numero ");
int num9;


num9 = Convert.ToInt32(Console.ReadLine());

if (num9 % 2 == 0) { 
Console.WriteLine("el numero es par");
}
else
{
    Console.WriteLine(" el numero es impar");
}
Console.WriteLine("parte 6#");
Console.WriteLine("VAMOS HACER UNA APROBACION DE UN PRESTAMOS");
Console.WriteLine("EL CUAL EL MONTO TIENE QUE SER MENOR A 50000 O SI EL USUARIO ES MAYOR DE 60 AÑOS");
const double MONTO_MAXIMO = 5000;
const int EDAD_MINIMA = 60;

double montoPrestamo;
Console.WriteLine("Introduzca el monto del préstamo:");
montoPrestamo = double.Parse(Console.ReadLine());

int edadUsuario;
Console.WriteLine("Introduzca su edad:");
edadUsuario = int.Parse(Console.ReadLine());

bool aprobado = false;
if (montoPrestamo <= MONTO_MAXIMO || edadUsuario >= EDAD_MINIMA)
{
    aprobado = true;
}

if (aprobado)
{
    Console.WriteLine("¡Felicidades! Su prestamo ha sido aprobado.");
}
else
{
    Console.WriteLine("Lo sentimos, su solicitud de prestamo ha sido rechazada.");

}
Console.WriteLine("parte6#");
Console.WriteLine("VAMOS A CALCULAR EL AREA DE UNA FIGURA GEOMETRICA");
char figura;
double area;

Console.WriteLine("Ingrese la figura (T/C/Q): ");
figura = Console.ReadLine().ToUpper()[0]; 

if (figura == 'T')
{
    double baseTriangulo, alturaTriangulo;
    Console.WriteLine("Ingrese la base del triángulo: ");
    baseTriangulo = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura del triángulo: ");
    alturaTriangulo = double.Parse(Console.ReadLine());
    area = (baseTriangulo * alturaTriangulo) / 2;
    Console.WriteLine("Área del triángulo: {0}", area);
}
else if (figura == 'C')
{
    double radioCirculo;
    Console.WriteLine("Ingrese el radio del círculo: ");
    radioCirculo = double.Parse(Console.ReadLine());
    area = Math.PI * radioCirculo * radioCirculo;
    Console.WriteLine("Área del círculo: {0}", area);
}
else if (figura == 'Q')
{
    double ladoCuadrado;
    Console.WriteLine("Ingrese el lado del cuadrado: ");
    ladoCuadrado = double.Parse(Console.ReadLine());
    area = ladoCuadrado * ladoCuadrado;
    Console.WriteLine("Área del cuadrado: {0}", area);
}
else
{
    Console.WriteLine("Figura inválida.");
}
Console.WriteLine("parte 1# usando switch");
string numeroenLetras;
int numeroenDigito;
int numeroDia;
string tipoServicio;
double importe;
string idioma;
int calificacion;
Console.WriteLine("Ingrese un número del 1 al 5 en letra:");
numeroenLetras = Console.ReadLine().ToLower();
switch (numeroenLetras)
{
    case "uno":
        numeroenDigito = 1;
        break;
    case "dos":
        numeroenDigito = 2;
        break;
    case "tres":
        numeroenDigito = 3;
        break;
    case "cuatro":
        numeroenDigito = 4;
        break;
    case "cinco":
        numeroenDigito = 5;
        break;
    default:

        Console.WriteLine("El número ingresado no es válido.");
        return;
}

Console.WriteLine("El número en dígito es: {0}", numeroenDigito);
Console.WriteLine("parte 2# ");



Console.WriteLine("Ingrese un número del 1 al 7:");
numeroDia = int.Parse(Console.ReadLine());

switch (numeroDia)
{
    case 1:
        Console.WriteLine("El día de la semana es: Lunes");
        break;
    case 2:
        Console.WriteLine("El día de la semana es: Martes");
        break;
    case 3:
        Console.WriteLine("El día de la semana es: Miércoles");
        break;
    case 4:
        Console.WriteLine("El día de la semana es: Jueves");
        break;
    case 5:
        Console.WriteLine("El día de la semana es: Viernes");
        break;
    case 6:
        Console.WriteLine("El día de la semana es: Sábado");
        break;
    case 7:
        Console.WriteLine("El día de la semana es: Domingo");
        break;
    default:

        Console.WriteLine("El número ingresado no es válido.");
        break;
}
Console.WriteLine("parte 3#");
Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revision mecanica):");
tipoServicio = Console.ReadLine().ToLower();
tipoServicio = tipoServicio.ToLower();
switch (tipoServicio)
{
    case "lavado de auto":
        importe = 20.0;
        break;
    case "cambio de aceite":
        importe = 50.0;
        break;
    case "revision mecanica":
        importe = 100.0;
        break;
    default:

        Console.WriteLine("El tipo de servicio ingresado no es válido.");
        return;
}


Console.WriteLine("El importe a pagar es: ${0}", importe);
Console.WriteLine("parte 4#");
Console.WriteLine("Ingrese el idioma de su preferencia (español, ingles, frances):");
idioma = Console.ReadLine().ToLower();


idioma = idioma.ToLower();


switch (idioma)
{
    case "español":
        Console.WriteLine("¡Hola! Bienvenido al programa.");
        break;
    case "ingles":
        Console.WriteLine("Hello! Welcome to the program.");
        break;
    case "frances":
        Console.WriteLine("Bonjour ! Bienvenue au programme.");
        break;
    default:

        Console.WriteLine("El idioma ingresado no es válido.");
        break;
}
Console.WriteLine("parte 5#");
Console.WriteLine("Ingrese la calificación del examen (0-100):");
calificacion = int.Parse(Console.ReadLine());
if (calificacion % 2 == 0)
{
    Console.WriteLine("la calificacion es un numero par");
}
else
{
    Console.WriteLine("la calidicaicon no es un numero par");
}
switch (calificacion)
{
    case int n when (n >= 95 && n <= 100):
        Console.WriteLine("¡Felicidades! Su desempeño es: Sobresaliente");
        break;
    case int n when (n >= 90 && n <= 94):
        Console.WriteLine("Su desempeño es: Sobresaliente");
        break;
    case int n when (n >= 80 && n <= 89):
        Console.WriteLine("Su desempeño es: Notable");
        break;
    case int n when (n >= 70 && n <= 79):
        Console.WriteLine("Su desempeño es: Aprobatoria");
        break;
    case int n when (n >= 60 && n <= 69):
        Console.WriteLine("Su desempeño es: No aprobatoria");
        break;
    case int n when (n < 60):
        Console.WriteLine("Su desempeño es: Deficiente. Debe estudiar más para aprobar el examen.");
        break;
}
}
    catch(Exeption error)
    {Console.WriteLine(error.Message);}

















