﻿namespace FrmFormulario
{
    partial class MenuPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPacientes));
            this.label7 = new System.Windows.Forms.Label();
            this.rbSiAtendido = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rbNoAtendido = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 518);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 26;
            // 
            // rbSiAtendido
            // 
            this.rbSiAtendido.AutoSize = true;
            this.rbSiAtendido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSiAtendido.Location = new System.Drawing.Point(156, 540);
            this.rbSiAtendido.Margin = new System.Windows.Forms.Padding(4);
            this.rbSiAtendido.Name = "rbSiAtendido";
            this.rbSiAtendido.Size = new System.Drawing.Size(54, 36);
            this.rbSiAtendido.TabIndex = 32;
            this.rbSiAtendido.TabStop = true;
            this.rbSiAtendido.Text = "SI";
            this.rbSiAtendido.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 504);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 32);
            this.label8.TabIndex = 33;
            this.label8.Text = "ATENDIDO :";
            // 
            // rbNoAtendido
            // 
            this.rbNoAtendido.AutoSize = true;
            this.rbNoAtendido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoAtendido.Location = new System.Drawing.Point(156, 575);
            this.rbNoAtendido.Margin = new System.Windows.Forms.Padding(4);
            this.rbNoAtendido.Name = "rbNoAtendido";
            this.rbNoAtendido.Size = new System.Drawing.Size(71, 36);
            this.rbNoAtendido.TabIndex = 34;
            this.rbNoAtendido.TabStop = true;
            this.rbNoAtendido.Text = "NO";
            this.rbNoAtendido.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(285, 518);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 49);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(315, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(546, 256);
            this.listBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Lista ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(767, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 42;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(41, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 40);
            this.button2.TabIndex = 43;
            this.button2.Text = "lista de pacientes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(41, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 40);
            this.button3.TabIndex = 44;
            this.button3.Text = "lista de medicos";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MenuPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(917, 507);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rbNoAtendido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbSiAtendido);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPacientes";
            this.Text = "Listas";
            this.Load += new System.EventHandler(this.MenuPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label7;
        private RadioButton rbSiAtendido;
        private Label label8;
        private RadioButton rbNoAtendido;
        private Button btnSalir;
        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}