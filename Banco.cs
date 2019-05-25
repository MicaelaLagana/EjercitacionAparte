using System;
public class Banco 
{
    public Cliente cl1, cl2, cl3; 
    public Banco()
    {   
        Cliente cl1 = new Cliente("Pepe");
        Cliente cl2 = new Cliente("Coqui");
        Cliente cl3 = new Cliente ("Dardo");
    }

    public void Operar()
    {
        cl1.Depositar(200);
        cl1.Extraer(100);
        cl2.Depositar(350);
        cl3.Depositar(180);
        cl3.Extraer(100);
        

    }

    public void DepositosTotales()
    {
        cl1.RetornarMonto();
        cl2.RetornarMonto();
        cl3.RetornarMonto();
    }
         
    
}