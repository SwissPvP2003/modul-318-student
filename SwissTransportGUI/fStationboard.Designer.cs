namespace SwissTransportGUI
{
    partial class fStationboard
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbStation = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.cDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbStation = new SwissTransportGUI.DropDownComboBox();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(336, 61);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Stationboard";
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Location = new System.Drawing.Point(12, 70);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(85, 25);
            this.lbStation.TabIndex = 4;
            this.lbStation.Text = "Station:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 154);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(383, 76);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvConnections
            // 
            this.lvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDepartureTime,
            this.cDestination,
            this.cDesignation});
            this.lvConnections.HideSelection = false;
            this.lvConnections.Location = new System.Drawing.Point(12, 263);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(850, 654);
            this.lvConnections.TabIndex = 13;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // cDepartureTime
            // 
            this.cDepartureTime.Text = "Departure Time";
            this.cDepartureTime.Width = 200;
            // 
            // cDestination
            // 
            this.cDestination.Text = "Destination";
            this.cDestination.Width = 200;
            // 
            // cDesignation
            // 
            this.cDesignation.Text = "Designation";
            this.cDesignation.Width = 200;
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(12, 98);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(383, 33);
            this.cbStation.TabIndex = 14;
            this.cbStation.TextUpdate += new System.EventHandler(this.dropDownComboBox1_TextUpdate);
            // 
            // fStationboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 929);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbStation);
            this.Controls.Add(this.lbTitle);
            this.MinimumSize = new System.Drawing.Size(900, 1000);
            this.Name = "fStationboard";
            this.Text = "fStationboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbStation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ColumnHeader cDepartureTime;
        private System.Windows.Forms.ColumnHeader cDestination;
        private System.Windows.Forms.ColumnHeader cDesignation;
        private DropDownComboBox cbStation;
    }
}