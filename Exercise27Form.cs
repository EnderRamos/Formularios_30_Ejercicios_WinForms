using System;
namespace Formularios30Ejercicios;
public class Exercise27Form : BaseExerciseForm
{
    TextBox consumo;
    double total=0; int contador=0;
    public Exercise27Form() : base("Ejercicio 27", "Calcular pagos de 130 consumos. Si consumo supera 150, descuento 15%.")
    {
        consumo=AddInput("Consumo:");
        AddButton("Agregar consumo", (_, _) => {
            if(!TryDouble(consumo,out double c)) return;
            contador++;
            double descuento=c>150?c*0.15:0;
            total += c-descuento;
            lblResultado.Text=$"Consumos registrados: {contador}\nÚltimo descuento: {descuento:N2}\nTotal acumulado: {total:N2}";
        });
    }
}