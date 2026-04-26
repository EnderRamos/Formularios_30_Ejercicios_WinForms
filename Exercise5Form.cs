using System;
namespace Formularios30Ejercicios;
public class Exercise5Form : BaseExerciseForm
{
    TextBox minutos;
    public Exercise5Form() : base("Ejercicio 05", "Convertir minutos a días, horas y minutos.")
    {
        minutos = AddInput("Tiempo en minutos:");
        AddButton("Convertir", (_, _) => {
            if(!TryInt(minutos,out int m)) return;
            if(m<0){ lblResultado.Text="El tiempo no puede ser negativo."; return; }
            int dias=m/1440; int resto=m%1440; int horas=resto/60; int mins=resto%60;
            lblResultado.Text=$"Equivale a {dias} días, {horas} horas y {mins} minutos.";
        });
    }
}