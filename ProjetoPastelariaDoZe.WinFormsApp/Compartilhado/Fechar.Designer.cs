namespace ProjetoPastelariaDoZe.WinFormsApp.Compartilhado
{
    partial class Fechar
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
            this.buttonSim = new System.Windows.Forms.Button();
            this.buttonNao = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelDesejaFechar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSim
            // 
            this.buttonSim.BackColor = System.Drawing.Color.White;
            this.buttonSim.FlatAppearance.BorderSize = 0;
            this.buttonSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSim.Location = new System.Drawing.Point(33, 104);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(70, 35);
            this.buttonSim.TabIndex = 0;
            this.buttonSim.Text = "Sim";
            this.buttonSim.UseVisualStyleBackColor = false;
            // 
            // buttonNao
            // 
            this.buttonNao.BackColor = System.Drawing.Color.White;
            this.buttonNao.FlatAppearance.BorderSize = 0;
            this.buttonNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNao.Location = new System.Drawing.Point(141, 104);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(70, 35);
            this.buttonNao.TabIndex = 1;
            this.buttonNao.Text = "Não";
            this.buttonNao.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(248, 104);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(70, 35);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // labelDesejaFechar
            // 
            this.labelDesejaFechar.AutoSize = true;
            this.labelDesejaFechar.BackColor = System.Drawing.Color.Transparent;
            this.labelDesejaFechar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDesejaFechar.ForeColor = System.Drawing.Color.White;
            this.labelDesejaFechar.Location = new System.Drawing.Point(33, 49);
            this.labelDesejaFechar.Name = "labelDesejaFechar";
            this.labelDesejaFechar.Size = new System.Drawing.Size(106, 20);
            this.labelDesejaFechar.TabIndex = 3;
            this.labelDesejaFechar.Text = "Deseja fechar?";
            // 
            // Fechar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(354, 184);
            this.ControlBox = false;
            this.Controls.Add(this.labelDesejaFechar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonNao);
            this.Controls.Add(this.buttonSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fechar";
            this.Text = "Aviso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSim;
        private Button buttonNao;
        private Button buttonCancelar;
        private Label labelDesejaFechar;
    }
}