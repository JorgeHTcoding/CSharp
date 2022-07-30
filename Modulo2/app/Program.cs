
//Ejercicio 1

    Console.WriteLine("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

    Console.WriteLine("Escribe tu apellido: ");
        string apellido = Console.ReadLine();

    Console.WriteLine("Escribe tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Se programar (true or false): ");
        bool sabeProg = Convert.ToBoolean(Console.ReadLine());

    Console.WriteLine(nombre + apellido + " tienes " + edad + " años y has respondido " + sabeProg + " a la pregunta de si sabes programar.");


//Ejercicio 2

    //Coche

        int puertas;
        int ruedas;
        string marca;
        bool itvVigente;

    //Mesa

        float peso; //podemos usar un double si queremos más precisión y no tenemos restricciones de memoria
        float largo; //podemos usar un double si queremos más precisión y no tenemos restricciones de memoria
        string material;
        string color;
        

//Ejercicio 3

    int w = 2;
    int x = 3;
    int y = 19;
    int z = 20;
    char character = Convert.ToChar("a");

    Console.WriteLine("¿Es el número: " + z + " mayor o igual que 18?: " + (z >= 18));
    Console.WriteLine("¿Es nuestro caracter " + character + " igual a el caracter a?: " + ( character == 'a'));
    Console.WriteLine("¿Son los números " + y + " y " + z +  " mayores o iguales que 18?: " + ( (y >= 18) && (z >= 18)));
    Console.WriteLine("¿Son los números " + x + " y " + z +  " mayores o iguales que 18?: " + ( (x >= 18) || (z >= 18)));
    Console.WriteLine("¿Son los números " + x + " y " + w +  " mayores o iguales que 18?: " + ( (x >= 18) || (w >= 18)));



