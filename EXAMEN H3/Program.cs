using System;
class ExploradorDemo
{ // Propiedades
  public string Nombre { get; set; }
  public int Energia { get; set; }

    // Constructor que recibe el nombrey la energia inicial
    public ExploradorDemo (string nombre, int energiaInicial)
    {
        Nombre = nombre;
        Energia = energiaInicial;
    }
    // Metodo para demostrar el estado actual 
    public void MostrarEstado()
    {
        Console.WriteLine($"explorador: {Nombre} energia: {Energia}");
    }
}
class Program
{ static void Main ()
    {
        // Creacion del objeto
        ExploradorDemo Luna = new ExploradorDemo("luna", 80);
        // Llamadaal metodo MostraEstado
        Luna. MostrarEstado ();
    }
}