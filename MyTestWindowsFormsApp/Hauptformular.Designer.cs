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
            this.btnEinkaeufeImportieren = new System.Windows.Forms.Button();
            this.dataGridEinkauf = new System.Windows.Forms.DataGridView();
            this.btnPersonalstammImportieren = new System.Windows.Forms.Button();
            this.tabPageAusgabe = new System.Windows.Forms.TabPage();
            this.dataGridViewAusgabe = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datenLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabPageEingabe.Controls.Add(this.btnEinkaeufeImportieren);
            this.tabPageEingabe.Controls.Add(this.dataGridEinkauf);
            this.tabPageEingabe.Controls.Add(this.btnPersonalstammImportieren);
            this.tabPageEingabe.Controls.Add(this.dataGridPersonalstammdaten);
            this.tabPageEingabe.Location = new System.Drawing.Point(4, 22);
            this.tabPageEingabe.Name = "tabPageEingabe";
            this.tabPageEingabe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEingabe.Size = new System.Drawing.Size(1127, 577);
            this.tabPageEingabe.TabIndex = 0;
            this.tabPageEingabe.Text = "Eingabe";
            this.tabPageEingabe.UseVisualStyleBackColor = true;
            // 
            // btnEinkaeufeImportieren
            // 
            this.btnEinkaeufeImportieren.Location = new System.Drawing.Point(575, 290);
            this.btnEinkaeufeImportieren.Name = "btnEinkaeufeImportieren";
            this.btnEinkaeufeImportieren.Size = new System.Drawing.Size(145, 23);
            this.btnEinkaeufeImportieren.TabIndex = 4;
            this.btnEinkaeufeImportieren.Text = "Einkäufe importieren";
            this.btnEinkaeufeImportieren.UseVisualStyleBackColor = true;
            this.btnEinkaeufeImportieren.Click += new System.EventHandler(this.btnEinkaeufeImportieren_Click);
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
            // btnPersonalstammImportieren
            // 
            this.btnPersonalstammImportieren.Location = new System.Drawing.Point(575, 7);
            this.btnPersonalstammImportieren.Name = "btnPersonalstammImportieren";
            this.btnPersonalstammImportieren.Size = new System.Drawing.Size(145, 23);
            this.btnPersonalstammImportieren.TabIndex = 2;
            this.btnPersonalstammImportieren.Text = "Personalstamm importieren";
            this.btnPersonalstammImportieren.UseVisualStyleBackColor = true;
            this.btnPersonalstammImportieren.Click += new System.EventHandler(this.btnPersonalstammImportieren_Click);
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
            this.datenLöschenToolStripMenuItem});
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
        private System.Windows.Forms.Button btnEinkaeufeImportieren;
        private System.Windows.Forms.DataGridView dataGridEinkauf;
        private System.Windows.Forms.Button btnPersonalstammImportieren;
        private System.Windows.Forms.TabPage tabPageAusgabe;
        private System.Windows.Forms.DataGridView dataGridViewAusgabe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datenLöschenToolStripMenuItem;
    }
}

