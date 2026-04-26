using System;
namespace Formularios30Ejercicios;
public class Exercise19Form : BaseExerciseForm
{
    TextBox numero;
    public Exercise19Form() : base("Ejercicio 19", "Determinar si un número tiene o no parte fraccionaria.")
    {
        numero=AddInput("Número:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(numero,out double n)) return;
            double fr=n-Math.Truncate(n);
            lblResultado.Text=fr==0?"No tiene parte fraccionaria":"Tiene parte fraccionaria";
        });
    }
}