﻿namespace ksıasıanav
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
            label1=new Label();
            textBox1=new TextBox();
            button1=new Button();
            button2=new Button();
            listBox1=new ListBox();
            button3=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 26);
            label1.Name="label1";
            label1.Size=new Size(37, 15);
            label1.TabIndex=0;
            label1.Text="Sayı : ";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(55, 26);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(123, 23);
            textBox1.TabIndex=1;
            // 
            // button1
            // 
            button1.Location=new Point(55, 55);
            button1.Name="button1";
            button1.Size=new Size(123, 23);
            button1.TabIndex=2;
            button1.Text="EKLE";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(55, 84);
            button2.Name="button2";
            button2.Size=new Size(123, 44);
            button2.TabIndex=3;
            button2.Text="ORTALAMA HESAPLA";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=15;
            listBox1.Location=new Point(184, 12);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(139, 499);
            listBox1.TabIndex=4;
            // 
            // button3
            // 
            button3.Location=new Point(55, 134);
            button3.Name="button3";
            button3.Size=new Size(123, 47);
            button3.TabIndex=5;
            button3.Text="VİRGÜLLÜ SAYI (tam sayı olmayan )";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(347, 527);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
    }
}