using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class frmMain : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        public frmMain()
        {
            InitializeComponent();
            checkedListBox.SetItemChecked(17, true);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();

            btn.Location= new System.Drawing.Point(e.X, e.Y);
            btn.Click += new System.EventHandler(this.yesOrNoBtn_Click);

            this.Controls.Add(btn);

            checkedListBox.SetItemChecked(0, true);
        }

        private void yesOrNoBtn_Click(object sender, EventArgs e)
        {
            if (this.okBtn.Text.Equals("YES")) 
            {
                this.okBtn.Text = "NO";
            }
            else
            {
                this.okBtn.Text = "YES";
            }

            checkedListBox.SetItemChecked(3, true);
        }

        private void deleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.Controls.Remove(deletedButton);

            checkedListBox.SetItemChecked(1, true);
            checkedListBox.SetItemChecked(4, true);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            changeXLabel.Text = e.X.ToString();
            changeYLabel.Text = e.Y.ToString();

            checkedListBox.SetItemChecked(2, true);
            checkedListBox.SetItemChecked(8, true);
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 3;

            progressBar.Increment(1);
            progressChangeLabel.Text = progressBar.Value.ToString();

            checkedListBox.SetItemChecked(5, true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colourComboBox.SelectedIndex == 0)
            {
                colourButton.BackColor = Color.Red;
            }
            else if (colourComboBox.SelectedIndex == 1)
            {
                colourButton.BackColor = Color.Green;
            }
            else if(colourComboBox.SelectedIndex == 2)
            {
                colourButton.BackColor = Color.Blue;
            }

            checkedListBox.SetItemChecked(6, true);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTextBox.Text = dateTimePicker.Value.ToShortDateString();

            checkedListBox.SetItemChecked(7, true);
        }

        private void monthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthTextBox.Text = monthListBox.SelectedItem.ToString();

            checkedListBox.SetItemChecked(9, true);
        }

        private void holdButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            this.timer.AutoReset= true;
            this.timer.Enabled = true;

            checkedListBox.SetItemChecked(10, true);
            checkedListBox.SetItemChecked(15, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (InvokeRequired)
                this.Invoke(new Action(() => numericUpDown.Value++));
            else
                numericUpDown.Value++;
        }

        private void holdButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer.Elapsed -= new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            this.timer.Enabled = false;
        }

        private void srcTextBox_TextChanged(object sender, EventArgs e)
        {
            dstTextBox.Text = srcTextBox.Text;

            checkedListBox.SetItemChecked(11, true);
        }

        private void dstTextBox_TextChanged(object sender, EventArgs e)
        {
            srcTextBox.Text = dstTextBox.Text;

            checkedListBox.SetItemChecked(11, true);
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            chosenDateLabel.Text = e.Start.ToShortDateString();

            checkedListBox.SetItemChecked(12, true);
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (arialRadio.Checked)
            {
                richTextBox.Font = new Font("Arial", 12, FontStyle.Bold);
            }
            else if (tnrRadio.Checked)
            {
                richTextBox.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            }
            else if (verdanaRadio.Checked)
            {
                richTextBox.Font = new Font("Courier New", 12, FontStyle.Underline);
            }

            checkedListBox.SetItemChecked(13, true);
            checkedListBox.SetItemChecked(14, true);
        }

        private void srcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            keyCodeTextBox.Text = e.KeyValue.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            yesOrNoTextBox.Text = "Yes";
        }

        private void yesOrNoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            yesOrNoTextBox.Text = "No";
        }

        private void performClickButton_Click(object sender, EventArgs e)
        {
            changeTextButton.PerformClick();
        }

        private void changeTextButton_Click(object sender, EventArgs e)
        {
            if (changeTextButton.Text.Equals("button2"))
            {
                changeTextButton.Text = "Clicked";
            }
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            heightChangedLabel.Text = this.Height.ToString();
            widthChangedLabel.Text = this.Width.ToString();

            checkedListBox.SetItemChecked(16, true);
        }

        private void ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (redToolStripMenuItem.Selected)
            {
                bottomButton.BackColor = Color.Red;
            }
            else if (greenToolStripMenuItem.Selected)
            {
                bottomButton.BackColor = Color.Green;
            }
            else if (blueToolStripMenuItem.Selected)
            {
                bottomButton.BackColor = Color.Blue;
            }
            checkedListBox.SetItemChecked(18, true);
        }
    }
}
