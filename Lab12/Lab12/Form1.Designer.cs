namespace Lab12
{
    partial class Form1
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
            this.StartStopBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clearDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cloudyDays = new System.Windows.Forms.TextBox();
            this.overcastDays = new System.Windows.Forms.TextBox();
            this.stateClear = new System.Windows.Forms.TextBox();
            this.stateCloudy = new System.Windows.Forms.TextBox();
            this.stateOvercast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.Time = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).BeginInit();
            this.SuspendLayout();
            // 
            // StartStopBtn
            // 
            this.StartStopBtn.Location = new System.Drawing.Point(12, 12);
            this.StartStopBtn.Name = "StartStopBtn";
            this.StartStopBtn.Size = new System.Drawing.Size(75, 23);
            this.StartStopBtn.TabIndex = 0;
            this.StartStopBtn.Text = "Start/Stop";
            this.StartStopBtn.UseVisualStyleBackColor = true;
            this.StartStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clearDays
            // 
            this.clearDays.Location = new System.Drawing.Point(115, 35);
            this.clearDays.Name = "clearDays";
            this.clearDays.Size = new System.Drawing.Size(100, 22);
            this.clearDays.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clear days:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cloudy days:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Overcast days:";
            // 
            // cloudyDays
            // 
            this.cloudyDays.Location = new System.Drawing.Point(115, 63);
            this.cloudyDays.Name = "cloudyDays";
            this.cloudyDays.Size = new System.Drawing.Size(100, 22);
            this.cloudyDays.TabIndex = 5;
            // 
            // overcastDays
            // 
            this.overcastDays.Location = new System.Drawing.Point(115, 91);
            this.overcastDays.Name = "overcastDays";
            this.overcastDays.Size = new System.Drawing.Size(100, 22);
            this.overcastDays.TabIndex = 6;
            // 
            // stateClear
            // 
            this.stateClear.Location = new System.Drawing.Point(115, 119);
            this.stateClear.Name = "stateClear";
            this.stateClear.Size = new System.Drawing.Size(100, 22);
            this.stateClear.TabIndex = 7;
            // 
            // stateCloudy
            // 
            this.stateCloudy.Location = new System.Drawing.Point(115, 147);
            this.stateCloudy.Name = "stateCloudy";
            this.stateCloudy.Size = new System.Drawing.Size(100, 22);
            this.stateCloudy.TabIndex = 8;
            // 
            // stateOvercast
            // 
            this.stateOvercast.Location = new System.Drawing.Point(115, 175);
            this.stateOvercast.Name = "stateOvercast";
            this.stateOvercast.Size = new System.Drawing.Size(100, 22);
            this.stateOvercast.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clear state:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cloudy state:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Overcast state:";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(668, 12);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(120, 22);
            this.Amount.TabIndex = 13;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(434, 12);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(120, 22);
            this.Time.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Amount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stateOvercast);
            this.Controls.Add(this.stateCloudy);
            this.Controls.Add(this.stateClear);
            this.Controls.Add(this.overcastDays);
            this.Controls.Add(this.cloudyDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearDays);
            this.Controls.Add(this.StartStopBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStopBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox clearDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cloudyDays;
        private System.Windows.Forms.TextBox overcastDays;
        private System.Windows.Forms.TextBox stateClear;
        private System.Windows.Forms.TextBox stateCloudy;
        private System.Windows.Forms.TextBox stateOvercast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.NumericUpDown Time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

