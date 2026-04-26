using System;
namespace Formularios30Ejercicios;
public class Exercise30Form : BaseExerciseForm
{
    TextBox n1,n2;
    public Exercise30Form() : base("Ejercicio 30", "Promedio de dos notas y estado aprobado/desaprobado.")
    {
        n1=AddInput("Primera nota:");
        n2=AddInput("Segunda nota:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(n1,out double a)||!TryDouble(n2,out double b)) return;
            if(a<0||a>20||b<0||b>20){ lblResultado.Text="Error: notas fuera de escala 0-20."; return; }
            double prom=(a+b)/2;
            lblResultado.Text=$"Promedio: {prom:N2}\nEstado: {(prom>=10.5?"Aprobado":"Desaprobado")}";
        });
    }
}