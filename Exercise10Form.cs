using System;
namespace Formularios30Ejercicios;
public class Exercise10Form : BaseExerciseForm
{
    TextBox numero;
    public Exercise10Form() : base("Ejercicio 10", "Dado un número, determinar la suma de sus dígitos.")
    {
        numero = AddInput("Número entero:");
        AddButton("Calcular", (_, _) => {
            if(!TryInt(numero,out int n)) return;
            n=Math.Abs(n); int suma=0;
            do{ suma += n%10; n/=10; }while(n>0);
            lblResultado.Text=$"Suma de los dígitos: {suma}";
        });
    }
}