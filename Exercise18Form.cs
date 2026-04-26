using System;
namespace Formularios30Ejercicios;
public class Exercise18Form : BaseExerciseForm
{
    TextBox caracter;
    public Exercise18Form() : base("Ejercicio 18", "Escribir la primera vocal ingresada por teclado.")
    {
        caracter=AddInput("Caracter:");
        AddButton("Verificar", (_, _) => {
            string c=caracter.Text.Trim().ToLower();
            if(c=="a"||c=="e"||c=="i"||c=="o"||c=="u") lblResultado.Text=$"La primera vocal ingresada fue: {c}";
            else lblResultado.Text="No es vocal. Ingrese otra.";
        });
    }
}