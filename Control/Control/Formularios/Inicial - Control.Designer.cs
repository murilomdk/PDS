namespace Control
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiculosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.motoristasToolStripMenuItem,
            this.peçasToolStripMenuItem,
            this.ordemDeServiçoToolStripMenuItem,
            this.veiculosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // motoristasToolStripMenuItem
            // 
            this.motoristasToolStripMenuItem.Name = "motoristasToolStripMenuItem";
            this.motoristasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.motoristasToolStripMenuItem.Text = "Motoristas";
            this.motoristasToolStripMenuItem.Click += new System.EventHandler(this.motoristasToolStripMenuItem_Click);
            // 
            // peçasToolStripMenuItem
            // 
            this.peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            this.peçasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.peçasToolStripMenuItem.Text = "Peças";
            this.peçasToolStripMenuItem.Click += new System.EventHandler(this.peçasToolStripMenuItem_Click);
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço";
            this.ordemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem1
            // 
            this.veiculosToolStripMenuItem1.Name = "veiculosToolStripMenuItem1";
            this.veiculosToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.veiculosToolStripMenuItem1.Text = "Veiculos";
            this.veiculosToolStripMenuItem1.Click += new System.EventHandler(this.veiculosToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Control";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem1;

    }
}

