namespace Ejercicio_programacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.agregar_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.registro_estudiantes_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su Nombre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su Edad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registros de Estudiantes";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(193, 49);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 23);
            this.name_textBox.TabIndex = 3;
            // 
            // age_textBox
            // 
            this.age_textBox.Location = new System.Drawing.Point(193, 95);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(100, 23);
            this.age_textBox.TabIndex = 4;
            // 
            // agregar_button
            // 
            this.agregar_button.Location = new System.Drawing.Point(305, 73);
            this.agregar_button.Name = "agregar_button";
            this.agregar_button.Size = new System.Drawing.Size(128, 23);
            this.agregar_button.TabIndex = 5;
            this.agregar_button.Text = "AGREGAR A LISTA";
            this.agregar_button.UseVisualStyleBackColor = true;
            this.agregar_button.Click += new System.EventHandler(this.agregar_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "LISTA DE ESTUDIANTES";
            // 
            // registro_estudiantes_listBox
            // 
            this.registro_estudiantes_listBox.BackColor = System.Drawing.SystemColors.Window;
            this.registro_estudiantes_listBox.FormattingEnabled = true;
            this.registro_estudiantes_listBox.ItemHeight = 15;
            this.registro_estudiantes_listBox.Location = new System.Drawing.Point(81, 188);
            this.registro_estudiantes_listBox.Name = "registro_estudiantes_listBox";
            this.registro_estudiantes_listBox.Size = new System.Drawing.Size(281, 214);
            this.registro_estudiantes_listBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(445, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registro_estudiantes_listBox);
            this.Controls.Add(this.agregar_button);
            this.Controls.Add(this.age_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name_textBox;
        private TextBox age_textBox;
        private Button agregar_button;
        private Label label4;
        private ListBox registro_estudiantes_listBox;
    }
}