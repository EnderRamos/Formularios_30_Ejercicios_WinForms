using System;
namespace Formularios30Ejercicios;
public class Exercise6Form : BaseExerciseForm
{
    TextBox n;
    public Exercise6Form() : base("Ejercicio 06", "Suma de los N primeros números naturales.")
    {
        n = AddInput("Ingrese N:");
        AddButton("Calcular", (_, _) => {
            if(!TryInt(n,out int num)) return;
            if(num<1){ lblResultado.Text="N debe ser mayor que 0."; return; }
            int suma=0; string serie="";
            for(int i=1;i<=num;i++){ suma+=i; serie += i + (i<num ? " + " : ""); }
            lblResultado.Text=$"{serie}\nSuma: {suma}";
        });
    }
}