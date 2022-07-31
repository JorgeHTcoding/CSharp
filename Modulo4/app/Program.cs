
//Ejercicio 1

/*int i = 0;


Console.WriteLine("Introduce un número sobre el cual quieras saber la tabla de multiplicar");
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("La tabla de multiplicar del " + j + " es: ");

while (i <= 10)
{
    Console.WriteLine(i * j);
        i++;
}
*/

//Ejercicio 2

/*
int positivo = 0;
int negativo = 0;
int i = 0;
                  
    do{
        Console.WriteLine("Introduce un número para saber si es positivo o negativo:");
        i = Convert.ToInt32(Console.ReadLine());
            if(i == 0)
            {
                Console.WriteLine(i + " no es ni positivo ni negativo");
            }else if(i < 0) {                     
                Console.WriteLine(i + " es un número negativo");
                negativo++;
                }else{                       
                    Console.WriteLine(i + " es un número positivo");
                    positivo++;
                }   
            }while ((negativo < 10) && (positivo < 10));

Console.WriteLine("La cantidad total de negativos introducidos es: " + negativo + " y la cantidad total de positivos introducidos es: " + positivo);

*/

//Ejercicio 3

Console.WriteLine("Introduce el ancho del rectángulo: ");
    int ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce el alto del rectángulo: ");
    int alto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce si el rectángulo está relleno o no (true or false): ");
    bool relleno = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Introduce cuantos rectángulos quieres que aparezcan ");
    int numRec = Convert.ToInt32(Console.ReadLine());
    char ast = '*';
     
      
if(relleno == true)
{
    for(int i = 0; i < numRec; i++)
    {
        Console.Write("\n"); 
        char[,] rectangulo = new char[ancho,alto];

            for(int k = 1 ; k <= alto ; k++)       
            {        
                Console.WriteLine(new String(ast,ancho));
            }       
    }
}else{

    for(int i = 0; i < numRec; i++)
    {
    Console.Write("\n"); 
    char[,] rectangulo = new char[ancho,alto];
        for(int x = 0; x < ancho; x++)
        {
            for(int y = 0; y < alto; y++)
            {
                if((x == 0 || x == ancho - 1) || ( y == 0 || y == alto - 1))
                {
                    rectangulo[x,y] = ast;
                    Console.Write(rectangulo[x,y]);               
                }
                else
                {
                    rectangulo[x,y] = ' ';
                    Console.Write(rectangulo[x,y]);               
                }                
            }  Console.Write("\n");                      
        }
        
    }
}
    
  





