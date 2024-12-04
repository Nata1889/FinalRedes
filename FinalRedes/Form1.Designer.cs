namespace FinalRedes
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
            cboPorts = new ComboBox();
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnOn = new Button();
            btnOff = new Button();
            txtLog = new TextBox();
            SuspendLayout();
            // 
            // cboPorts
            // 
            cboPorts.FormattingEnabled = true;
            cboPorts.Location = new Point(21, 25);
            cboPorts.Name = "cboPorts";
            cboPorts.Size = new Size(151, 28);
            cboPorts.TabIndex = 0;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(21, 145);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(94, 29);
            btnConectar.TabIndex = 1;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(182, 145);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(103, 29);
            btnDesconectar.TabIndex = 2;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnOn
            // 
            btnOn.Location = new Point(21, 234);
            btnOn.Name = "btnOn";
            btnOn.Size = new Size(94, 29);
            btnOn.TabIndex = 3;
            btnOn.Text = "ON";
            btnOn.UseVisualStyleBackColor = true;
            btnOn.Click += btnOn_Click;
            // 
            // btnOff
            // 
            btnOff.Location = new Point(182, 234);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(94, 29);
            btnOff.TabIndex = 4;
            btnOff.Text = "OFF";
            btnOff.UseVisualStyleBackColor = true;
            btnOff.Click += btnOff_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(21, 372);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(255, 27);
            txtLog.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLog);
            Controls.Add(btnOff);
            Controls.Add(btnOn);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Controls.Add(cboPorts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPorts;
        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnOn;
        private Button btnOff;
        private TextBox txtLog;
    }
}
