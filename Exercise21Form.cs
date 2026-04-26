using System;
namespace Formularios30Ejercicios;
public class Exercise21Form : BaseExerciseForm
{
    TextBox n1,n2;
    public Exercise21Form() : base("Ejercicio 21", "Ingresar 2 números y calcular suma, resta, multiplicación y división. Repetir 10 veces.")
    {
        n1=AddInput("Número 1:");
        n2=AddInput("Número 2:");
        AddButton("Calcular una vez", (_, _) => {
            if(!TryDouble(n1,out double a)||!TryDouble(n2,out double b)) return;
            lblResultado.Text=$"Suma: {a+b:N2}\nResta: {a-b:N2}\nMultiplicación: {a*b:N2}\nDivisión: {(b!=0?(a/b).ToString("N2"):"No definida")}";
        });
    }
}