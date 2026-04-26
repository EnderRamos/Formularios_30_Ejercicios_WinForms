using System;
namespace Formularios30Ejercicios;
public class Exercise29Form : BaseExerciseForm
{
    TextBox egreso;
    double caja=3.71, total=0; int cont=0;
    public Exercise29Form() : base("Ejercicio 29", "Caja inicial 3.71. Ingresar egresos hasta -1 y mostrar restante.")
    {
        egreso=AddInput("Egreso:");
        AddButton("Agregar", (_, _) => {
            if(!TryDouble(egreso,out double e)) return;
            if(e==-1){ lblResultado.Text=$"Total egresos: {total:N2}\nSobrante en caja: {(caja-total):N2}"; return; }
            cont++; total+=e;
            lblResultado.Text=$"Egresos registrados: {cont}\nTotal egresos: {total:N2}\nSobrante: {(caja-total):N2}";
        });
    }
}