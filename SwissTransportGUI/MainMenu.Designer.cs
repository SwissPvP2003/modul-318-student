namespace SwissTransportGUI
{
    partial class MainMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearchConnetctions = new System.Windows.Forms.Button();
            this.btnShowStationboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(168, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(715, 91);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Choose an Option:";
            // 
            // btnSearchConnetctions
            // 
            this.btnSearchConnetctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConnetctions.Location = new System.Drawing.Point(76, 179);
            this.btnSearchConnetctions.Name = "btnSearchConnetctions";
            this.btnSearchConnetctions.Size = new System.Drawing.Size(297, 125);
            this.btnSearchConnetctions.TabIndex = 1;
            this.btnSearchConnetctions.Text = "Search Connections";
            this.btnSearchConnetctions.UseVisualStyleBackColor = true;
            this.btnSearchConnetctions.Click += new System.EventHandler(this.BtnSearchConnetctions_Click);
            // 
            // btnShowStationboard
            // 
            this.btnShowStationboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowStationboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStationboard.Location = new System.Drawing.Point(662, 179);
            this.btnShowStationboard.Name = "btnShowStationboard";
            this.btnShowStationboard.Size = new System.Drawing.Size(297, 125);
            this.btnShowStationboard.TabIndex = 2;
            this.btnShowStationboard.Text = "Stationboard";
            this.btnShowStationboard.UseVisualStyleBackColor = true;
            this.btnShowStationboard.Click += new System.EventHandler(this.BtnShowStationboard_Click);
            // 
            // fStartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 434);
            this.Controls.Add(this.btnShowStationboard);
            this.Controls.Add(this.btnSearchConnetctions);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "fStartGUI";
            this.Text = "TransportAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearchConnetctions;
        private System.Windows.Forms.Button btnShowStationboard;
    }
}

