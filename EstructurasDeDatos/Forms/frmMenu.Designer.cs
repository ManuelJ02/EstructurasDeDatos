namespace EstructurasDeDatos.Forms
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPilas = new System.Windows.Forms.Button();
            this.btnColasSimples = new System.Windows.Forms.Button();
            this.btnColasCirculares = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tnListasSimples = new System.Windows.Forms.Button();
            this.btnListasDobles = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estrucutras de datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estrucutras Basicas";
            // 
            // btnPilas
            // 
            this.btnPilas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPilas.Location = new System.Drawing.Point(97, 112);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Size = new System.Drawing.Size(75, 23);
            this.btnPilas.TabIndex = 2;
            this.btnPilas.Text = "Pilas";
            this.btnPilas.UseVisualStyleBackColor = false;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // btnColasSimples
            // 
            this.btnColasSimples.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnColasSimples.Location = new System.Drawing.Point(187, 112);
            this.btnColasSimples.Name = "btnColasSimples";
            this.btnColasSimples.Size = new System.Drawing.Size(93, 23);
            this.btnColasSimples.TabIndex = 3;
            this.btnColasSimples.Text = "Colas Simples";
            this.btnColasSimples.UseVisualStyleBackColor = false;
            this.btnColasSimples.Click += new System.EventHandler(this.btnColasSimples_Click);
            // 
            // btnColasCirculares
            // 
            this.btnColasCirculares.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnColasCirculares.Location = new System.Drawing.Point(296, 112);
            this.btnColasCirculares.Name = "btnColasCirculares";
            this.btnColasCirculares.Size = new System.Drawing.Size(92, 23);
            this.btnColasCirculares.TabIndex = 4;
            this.btnColasCirculares.Text = "Colas Circulares";
            this.btnColasCirculares.UseVisualStyleBackColor = false;
            this.btnColasCirculares.Click += new System.EventHandler(this.btnColasCirculares_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listas Enlazadas";
            // 
            // tnListasSimples
            // 
            this.tnListasSimples.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tnListasSimples.Location = new System.Drawing.Point(97, 210);
            this.tnListasSimples.Name = "tnListasSimples";
            this.tnListasSimples.Size = new System.Drawing.Size(84, 23);
            this.tnListasSimples.TabIndex = 6;
            this.tnListasSimples.Text = "Listas Simples";
            this.tnListasSimples.UseVisualStyleBackColor = false;
            this.tnListasSimples.Click += new System.EventHandler(this.tnListasSimples_Click);
            // 
            // btnListasDobles
            // 
            this.btnListasDobles.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnListasDobles.Location = new System.Drawing.Point(196, 210);
            this.btnListasDobles.Name = "btnListasDobles";
            this.btnListasDobles.Size = new System.Drawing.Size(84, 23);
            this.btnListasDobles.TabIndex = 7;
            this.btnListasDobles.Text = "Listas Dobles";
            this.btnListasDobles.UseVisualStyleBackColor = false;
            this.btnListasDobles.Click += new System.EventHandler(this.btnListasDobles_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Algoritmos de Ordenamiento";
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBubbleSort.Location = new System.Drawing.Point(97, 300);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(84, 23);
            this.btnBubbleSort.TabIndex = 9;
            this.btnBubbleSort.Text = "BubbleSort";
            this.btnBubbleSort.UseVisualStyleBackColor = false;
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnQuickSort.Location = new System.Drawing.Point(196, 300);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(84, 23);
            this.btnQuickSort.TabIndex = 10;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(453, 509);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListasDobles);
            this.Controls.Add(this.tnListasSimples);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnColasCirculares);
            this.Controls.Add(this.btnColasSimples);
            this.Controls.Add(this.btnPilas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPilas;
        private System.Windows.Forms.Button btnColasSimples;
        private System.Windows.Forms.Button btnColasCirculares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tnListasSimples;
        private System.Windows.Forms.Button btnListasDobles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnQuickSort;
    }
}