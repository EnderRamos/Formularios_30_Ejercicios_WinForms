using System;
namespace Formularios30Ejercicios;
public class Exercise22Form : BaseExerciseForm
{
    TextBox numero;
    public Exercise22Form() : base("Ejercicio 22", "Calcular cubo y raíz cuadrada. Termina si el número es 0.")
    {
        numero=AddInput("Número:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(numero,out double n)) return;
            if(n==0){ lblResultado.Text="Final del proceso."; return; }
            string raiz = n>=0 ? Math.Sqrt(n).ToString("N2") : "No existe en reales";
            lblResultado.Text=$"Cubo: {Math.Pow(n,3):N2}\nRaíz cuadrada: {raiz}";
        });
    }
}