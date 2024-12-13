public class Cuadrado{
    private double Lado;

    private double P=4;
    
/// <summary>
/// Este es eñ constructor de la clase cuadrado
/// </summary>
/// <param name="_lado">Es la medidad del cuadrado</param>
/// <param name="_p">Es la constante de sus cuatro lados</param>
    public Cuadrado(double _lado , double _p){
        Lado = _lado;
        P = _p;

    }

    /// <summary>
    /// funcion para calcular el area del cuadrado
    /// </summary>
    /// <returns>Retorna su valor</returns>
    public double Area(){
        return Lado * Lado; 
        
    }
    public double Perimetro(){
        return 4 * Lado;
    }
    

}