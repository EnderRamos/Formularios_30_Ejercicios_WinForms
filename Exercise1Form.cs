using System;
namespace Formularios30Ejercicios;
public class Exercise1Form : BaseExerciseForm
{
    TextBox horas, tarifa;
    public Exercise1Form() : base("Ejercicio 01", "Salario con horas extras: si trabaja más de 40 horas, las extras aumentan 50%.")
    {
        horas = AddInput("Horas trabajadas:");
        tarifa = AddInput("Tarifa por hora:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(horas,out double h)||!TryDouble(tarifa,out double t)) return;
            if(h<0 || t<0){ lblResultado.Text="Error: los valores no pueden ser negativos."; return; }
            double salario = h<=40 ? h*t : 40*t + (h-40)*(t*1.5);
            lblResultado.Text = $"Salario: {salario:N2}";
        });
    }
}