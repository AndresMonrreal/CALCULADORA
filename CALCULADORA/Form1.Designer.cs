namespace CALCULADORA
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
            txtTexto = new TextBox();
            but1 = new Button();
            but2 = new Button();
            but3 = new Button();
            but4 = new Button();
            but5 = new Button();
            but6 = new Button();
            but8 = new Button();
            but7 = new Button();
            but9 = new Button();
            butt0 = new Button();
            butPunto = new Button();
            butResta = new Button();
            butSuma = new Button();
            butMultiplicar = new Button();
            butDIvision = new Button();
            butResto = new Button();
            buttDE = new Button();
            butEliminar = new Button();
            butIgual = new Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(27, 79);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(307, 27);
            txtTexto.TabIndex = 0;
            txtTexto.TextChanged += txtTexto_TextChanged;
            // 
            // but1
            // 
            but1.Location = new Point(40, 255);
            but1.Name = "but1";
            but1.Size = new Size(94, 29);
            but1.TabIndex = 1;
            but1.Text = "1";
            but1.UseVisualStyleBackColor = true;
            but1.Click += button1_Click;
            // 
            // but2
            // 
            but2.Location = new Point(140, 255);
            but2.Name = "but2";
            but2.Size = new Size(94, 29);
            but2.TabIndex = 2;
            but2.Text = "2";
            but2.UseVisualStyleBackColor = true;
            but2.Click += but2_Click;
            // 
            // but3
            // 
            but3.Location = new Point(240, 255);
            but3.Name = "but3";
            but3.Size = new Size(94, 29);
            but3.TabIndex = 3;
            but3.Text = "3";
            but3.UseVisualStyleBackColor = true;
            but3.Click += but3_Click;
            // 
            // but4
            // 
            but4.Location = new Point(40, 309);
            but4.Name = "but4";
            but4.Size = new Size(94, 29);
            but4.TabIndex = 4;
            but4.Text = "4";
            but4.UseVisualStyleBackColor = true;
            but4.Click += button4_Click;
            // 
            // but5
            // 
            but5.Location = new Point(140, 309);
            but5.Name = "but5";
            but5.Size = new Size(94, 29);
            but5.TabIndex = 5;
            but5.Text = "5";
            but5.UseVisualStyleBackColor = true;
            but5.Click += but5_Click;
            // 
            // but6
            // 
            but6.Location = new Point(240, 309);
            but6.Name = "but6";
            but6.Size = new Size(94, 29);
            but6.TabIndex = 6;
            but6.Text = "6";
            but6.UseVisualStyleBackColor = true;
            but6.Click += button6_Click;
            // 
            // but8
            // 
            but8.Location = new Point(140, 357);
            but8.Name = "but8";
            but8.Size = new Size(94, 29);
            but8.TabIndex = 7;
            but8.Text = "8";
            but8.UseVisualStyleBackColor = true;
            but8.Click += but8_Click;
            // 
            // but7
            // 
            but7.Location = new Point(40, 357);
            but7.Name = "but7";
            but7.Size = new Size(94, 29);
            but7.TabIndex = 8;
            but7.Text = "7";
            but7.UseVisualStyleBackColor = true;
            but7.Click += but7_Click;
            // 
            // but9
            // 
            but9.Location = new Point(240, 357);
            but9.Name = "but9";
            but9.Size = new Size(94, 29);
            but9.TabIndex = 9;
            but9.Text = "9";
            but9.UseVisualStyleBackColor = true;
            but9.Click += but9_Click;
            // 
            // butt0
            // 
            butt0.Location = new Point(140, 408);
            butt0.Name = "butt0";
            butt0.Size = new Size(94, 29);
            butt0.TabIndex = 10;
            butt0.Text = "0";
            butt0.UseVisualStyleBackColor = true;
            butt0.Click += button0_Click;
            // 
            // butPunto
            // 
            butPunto.Location = new Point(240, 408);
            butPunto.Name = "butPunto";
            butPunto.Size = new Size(94, 29);
            butPunto.TabIndex = 11;
            butPunto.Text = ".";
            butPunto.UseVisualStyleBackColor = true;
            butPunto.Click += butPunto_Click;
            // 
            // butResta
            // 
            butResta.Location = new Point(115, 148);
            butResta.Name = "butResta";
            butResta.Size = new Size(65, 29);
            butResta.TabIndex = 12;
            butResta.Text = "-";
            butResta.UseVisualStyleBackColor = true;
            butResta.Click += butResta_Click;
            // 
            // butSuma
            // 
            butSuma.Location = new Point(40, 148);
            butSuma.Name = "butSuma";
            butSuma.Size = new Size(69, 29);
            butSuma.TabIndex = 13;
            butSuma.Text = "+";
            butSuma.UseVisualStyleBackColor = true;
            butSuma.Click += butSuma_Click;
            // 
            // butMultiplicar
            // 
            butMultiplicar.Location = new Point(186, 148);
            butMultiplicar.Name = "butMultiplicar";
            butMultiplicar.Size = new Size(65, 29);
            butMultiplicar.TabIndex = 14;
            butMultiplicar.Text = "*";
            butMultiplicar.UseVisualStyleBackColor = true;
            butMultiplicar.Click += butMultiplicar_Click;
            // 
            // butDIvision
            // 
            butDIvision.Location = new Point(257, 148);
            butDIvision.Name = "butDIvision";
            butDIvision.Size = new Size(77, 29);
            butDIvision.TabIndex = 15;
            butDIvision.Text = "/";
            butDIvision.UseVisualStyleBackColor = true;
            butDIvision.Click += butDIvision_Click;
            // 
            // butResto
            // 
            butResto.Location = new Point(140, 202);
            butResto.Name = "butResto";
            butResto.Size = new Size(94, 29);
            butResto.TabIndex = 16;
            butResto.Text = "%";
            butResto.UseVisualStyleBackColor = true;
            butResto.Click += butResto_Click;
            // 
            // buttDE
            // 
            buttDE.Location = new Point(240, 202);
            buttDE.Name = "buttDE";
            buttDE.Size = new Size(94, 29);
            buttDE.TabIndex = 17;
            buttDE.Text = "De";
            buttDE.UseVisualStyleBackColor = true;
            buttDE.Click += buttonDe_Click;
            // 
            // butEliminar
            // 
            butEliminar.Location = new Point(40, 408);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(94, 29);
            butEliminar.TabIndex = 19;
            butEliminar.Text = "Elim";
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // butIgual
            // 
            butIgual.Location = new Point(40, 202);
            butIgual.Name = "butIgual";
            butIgual.Size = new Size(94, 29);
            butIgual.TabIndex = 20;
            butIgual.Text = "=";
            butIgual.UseVisualStyleBackColor = true;
            butIgual.Click += butIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 511);
            Controls.Add(butIgual);
            Controls.Add(butEliminar);
            Controls.Add(buttDE);
            Controls.Add(butResto);
            Controls.Add(butDIvision);
            Controls.Add(butMultiplicar);
            Controls.Add(butSuma);
            Controls.Add(butResta);
            Controls.Add(butPunto);
            Controls.Add(butt0);
            Controls.Add(but9);
            Controls.Add(but7);
            Controls.Add(but8);
            Controls.Add(but6);
            Controls.Add(but5);
            Controls.Add(but4);
            Controls.Add(but3);
            Controls.Add(but2);
            Controls.Add(but1);
            Controls.Add(txtTexto);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTexto;
        private Button but1;
        private Button but2;
        private Button but3;
        private Button but4;
        private Button but5;
        private Button but6;
        private Button but8;
        private Button but7;
        private Button but9;
        private Button butt0;
        private Button butPunto;
        private Button butResta;
        private Button butSuma;
        private Button butMultiplicar;
        private Button butDIvision;
        private Button butResto;
        private Button buttDE;
        private Button butEliminar;
        private Button butIgual;
    }
}
