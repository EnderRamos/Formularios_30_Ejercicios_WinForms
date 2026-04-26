using System;
namespace Formularios30Ejercicios;
public class Exercise26Form : BaseExerciseForm
{
    TextBox radio;
    public Exercise26Form() : base("Ejercicio 26", "Calcular longitud de circunferencia, área del círculo y volumen de esfera.")
    {
        radio=AddInput("Radio:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(radio,out double r)) return;
            double pi=Math.PI;
            lblResultado.Text=$"Longitud: {(2*pi*r):N2}\nÁrea del círculo: {(pi*r*r):N2}\nVolumen de esfera: {((4.0/3.0)*pi*Math.Pow(r,3)):N2}";
        });
    }
}