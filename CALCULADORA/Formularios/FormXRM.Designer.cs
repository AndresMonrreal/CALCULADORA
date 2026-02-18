namespace CALCULADORA.Formularios
{
    partial class FormXRM
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
            spcXML = new SplitContainer();
            dgvXml = new DataGridView();
            Columnid = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColTel = new DataGridViewTextBoxColumn();
            butGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)spcXML).BeginInit();
            spcXML.Panel1.SuspendLayout();
            spcXML.Panel2.SuspendLayout();
            spcXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXml).BeginInit();
            SuspendLayout();
            // 
            // spcXML
            // 
            spcXML.Dock = DockStyle.Fill;
            spcXML.Location = new Point(0, 0);
            spcXML.Name = "spcXML";
            spcXML.Orientation = Orientation.Horizontal;
            // 
            // spcXML.Panel1
            // 
            spcXML.Panel1.Controls.Add(dgvXml);
            // 
            // spcXML.Panel2
            // 
            spcXML.Panel2.Controls.Add(butGuardar);
            spcXML.Size = new Size(909, 450);
            spcXML.SplitterDistance = 318;
            spcXML.TabIndex = 1;
            // 
            // dgvXml
            // 
            dgvXml.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXml.Columns.AddRange(new DataGridViewColumn[] { Columnid, ColumnName, ColTel });
            dgvXml.Dock = DockStyle.Fill;
            dgvXml.Location = new Point(0, 0);
            dgvXml.Name = "dgvXml";
            dgvXml.RowHeadersWidth = 51;
            dgvXml.Size = new Size(909, 318);
            dgvXml.TabIndex = 6;
            // 
            // Columnid
            // 
            Columnid.HeaderText = "ID";
            Columnid.MinimumWidth = 6;
            Columnid.Name = "Columnid";
            Columnid.Width = 50;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 550;
            // 
            // ColTel
            // 
            ColTel.HeaderText = "Telefono";
            ColTel.MinimumWidth = 6;
            ColTel.Name = "ColTel";
            ColTel.Width = 250;
            // 
            // butGuardar
            // 
            butGuardar.Location = new Point(370, 56);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(94, 29);
            butGuardar.TabIndex = 0;
            butGuardar.Text = "Guardar";
            butGuardar.UseVisualStyleBackColor = true;
            butGuardar.Click += butGuardar_Click;
            // 
            // FormXRM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(spcXML);
            Name = "FormXRM";
            Text = "FormXRM";
            spcXML.Panel1.ResumeLayout(false);
            spcXML.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcXML).EndInit();
            spcXML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvXml).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer spcXML;
        private DataGridView dgvXml;
        private DataGridViewTextBoxColumn Columnid;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColTel;
        private Button butGuardar;
    }
}