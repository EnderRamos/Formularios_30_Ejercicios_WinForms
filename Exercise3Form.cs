using System;
namespace Formularios30Ejercicios;
public class Exercise3Form : BaseExerciseForm
{
    TextBox monto;
    public Exercise3Form() : base("Ejercicio 03", "Calcular descuento: por encima de 100 el descuento es 10%, por debajo 2%.")
    {
        monto = AddInput("Monto:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(monto,out double m)) return;
            if(m<0){ lblResultado.Text="Error: el monto no puede ser negativo."; return; }
            double d = m>100 ? m*0.10 : m*0.02;
            lblResultado.Text = $"Monto: {m:N2}\nDescuento: {d:N2}\nTotal: {(m-d):N2}";
        });
    }
}