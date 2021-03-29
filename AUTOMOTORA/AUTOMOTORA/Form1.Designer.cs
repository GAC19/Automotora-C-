
namespace AUTOMOTORA
{
    partial class P1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1));
            this.label1 = new System.Windows.Forms.Label();
            this.tx_1 = new System.Windows.Forms.TextBox();
            this.tx_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(111, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Cuenta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tx_1
            // 
            this.tx_1.Location = new System.Drawing.Point(122, 119);
            this.tx_1.Name = "tx_1";
            this.tx_1.Size = new System.Drawing.Size(170, 22);
            this.tx_1.TabIndex = 1;
            // 
            // tx_2
            // 
            this.tx_2.Location = new System.Drawing.Point(122, 174);
            this.tx_2.Name = "tx_2";
            this.tx_2.PasswordChar = '*';
            this.tx_2.Size = new System.Drawing.Size(170, 22);
            this.tx_2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(194, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(172, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bt_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_1.ForeColor = System.Drawing.Color.White;
            this.bt_1.Location = new System.Drawing.Point(149, 250);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(131, 40);
            this.bt_1.TabIndex = 5;
            this.bt_1.Text = "ENTER";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // P1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 432);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_2);
            this.Controls.Add(this.tx_1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P1";
            this.Text = "Automotora ";
            this.Load += new System.EventHandler(this.P1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_1;
        private System.Windows.Forms.TextBox tx_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

