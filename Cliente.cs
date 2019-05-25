using System;
public class Cliente
{
public string Nombre;
public int Monto;
public Cliente(String nombre)
{
    this.Nombre = nombre;
    Monto = 0;
}
public void Depositar(int Cantidad)
{
    this.Monto += Cantidad;
    Console.WriteLine("Ha depositado :$" + Cantidad);
}
public void Extraer(int Cantidad)
{
    this.Monto -= Cantidad;
    Console.WriteLine("Ha extraído $:" + Cantidad);
}
public int RetornarMonto()
{
    return Monto;
    Console.WriteLine("Su monto es: " + Monto);
}

}