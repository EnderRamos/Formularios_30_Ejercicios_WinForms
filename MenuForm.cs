using System;
using System.Drawing;
using System.Windows.Forms;

namespace Formularios30Ejercicios;

public class MenuForm : Form
{
    public MenuForm()
    {
        Text = "Menú de 30 ejercicios";
        Width = 920;
        Height = 680;
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.FromArgb(245, 247, 250);
        Font = new Font("Segoe UI", 10);

        var header = new Panel
        {
            Dock = DockStyle.Top,
            Height = 80,
            BackColor = Color.FromArgb(15, 23, 42)
        };

        var title = new Label
        {
            Text = "Menú principal - Ejercicios en Formularios",
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 20, FontStyle.Bold),
            AutoSize = true,
            Left = 25,
            Top = 22
        };
        header.Controls.Add(title);

        var panel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            Padding = new Padding(25),
            BackColor = Color.FromArgb(245, 247, 250)
        };

        Controls.Add(panel);
        Controls.Add(header);

        for (int i = 1; i <= 30; i++)
        {
            int n = i;
            var btn = new Button
            {
                Text = $"Ejercicio {n:00}",
                Width = 160,
                Height = 55,
                Margin = new Padding(10),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(15, 23, 42),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderColor = Color.FromArgb(225, 228, 235);
            btn.Click += (_, _) => Abrir(n);
            panel.Controls.Add(btn);
        }
    }

    private void Abrir(int n)
    {
        Form f = n switch
        {
            1 => new Exercise1Form(),
            2 => new Exercise2Form(),
            3 => new Exercise3Form(),
            4 => new Exercise4Form(),
            5 => new Exercise5Form(),
            6 => new Exercise6Form(),
            7 => new Exercise7Form(),
            8 => new Exercise8Form(),
            9 => new Exercise9Form(),
            10 => new Exercise10Form(),
            11 => new Exercise11Form(),
            12 => new Exercise12Form(),
            13 => new Exercise13Form(),
            14 => new Exercise14Form(),
            15 => new Exercise15Form(),
            16 => new Exercise16Form(),
            17 => new Exercise17Form(),
            18 => new Exercise18Form(),
            19 => new Exercise19Form(),
            20 => new Exercise20Form(),
            21 => new Exercise21Form(),
            22 => new Exercise22Form(),
            23 => new Exercise23Form(),
            24 => new Exercise24Form(),
            25 => new Exercise25Form(),
            26 => new Exercise26Form(),
            27 => new Exercise27Form(),
            28 => new Exercise28Form(),
            29 => new Exercise29Form(),
            30 => new Exercise30Form(),
            _ => new Exercise1Form()
        };
        f.ShowDialog();
    }
}
