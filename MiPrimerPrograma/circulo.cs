namespace MiPrimerPrograma;

public class CalculadoraCirculo 
{
    public void Ejecutar() 
    {
        double Pi = 3.1416;
        double radio;
        
        Console.WriteLine("Ingrese el valor del radio");
        radio = Convert.ToDouble(Console.ReadLine());

        double resultado = Pi * radio * radio;

        Console.WriteLine("El área de tu círculo es de: " + resultado);
    }
}