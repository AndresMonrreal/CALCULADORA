namespace CALCULADORA.Formularios
{
    partial class FormContador
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
            lblCuenta = new Label();
            tkbVelocidad = new TrackBar();
            butIniciar = new Button();
            butDetener = new Button();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tkbVelocidad).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(172, 33);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(67, 81);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "0";
            // 
            // tkbVelocidad
            // 
            tkbVelocidad.Location = new Point(23, 140);
            tkbVelocidad.Maximum = 5;
            tkbVelocidad.Minimum = 1;
            tkbVelocidad.Name = "tkbVelocidad";
            tkbVelocidad.Size = new Size(356, 56);
            tkbVelocidad.TabIndex = 3;
            tkbVelocidad.Value = 1;
            tkbVelocidad.Scroll += tkbVelocidad_Scroll;
            // 
            // butIniciar
            // 
            butIniciar.Location = new Point(238, 218);
            butIniciar.Name = "butIniciar";
            butIniciar.Size = new Size(94, 29);
            butIniciar.TabIndex = 2;
            butIniciar.Text = "Iniciar";
            butIniciar.UseVisualStyleBackColor = true;
            butIniciar.Click += butIniciar_Click;
            // 
            // butDetener
            // 
            butDetener.Location = new Point(67, 218);
            butDetener.Name = "butDetener";
            butDetener.Size = new Size(94, 29);
            butDetener.TabIndex = 3;
            butDetener.Text = "Detener";
            butDetener.UseVisualStyleBackColor = true;
            butDetener.Click += butDetener_Click;
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // FormContador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 303);
            Controls.Add(butDetener);
            Controls.Add(butIniciar);
            Controls.Add(tkbVelocidad);
            Controls.Add(lblCuenta);
            Name = "FormContador";
            Text = "FormContador";
            ((System.ComponentModel.ISupportInitialize)tkbVelocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private TrackBar tkbVelocidad;
        private Button butIniciar;
        private Button butDetener;
        private System.Windows.Forms.Timer tmrContador;
    }
}