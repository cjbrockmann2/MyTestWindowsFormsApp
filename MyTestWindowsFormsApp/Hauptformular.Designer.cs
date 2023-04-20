namespace CopitosWindowsFormsApp
{
    partial class Hauptformular
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridPersonalstammdaten = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEingabe = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridEinkauf = new System.Windows.Forms.DataGridView();
            this.tabPageAusgabe = new System.Windows.Forms.TabPage();
            this.dataGridViewAusgabe = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datenLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalstammImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einkaeufeImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonalstammdaten)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageEingabe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEinkauf)).BeginInit();
            this.tabPageAusgabe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAusgabe)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPersonalstammdaten
            // 
            this.dataGridPersonalstammdaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonalstammdaten.Location = new System.Drawing.Point(6, 34);
            this.dataGridPersonalstammdaten.Name = "dataGridPersonalstammdaten";
            this.dataGridPersonalstammdaten.Size = new System.Drawing.Size(1115, 247);
            this.dataGridPersonalstammdaten.TabIndex = 1;
            this.dataGridPersonalstammdaten.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridPersonalstammdaten_CellBeginEdit);
            this.dataGridPersonalstammdaten.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPersonalstammdaten_CellEndEdit);
            this.dataGridPersonalstammdaten.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridPersonalstammdaten_CellValidating);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEingabe);
            this.tabControl.Controls.Add(this.tabPageAusgabe);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1135, 603);
            this.tabControl.TabIndex = 3;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabPageEingabe
            // 
            this.tabPageEingabe.Controls.Add(this.label2);
            this.tabPageEingabe.Controls.Add(this.label1);
            this.tabPageEingabe.Controls.Add(this.dataGridEinkauf);
            this.tabPageEingabe.Controls.Add(this.dataGridPersonalstammdaten);
            this.tabPageEingabe.Location = new System.Drawing.Point(4, 22);
            this.tabPageEingabe.Name = "tabPageEingabe";
            this.tabPageEingabe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEingabe.Size = new System.Drawing.Size(1127, 577);
            this.tabPageEingabe.TabIndex = 0;
            this.tabPageEingabe.Text = "Eingabe";
            this.tabPageEingabe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personalstamm";
            // 
            // dataGridEinkauf
            // 
            this.dataGridEinkauf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEinkauf.Location = new System.Drawing.Point(6, 317);
            this.dataGridEinkauf.Name = "dataGridEinkauf";
            this.dataGridEinkauf.Size = new System.Drawing.Size(1115, 247);
            this.dataGridEinkauf.TabIndex = 3;
            this.dataGridEinkauf.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridEinkauf_CellBeginEdit);
            this.dataGridEinkauf.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEinkauf_CellEndEdit);
            this.dataGridEinkauf.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridEinkauf_CellValidating);
            // 
            // tabPageAusgabe
            // 
            this.tabPageAusgabe.Controls.Add(this.dataGridViewAusgabe);
            this.tabPageAusgabe.Location = new System.Drawing.Point(4, 22);
            this.tabPageAusgabe.Name = "tabPageAusgabe";
            this.tabPageAusgabe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAusgabe.Size = new System.Drawing.Size(1127, 577);
            this.tabPageAusgabe.TabIndex = 1;
            this.tabPageAusgabe.Text = "Ausgabe";
            this.tabPageAusgabe.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAusgabe
            // 
            this.dataGridViewAusgabe.AllowUserToAddRows = false;
            this.dataGridViewAusgabe.AllowUserToDeleteRows = false;
            this.dataGridViewAusgabe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAusgabe.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewAusgabe.Name = "dataGridViewAusgabe";
            this.dataGridViewAusgabe.ReadOnly = true;
            this.dataGridViewAusgabe.Size = new System.Drawing.Size(1115, 537);
            this.dataGridViewAusgabe.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datenLöschenToolStripMenuItem,
            this.personalstammImportierenToolStripMenuItem,
            this.einkaeufeImportierenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datenLöschenToolStripMenuItem
            // 
            this.datenLöschenToolStripMenuItem.Name = "datenLöschenToolStripMenuItem";
            this.datenLöschenToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.datenLöschenToolStripMenuItem.Text = "Daten löschen";
            this.datenLöschenToolStripMenuItem.Click += new System.EventHandler(this.datenLöschenToolStripMenuItem_Click);
            // 
            // personalstammImportierenToolStripMenuItem
            // 
            this.personalstammImportierenToolStripMenuItem.Name = "personalstammImportierenToolStripMenuItem";
            this.personalstammImportierenToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.personalstammImportierenToolStripMenuItem.Text = "Personalstamm importieren";
            this.personalstammImportierenToolStripMenuItem.Click += new System.EventHandler(this.personalstammImportierenToolStripMenuItem_Click);
            // 
            // einkaeufeImportierenToolStripMenuItem
            // 
            this.einkaeufeImportierenToolStripMenuItem.Name = "einkaeufeImportierenToolStripMenuItem";
            this.einkaeufeImportierenToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.einkaeufeImportierenToolStripMenuItem.Text = "Einkäufe importieren";
            this.einkaeufeImportierenToolStripMenuItem.Click += new System.EventHandler(this.einkaeufeImportierenToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Einkäufe";
            // 
            // Hauptformular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 679);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hauptformular";
            this.Text = "Einkäufeliste";
            this.Load += new System.EventHandler(this.Hauptformular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonalstammdaten)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageEingabe.ResumeLayout(false);
            this.tabPageEingabe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEinkauf)).EndInit();
            this.tabPageAusgabe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAusgabe)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridPersonalstammdaten;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEingabe;
        private System.Windows.Forms.DataGridView dataGridEinkauf;
        private System.Windows.Forms.TabPage tabPageAusgabe;
        private System.Windows.Forms.DataGridView dataGridViewAusgabe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datenLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalstammImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einkaeufeImportierenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

