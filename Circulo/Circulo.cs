

public class Circulo{
    private double PI=3.1416;
    private double R2;
    private double P=2;

/// <summary>
/// Este es el constructor de la clase circulo
/// </summary>
/// <param name="_r2">Ingrese un valor decimal del radio de un circulo</param>
    public Circulo(double _r2){
        R2 = _r2;

    }
    public double Area(){
        return PI * R2;
    }
    public double Perimetro(){
        return P * PI * R2;

    }
    
}