using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PuzzleApp
{
    public partial class Form1 : Form
    {
        //attributes
        private TableLayoutPanelCellPosition free;
        private Button[] btns;
        private int Time;
        private TableLayoutPanelCellPosition selected;
        private int lastPosition =0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Time > 0)
            {
                Time--;
                int minute = Time / 60;
                int seconde = Time - (minute * 60);
                clock.Text = string.Format("{0:00}:{1:00}", minute, seconde);

            }
            else
            {
                Start.Enabled = true;
                Stop.Enabled = false;
                timer.Stop();
                MessageBox.Show("Game Over");
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Time = 600;
            Start.Enabled = false;
            Stop.Enabled = true;
            timer.Enabled = true;
            table.Focus();



            table.Controls.Clear();
            List<TableLayoutPanelCellPosition> positions = new List<TableLayoutPanelCellPosition>
            {   new TableLayoutPanelCellPosition(0, 0),
                new TableLayoutPanelCellPosition(0, 1),
                new TableLayoutPanelCellPosition(0, 2),
                new TableLayoutPanelCellPosition(1, 0),
                new TableLayoutPanelCellPosition(1, 1),
                new TableLayoutPanelCellPosition(1, 2),
                new TableLayoutPanelCellPosition(2, 0),
                new TableLayoutPanelCellPosition(2, 1),
                new TableLayoutPanelCellPosition(2, 2)
            };
            Random random = new Random();
            for (int i = 0; i < btns.Length ; i++)
            {
                int index = random.Next(positions.Count - 1);
                table.Controls.Add(btns[i], positions[index].Column, positions[index].Row);
                positions.RemoveAt(index);
            }
            free = positions[0];



        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Start.Enabled = true;
            Stop.Enabled = false;
            timer.Stop();
            clock.Text = "00:00";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stop.Enabled = false;
            btns = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 };
            
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (timer.Enabled == true)
            {

                if (keyData == Keys.Down)
                {

                    if (free.Row - 1 >= 0)
                    {
                        move(new TableLayoutPanelCellPosition(free.Column, free.Row - 1));
                        return true;
                    }
                }
                if (keyData == Keys.Up)
                {
                    if (free.Row + 1 <= 2)
                    {
                        move(new TableLayoutPanelCellPosition(free.Column, free.Row + 1));
                        return true;
                    }
                }
                if (keyData == Keys.Right)
                {
                    if (free.Column - 1 >= 0)
                    {
                        move(new TableLayoutPanelCellPosition(free.Column - 1, free.Row));
                        return true;
                    }
                }
                if (keyData == Keys.Left)
                {
                    if (free.Column + 1 <= 2)
                    {
                        move(new TableLayoutPanelCellPosition(free.Column + 1, free.Row));
                        return true;
                    }
                }
                if (keyData == Keys.Tab)
                {
                    while (!find(++lastPosition));
                    return true;
                }
                if (keyData == Keys.Enter && lastPosition != 0)
                {
                    if ((selected.Row - free.Row == -1 && selected.Column - free.Column == 0)
                        || (selected.Row - free.Row == 1 && selected.Column - free.Column == 0)
                        || (selected.Row - free.Row == 0 && selected.Column - free.Column == -1)
                        || (selected.Row - free.Row == 0 && selected.Column - free.Column == 1))
                    {
                        move(selected);
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void move(TableLayoutPanelCellPosition oldposition)
        {
            Button button = (Button)table.GetControlFromPosition(oldposition.Column, oldposition.Row);
            table.Controls.Remove(button);
            table.Controls.Add(button, free.Column, free.Row);
            free = oldposition;
            checker();
        }
        private bool find(int position)
        {
            if (position>4)
            {
                position = lastPosition = 1;
            }
            switch (position)
            { 
                case 1:
                    if (free.Row - 1 >= 0)
                    {
                        selected = new TableLayoutPanelCellPosition(free.Column, free.Row - 1);
                        table.GetControlFromPosition(selected.Column, selected.Row ).Focus();
                        return true;
                    }
                    break;

                case 2:
                    if (free.Column + 1 <= 2)
                    {
                        selected = new TableLayoutPanelCellPosition(free.Column + 1, free.Row);
                        table.GetControlFromPosition(selected.Column ,selected.Row).Focus();
                        return true;
                    }
                    break;
                case 3:
                    if (free.Row + 1 <= 2)
                    {
                        selected = new TableLayoutPanelCellPosition(free.Column, free.Row + 1);
                        table.GetControlFromPosition(selected.Column, selected.Row).Focus();
                        return true;
                    }
                    break;
                case 4:
                    if (free.Column - 1 >= 0)
                    {
                        selected = new TableLayoutPanelCellPosition(free.Column - 1, free.Row);
                        table.GetControlFromPosition(selected.Column, selected.Row).Focus();
                        return true;
                    }
                    break;
                default:
                    break;
            }
            return false;
        }
        private bool checker()
        {
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (table.GetControlFromPosition(j, i) != null)
                    {
                            output += table.GetControlFromPosition(j, i).Text;
                    }

                }

            }
            if (output.Equals("12345678"))
            {
                
                timer.Stop();
                clock.Text = "00:00";
                Start.Enabled = true;
                Stop.Enabled = false;

                MessageBox.Show("U win");
                return true;
            }
            return false;
        }

       
    }
}
