namespace SwissTransportGUI
{
    partial class fSearchConnections
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
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbWhen = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnSwitchStations = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbStationTo = new SwissTransportGUI.DropDownComboBox();
            this.cbStationFrom = new SwissTransportGUI.DropDownComboBox();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(490, 61);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Search Connection";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(12, 92);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(67, 25);
            this.lbFrom.TabIndex = 3;
            this.lbFrom.Text = "From:";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(12, 172);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(43, 25);
            this.lbTo.TabIndex = 4;
            this.lbTo.Text = "To:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(17, 282);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(241, 31);
            this.dtpDate.TabIndex = 4;
            // 
            // lbWhen
            // 
            this.lbWhen.AutoSize = true;
            this.lbWhen.Location = new System.Drawing.Point(12, 254);
            this.lbWhen.Name = "lbWhen";
            this.lbWhen.Size = new System.Drawing.Size(74, 25);
            this.lbWhen.TabIndex = 9;
            this.lbWhen.Text = "When:";
            // 
            // dtpTime
            // 
            this.dtpTime.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(264, 282);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(131, 31);
            this.dtpTime.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 332);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(383, 76);
            this.btnSearch.TabIndex = 6;
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
            this.cDate,
            this.cDepartureTime,
            this.cDepartureStation,
            this.cArrivalTime,
            this.cArrivalStation,
            this.cDuration,
            this.cPlatform});
            this.lvConnections.HideSelection = false;
            this.lvConnections.Location = new System.Drawing.Point(12, 442);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(1412, 575);
            this.lvConnections.TabIndex = 8;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // cDate
            // 
            this.cDate.Text = "Date";
            this.cDate.Width = 100;
            // 
            // cDepartureTime
            // 
            this.cDepartureTime.Text = "Departure Time";
            this.cDepartureTime.Width = 100;
            // 
            // cDepartureStation
            // 
            this.cDepartureStation.Text = "Departure Station";
            this.cDepartureStation.Width = 100;
            // 
            // cArrivalTime
            // 
            this.cArrivalTime.Text = "Arrival Time";
            this.cArrivalTime.Width = 100;
            // 
            // cArrivalStation
            // 
            this.cArrivalStation.Text = "Arrival Station";
            this.cArrivalStation.Width = 100;
            // 
            // cDuration
            // 
            this.cDuration.Text = "Duration";
            this.cDuration.Width = 100;
            // 
            // cPlatform
            // 
            this.cPlatform.Text = "Platform";
            this.cPlatform.Width = 100;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.Location = new System.Drawing.Point(1041, 332);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(383, 76);
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnSwitchStations
            // 
            this.btnSwitchStations.Location = new System.Drawing.Point(424, 120);
            this.btnSwitchStations.Name = "btnSwitchStations";
            this.btnSwitchStations.Size = new System.Drawing.Size(204, 113);
            this.btnSwitchStations.TabIndex = 3;
            this.btnSwitchStations.Text = "Switch Stations";
            this.btnSwitchStations.UseVisualStyleBackColor = true;
            this.btnSwitchStations.Click += new System.EventHandler(this.btnSwitchStations_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1315, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 65);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbStationTo
            // 
            this.cbStationTo.FormattingEnabled = true;
            this.cbStationTo.Location = new System.Drawing.Point(12, 200);
            this.cbStationTo.Name = "cbStationTo";
            this.cbStationTo.Size = new System.Drawing.Size(371, 33);
            this.cbStationTo.TabIndex = 2;
            this.cbStationTo.TextUpdate += new System.EventHandler(this.cbStationTo_TextUpdate);
            // 
            // cbStationFrom
            // 
            this.cbStationFrom.FormattingEnabled = true;
            this.cbStationFrom.Location = new System.Drawing.Point(12, 120);
            this.cbStationFrom.Name = "cbStationFrom";
            this.cbStationFrom.Size = new System.Drawing.Size(371, 33);
            this.cbStationFrom.TabIndex = 1;
            this.cbStationFrom.TextUpdate += new System.EventHandler(this.dropDownComboBox1_TextUpdate);
            // 
            // fSearchConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 1029);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSwitchStations);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.cbStationTo);
            this.Controls.Add(this.cbStationFrom);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lbWhen);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.lbTitle);
            this.MinimumSize = new System.Drawing.Size(1462, 1100);
            this.Name = "fSearchConnections";
            this.Text = "Verbindungen Suchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbWhen;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ColumnHeader cDate;
        private System.Windows.Forms.ColumnHeader cDepartureTime;
        private System.Windows.Forms.ColumnHeader cDepartureStation;
        private System.Windows.Forms.ColumnHeader cArrivalTime;
        private System.Windows.Forms.ColumnHeader cArrivalStation;
        private System.Windows.Forms.ColumnHeader cPlatform;
        private System.Windows.Forms.ColumnHeader cDuration;
        private DropDownComboBox cbStationFrom;
        private DropDownComboBox cbStationTo;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnSwitchStations;
        private System.Windows.Forms.Button btnCancel;
    }
}