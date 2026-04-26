using System;
namespace Formularios30Ejercicios;
public class Exercise11Form : BaseExerciseForm
{
    TextBox precio, cantidad;
    public Exercise11Form() : base("Ejercicio 11", "Factura: IVA 15% y descuento 5% si precio bruto supera 50.")
    {
        precio=AddInput("Precio:");
        cantidad=AddInput("Cantidad:");
        AddButton("Calcular", (_, _) => {
            if(!TryDouble(precio,out double p)||!TryDouble(cantidad,out double c)) return;
            double iva=p*c*0.15; double bruto=p*c+iva; double desc=bruto>50?bruto*0.05:0; double total=bruto-desc;
            lblResultado.Text=$"Precio de venta: {p:N2}\nCantidad: {c}\nIVA: {iva:N2}\nPrecio bruto: {bruto:N2}\nDescuento: {desc:N2}\nTotal a pagar: {total:N2}";
        });
    }
}