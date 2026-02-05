namespace CALCULADORA.Formularios
{
    partial class FormRegistro
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            labNombre = new Label();
            labApellidos = new Label();
            textBox2 = new TextBox();
            labFechaNacimiento = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-5, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(806, 457);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(798, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(labFechaNacimiento);
            tabPage2.Controls.Add(labApellidos);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(labNombre);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(798, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(39, 272);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // labNombre
            // 
            labNombre.AutoSize = true;
            labNombre.Location = new Point(46, 42);
            labNombre.Name = "labNombre";
            labNombre.Size = new Size(64, 20);
            labNombre.TabIndex = 2;
            labNombre.Text = "Nombre";
            // 
            // labApellidos
            // 
            labApellidos.AutoSize = true;
            labApellidos.Location = new Point(46, 142);
            labApellidos.Name = "labApellidos";
            labApellidos.Size = new Size(72, 20);
            labApellidos.TabIndex = 4;
            labApellidos.Text = "Apellidos";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(39, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // labFechaNacimiento
            // 
            labFechaNacimiento.AutoSize = true;
            labFechaNacimiento.Location = new Point(46, 240);
            labFechaNacimiento.Name = "labFechaNacimiento";
            labFechaNacimiento.Size = new Size(124, 20);
            labFechaNacimiento.TabIndex = 5;
            labFechaNacimiento.Text = "FechaNacimiento";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormRegistro";
            Text = "Registro";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label labFechaNacimiento;
        private Label labApellidos;
        private TextBox textBox2;
        private Label labNombre;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
    }
}