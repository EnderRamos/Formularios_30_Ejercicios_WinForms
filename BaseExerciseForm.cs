using System;
using System.Drawing;
using System.Windows.Forms;

namespace Formularios30Ejercicios;

public class BaseExerciseForm : Form
{
    protected Panel content = new Panel();
    protected Label lblResultado = new Label();
    private int y = 95;

    public BaseExerciseForm(string titulo, string descripcion)
    {
        Text = titulo;
        Width = 760;
        Height = 560;
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.FromArgb(245, 247, 250);
        Font = new Font("Segoe UI", 10);

        var header = new Panel
        {
            Dock = DockStyle.Top,
            Height = 75,
            BackColor = Color.FromArgb(15, 23, 42)
        };

        var lblTitulo = new Label
        {
            Text = titulo,
            AutoSize = true,
            Left = 20,
            Top = 14,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 17, FontStyle.Bold)
        };

        var lblDesc = new Label
        {
            Text = descripcion,
            AutoSize = false,
            Left = 22,
            Top = 45,
            Width = 700,
            Height = 25,
            ForeColor = Color.WhiteSmoke,
            Font = new Font("Segoe UI", 9)
        };

        header.Controls.Add(lblTitulo);
        header.Controls.Add(lblDesc);

        content.Dock = DockStyle.Fill;
        content.AutoScroll = true;

        lblResultado.Left = 25;
        lblResultado.Top = 380;
        lblResultado.Width = 680;
        lblResultado.Height = 110;
        lblResultado.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        lblResultado.ForeColor = Color.FromArgb(34, 177, 76);
        lblResultado.BorderStyle = BorderStyle.FixedSingle;
        lblResultado.BackColor = Color.White;
        lblResultado.Padding = new Padding(10);

        Controls.Add(content);
        Controls.Add(header);
        content.Controls.Add(lblResultado);
    }

    protected TextBox AddInput(string label)
    {
        var lbl = new Label
        {
            Text = label,
            Left = 25,
            Top = y + 5,
            Width = 260,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };

        var txt = new TextBox
        {
            Left = 300,
            Top = y,
            Width = 180,
            Height = 30
        };

        content.Controls.Add(lbl);
        content.Controls.Add(txt);
        y += 45;
        return txt;
    }

    protected Button AddButton(string text, EventHandler click)
    {
        var btn = new Button
        {
            Text = text,
            Left = 25,
            Top = y + 10,
            Width = 170,
            Height = 42,
            BackColor = Color.FromArgb(37, 99, 235),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            Cursor = Cursors.Hand
        };
        btn.FlatAppearance.BorderSize = 0;
        btn.Click += click;
        content.Controls.Add(btn);
        y += 65;
        return btn;
    }

    protected bool TryDouble(TextBox txt, out double value)
    {
        if (!double.TryParse(txt.Text, out value))
        {
            MessageBox.Show("Ingrese un número válido.");
            txt.Focus();
            return false;
        }
        return true;
    }

    protected bool TryInt(TextBox txt, out int value)
    {
        if (!int.TryParse(txt.Text, out value))
        {
            MessageBox.Show("Ingrese un número entero válido.");
            txt.Focus();
            return false;
        }
        return true;
    }
}
