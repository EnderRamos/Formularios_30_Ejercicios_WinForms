using System;
namespace Formularios30Ejercicios;
public class Exercise16Form : BaseExerciseForm
{
    TextBox inicio, fin;
    public Exercise16Form() : base("Ejercicio 16", "Mostrar números de un rango usando un ciclo repetitivo.")
    {
        inicio=AddInput("Inicio:");
        fin=AddInput("Fin:");
        AddButton("Mostrar", (_, _) => {
            if(!TryInt(inicio,out int a)||!TryInt(fin,out int b)) return;
            string r="";
            for(int i=a;i<=b;i++) r+=i+" ";
            lblResultado.Text=r;
        });
    }
}