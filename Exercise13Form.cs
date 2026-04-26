using System;
namespace Formularios30Ejercicios;
public class Exercise13Form : BaseExerciseForm
{
    TextBox numero;
    public Exercise13Form() : base("Ejercicio 13", "Calcular e imprimir el factorial de un número.")
    {
        numero=AddInput("Número:");
        AddButton("Calcular", (_, _) => {
            if(!TryInt(numero,out int n)) return;
            if(n<0){ lblResultado.Text="No existe factorial de negativo."; return; }
            long f=1; string proc="";
            for(int i=1;i<=n;i++){ f*=i; proc += i + (i<n?" x ":""); }
            lblResultado.Text=$"{proc}\nFactorial: {f}";
        });
    }
}