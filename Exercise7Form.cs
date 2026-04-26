using System;
namespace Formularios30Ejercicios;
public class Exercise7Form : BaseExerciseForm
{
    TextBox trabajadores;
    public Exercise7Form() : base("Ejercicio 07", "Calcular la suma de salarios de todos los trabajadores.")
    {
        trabajadores = AddInput("Cantidad de trabajadores:");
        AddButton("Calcular", (_, _) => {
            if(!TryInt(trabajadores,out int n)) return;
            double suma=0;
            for(int i=1;i<=n;i++)
            {
                string htxt = Microsoft.VisualBasic.Interaction.InputBox($"Horas trabajadas del trabajador {i}", "Horas", "0");
                string ttxt = Microsoft.VisualBasic.Interaction.InputBox($"Tarifa del trabajador {i}", "Tarifa", "0");
                double h=double.Parse(htxt); double t=double.Parse(ttxt);
                suma += h*t;
            }
            lblResultado.Text=$"Suma de salarios: {suma:N2}";
        });
    }
}