namespace linea_recta
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
            this.lbl_X2 = new System.Windows.Forms.Label();
            this.lbl_y2 = new System.Windows.Forms.Label();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.lbl_x1 = new System.Windows.Forms.Label();
            this.lbl_y1 = new System.Windows.Forms.Label();
            this.txt_X1 = new System.Windows.Forms.TextBox();
            this.txt_Y1 = new System.Windows.Forms.TextBox();
            this.txt_X2 = new System.Windows.Forms.TextBox();
            this.txt_Y2 = new System.Windows.Forms.TextBox();
            this.pb_grafica = new System.Windows.Forms.PictureBox();
            this.lbl_pendeinte = new System.Windows.Forms.Label();
            this.txt_pendiente = new System.Windows.Forms.TextBox();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_xy = new System.Windows.Forms.TextBox();
            this.lbl_cooY = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.lbl_x = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_X2
            // 
            this.lbl_X2.AutoSize = true;
            this.lbl_X2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X2.Location = new System.Drawing.Point(228, 133);
            this.lbl_X2.Name = "lbl_X2";
            this.lbl_X2.Size = new System.Drawing.Size(35, 28);
            this.lbl_X2.TabIndex = 2;
            this.lbl_X2.Text = "X2";
            this.lbl_X2.Click += new System.EventHandler(this.lbl_X2_Click);
            // 
            // lbl_y2
            // 
            this.lbl_y2.AutoSize = true;
            this.lbl_y2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_y2.Location = new System.Drawing.Point(378, 133);
            this.lbl_y2.Name = "lbl_y2";
            this.lbl_y2.Size = new System.Drawing.Size(34, 28);
            this.lbl_y2.TabIndex = 3;
            this.lbl_y2.Text = "Y2";
            this.lbl_y2.Click += new System.EventHandler(this.lbl_y2_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar.Location = new System.Drawing.Point(32, 725);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(117, 44);
            this.btn_Mostrar.TabIndex = 4;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // lbl_x1
            // 
            this.lbl_x1.AutoSize = true;
            this.lbl_x1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x1.Location = new System.Drawing.Point(222, 61);
            this.lbl_x1.Name = "lbl_x1";
            this.lbl_x1.Size = new System.Drawing.Size(35, 28);
            this.lbl_x1.TabIndex = 5;
            this.lbl_x1.Text = "X1";
            this.lbl_x1.Click += new System.EventHandler(this.lbl_x1_Click_1);
            // 
            // lbl_y1
            // 
            this.lbl_y1.AutoSize = true;
            this.lbl_y1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_y1.Location = new System.Drawing.Point(378, 61);
            this.lbl_y1.Name = "lbl_y1";
            this.lbl_y1.Size = new System.Drawing.Size(34, 28);
            this.lbl_y1.TabIndex = 6;
            this.lbl_y1.Text = "Y1";
            this.lbl_y1.Click += new System.EventHandler(this.lbl_y1_Click);
            // 
            // txt_X1
            // 
            this.txt_X1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_X1.Location = new System.Drawing.Point(111, 58);
            this.txt_X1.Name = "txt_X1";
            this.txt_X1.Size = new System.Drawing.Size(100, 34);
            this.txt_X1.TabIndex = 7;
            this.txt_X1.TextChanged += new System.EventHandler(this.txt_X1_TextChanged);
            // 
            // txt_Y1
            // 
            this.txt_Y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Y1.Location = new System.Drawing.Point(272, 58);
            this.txt_Y1.Name = "txt_Y1";
            this.txt_Y1.Size = new System.Drawing.Size(100, 34);
            this.txt_Y1.TabIndex = 8;
            this.txt_Y1.TextChanged += new System.EventHandler(this.txt_Y1_TextChanged);
            // 
            // txt_X2
            // 
            this.txt_X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_X2.Location = new System.Drawing.Point(111, 133);
            this.txt_X2.Name = "txt_X2";
            this.txt_X2.Size = new System.Drawing.Size(100, 34);
            this.txt_X2.TabIndex = 9;
            this.txt_X2.TextChanged += new System.EventHandler(this.txt_X2_TextChanged);
            // 
            // txt_Y2
            // 
            this.txt_Y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Y2.Location = new System.Drawing.Point(272, 133);
            this.txt_Y2.Name = "txt_Y2";
            this.txt_Y2.Size = new System.Drawing.Size(100, 34);
            this.txt_Y2.TabIndex = 10;
            this.txt_Y2.TextChanged += new System.EventHandler(this.txt_Y2_TextChanged);
            // 
            // pb_grafica
            // 
            this.pb_grafica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_grafica.Location = new System.Drawing.Point(543, 154);
            this.pb_grafica.Name = "pb_grafica";
            this.pb_grafica.Size = new System.Drawing.Size(823, 538);
            this.pb_grafica.TabIndex = 12;
            this.pb_grafica.TabStop = false;
            this.pb_grafica.Click += new System.EventHandler(this.pb_grafica_Click);
            // 
            // lbl_pendeinte
            // 
            this.lbl_pendeinte.AutoSize = true;
            this.lbl_pendeinte.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pendeinte.Location = new System.Drawing.Point(105, 197);
            this.lbl_pendeinte.Name = "lbl_pendeinte";
            this.lbl_pendeinte.Size = new System.Drawing.Size(117, 31);
            this.lbl_pendeinte.TabIndex = 14;
            this.lbl_pendeinte.Text = "Pendiente";
            this.lbl_pendeinte.Click += new System.EventHandler(this.lbl_pendeinte_Click);
            // 
            // txt_pendiente
            // 
            this.txt_pendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pendiente.Location = new System.Drawing.Point(231, 197);
            this.txt_pendiente.Name = "txt_pendiente";
            this.txt_pendiente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_pendiente.Size = new System.Drawing.Size(154, 34);
            this.txt_pendiente.TabIndex = 15;
            this.txt_pendiente.TextChanged += new System.EventHandler(this.txt_pendiente_TextChanged);
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A.Location = new System.Drawing.Point(-1, 52);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(98, 31);
            this.lbl_A.TabIndex = 16;
            this.lbl_A.Text = "Punto A";
            this.lbl_A.Click += new System.EventHandler(this.lbl_A_Click);
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B.Location = new System.Drawing.Point(1, 133);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(96, 31);
            this.lbl_B.TabIndex = 17;
            this.lbl_B.Text = "Punto B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 106);
            this.label1.TabIndex = 18;
            this.label1.Text = "LINEA DDA";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(283, 713);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(113, 44);
            this.btn_limpiar.TabIndex = 19;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // txt_xy
            // 
            this.txt_xy.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xy.Location = new System.Drawing.Point(299, 302);
            this.txt_xy.Margin = new System.Windows.Forms.Padding(5);
            this.txt_xy.Multiline = true;
            this.txt_xy.Name = "txt_xy";
            this.txt_xy.Size = new System.Drawing.Size(186, 390);
            this.txt_xy.TabIndex = 21;
            this.txt_xy.TextChanged += new System.EventHandler(this.txt_xy_TextChanged);
            // 
            // lbl_cooY
            // 
            this.lbl_cooY.AutoSize = true;
            this.lbl_cooY.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cooY.Location = new System.Drawing.Point(293, 257);
            this.lbl_cooY.Name = "lbl_cooY";
            this.lbl_cooY.Size = new System.Drawing.Size(207, 31);
            this.lbl_cooY.TabIndex = 22;
            this.lbl_cooY.Text = "Coordenadas de Y";
            // 
            // txt_x
            // 
            this.txt_x.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x.Location = new System.Drawing.Point(44, 302);
            this.txt_x.Margin = new System.Windows.Forms.Padding(5);
            this.txt_x.Multiline = true;
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(186, 390);
            this.txt_x.TabIndex = 23;
            this.txt_x.TextChanged += new System.EventHandler(this.txt_x_TextChanged);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.Location = new System.Drawing.Point(38, 257);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(208, 31);
            this.lbl_x.TabIndex = 24;
            this.lbl_x.Text = "Coordenadas de X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 871);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.lbl_cooY);
            this.Controls.Add(this.txt_xy);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.txt_pendiente);
            this.Controls.Add(this.lbl_pendeinte);
            this.Controls.Add(this.pb_grafica);
            this.Controls.Add(this.txt_Y2);
            this.Controls.Add(this.txt_X2);
            this.Controls.Add(this.txt_Y1);
            this.Controls.Add(this.txt_X1);
            this.Controls.Add(this.lbl_y1);
            this.Controls.Add(this.lbl_x1);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.lbl_y2);
            this.Controls.Add(this.lbl_X2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_X2;
        private System.Windows.Forms.Label lbl_y2;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Label lbl_x1;
        private System.Windows.Forms.Label lbl_y1;
        private System.Windows.Forms.TextBox txt_X1;
        private System.Windows.Forms.TextBox txt_Y1;
        private System.Windows.Forms.TextBox txt_X2;
        private System.Windows.Forms.TextBox txt_Y2;
        private System.Windows.Forms.PictureBox pb_grafica;
        private System.Windows.Forms.Label lbl_pendeinte;
        private System.Windows.Forms.TextBox txt_pendiente;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_xy;
        private System.Windows.Forms.Label lbl_cooY;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.Label lbl_x;
    }
}

