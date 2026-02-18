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
            butRegistrar = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            label1 = new Label();
            labApellido = new Label();
            tbApellido = new TextBox();
            labNombre = new Label();
            tbNombre = new TextBox();
            tabPage2 = new TabPage();
            butEliminar = new Button();
            dataGridViewPersonas = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-5, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(806, 561);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(butRegistrar);
            tabPage1.Controls.Add(dtpFechaNacimiento);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(labApellido);
            tabPage1.Controls.Add(tbApellido);
            tabPage1.Controls.Add(labNombre);
            tabPage1.Controls.Add(tbNombre);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(798, 528);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // butRegistrar
            // 
            butRegistrar.Location = new Point(276, 127);
            butRegistrar.Name = "butRegistrar";
            butRegistrar.Size = new Size(94, 29);
            butRegistrar.TabIndex = 8;
            butRegistrar.Text = "Registrar";
            butRegistrar.UseVisualStyleBackColor = true;
            butRegistrar.Click += butRegistrar_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(39, 280);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 224);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 6;
            label1.Text = "FechaNacimiento";
            // 
            // labApellido
            // 
            labApellido.AutoSize = true;
            labApellido.Location = new Point(41, 127);
            labApellido.Name = "labApellido";
            labApellido.Size = new Size(66, 20);
            labApellido.TabIndex = 5;
            labApellido.Text = "Apellido";
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(41, 165);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(225, 27);
            tbApellido.TabIndex = 4;
            // 
            // labNombre
            // 
            labNombre.AutoSize = true;
            labNombre.Location = new Point(41, 35);
            labNombre.Name = "labNombre";
            labNombre.Size = new Size(64, 20);
            labNombre.TabIndex = 3;
            labNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(41, 73);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(225, 27);
            tbNombre.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DimGray;
            tabPage2.Controls.Add(butEliminar);
            tabPage2.Controls.Add(dataGridViewPersonas);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(798, 528);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            // 
            // butEliminar
            // 
            butEliminar.Location = new Point(533, 499);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(94, 29);
            butEliminar.TabIndex = 1;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPersonas
            // 
            dataGridViewPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonas.Location = new Point(-4, 3);
            dataGridViewPersonas.Name = "dataGridViewPersonas";
            dataGridViewPersonas.RowHeadersWidth = 51;
            dataGridViewPersonas.Size = new Size(806, 484);
            dataGridViewPersonas.TabIndex = 0;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(tabControl1);
            Name = "FormRegistro";
            Text = "Registro";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;

      
        private TextBox textBox2;
        
      
       
        private TextBox tbNombre;
        private Label labNombre;
        private Button butRegistrar;
        private DateTimePicker dtpFechaNacimiento;
        private Label label1;
        private Label labApellido;
        private TextBox tbApellido;
        private DataGridView dataGridViewPersonas;
        private Button butEliminar;
    }
}