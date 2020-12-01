namespace PuzzleApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Stop = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Start.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Start.Location = new System.Drawing.Point(59, 381);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(87, 48);
            this.Start.TabIndex = 0;
            this.Start.TabStop = false;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // table
            // 
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.38596F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.63158F));
            this.table.Controls.Add(this.btn7, 0, 2);
            this.table.Controls.Add(this.btn4, 0, 1);
            this.table.Controls.Add(this.btn3, 2, 0);
            this.table.Controls.Add(this.btn2, 1, 0);
            this.table.Controls.Add(this.btn1, 0, 0);
            this.table.Controls.Add(this.btn8, 1, 2);
            this.table.Controls.Add(this.btn5, 1, 1);
            this.table.Controls.Add(this.btn6, 2, 1);
            this.table.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.table.Location = new System.Drawing.Point(53, 104);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.Size = new System.Drawing.Size(288, 245);
            this.table.TabIndex = 1;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(6, 166);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 73);
            this.btn7.TabIndex = 0;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(6, 86);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 71);
            this.btn4.TabIndex = 0;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(197, 6);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 71);
            this.btn3.TabIndex = 0;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(100, 6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(86, 71);
            this.btn2.TabIndex = 0;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(6, 6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 71);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(100, 166);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(88, 73);
            this.btn8.TabIndex = 0;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(100, 86);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 71);
            this.btn5.TabIndex = 0;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(197, 86);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 71);
            this.btn6.TabIndex = 0;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.BackColor = System.Drawing.Color.Black;
            this.clock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clock.Font = new System.Drawing.Font("Segoe UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.clock.ForeColor = System.Drawing.Color.LavenderBlush;
            this.clock.Location = new System.Drawing.Point(133, 25);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(128, 56);
            this.clock.TabIndex = 2;
            this.clock.Text = "00:00";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(98, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 75);
            this.button6.TabIndex = 0;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(193, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 75);
            this.button7.TabIndex = 0;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(3, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 75);
            this.button8.TabIndex = 0;
            this.button8.Text = "1";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(98, 165);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 75);
            this.button9.TabIndex = 0;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(193, 165);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 75);
            this.button10.TabIndex = 0;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Stop.FlatAppearance.BorderSize = 4;
            this.Stop.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Stop.ForeColor = System.Drawing.Color.Maroon;
            this.Stop.Location = new System.Drawing.Point(250, 381);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(91, 51);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "STOP";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 468);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.table);
            this.Controls.Add(this.Start);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Stop;
    }
}

