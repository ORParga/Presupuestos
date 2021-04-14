using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Presupuestos
{
    public partial class frmDebugger : Form
    {
        List<TextBox> txtMessageList;
        List<TextBox> txtMessageNumberList;
        List<List<TextBox>> txtArgumentList;

        List<int> intMessageNumber;

        int spacing = 10;

        // Get call stack
        StackTrace stackTrace = new StackTrace();

        public frmDebugger()
        {
            InitializeComponent();
            txtMessageList = new List<TextBox>();
            txtMessageNumberList = new List<TextBox>();
            txtArgumentList = new List<List<TextBox>>();
            intMessageNumber = new List<int>();

        }
        public void setPosition(int Top, int Left)
        {
            this.Top = Top;
            this.Left = Left;
        }
        public void Present(int X, int Y)
        {
            Show();
            setPosition(X, Y);
        }

        public void AddMessage(string shape, List<string> strArgumentList)
        {

            //string callerMethodName = stackTrace.GetFrame(1).GetMethod().Name;

            Boolean found = false;
            TextBox temp;
            int left = 0;
            //*******************Busca la palabra clave (shape) en la lista ******************
            for (int i = 0; i < txtMessageList.Count; i++)
            {
                //************************* Devuelve el color Blanco de fondo a todos los TextBox**********
                txtMessageList[i].BackColor = Color.White;
                txtMessageNumberList[i].BackColor = Color.White;
                foreach (TextBox cell in txtArgumentList[i]) { cell.BackColor = Color.White; }
                if (txtMessageList[i].Text.Equals(shape))
                {
                    intMessageNumber[i]++;
                    txtMessageNumberList[i].Text = intMessageNumber[i].ToString();
                    txtMessageList[i].BackColor = Color.Yellow;
                    txtMessageNumberList[i].BackColor = Color.Yellow;
                    found = true;

                    if (strArgumentList == null)
                    {

                    }
                    else
                    {
                        left = txtMessageNumberList[i].Right+ spacing;
                        for (int index = 0; index < strArgumentList.Count; index++)
                        {
                            if (index<txtArgumentList[i].Count )
                            {
                                //ya hay un textBox como argumento[index] así que se sobreescribe

                                txtArgumentList[i][index].Text = strArgumentList[index];
                                txtArgumentList[i][index].BackColor = Color.Yellow;

                            }
                            else
                            {
                                //No hay un textBox como argumento[index]así que se crea uno nuevo
                                temp = new TextBox();
                                txtArgumentList[i].Add(temp);
                                temp.Top = txtMessageList[i].Top;
                                temp.Left = left;
                                temp.Width = 200;
                                Controls.Add(temp);
                                temp.Text = strArgumentList[index];
                                temp.BackColor = Color.Yellow;
                                temp.Show();
                            }
                            left = txtArgumentList[i][index].Right + spacing;
                        }
                    }
                }

            }
            if (found) return;
            //Si la palabra clave no ha sido encontrada, generea una nueva fila

            temp = new TextBox();
            txtMessageList.Add(temp);
            temp.Top = 20 * txtMessageList.Count;
            temp.Width = 200;
            Controls.Add(temp);
            temp.Text = shape;
            temp.BackColor = Color.Yellow;
            temp.Show();

            intMessageNumber.Add(1);

            TextBox temp2 = new TextBox();
            txtMessageNumberList.Add(temp2);
            temp2.Top = temp.Top;
            temp2.Left = temp.Right + spacing;
            Controls.Add(temp2);
            temp2.Text = "1";
            temp2.BackColor = Color.Yellow;
            temp2.Show();

            TextBox temp3;
            List<TextBox> new_argumentList = new List<TextBox>();
            left = temp2.Right;
            foreach (string arg in strArgumentList)
            {
                temp3 = new TextBox();
                new_argumentList.Add(temp3);
                temp3.Top = temp.Top;
                temp3.Left = left + spacing;
                Controls.Add(temp3);
                temp3.Text = arg;
                temp3.BackColor = Color.Yellow;
                temp3.Show();
                left = temp3.Right;
            }
            txtArgumentList.Add(new_argumentList);
        }

        public void AddMessage(string shape, String Argument)
        {

            List<string> argumentList = new List<string>();
            argumentList.Add(Argument);
            AddMessage(shape, argumentList);
        }
        public void AddMessage(string shape, string Argument0, string Argument1)
        {
            List<string> argumentList = new List<string>();
            argumentList.Add(Argument0);
            argumentList.Add(Argument1);
            AddMessage(shape, argumentList);
        }
        public void AddMessage(string shape, string Argument0, string Argument1, string Argument2)
        {
            List<string> argumentList = new List<string>();
            argumentList.Add(Argument0);
            argumentList.Add(Argument1);
            argumentList.Add(Argument2);
            AddMessage(shape, argumentList);
        }
        public void AddMessage(string shape, string Argument0, string Argument1, string Argument2, string Argument3)
        {
            List<string> argumentList = new List<string>();
            argumentList.Add(Argument0);
            argumentList.Add(Argument1);
            argumentList.Add(Argument2);
            argumentList.Add(Argument3);
            AddMessage(shape, argumentList);
        }

        public void AddMessage(string shape)
        {
            Boolean found = false;

            for (int i = 0; i < txtMessageList.Count; i++)
            {
                txtMessageList[i].BackColor = Color.White;
                txtMessageNumberList[i].BackColor = Color.White;
                foreach (TextBox cell in txtArgumentList[i]) { cell.BackColor = Color.White; }
                if (txtMessageList[i].Text.Equals(shape))
                {
                    intMessageNumber[i]++;
                    txtMessageNumberList[i].Text = intMessageNumber[i].ToString();
                    txtMessageList[i].BackColor = Color.Yellow;
                    txtMessageNumberList[i].BackColor = Color.Yellow;
                    found = true;
                }

            }
            if (found) return;

            TextBox temp = new TextBox();
            txtMessageList.Add(temp);
            temp.Top = 20 * txtMessageList.Count;
            temp.Width=400;
            Controls.Add(temp);
            temp.Text = shape;
            temp.BackColor = Color.Yellow;
            temp.Show();

            intMessageNumber.Add(1);

            TextBox temp2 = new TextBox();
            txtMessageNumberList.Add(temp2);
            temp2.Top = 20 * txtMessageNumberList.Count;
            temp2.Left = temp.Right + 10;
            Controls.Add(temp2);
            temp2.Text = "1";
            temp2.BackColor = Color.Yellow;
            temp2.Show();


            List<TextBox> argumentList = new List<TextBox>();
            txtArgumentList.Add(argumentList);
        }
    }
}
