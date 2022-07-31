
Cliente cliente1 = new Cliente ( 

    "Jorge Holgado Torres",
    611223344,
    "c/De la programación nº 1",
    "jorge_holgado@gmail.com",
    true
    
);
cliente1.imprimirConsola();
// Console.WriteLine(cliente1.fullName + cliente1.phone + cliente1.address + cliente1.mail + cliente1.newCustomer);
public struct Cliente{
    public Cliente(string nombreCompleto, int telefono, string direccion, string email, bool nuevoCliente)
    {
        
        this.nombreCompleto = nombreCompleto ;
        this.telefono = telefono;
        this.direccion = direccion ;
        this.email = email ;
        this.nuevoCliente = nuevoCliente ;    
            
    }
    public string nombreCompleto { get; set; }
    public int telefono { get; set; }
    public string direccion { get; set; }
    public string email { get; set; }
    public bool nuevoCliente { get; set; }
        
    public string imprimirConsola()    
    {
        string resultado = "Nombre completo: " + nombreCompleto + " | " +" Teléfono: " + telefono + " | " + " Dirección: " + direccion + " | " + " E-mail: " + email + " | " + " Nuevo Cliente: " + nuevoCliente;
        Console.WriteLine(resultado);
        return resultado;
    }
}