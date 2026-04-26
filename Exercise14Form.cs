using System;
namespace Formularios30Ejercicios;
public class Exercise14Form : BaseExerciseForm
{
    public Exercise14Form() : base("Ejercicio 14", "Calcular la media de 100 números.")
    {
        AddButton("Iniciar captura", (_, _) => {
            double suma=0;
            for(int i=1;i<=100;i++)
                suma+=double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Número {i}", "Número", "0"));
            lblResultado.Text=$"Media de los 100 números: {(suma/100):N2}";
        });
    }
}