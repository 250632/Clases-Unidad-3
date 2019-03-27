namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ValA = new System.Windows.Forms.TextBox();
            this.ValB = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelResul = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbGrupoA = new System.Windows.Forms.GroupBox();
            this.grbGrupoA.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValA
            // 
            this.ValA.Location = new System.Drawing.Point(84, 28);
            this.ValA.Name = "ValA";
            this.ValA.Size = new System.Drawing.Size(113, 20);
            this.ValA.TabIndex = 0;
            // 
            // ValB
            // 
            this.ValB.Location = new System.Drawing.Point(84, 75);
            this.ValB.Name = "ValB";
            this.ValB.Size = new System.Drawing.Size(113, 20);
            this.ValB.TabIndex = 1;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(19, 29);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(42, 13);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "VAlor A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(19, 78);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(41, 13);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Valor B";
            // 
            // labelResul
            // 
            this.labelResul.AutoSize = true;
            this.labelResul.Location = new System.Drawing.Point(106, 131);
            this.labelResul.Name = "labelResul";
            this.labelResul.Size = new System.Drawing.Size(73, 13);
            this.labelResul.TabIndex = 4;
            this.labelResul.Text = "RESULTADO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbGrupoA
            // 
            this.grbGrupoA.Controls.Add(this.button1);
            this.grbGrupoA.Controls.Add(this.labelResul);
            this.grbGrupoA.Controls.Add(this.labelB);
            this.grbGrupoA.Controls.Add(this.labelA);
            this.grbGrupoA.Controls.Add(this.ValB);
            this.grbGrupoA.Controls.Add(this.ValA);
            this.grbGrupoA.Location = new System.Drawing.Point(63, 30);
            this.grbGrupoA.Name = "grbGrupoA";
            this.grbGrupoA.Size = new System.Drawing.Size(255, 240);
            this.grbGrupoA.TabIndex = 6;
            this.grbGrupoA.TabStop = false;
            this.grbGrupoA.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 329);
            this.Controls.Add(this.grbGrupoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGrupoA.ResumeLayout(false);
            this.grbGrupoA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ValA;
        private System.Windows.Forms.TextBox ValB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelResul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbGrupoA;
    }
}

