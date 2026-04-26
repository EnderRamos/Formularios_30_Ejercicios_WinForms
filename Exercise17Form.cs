using System;
namespace Formularios30Ejercicios;
public class Exercise17Form : BaseExerciseForm
{
    TextBox numero;
    public Exercise17Form() : base("Ejercicio 17", "Mostrar la tabla de multiplicar de un número.")
    {
        numero=AddInput("Número:");
        AddButton("Calcular", (_, _) => {
            if(!TryInt(numero,out int n)) return;
            string r="";
            for(int i=1;i<=12;i++) r+=$"{n} x {i} = {n*i}\n";
            lblResultado.Text=r;
        });
    }
}