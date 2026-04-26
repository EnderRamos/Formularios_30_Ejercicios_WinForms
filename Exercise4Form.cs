using System;
namespace Formularios30Ejercicios;
public class Exercise4Form : BaseExerciseForm
{
    TextBox segundos;
    public Exercise4Form() : base("Ejercicio 04", "Convertir segundos a minutos y segundos restantes.")
    {
        segundos = AddInput("Tiempo en segundos:");
        AddButton("Convertir", (_, _) => {
            if(!TryInt(segundos,out int s)) return;
            if(s<0){ lblResultado.Text="La cantidad de segundos debe ser positiva."; return; }
            lblResultado.Text = $"Equivale a {s/60} minutos y faltan {s%60} segundos.";
        });
    }
}