namespace CALCULADORA
{
    partial class FormMetodoOrdenamiento
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
            DGVdesordenado = new DataGridView();
            Desodernado = new DataGridViewTextBoxColumn();
            DGVOrdenado = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            butRandom = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVdesordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVOrdenado).BeginInit();
            SuspendLayout();
            // 
            // DGVdesordenado
            // 
            DGVdesordenado.AllowUserToAddRows = false;
            DGVdesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVdesordenado.Columns.AddRange(new DataGridViewColumn[] { Desodernado });
            DGVdesordenado.Location = new Point(51, 49);
            DGVdesordenado.Name = "DGVdesordenado";
            DGVdesordenado.RowHeadersWidth = 51;
            DGVdesordenado.Size = new Size(196, 467);
            DGVdesordenado.TabIndex = 0;
            // 
            // Desodernado
            // 
            Desodernado.HeaderText = "Numeros";
            Desodernado.MinimumWidth = 6;
            Desodernado.Name = "Desodernado";
            Desodernado.Width = 125;
            // 
            // DGVOrdenado
            // 
            DGVOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVOrdenado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            DGVOrdenado.Location = new Point(505, 49);
            DGVOrdenado.Name = "DGVOrdenado";
            DGVOrdenado.RowHeadersWidth = 51;
            DGVOrdenado.Size = new Size(196, 467);
            DGVOrdenado.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Numeros";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // butRandom
            // 
            butRandom.Location = new Point(335, 94);
            butRandom.Name = "butRandom";
            butRandom.Size = new Size(94, 29);
            butRandom.TabIndex = 2;
            butRandom.Text = "Random";
            butRandom.UseVisualStyleBackColor = true;
            butRandom.Click += butRandom_Click;
            // 
            // FormMetodoOrdenamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(butRandom);
            Controls.Add(DGVOrdenado);
            Controls.Add(DGVdesordenado);
            Name = "FormMetodoOrdenamiento";
            Text = "FormMetodoOrdenamiento";
            ((System.ComponentModel.ISupportInitialize)DGVdesordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVOrdenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVdesordenado;
        private DataGridViewTextBoxColumn Desodernado;
        private DataGridView DGVOrdenado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button butRandom;
    }
}