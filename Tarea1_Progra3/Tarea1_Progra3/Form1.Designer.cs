namespace Tarea1_Progra3
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
            this.Procesar_button = new System.Windows.Forms.Button();
            this.numero_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Procesar_button
            // 
            this.Procesar_button.Location = new System.Drawing.Point(314, 27);
            this.Procesar_button.Name = "Procesar_button";
            this.Procesar_button.Size = new System.Drawing.Size(75, 23);
            this.Procesar_button.TabIndex = 0;
            this.Procesar_button.Text = "Procesar";
            this.Procesar_button.UseVisualStyleBackColor = true;
            this.Procesar_button.Click += new System.EventHandler(this.Procesar_button_Click);
            // 
            // numero_textBox
            // 
            this.numero_textBox.Location = new System.Drawing.Point(190, 27);
            this.numero_textBox.Name = "numero_textBox";
            this.numero_textBox.Size = new System.Drawing.Size(100, 23);
            this.numero_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese un numero: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 94);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero_textBox);
            this.Controls.Add(this.Procesar_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Procesar_button;
        private TextBox numero_textBox;
        private Label label1;
    }
}