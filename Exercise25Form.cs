using System;
namespace Formularios30Ejercicios;
public class Exercise25Form : BaseExerciseForm
{
    TextBox c1,c2;
    public Exercise25Form() : base("Ejercicio 25", "Calcular hipotenusa de un triángulo rectángulo.")
    {
        c1=AddInput("Cateto 1:");
        c2=AddInput("Cateto 2:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(c1,out double a)||!TryDouble(c2,out double b)) return;
            lblResultado.Text=$"Hipotenusa: {Math.Sqrt(a*a+b*b):N2}";
        });
    }
}