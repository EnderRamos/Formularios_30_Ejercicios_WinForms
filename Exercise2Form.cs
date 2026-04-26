using System;
namespace Formularios30Ejercicios;
public class Exercise2Form : BaseExerciseForm
{
    TextBox sueldo;
    public Exercise2Form() : base("Ejercicio 02", "Descuento al sueldo: 10% hasta 1000, 5% adicional hasta 2000 y 3% por encima.")
    {
        sueldo = AddInput("Sueldo:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(sueldo,out double s)) return;
            if(s<0){ lblResultado.Text="Error: el sueldo no puede ser negativo."; return; }
            double d = s<=1000 ? s*0.10 : s<=2000 ? 1000*0.10+(s-1000)*0.05 : 1000*0.10+1000*0.05+(s-2000)*0.03;
            lblResultado.Text = $"Descuento: {d:N2}\nSueldo neto: {(s-d):N2}";
        });
    }
}