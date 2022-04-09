namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class Comandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comandas));
            this.buttonFechar = new System.Windows.Forms.Button();
            this.PanelComandas = new System.Windows.Forms.Panel();
            this.PanelComandas.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.White;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Location = new System.Drawing.Point(698, 403);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 0;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // PanelComandas
            // 
            this.PanelComandas.Controls.Add(this.buttonFechar);
            this.PanelComandas.Location = new System.Drawing.Point(12, 12);
            this.PanelComandas.Name = "PanelComandas";
            this.PanelComandas.Size = new System.Drawing.Size(776, 426);
            this.PanelComandas.TabIndex = 1;
            // 
            // Comandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.PanelComandas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comandas";
            this.Text = "Comandas";
            this.PanelComandas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonFechar;
        private Panel PanelComandas;
    }
}