using System;
namespace Formularios30Ejercicios;
public class Exercise9Form : BaseExerciseForm
{
    TextBox cantidad;
    public Exercise9Form() : base("Ejercicio 09", "Calcular notas aprobadas, desaprobadas y promedios.")
    {
        cantidad = AddInput("Cantidad de notas:");
        AddButton("Calcular", (_, _) => {
            if(!TryInt(cantidad,out int n)) return;
            int aprob=0, desap=0; double suma=0, sumaA=0, sumaD=0;
            for(int i=1;i<=n;i++){
                double nota=double.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Nota {i}", "Nota", "0"));
                suma += nota;
                if(nota >= 10.5){ aprob++; sumaA += nota; } else { desap++; sumaD += nota; }
            }
            lblResultado.Text=$"Aprobadas: {aprob}\nDesaprobadas: {desap}\nPromedio aprobadas: {(aprob>0?sumaA/aprob:0):N2}\nPromedio desaprobadas: {(desap>0?sumaD/desap:0):N2}\nPromedio final: {(n>0?suma/n:0):N2}";
        });
    }
}