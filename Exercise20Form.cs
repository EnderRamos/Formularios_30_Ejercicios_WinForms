using System;
namespace Formularios30Ejercicios;
public class Exercise20Form : BaseExerciseForm
{
    TextBox a,b,c;
    public Exercise20Form() : base("Ejercicio 20", "Calcular soluciones de una ecuación cuadrática.")
    {
        a=AddInput("Coeficiente a:");
        b=AddInput("Coeficiente b:");
        c=AddInput("Coeficiente c:");
        AddButton("Resolver", (_, _) => {
            if(!TryDouble(a,out double A)||!TryDouble(b,out double B)||!TryDouble(c,out double C)) return;
            if(A==0){ lblResultado.Text="No es cuadrática porque a = 0."; return; }
            double d=B*B-4*A*C;
            if(d>0){ double x1=(-B+Math.Sqrt(d))/(2*A); double x2=(-B-Math.Sqrt(d))/(2*A); lblResultado.Text=$"Discriminante positivo.\nx1={x1:N2}\nx2={x2:N2}"; }
            else if(d==0){ double x=-B/(2*A); lblResultado.Text=$"Una solución real: x={x:N2}"; }
            else{ lblResultado.Text="Tiene raíces imaginarias."; }
        });
    }
}