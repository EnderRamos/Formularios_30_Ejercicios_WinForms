using System;
namespace Formularios30Ejercicios;
public class Exercise28Form : BaseExerciseForm
{
    TextBox numero;
    public Exercise28Form() : base("Ejercicio 28", "Sumar números enteros desde 8 hasta N.")
    {
        numero=AddInput("Número N:");
        AddButton("Calcular", (_, _) => {
            if(!TryInt(numero,out int n)) return;
            if(n<8){ lblResultado.Text="Error: N debe ser mayor o igual a 8."; return; }
            int suma=0; for(int i=8;i<=n;i++) suma+=i;
            lblResultado.Text=$"La suma desde 8 hasta {n} es: {suma}";
        });
    }
}