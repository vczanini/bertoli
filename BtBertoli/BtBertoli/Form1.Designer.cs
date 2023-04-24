namespace BtBertoli
{
    partial class Eletroestimulador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Bt_Connect = new System.Windows.Forms.Button();
            this.Bt_Start = new System.Windows.Forms.Button();
            this.Bt_5map = new System.Windows.Forms.Button();
            this.Bt_5man = new System.Windows.Forms.Button();
            this.Bt_1an = new System.Windows.Forms.Button();
            this.Bt_1am = new System.Windows.Forms.Button();
            this.Tx_Value = new System.Windows.Forms.TextBox();
            this.Lb_Connect = new System.Windows.Forms.Label();
            this.Lb_Start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bt_Connect
            // 
            this.Bt_Connect.Location = new System.Drawing.Point(34, 50);
            this.Bt_Connect.Name = "Bt_Connect";
            this.Bt_Connect.Size = new System.Drawing.Size(75, 23);
            this.Bt_Connect.TabIndex = 0;
            this.Bt_Connect.Text = "Conectar";
            this.Bt_Connect.UseVisualStyleBackColor = true;
            this.Bt_Connect.Click += new System.EventHandler(this.Bt_Connect_Click);
            // 
            // Bt_Start
            // 
            this.Bt_Start.Location = new System.Drawing.Point(516, 237);
            this.Bt_Start.Name = "Bt_Start";
            this.Bt_Start.Size = new System.Drawing.Size(75, 23);
            this.Bt_Start.TabIndex = 1;
            this.Bt_Start.Text = "Iniciar";
            this.Bt_Start.UseVisualStyleBackColor = true;
            this.Bt_Start.Click += new System.EventHandler(this.Bt_Start_Click);
            // 
            // Bt_5map
            // 
            this.Bt_5map.Location = new System.Drawing.Point(84, 382);
            this.Bt_5map.Name = "Bt_5map";
            this.Bt_5map.Size = new System.Drawing.Size(75, 23);
            this.Bt_5map.TabIndex = 2;
            this.Bt_5map.Text = "+ 0.5 mA";
            this.Bt_5map.UseVisualStyleBackColor = true;
            this.Bt_5map.Click += new System.EventHandler(this.Bt_5map_Click);
            // 
            // Bt_5man
            // 
            this.Bt_5man.Location = new System.Drawing.Point(459, 382);
            this.Bt_5man.Name = "Bt_5man";
            this.Bt_5man.Size = new System.Drawing.Size(75, 23);
            this.Bt_5man.TabIndex = 3;
            this.Bt_5man.Text = "- 0.5 mA";
            this.Bt_5man.UseVisualStyleBackColor = true;
            this.Bt_5man.Click += new System.EventHandler(this.Bt_5man_Click);
            // 
            // Bt_1an
            // 
            this.Bt_1an.Location = new System.Drawing.Point(378, 382);
            this.Bt_1an.Name = "Bt_1an";
            this.Bt_1an.Size = new System.Drawing.Size(75, 23);
            this.Bt_1an.TabIndex = 4;
            this.Bt_1an.Text = "- 0.1 mA";
            this.Bt_1an.UseVisualStyleBackColor = true;
            this.Bt_1an.Click += new System.EventHandler(this.Bt_1an_Click);
            // 
            // Bt_1am
            // 
            this.Bt_1am.Location = new System.Drawing.Point(165, 382);
            this.Bt_1am.Name = "Bt_1am";
            this.Bt_1am.Size = new System.Drawing.Size(75, 23);
            this.Bt_1am.TabIndex = 5;
            this.Bt_1am.Text = "+ 0.1 mA";
            this.Bt_1am.UseVisualStyleBackColor = true;
            this.Bt_1am.Click += new System.EventHandler(this.Bt_1am_Click);
            // 
            // Tx_Value
            // 
            this.Tx_Value.Location = new System.Drawing.Point(275, 206);
            this.Tx_Value.Name = "Tx_Value";
            this.Tx_Value.Size = new System.Drawing.Size(100, 20);
            this.Tx_Value.TabIndex = 6;
            this.Tx_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tx_Value.TextChanged += new System.EventHandler(this.Tx_Value_TextChanged);
            // 
            // Lb_Connect
            // 
            this.Lb_Connect.AutoSize = true;
            this.Lb_Connect.Location = new System.Drawing.Point(31, 85);
            this.Lb_Connect.Name = "Lb_Connect";
            this.Lb_Connect.Size = new System.Drawing.Size(77, 13);
            this.Lb_Connect.TabIndex = 7;
            this.Lb_Connect.Text = "Desconectado";
            // 
            // Lb_Start
            // 
            this.Lb_Start.AutoSize = true;
            this.Lb_Start.Location = new System.Drawing.Point(513, 263);
            this.Lb_Start.Name = "Lb_Start";
            this.Lb_Start.Size = new System.Drawing.Size(0, 13);
            this.Lb_Start.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Eletroestimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lb_Start);
            this.Controls.Add(this.Lb_Connect);
            this.Controls.Add(this.Tx_Value);
            this.Controls.Add(this.Bt_1am);
            this.Controls.Add(this.Bt_1an);
            this.Controls.Add(this.Bt_5man);
            this.Controls.Add(this.Bt_5map);
            this.Controls.Add(this.Bt_Start);
            this.Controls.Add(this.Bt_Connect);
            this.Name = "Eletroestimulador";
            this.Text = "Eletroestimulador";
            this.Load += new System.EventHandler(this.Eletroestimulador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Connect;
        private System.Windows.Forms.Button Bt_Start;
        private System.Windows.Forms.Button Bt_5map;
        private System.Windows.Forms.Button Bt_5man;
        private System.Windows.Forms.Button Bt_1an;
        private System.Windows.Forms.Button Bt_1am;
        private System.Windows.Forms.TextBox Tx_Value;
        private System.Windows.Forms.Label Lb_Connect;
        private System.Windows.Forms.Label Lb_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

