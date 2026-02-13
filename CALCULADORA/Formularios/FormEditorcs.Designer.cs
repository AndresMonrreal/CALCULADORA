namespace CALCULADORA.Formularios
{
    partial class FormEditorcs
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
            sfdEditor = new SaveFileDialog();
            mnsEditor = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            rtbEditor = new RichTextBox();
            stsEditar = new StatusStrip();
            odfEditor = new OpenFileDialog();
            tssEditor = new ToolStripStatusLabel();
            mnsEditor.SuspendLayout();
            stsEditar.SuspendLayout();
            SuspendLayout();
            // 
            // sfdEditor
            // 
            sfdEditor.Filter = "\"Archivo de Texto\"|*.txt";
            // 
            // mnsEditor
            // 
            mnsEditor.ImageScalingSize = new Size(20, 20);
            mnsEditor.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            mnsEditor.Location = new Point(0, 0);
            mnsEditor.Name = "mnsEditor";
            mnsEditor.Size = new Size(800, 28);
            mnsEditor.TabIndex = 1;
            mnsEditor.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, abrirToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(189, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(189, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(189, 26);
            guardarComoToolStripMenuItem.Text = "Guardar Como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(189, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(186, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(189, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // rtbEditor
            // 
            rtbEditor.Location = new Point(0, 31);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(800, 407);
            rtbEditor.TabIndex = 0;
            rtbEditor.Text = "";
            rtbEditor.TextChanged += rtbEditor_TextChanged;
            // 
            // stsEditar
            // 
            stsEditar.ImageScalingSize = new Size(20, 20);
            stsEditar.Items.AddRange(new ToolStripItem[] { tssEditor });
            stsEditar.Location = new Point(0, 424);
            stsEditar.Name = "stsEditar";
            stsEditar.Size = new Size(800, 26);
            stsEditar.TabIndex = 2;
            stsEditar.Text = "statusStrip1";
            // 
            // odfEditor
            // 
            odfEditor.Filter = "\"Archivo de Texto\"|*.txt";
            // 
            // tssEditor
            // 
            tssEditor.Name = "tssEditor";
            tssEditor.Size = new Size(76, 20);
            tssEditor.Text = "0 Palabras";
            tssEditor.Click += tssEditor_Click;
            // 
            // FormEditorcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stsEditar);
            Controls.Add(rtbEditor);
            Controls.Add(mnsEditor);
            MainMenuStrip = mnsEditor;
            Name = "FormEditorcs";
            Text = "Editores";
            mnsEditor.ResumeLayout(false);
            mnsEditor.PerformLayout();
            stsEditar.ResumeLayout(false);
            stsEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog sfdEditor;
        private MenuStrip mnsEditor;
        private RichTextBox rtbEditor;
        private StatusStrip stsEditar;
        private OpenFileDialog odfEditor;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripStatusLabel tssEditor;
    }
}