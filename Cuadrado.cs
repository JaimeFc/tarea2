public class Cuadrado{
    private double Lado1;
    private double Lado2;

/// <summary>
/// Constructor de la clase Cuadrado
/// </summary>
/// <param name="_ladoA">Es la medida de un lado de cuadrado</param>
/// <param name="_ladoB">Es la medida del otro lado del cuadrado</param>
    public Cuadrado(double _ladoA, double _ladoB){
        Lado1 = _ladoA;
        Lado2 = _ladoB;
    }
    /// <summary>
    /// funcion para calcular el area del cuadrado
    /// </summary>
    /// <returns>Retorna su valor</returns>
    public double Area(){
        return Lado1 * Lado2;
    }
}