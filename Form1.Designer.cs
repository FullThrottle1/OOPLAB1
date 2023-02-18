using System.Windows.Forms;

namespace LAB1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.okBtn = new System.Windows.Forms.Button();
            this.deletedButton = new System.Windows.Forms.Button();
            this.createLabel = new System.Windows.Forms.Label();
            this.deleteCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.coordinatesLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.changeXLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.changeYLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressChangeLabel = new System.Windows.Forms.Label();
            this.progressValueLabel = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.colourComboBox = new System.Windows.Forms.ComboBox();
            this.colourButton = new System.Windows.Forms.Button();
            this.comboboxLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.chooseDateLabel = new System.Windows.Forms.Label();
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.holdLabel = new System.Windows.Forms.Label();
            this.holdButton = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.srcTextBox = new System.Windows.Forms.TextBox();
            this.dstTextBox = new System.Windows.Forms.TextBox();
            this.randomWordLabel = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.chosenDateLabel = new System.Windows.Forms.Label();
            this.arialRadio = new System.Windows.Forms.RadioButton();
            this.tnrRadio = new System.Windows.Forms.RadioButton();
            this.verdanaRadio = new System.Windows.Forms.RadioButton();
            this.fontLabel = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.keyCodeTextBox = new System.Windows.Forms.TextBox();
            this.yesOrNoLabel = new System.Windows.Forms.Label();
            this.yesOrNoTextBox = new System.Windows.Forms.TextBox();
            this.performClickLabel = new System.Windows.Forms.Label();
            this.performClickButton = new System.Windows.Forms.Button();
            this.changeTextButton = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthChangedLabel = new System.Windows.Forms.Label();
            this.heightChangedLabel = new System.Windows.Forms.Label();
            this.windowSizeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(32, 49);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "YesOrNo";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.yesOrNoBtn_Click);
            // 
            // deletedButton
            // 
            this.deletedButton.Location = new System.Drawing.Point(93, 120);
            this.deletedButton.Name = "deletedButton";
            this.deletedButton.Size = new System.Drawing.Size(75, 23);
            this.deletedButton.TabIndex = 1;
            this.deletedButton.Text = "btnToBeDeleted";
            this.deletedButton.UseVisualStyleBackColor = true;
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Location = new System.Drawing.Point(29, 23);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(176, 13);
            this.createLabel.TabIndex = 2;
            this.createLabel.Text = "Click on the form to create a button:";
            // 
            // deleteCheckBox
            // 
            this.deleteCheckBox.AutoSize = true;
            this.deleteCheckBox.Location = new System.Drawing.Point(32, 126);
            this.deleteCheckBox.Name = "deleteCheckBox";
            this.deleteCheckBox.Size = new System.Drawing.Size(55, 17);
            this.deleteCheckBox.TabIndex = 3;
            this.deleteCheckBox.Text = "delete";
            this.deleteCheckBox.UseVisualStyleBackColor = true;
            this.deleteCheckBox.CheckedChanged += new System.EventHandler(this.deleteCheckBox_CheckedChanged);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Location = new System.Drawing.Point(29, 92);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(101, 13);
            this.deleteLabel.TabIndex = 4;
            this.deleteLabel.Text = "Delete btnToBeDel:";
            // 
            // coordinatesLabel
            // 
            this.coordinatesLabel.AutoSize = true;
            this.coordinatesLabel.Location = new System.Drawing.Point(32, 166);
            this.coordinatesLabel.Name = "coordinatesLabel";
            this.coordinatesLabel.Size = new System.Drawing.Size(66, 13);
            this.coordinatesLabel.TabIndex = 5;
            this.coordinatesLabel.Text = "Coordinates:";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(32, 194);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 13);
            this.xLabel.TabIndex = 6;
            this.xLabel.Text = "X:";
            // 
            // changeXLabel
            // 
            this.changeXLabel.AutoSize = true;
            this.changeXLabel.Location = new System.Drawing.Point(65, 194);
            this.changeXLabel.Name = "changeXLabel";
            this.changeXLabel.Size = new System.Drawing.Size(13, 13);
            this.changeXLabel.TabIndex = 7;
            this.changeXLabel.Text = "0";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(112, 193);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 13);
            this.yLabel.TabIndex = 8;
            this.yLabel.Text = "Y:";
            // 
            // changeYLabel
            // 
            this.changeYLabel.AutoSize = true;
            this.changeYLabel.Location = new System.Drawing.Point(152, 193);
            this.changeYLabel.Name = "changeYLabel";
            this.changeYLabel.Size = new System.Drawing.Size(13, 13);
            this.changeYLabel.TabIndex = 9;
            this.changeYLabel.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(35, 238);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 11;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(35, 222);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(112, 13);
            this.progressLabel.TabIndex = 12;
            this.progressLabel.Text = "Click the progress bar:";
            // 
            // progressChangeLabel
            // 
            this.progressChangeLabel.AutoSize = true;
            this.progressChangeLabel.Location = new System.Drawing.Point(184, 248);
            this.progressChangeLabel.Name = "progressChangeLabel";
            this.progressChangeLabel.Size = new System.Drawing.Size(13, 13);
            this.progressChangeLabel.TabIndex = 13;
            this.progressChangeLabel.Text = "0";
            // 
            // progressValueLabel
            // 
            this.progressValueLabel.AutoSize = true;
            this.progressValueLabel.Location = new System.Drawing.Point(141, 248);
            this.progressValueLabel.Name = "progressValueLabel";
            this.progressValueLabel.Size = new System.Drawing.Size(37, 13);
            this.progressValueLabel.TabIndex = 14;
            this.progressValueLabel.Text = "Value:";
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Creation",
            "Deletion",
            "Coordinates",
            "Button",
            "CheckBox",
            "ProgressBar",
            "ComboBox",
            "DateTimePicker",
            "Label",
            "ListBox",
            "NumericUpDown",
            "TextBox",
            "MonthCalendar",
            "RadioButton",
            "RichTextBox",
            "Timer",
            "SizeChanged",
            "CheckedListBox",
            "MenuStrip"});
            this.checkedListBox.Location = new System.Drawing.Point(620, 23);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(120, 289);
            this.checkedListBox.TabIndex = 15;
            // 
            // colourComboBox
            // 
            this.colourComboBox.FormattingEnabled = true;
            this.colourComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.colourComboBox.Location = new System.Drawing.Point(32, 298);
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(121, 21);
            this.colourComboBox.TabIndex = 16;
            this.colourComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // colourButton
            // 
            this.colourButton.Location = new System.Drawing.Point(159, 298);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(75, 23);
            this.colourButton.TabIndex = 17;
            this.colourButton.Text = "Colour";
            this.colourButton.UseVisualStyleBackColor = true;
            // 
            // comboboxLabel
            // 
            this.comboboxLabel.AutoSize = true;
            this.comboboxLabel.Location = new System.Drawing.Point(33, 282);
            this.comboboxLabel.Name = "comboboxLabel";
            this.comboboxLabel.Size = new System.Drawing.Size(87, 13);
            this.comboboxLabel.TabIndex = 18;
            this.comboboxLabel.Text = "Choose a colour:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(32, 359);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(159, 359);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(75, 20);
            this.dateTextBox.TabIndex = 20;
            // 
            // chooseDateLabel
            // 
            this.chooseDateLabel.AutoSize = true;
            this.chooseDateLabel.Location = new System.Drawing.Point(32, 340);
            this.chooseDateLabel.Name = "chooseDateLabel";
            this.chooseDateLabel.Size = new System.Drawing.Size(79, 13);
            this.chooseDateLabel.TabIndex = 21;
            this.chooseDateLabel.Text = "Choose a date:";
            // 
            // monthListBox
            // 
            this.monthListBox.FormattingEnabled = true;
            this.monthListBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June"});
            this.monthListBox.Location = new System.Drawing.Point(312, 39);
            this.monthListBox.Name = "monthListBox";
            this.monthListBox.Size = new System.Drawing.Size(84, 82);
            this.monthListBox.TabIndex = 22;
            this.monthListBox.SelectedIndexChanged += new System.EventHandler(this.monthListBox_SelectedIndexChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(309, 23);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(87, 13);
            this.monthLabel.TabIndex = 23;
            this.monthLabel.Text = "Choose a month:";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(418, 39);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 24;
            // 
            // holdLabel
            // 
            this.holdLabel.AutoSize = true;
            this.holdLabel.Location = new System.Drawing.Point(309, 127);
            this.holdLabel.Name = "holdLabel";
            this.holdLabel.Size = new System.Drawing.Size(83, 13);
            this.holdLabel.TabIndex = 25;
            this.holdLabel.Text = "Hold the button:";
            // 
            // holdButton
            // 
            this.holdButton.Location = new System.Drawing.Point(312, 143);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(75, 23);
            this.holdButton.TabIndex = 26;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = true;
            this.holdButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.holdButton_MouseDown);
            this.holdButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.holdButton_MouseUp);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(393, 146);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // srcTextBox
            // 
            this.srcTextBox.Location = new System.Drawing.Point(312, 189);
            this.srcTextBox.Name = "srcTextBox";
            this.srcTextBox.Size = new System.Drawing.Size(100, 20);
            this.srcTextBox.TabIndex = 28;
            this.srcTextBox.TextChanged += new System.EventHandler(this.srcTextBox_TextChanged);
            this.srcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.srcTextBox_KeyDown);
            // 
            // dstTextBox
            // 
            this.dstTextBox.Location = new System.Drawing.Point(418, 190);
            this.dstTextBox.Name = "dstTextBox";
            this.dstTextBox.Size = new System.Drawing.Size(100, 20);
            this.dstTextBox.TabIndex = 29;
            this.dstTextBox.TextChanged += new System.EventHandler(this.dstTextBox_TextChanged);
            this.dstTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.srcTextBox_KeyDown);
            // 
            // randomWordLabel
            // 
            this.randomWordLabel.AutoSize = true;
            this.randomWordLabel.Location = new System.Drawing.Point(309, 173);
            this.randomWordLabel.Name = "randomWordLabel";
            this.randomWordLabel.Size = new System.Drawing.Size(108, 13);
            this.randomWordLabel.TabIndex = 30;
            this.randomWordLabel.Text = "Enter a random word:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(312, 234);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 31;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Location = new System.Drawing.Point(309, 212);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(79, 13);
            this.calendarLabel.TabIndex = 32;
            this.calendarLabel.Text = "Choose a date:";
            // 
            // chosenDateLabel
            // 
            this.chosenDateLabel.AutoSize = true;
            this.chosenDateLabel.Location = new System.Drawing.Point(515, 282);
            this.chosenDateLabel.Name = "chosenDateLabel";
            this.chosenDateLabel.Size = new System.Drawing.Size(0, 13);
            this.chosenDateLabel.TabIndex = 33;
            // 
            // arialRadio
            // 
            this.arialRadio.AutoSize = true;
            this.arialRadio.Checked = true;
            this.arialRadio.Location = new System.Drawing.Point(32, 408);
            this.arialRadio.Name = "arialRadio";
            this.arialRadio.Size = new System.Drawing.Size(45, 17);
            this.arialRadio.TabIndex = 34;
            this.arialRadio.TabStop = true;
            this.arialRadio.Text = "Arial";
            this.arialRadio.UseVisualStyleBackColor = true;
            this.arialRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // tnrRadio
            // 
            this.tnrRadio.AutoSize = true;
            this.tnrRadio.Location = new System.Drawing.Point(32, 431);
            this.tnrRadio.Name = "tnrRadio";
            this.tnrRadio.Size = new System.Drawing.Size(115, 17);
            this.tnrRadio.TabIndex = 35;
            this.tnrRadio.Text = "Times New Roman";
            this.tnrRadio.UseVisualStyleBackColor = true;
            this.tnrRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // verdanaRadio
            // 
            this.verdanaRadio.AutoSize = true;
            this.verdanaRadio.Location = new System.Drawing.Point(32, 454);
            this.verdanaRadio.Name = "verdanaRadio";
            this.verdanaRadio.Size = new System.Drawing.Size(65, 17);
            this.verdanaRadio.TabIndex = 36;
            this.verdanaRadio.Text = "Verdana";
            this.verdanaRadio.UseVisualStyleBackColor = true;
            this.verdanaRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(29, 392);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(76, 13);
            this.fontLabel.TabIndex = 37;
            this.fontLabel.Text = "Choose a font:";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(155, 392);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(88, 82);
            this.richTextBox.TabIndex = 38;
            this.richTextBox.Text = "Hello, \nI love\nthis\nprogramming\nlanguage";
            // 
            // keyCodeTextBox
            // 
            this.keyCodeTextBox.Location = new System.Drawing.Point(524, 190);
            this.keyCodeTextBox.Name = "keyCodeTextBox";
            this.keyCodeTextBox.Size = new System.Drawing.Size(46, 20);
            this.keyCodeTextBox.TabIndex = 39;
            // 
            // yesOrNoLabel
            // 
            this.yesOrNoLabel.AutoSize = true;
            this.yesOrNoLabel.Location = new System.Drawing.Point(312, 408);
            this.yesOrNoLabel.Name = "yesOrNoLabel";
            this.yesOrNoLabel.Size = new System.Drawing.Size(166, 13);
            this.yesOrNoLabel.TabIndex = 40;
            this.yesOrNoLabel.Text = "Press any key and then release it:";
            // 
            // yesOrNoTextBox
            // 
            this.yesOrNoTextBox.Location = new System.Drawing.Point(312, 425);
            this.yesOrNoTextBox.Name = "yesOrNoTextBox";
            this.yesOrNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.yesOrNoTextBox.TabIndex = 41;
            this.yesOrNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.yesOrNoTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.yesOrNoTextBox_KeyUp);
            // 
            // performClickLabel
            // 
            this.performClickLabel.AutoSize = true;
            this.performClickLabel.Location = new System.Drawing.Point(32, 478);
            this.performClickLabel.Name = "performClickLabel";
            this.performClickLabel.Size = new System.Drawing.Size(123, 13);
            this.performClickLabel.TabIndex = 42;
            this.performClickLabel.Text = "PerformClick on button2:";
            // 
            // performClickButton
            // 
            this.performClickButton.Location = new System.Drawing.Point(32, 504);
            this.performClickButton.Name = "performClickButton";
            this.performClickButton.Size = new System.Drawing.Size(75, 23);
            this.performClickButton.TabIndex = 43;
            this.performClickButton.Text = "PerformClick";
            this.performClickButton.UseVisualStyleBackColor = true;
            this.performClickButton.Click += new System.EventHandler(this.performClickButton_Click);
            // 
            // changeTextButton
            // 
            this.changeTextButton.Location = new System.Drawing.Point(130, 504);
            this.changeTextButton.Name = "changeTextButton";
            this.changeTextButton.Size = new System.Drawing.Size(75, 23);
            this.changeTextButton.TabIndex = 44;
            this.changeTextButton.Text = "button2";
            this.changeTextButton.UseVisualStyleBackColor = true;
            this.changeTextButton.Click += new System.EventHandler(this.changeTextButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(614, 478);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 45;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(614, 504);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 46;
            this.heightLabel.Text = "Height:";
            // 
            // widthChangedLabel
            // 
            this.widthChangedLabel.AutoSize = true;
            this.widthChangedLabel.Location = new System.Drawing.Point(658, 478);
            this.widthChangedLabel.Name = "widthChangedLabel";
            this.widthChangedLabel.Size = new System.Drawing.Size(13, 13);
            this.widthChangedLabel.TabIndex = 47;
            this.widthChangedLabel.Text = "0";
            // 
            // heightChangedLabel
            // 
            this.heightChangedLabel.AutoSize = true;
            this.heightChangedLabel.Location = new System.Drawing.Point(658, 504);
            this.heightChangedLabel.Name = "heightChangedLabel";
            this.heightChangedLabel.Size = new System.Drawing.Size(13, 13);
            this.heightChangedLabel.TabIndex = 48;
            this.heightChangedLabel.Text = "0";
            // 
            // windowSizeLabel
            // 
            this.windowSizeLabel.AutoSize = true;
            this.windowSizeLabel.Location = new System.Drawing.Point(614, 461);
            this.windowSizeLabel.Name = "windowSizeLabel";
            this.windowSizeLabel.Size = new System.Drawing.Size(107, 13);
            this.windowSizeLabel.TabIndex = 49;
            this.windowSizeLabel.Text = "Change window size:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 20);
            this.toolStripMenuItem1.Text = "Change bottom button colour";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(102, 6);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItem_MouseDown);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItem_MouseDown);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItem_MouseDown);
            // 
            // bottomButton
            // 
            this.bottomButton.Location = new System.Drawing.Point(355, 478);
            this.bottomButton.Name = "bottomButton";
            this.bottomButton.Size = new System.Drawing.Size(105, 55);
            this.bottomButton.TabIndex = 51;
            this.bottomButton.Text = "bottomButton";
            this.bottomButton.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.bottomButton);
            this.Controls.Add(this.windowSizeLabel);
            this.Controls.Add(this.heightChangedLabel);
            this.Controls.Add(this.widthChangedLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.changeTextButton);
            this.Controls.Add(this.performClickButton);
            this.Controls.Add(this.performClickLabel);
            this.Controls.Add(this.yesOrNoTextBox);
            this.Controls.Add(this.yesOrNoLabel);
            this.Controls.Add(this.keyCodeTextBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.verdanaRadio);
            this.Controls.Add(this.tnrRadio);
            this.Controls.Add(this.arialRadio);
            this.Controls.Add(this.chosenDateLabel);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.randomWordLabel);
            this.Controls.Add(this.dstTextBox);
            this.Controls.Add(this.srcTextBox);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.holdButton);
            this.Controls.Add(this.holdLabel);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.monthListBox);
            this.Controls.Add(this.chooseDateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboboxLabel);
            this.Controls.Add(this.colourButton);
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.progressValueLabel);
            this.Controls.Add(this.progressChangeLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.changeYLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.changeXLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.coordinatesLabel);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.deleteCheckBox);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.deletedButton);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button deletedButton;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.CheckBox deleteCheckBox;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Label coordinatesLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label changeXLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label changeYLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label progressChangeLabel;
        private System.Windows.Forms.Label progressValueLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ComboBox colourComboBox;
        private System.Windows.Forms.Button colourButton;
        private System.Windows.Forms.Label comboboxLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label chooseDateLabel;
        private System.Windows.Forms.ListBox monthListBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label holdLabel;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox srcTextBox;
        private System.Windows.Forms.TextBox dstTextBox;
        private System.Windows.Forms.Label randomWordLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.Label chosenDateLabel;
        private System.Windows.Forms.RadioButton arialRadio;
        private System.Windows.Forms.RadioButton tnrRadio;
        private System.Windows.Forms.RadioButton verdanaRadio;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox keyCodeTextBox;
        private System.Windows.Forms.Label yesOrNoLabel;
        private System.Windows.Forms.TextBox yesOrNoTextBox;
        private System.Windows.Forms.Label performClickLabel;
        private System.Windows.Forms.Button performClickButton;
        private System.Windows.Forms.Button changeTextButton;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthChangedLabel;
        private System.Windows.Forms.Label heightChangedLabel;
        private System.Windows.Forms.Label windowSizeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.Button bottomButton;
    }
}

