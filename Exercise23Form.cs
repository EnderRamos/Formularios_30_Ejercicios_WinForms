using System;
namespace Formularios30Ejercicios;
public class Exercise23Form : BaseExerciseForm
{
    TextBox n1,n2;
    public Exercise23Form() : base("Ejercicio 23", "Con dos números: suma, resta, multiplicación y división. Termina si el primero es 0.")
    {
        n1=AddInput("Número 1:");
        n2=AddInput("Número 2:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(n1,out double a)||!TryDouble(n2,out double b)) return;
            if(a==0){ lblResultado.Text="Final del proceso."; return; }
            lblResultado.Text=$"Suma: {a+b:N2}\nResta: {a-b:N2}\nMultiplicación: {a*b:N2}\nDivisión: {(b!=0?(a/b).ToString("N2"):"No definida")}";
        });
    }
}