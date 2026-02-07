namespace CALCULADORA.Formularios
{
    partial class FormTemporizadorcs
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
            components = new System.ComponentModel.Container();
            labHora = new Label();
            timeHora = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labHora
            // 
            labHora.AutoSize = true;
            labHora.Font = new Font("SimSun", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labHora.Location = new Point(82, 99);
            labHora.Name = "labHora";
            labHora.Size = new Size(308, 47);
            labHora.TabIndex = 0;
            labHora.Text = "00:00:00 x.x";
            // 
            // timeHora
            // 
            timeHora.Tick += timeHora_Tick;
            // 
            // FormTemporizadorcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 264);
            Controls.Add(labHora);
            Name = "FormTemporizadorcs";
            Text = "FormTemporizadorcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labHora;
        private System.Windows.Forms.Timer timeHora;
    }
}