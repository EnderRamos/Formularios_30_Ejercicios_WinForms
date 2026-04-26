using System;
using System.Windows.Forms;

namespace Formularios30Ejercicios;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MenuForm());
    }
}
