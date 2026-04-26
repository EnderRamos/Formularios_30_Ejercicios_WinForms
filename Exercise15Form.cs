using System;
namespace Formularios30Ejercicios;
public class Exercise15Form : BaseExerciseForm
{
    public Exercise15Form() : base("Ejercicio 15", "Suma y producto de los números pares entre 20 y 400, ambos inclusive.")
    {
        AddButton("Calcular", (_, _) => {
            double suma=0; decimal producto=1;
            for(int x=20;x<=400;x+=2){ suma+=x; producto*=x; }
            lblResultado.Text=$"Suma: {suma:N0}\nProducto: {producto:E2}";
        });
    }
}