namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcuadro = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnseven = new System.Windows.Forms.Button();
            this.btneight = new System.Windows.Forms.Button();
            this.btnnine = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnfive = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btnone = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btnsame = new System.Windows.Forms.Button();
            this.btndivi = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcuadro
            // 
            this.txtcuadro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuadro.Location = new System.Drawing.Point(12, 12);
            this.txtcuadro.Multiline = true;
            this.txtcuadro.Name = "txtcuadro";
            this.txtcuadro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcuadro.Size = new System.Drawing.Size(176, 40);
            this.txtcuadro.TabIndex = 0;
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(14, 68);
            this.btnsuma.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(54, 39);
            this.btnsuma.TabIndex = 1;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(74, 68);
            this.btnresta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(54, 39);
            this.btnresta.TabIndex = 2;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmulti.Location = new System.Drawing.Point(134, 68);
            this.btnmulti.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(54, 39);
            this.btnmulti.TabIndex = 3;
            this.btnmulti.Text = "x";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnseven
            // 
            this.btnseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseven.Location = new System.Drawing.Point(14, 114);
            this.btnseven.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(74, 39);
            this.btnseven.TabIndex = 4;
            this.btnseven.Text = "7";
            this.btnseven.UseVisualStyleBackColor = true;
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btneight
            // 
            this.btneight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneight.Location = new System.Drawing.Point(94, 114);
            this.btneight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btneight.Name = "btneight";
            this.btneight.Size = new System.Drawing.Size(74, 39);
            this.btneight.TabIndex = 5;
            this.btneight.Text = "8";
            this.btneight.UseVisualStyleBackColor = true;
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnnine
            // 
            this.btnnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnine.Location = new System.Drawing.Point(174, 114);
            this.btnnine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnnine.Name = "btnnine";
            this.btnnine.Size = new System.Drawing.Size(74, 39);
            this.btnnine.TabIndex = 6;
            this.btnnine.Text = "9";
            this.btnnine.UseVisualStyleBackColor = true;
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btnfour
            // 
            this.btnfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfour.Location = new System.Drawing.Point(14, 156);
            this.btnfour.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(74, 39);
            this.btnfour.TabIndex = 7;
            this.btnfour.Text = "4";
            this.btnfour.UseVisualStyleBackColor = true;
            this.btnfour.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnfive
            // 
            this.btnfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfive.Location = new System.Drawing.Point(94, 156);
            this.btnfive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnfive.Name = "btnfive";
            this.btnfive.Size = new System.Drawing.Size(74, 39);
            this.btnfive.TabIndex = 8;
            this.btnfive.Text = "5";
            this.btnfive.UseVisualStyleBackColor = true;
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btnsix
            // 
            this.btnsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsix.Location = new System.Drawing.Point(174, 156);
            this.btnsix.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(74, 39);
            this.btnsix.TabIndex = 9;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = true;
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnone
            // 
            this.btnone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnone.Location = new System.Drawing.Point(14, 200);
            this.btnone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(74, 39);
            this.btnone.TabIndex = 10;
            this.btnone.Text = "1";
            this.btnone.UseVisualStyleBackColor = true;
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btntwo
            // 
            this.btntwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntwo.Location = new System.Drawing.Point(94, 200);
            this.btntwo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(74, 39);
            this.btntwo.TabIndex = 11;
            this.btntwo.Text = "2";
            this.btntwo.UseVisualStyleBackColor = true;
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnthree
            // 
            this.btnthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthree.Location = new System.Drawing.Point(174, 200);
            this.btnthree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(74, 39);
            this.btnthree.TabIndex = 12;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = true;
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoint.Location = new System.Drawing.Point(14, 244);
            this.btnpoint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(74, 39);
            this.btnpoint.TabIndex = 13;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = true;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btnzero
            // 
            this.btnzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.Location = new System.Drawing.Point(94, 244);
            this.btnzero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(74, 39);
            this.btnzero.TabIndex = 14;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btnsame
            // 
            this.btnsame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsame.Location = new System.Drawing.Point(174, 244);
            this.btnsame.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsame.Name = "btnsame";
            this.btnsame.Size = new System.Drawing.Size(74, 39);
            this.btnsame.TabIndex = 15;
            this.btnsame.Text = "=";
            this.btnsame.UseVisualStyleBackColor = true;
            this.btnsame.Click += new System.EventHandler(this.btnsame_Click);
            // 
            // btndivi
            // 
            this.btndivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivi.Location = new System.Drawing.Point(194, 68);
            this.btndivi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndivi.Name = "btndivi";
            this.btndivi.Size = new System.Drawing.Size(54, 39);
            this.btndivi.TabIndex = 16;
            this.btndivi.Text = "/";
            this.btndivi.UseVisualStyleBackColor = true;
            this.btndivi.Click += new System.EventHandler(this.btndivi_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(194, 13);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(54, 39);
            this.btnborrar.TabIndex = 17;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 290);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btndivi);
            this.Controls.Add(this.btnsame);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtcuadro);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcuadro;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnseven;
        private System.Windows.Forms.Button btneight;
        private System.Windows.Forms.Button btnnine;
        private System.Windows.Forms.Button btnfour;
        private System.Windows.Forms.Button btnfive;
        private System.Windows.Forms.Button btnsix;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnthree;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnsame;
        private System.Windows.Forms.Button btndivi;
        private System.Windows.Forms.Button btnborrar;
    }
}

