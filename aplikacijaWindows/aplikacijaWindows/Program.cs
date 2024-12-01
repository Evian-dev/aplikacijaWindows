using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace aplikacijaWindows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

public class MyForm : Form
        {
            CheckBox[] checkBoxes = new CheckBox[4];
            Button button = new Button();
            TextBox textBox = new TextBox();

            public MyForm()
            {
                for (int i = 0; i < 4; i++)
                {
                    checkBoxes[i] = new CheckBox { Text = $"Opcija {i + 1}", Location = new System.Drawing.Point(10, 10 + i * 30) };
                    Controls.Add(checkBoxes[i]);
                }

                button.Text = "Potvrdi";
                button.Location = new System.Drawing.Point(10, 130);
                button.Click += (s, e) =>
                {
                    textBox.Text = string.Join(", ", Array.FindAll(checkBoxes, cb => cb.Checked).Select(cb => cb.Text));
                };
                Controls.Add(button);

                textBox.Multiline = true;
                textBox.Location = new System.Drawing.Point(10, 160);
                textBox.Size = new System.Drawing.Size(200, 100);
                Controls.Add(textBox);
            }

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.Run(new MyForm());
            }
        }







    }
}

