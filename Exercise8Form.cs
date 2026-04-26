using System;
namespace Formularios30Ejercicios;
public class Exercise8Form : BaseExerciseForm
{
    TextBox horas, tarifa;
    public Exercise8Form() : base("Ejercicio 08", "Calcular salario de una persona según horas trabajadas y tarifa.")
    {
        horas = AddInput("Horas trabajadas:");
        tarifa = AddInput("Tarifa:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(horas,out double h)||!TryDouble(tarifa,out double t)) return;
            lblResultado.Text=$"Salario del trabajador: {(h*t):N2}";
        });
    }
}