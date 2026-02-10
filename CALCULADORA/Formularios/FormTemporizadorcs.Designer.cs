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
            menuStrip1 = new MenuStrip();
            mnsAlarma = new ToolStripMenuItem();
            mnsAlarma1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsAlarma });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(495, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsAlarma
            // 
            mnsAlarma.DropDownItems.AddRange(new ToolStripItem[] { mnsAlarma1 });
            mnsAlarma.Name = "mnsAlarma";
            mnsAlarma.Size = new Size(71, 24);
            mnsAlarma.Text = "Alarma";
            // 
            // mnsAlarma1
            // 
            mnsAlarma1.Name = "mnsAlarma1";
            mnsAlarma1.Size = new Size(224, 26);
            mnsAlarma1.Text = "Esrablecer Alarma1";
            mnsAlarma1.Click += mnsAlarma1_Click;
            // 
            // FormTemporizadorcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 264);
            Controls.Add(labHora);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTemporizadorcs";
            Text = "FormTemporizadorcs";
            Load += FormTemporizadorcs_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labHora;
        private System.Windows.Forms.Timer timeHora;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsAlarma;
        private ToolStripMenuItem mnsAlarma1;
    }
}