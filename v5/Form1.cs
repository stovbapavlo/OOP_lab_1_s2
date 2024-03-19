using System;
using System.Drawing;
using System.Windows.Forms;

namespace v5
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new Random();

        private bool anyCheckBoxChecked = false;

        public delegate void CheckBoxAction();

        private double OpacityValue = 1.0;
        private Color BackColorValue = Color.White;

        public Form1()
        {
            InitializeComponent();

            button1.Click += (sender, e) => ChangeTransparency();
            button2.Click += (sender, e) => ChangeBackgroundColor();
            button3.Click += (sender, e) => DisplayHelloWorldMessage();
            button4.Click += (sender, e) => MegaButtonAction();

            checkBox1.CheckedChanged += CheckBoxStateChanged;
            checkBox2.CheckedChanged += CheckBoxStateChanged;
            checkBox3.CheckedChanged += CheckBoxStateChanged;

            button4.BackColor = Color.FromArgb(255, 255, 0);
            button4.ForeColor = Color.Black;
            button4.Font = new Font("Arial", 14, FontStyle.Bold);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 0);

            // Rounded corners
            int cornerRadius = 10;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(button4.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(button4.Width - cornerRadius, button4.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, button4.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            button4.Region = new Region(path);

            button4.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void ChangeTransparency()
        {
            OpacityValue = OpacityValue == 1.0 ? 0.5 : 1.0;
            this.Opacity = OpacityValue;
        }

        private void ChangeBackgroundColor()
        {
            BackColorValue = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            this.BackColor = BackColorValue;
        }

        private void DisplayHelloWorldMessage()
        {
            MessageBox.Show("Hello World!");
        }

        private void MegaButtonAction()
        {
            if (anyCheckBoxChecked)
            {
                CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3 };
                CheckBoxAction[] actions = new CheckBoxAction[]
                {
                                ChangeTransparency,
                                ChangeBackgroundColor,
                                DisplayHelloWorldMessage
                };

                for (int i = 0; i < checkBoxes.Length; i++)
                {
                    if (checkBoxes[i].Checked)
                    {
                        actions[i]();
                    }
                }
            }
            else
            {
                MessageBox.Show("ъ ясоеп лецю ймнойю");
            }
        }

        private void CheckBoxStateChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            anyCheckBoxChecked = checkBox1.Checked || checkBox2.Checked || checkBox3.Checked;
        }
    }
}
