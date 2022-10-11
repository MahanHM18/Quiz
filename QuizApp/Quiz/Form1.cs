using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private string[] Questions =
        {
            "All statments must end with a ____",
            "What result is returned by 2 + 3 * 4 / 2?",
            "What keyword is used to declare an integer?",
            "What result is returned by (3 > 2) & (4 < 2)?",
            "what do duble slashes (//) precode?"
        };

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Text = Questions[rnd.Next(0, Questions.Length)];

            label2.Text = Questions[rnd.Next(0, Questions.Length)];

            label3.Text = Questions[rnd.Next(0, Questions.Length)];

            CheckQuestions();
        }


        private void CheckQuestions()
        {
            while (label2.Text == label1.Text)
            {
                label2.Text = Questions[rnd.Next(0, Questions.Length)];
            }

            while (label3.Text == label2.Text || label3.Text == label1.Text)
            {
                label3.Text = Questions[rnd.Next(0, Questions.Length)];
            }
        }


        private bool GetCorrectAnsewr(int index)
        {
            if (index == 1)
            {
                switch (label1.Text)
                {
                    case "All statments must end with a ____":
                    {
                        if (A1.Text == ";")
                        {
                            return true;
                            break;
                        }

                        return false;
                    }
                    case "What result is returned by 2 + 3 * 4 / 2?":
                    {
                        if (A1.Text == "8")
                        {
                            return true;
                            break;
                        }

                        return false;
                    }
                    case "What keyword is used to declare an integer?":
                    {
                        if (A1.Text == "in")
                        {
                            return true;
                            break;
                        }

                        return false;
                        break;
                    }
                    case "What result is returned by (3 > 2) & (4 < 2)?":
                    {
                        if (A1.Text == "false")
                        {
                            return true;
                            break;
                        }

                        return false;
                        break;
                    }
                    case "what do double slashes (//) precode?":
                    {
                        if (A1.Text == "comments")
                        {
                            return true;
                            break;
                        }

                        return false;
                        break;
                    }

                    default:
                        break;
                }
            }
            else if (index == 2)
            {
                switch (label2.Text)
                {
                    case "All statments must end with a ____":
                    {
                        if (A2.Text == ";")
                        {
                            return true;
                            break;
                        }

                        return false;
                    }
                    case "What result is returned by 2 + 3 * 4 / 2?":
                    {
                        if (A2.Text == "8")
                        {
                            return true;
                            break;
                        }

                        return false;
                    }
                    case "What keyword is used to declare an integer?":
                    {
                        if (A2.Text == "in")
                        {
                            return true;
                            break;
                        }

                        return false;
                        break;
                    }
                    case "What result is returned by (3 > 2) & (4 < 2)?":
                    {
                        if (A2.Text == "false")
                        {
                            return true;
                            break;
                        }

                        return false;
                        break;
                    }
                    case "what do duble slashes (//) precode?":
                    {
                        if (A2.Text == "comments")
                        {
                            return true;
                            break;
                        }

                        return false;
                        break;
                    }

                    default:
                        break;
                }
            }
            else if (index == 3)
            {
                switch (label3.Text)
                {
                    case "All statments must end with a ____":
                    {
                        if (A3.Text == ";")
                        {
                            return true;
                            break;
                        }

                        return false;
                    }
                    case "What result is returned by 2 + 3 * 4 / 2?":
                    {
                        if (A3.Text == "8")
                        {
                            return true;
                            break;
                        }

                        return false;
                    }
                    case "What keyword is used to declare an integer?":
                    {
                        if (A3.Text == "in")
                        {
                            return true;
                            break;
                        }

                        return false;
                        break;
                    }
                    case "What result is returned by (3 > 2) & (4 < 2)?":
                    {
                        if (A3.Text == "false")
                        {
                            return true;
                            break;
                        }

                        return false;
                        break;
                    }
                    case "what do duble slashes (//) precode?":
                    {
                        if (A3.Text == "comments")
                        {
                            return true;
                            break;
                        }

                        return false;
                        break;
                    }

                    default:
                        break;
                }
            }


            return false;
        }

        private void FinishQuizBtn_Click(object sender, EventArgs e)
        {
            string[] message =
            {
                GetCorrectAnsewr(1) ? "correct" : "incorrect",
                GetCorrectAnsewr(2) ? "correct" : "incorrect",
                GetCorrectAnsewr(3) ? "correct" : "incorrect",
            };
            MessageBox.Show(message[0] + "\n" + message[1] + "\n" + message[2] + "\n","Result");
        }
    }
}
