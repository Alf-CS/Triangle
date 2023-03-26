namespace Triangle
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
            this.textBoxLado1 = new System.Windows.Forms.TextBox();
            this.textBoxLado2 = new System.Windows.Forms.TextBox();
            this.textBoxLado3 = new System.Windows.Forms.TextBox();
            this.buttonEquilatero = new System.Windows.Forms.Button();
            this.buttonLadoMayor = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonCrearTriangulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado3";
            // 
            // textBoxLado1
            // 
            this.textBoxLado1.Location = new System.Drawing.Point(181, 82);
            this.textBoxLado1.Name = "textBoxLado1";
            this.textBoxLado1.Size = new System.Drawing.Size(125, 27);
            this.textBoxLado1.TabIndex = 3;
            // 
            // textBoxLado2
            // 
            this.textBoxLado2.Location = new System.Drawing.Point(181, 168);
            this.textBoxLado2.Name = "textBoxLado2";
            this.textBoxLado2.Size = new System.Drawing.Size(125, 27);
            this.textBoxLado2.TabIndex = 4;
            // 
            // textBoxLado3
            // 
            this.textBoxLado3.Location = new System.Drawing.Point(181, 263);
            this.textBoxLado3.Name = "textBoxLado3";
            this.textBoxLado3.Size = new System.Drawing.Size(125, 27);
            this.textBoxLado3.TabIndex = 5;
            // 
            // buttonEquilatero
            // 
            this.buttonEquilatero.Location = new System.Drawing.Point(88, 369);
            this.buttonEquilatero.Name = "buttonEquilatero";
            this.buttonEquilatero.Size = new System.Drawing.Size(94, 29);
            this.buttonEquilatero.TabIndex = 6;
            this.buttonEquilatero.Text = "Equilatero";
            this.buttonEquilatero.UseVisualStyleBackColor = true;
            this.buttonEquilatero.Click += new System.EventHandler(this.buttonEquilatero_Click);
            // 
            // buttonLadoMayor
            // 
            this.buttonLadoMayor.Location = new System.Drawing.Point(331, 369);
            this.buttonLadoMayor.Name = "buttonLadoMayor";
            this.buttonLadoMayor.Size = new System.Drawing.Size(126, 29);
            this.buttonLadoMayor.TabIndex = 7;
            this.buttonLadoMayor.Text = "Lado Mayor";
            this.buttonLadoMayor.UseVisualStyleBackColor = true;
            this.buttonLadoMayor.Click += new System.EventHandler(this.buttonLadoMayor_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(587, 369);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(94, 29);
            this.buttonArea.TabIndex = 8;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            // 
            // buttonCrearTriangulo
            // 
            this.buttonCrearTriangulo.Location = new System.Drawing.Point(559, 121);
            this.buttonCrearTriangulo.Name = "buttonCrearTriangulo";
            this.buttonCrearTriangulo.Size = new System.Drawing.Size(147, 129);
            this.buttonCrearTriangulo.TabIndex = 9;
            this.buttonCrearTriangulo.Text = "CREAR TRIANGULO";
            this.buttonCrearTriangulo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCrearTriangulo);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonLadoMayor);
            this.Controls.Add(this.buttonEquilatero);
            this.Controls.Add(this.textBoxLado3);
            this.Controls.Add(this.textBoxLado2);
            this.Controls.Add(this.textBoxLado1);
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
        private TextBox textBoxLado1;
        private TextBox textBoxLado2;
        private TextBox textBoxLado3;
        private Button buttonEquilatero;
        private Button buttonLadoMayor;
        private Button buttonArea;
        private Button buttonCrearTriangulo;
    }
}