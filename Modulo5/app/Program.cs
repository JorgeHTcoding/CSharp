//Ejercicio 1


Console.WriteLine("Introduce tu nombre: ");
    string name = Convert.ToString(Console.ReadLine());
Console.WriteLine("Introduce tu email: ");
    string email = Convert.ToString(Console.ReadLine());
Console.WriteLine("¿Tienes cupón de descuento? (true or false): ");
    bool cupon = Convert.ToBoolean(Console.ReadLine());

Cliente cliente1 = new Cliente(
    name,
    email,
    cupon

    );

    cliente1.aplicarDescuento();
   

public struct Cliente      
{
    public Cliente(string name, string email, bool cupon)

    {
        this.name = name;
        this.email = email;
        this.cupon = cupon;

        
    }
    public string name { get; set; }
    public string email { get; set; }
    public bool cupon { get; set; }

    public string aplicarDescuento()
     
    {
         double precio1 = 25.55;
         double descuento = 0.25;
         double precioDescontado = precio1 - (precio1 * descuento);

        if(cupon == true)
        {
           string resultado = "Con tu cupón el producto tiene un descuento del 25%, quedándose en un precio de: " + precioDescontado;
           Console.WriteLine(resultado);
           return resultado;
        }
        else
        {
           string resultado ="No dispones de cupón por tanto el precio total del producto es de: " + precio1;
           Console.WriteLine(resultado);
           return resultado;
        }       
    }
}


//Ejercicio 2


Console.WriteLine("C# = 1");
Console.WriteLine("Java = 2" );
Console.WriteLine("C++ = 3" + "\n");
Console.WriteLine("Selecciona uno de los siguientes lenguajes de programación: " );

int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case 1:       
        Console.WriteLine("Enhorabuena, has seleccionado C#");      
        break;
    case 2:       
        Console.WriteLine("Enhorabuena, has seleccionado Java");       
        break;
    case 3:
        Console.WriteLine("Enhorabuena, has seleccionado C++");
        break;
}
