namespace Exercício_11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            mudarTipoDeLetraECorToolStripMenuItem = new ToolStripMenuItem();
            corToolStripMenuItem = new ToolStripMenuItem();
            letraToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(280, 153);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Poo em C#";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { formatarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mudarTipoDeLetraECorToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // mudarTipoDeLetraECorToolStripMenuItem
            // 
            mudarTipoDeLetraECorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { corToolStripMenuItem, letraToolStripMenuItem });
            mudarTipoDeLetraECorToolStripMenuItem.Name = "mudarTipoDeLetraECorToolStripMenuItem";
            mudarTipoDeLetraECorToolStripMenuItem.Size = new Size(204, 22);
            mudarTipoDeLetraECorToolStripMenuItem.Text = "Mudar tipo de letra e cor";
            mudarTipoDeLetraECorToolStripMenuItem.Click += mudarTipoDeLetraECorToolStripMenuItem_Click;
            // 
            // corToolStripMenuItem
            // 
            corToolStripMenuItem.Name = "corToolStripMenuItem";
            corToolStripMenuItem.Size = new Size(100, 22);
            corToolStripMenuItem.Text = "Cor";
            corToolStripMenuItem.Click += corToolStripMenuItem_Click;
            // 
            // letraToolStripMenuItem
            // 
            letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            letraToolStripMenuItem.Size = new Size(100, 22);
            letraToolStripMenuItem.Text = "Letra";
            letraToolStripMenuItem.Click += letraToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(577, 309);
            button1.Name = "button1";
            button1.Size = new Size(119, 72);
            button1.TabIndex = 2;
            button1.Text = "Página 2 ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem mudarTipoDeLetraECorToolStripMenuItem;
        private ToolStripMenuItem corToolStripMenuItem;
        private ToolStripMenuItem letraToolStripMenuItem;
        private Button button1;
    }
}