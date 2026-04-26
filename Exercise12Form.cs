using System;
namespace Formularios30Ejercicios;
public class Exercise12Form : BaseExerciseForm
{
    public Exercise12Form() : base("Ejercicio 12", "Pedir 50 números y determinar pares, impares, positivos y negativos.")
    {
        AddButton("Iniciar captura", (_, _) => {
            int pares=0, impares=0, positivos=0, negativos=0;
            for(int i=1;i<=50;i++){
                int n=int.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Número {i}", "Número", "0"));
                if(n%2==0) pares++; else impares++;
                if(n>0) positivos++; else if(n<0) negativos++;
            }
            lblResultado.Text=$"Pares: {pares}\nImpares: {impares}\nPositivos: {positivos}\nNegativos: {negativos}";
        });
    }
}