using System;
namespace Formularios30Ejercicios;
public class Exercise24Form : BaseExerciseForm
{
    TextBox l1,l2,l3;
    public Exercise24Form() : base("Ejercicio 24", "Calcular área de triángulo con sus tres lados usando la fórmula de Herón.")
    {
        l1=AddInput("Lado A:");
        l2=AddInput("Lado B:");
        l3=AddInput("Lado C:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(l1,out double a)||!TryDouble(l2,out double b)||!TryDouble(l3,out double c)) return;
            if(a+b<=c || a+c<=b || b+c<=a){ lblResultado.Text="Los lados no forman un triángulo."; return; }
            double s=(a+b+c)/2; double area=Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            lblResultado.Text=$"Área del triángulo: {area:N2}";
        });
    }
}