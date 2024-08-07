/*Sobrecarga ocorre quando uma classe tem dois ou mais métodos com o mesmo nome, porém com diferentes listas de parâmetros.*/

public class sobrecarga{
    public int multiplicar(int a, int b){
        return a * b;
    }

    public double multiplicar(double a, double b){
        return a * b;
    }
}