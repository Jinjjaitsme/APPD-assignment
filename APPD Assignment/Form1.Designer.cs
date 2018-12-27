namespace APPD_Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartNavigation = new System.Windows.Forms.Button();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnShowNotification = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "From ::";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "To ::";
            // 
            // btnStartNavigation
            // 
            this.btnStartNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNavigation.Location = new System.Drawing.Point(227, 532);
            this.btnStartNavigation.Name = "btnStartNavigation";
            this.btnStartNavigation.Size = new System.Drawing.Size(135, 60);
            this.btnStartNavigation.TabIndex = 3;
            this.btnStartNavigation.Text = "Start Navigation";
            this.btnStartNavigation.UseVisualStyleBackColor = true;
            this.btnStartNavigation.Click += new System.EventHandler(this.btnStartNavigation_Click);
            // 
            // cbFrom
            // 
            this.cbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "CC1-Dhoby Ghaut",
            "CC2-Bras Basah",
            "CC3-Esplanade",
            "CC4-Promenade",
            "CC5-Nicoll Highway",
            "CC6-Stadium",
            "CC7-Mountbatten",
            "CC8-Dakota",
            "CC9-Paya Lebar",
            "CC10-MacPherson",
            "CC11-Tai Seng",
            "CC12-Bartley",
            "CC13-Serangoon",
            "CC14-Lorong Chuan",
            "CC15-Bishan",
            "CC16-Marymount",
            "CC17-Caldecott",
            "CC18-Bukit Brown",
            "CC19-Botanic Gardens",
            "CC20-Farrer Road",
            "CC21-Holland Village",
            "CC22-Buona Vista",
            "CC23-One North",
            "CC24-Kent Ridge",
            "CC25-Haw Par Villa",
            "CC26-Pasir Panjang",
            "CC27-Labrador Park",
            "CC28-Telok Blangah",
            "CC29-HarbourFront",
            "DT1-Bukit Panjang",
            "DT2-Cashew",
            "DT3-Hillview",
            "DT5-Beauty World",
            "DT6-King Albert Park",
            "DT7-Sixth Avenue",
            "DT8-Tan Kah Kee",
            "DT9-Botanic Gardens",
            "DT10-Stevens",
            "DT11-Newton",
            "DT12-Little India",
            "DT13-Rochor",
            "DT14-Bugis",
            "DT15-Promenade",
            "DT16-Bayfront",
            "DT17-Downtown",
            "DT18-Telok Ayer",
            "DT19-Chinatown",
            "DT20-Fort Canning",
            "DT21-Bencoolen",
            "DT22-Jalan Besar",
            "DT23-Bendemeer",
            "DT24-Geylang Bahru",
            "DT25-Mattar",
            "DT26-MacPherson",
            "DT27-Ubi",
            "DT28-Kaki Bukit",
            "DT29-Bedok North",
            "DT30-Bedok Reservoir",
            "DT31-Tampines West",
            "DT32-Tampines",
            "DT33-Tampines East",
            "DT34-Upper Changi",
            "DT35-Expo",
            "DT36-Xilin",
            "DT37-Sungei Bedok",
            "EW1-Pasir Ris",
            "EW2-Tampines",
            "EW3-Simei",
            "EW4-Tanah Merah",
            "EW5-Bedok",
            "EW6-Kembangan",
            "EW7-Eunos",
            "EW8-Paya Lebar",
            "EW9-Aljunied",
            "EW10-Kallang",
            "EW11-Lavender",
            "EW12-Bugis",
            "EW13-City Hall",
            "EW14-Raffles Place",
            "EW15-Tanjong Pagar",
            "EW16-Outram Park",
            "EW17-Tiong Bahru",
            "EW18-Redhill",
            "EW19-Queenstown",
            "EW20-Commonwealth",
            "EW21-Buona Vista",
            "EW22-Dover",
            "EW23-Clementi",
            "EW24-Jurong East",
            "EW25-Chinese Garden",
            "EW26-Lakeside",
            "EW27-Boon Lay",
            "EW28-Pioneer",
            "EW29-Joo Koon",
            "EW30-Gul Circle",
            "EW31-Tuas Crescent",
            "EW32-Tuas West-Road",
            "EW33-Tuas Link",
            "NS1-Jurong East",
            "NS2-Bukit Batok",
            "NS3-Bukit Gombak",
            "NS4-Choa Chu-Kang",
            "NS5-Yew Tee",
            "NS7-Kranji",
            "NS8-Marsiling",
            "NS9-Woodlands",
            "NS10-Admiralty",
            "NS11-Sembawang",
            "NS13-Yishun",
            "NS14-Khatib",
            "NS15-Yio Chu Kang",
            "NS16-Ang Mo Kio",
            "NS17-Bishan",
            "NS18-Braddell",
            "NS19-Toa Payoh",
            "NS20-Novena",
            "NS21-Newton",
            "NS22-Orchard",
            "NS23-Somerset",
            "NS24-Dhoby Ghaut",
            "NS25-City Hall",
            "NS26-Raffles Place",
            "NS27-Marina Bay",
            "NS28-Marina South-Pier",
            "CG1-Expo",
            "CG2-Changi Airport",
            "NE1-HarbourFront",
            "NE3-Outram Park",
            "NE4-Chinatown",
            "NE5-Clarke Quay",
            "NE6-Dhoby Ghaut",
            "NE7-Little India",
            "NE8-Farrer Park",
            "NE9-Boon Keng",
            "NE10-Potong Pasir",
            "NE11-Woodleigh",
            "NE12-Serangoon",
            "NE13-Kovan",
            "NE14-Hougang",
            "NE15-Buangkok",
            "NE16-Sengkang",
            "NE17-Punggol"});
            this.cbFrom.Location = new System.Drawing.Point(160, 324);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(217, 33);
            this.cbFrom.TabIndex = 4;
            // 
            // cbTo
            // 
            this.cbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "CC1-Dhoby Ghaut",
            "CC2-Bras Basah",
            "CC3-Esplanade",
            "CC4-Promenade",
            "CC5-Nicoll Highway",
            "CC6-Stadium",
            "CC7-Mountbatten",
            "CC8-Dakota",
            "CC9-Paya Lebar",
            "CC10-MacPherson",
            "CC11-Tai Seng",
            "CC12-Bartley",
            "CC13-Serangoon",
            "CC14-Lorong Chuan",
            "CC15-Bishan",
            "CC16-Marymount",
            "CC17-Caldecott",
            "CC18-Bukit Brown",
            "CC19-Botanic Gardens",
            "CC20-Farrer Road",
            "CC21-Holland Village",
            "CC22-Buona Vista",
            "CC23-One North",
            "CC24-Kent Ridge",
            "CC25-Haw Par Villa",
            "CC26-Pasir Panjang",
            "CC27-Labrador Park",
            "CC28-Telok Blangah",
            "CC29-HarbourFront",
            "DT1-Bukit Panjang",
            "DT2-Cashew",
            "DT3-Hillview",
            "DT5-Beauty World",
            "DT6-King Albert Park",
            "DT7-Sixth Avenue",
            "DT8-Tan Kah Kee",
            "DT9-Botanic Gardens",
            "DT10-Stevens",
            "DT11-Newton",
            "DT12-Little India",
            "DT13-Rochor",
            "DT14-Bugis",
            "DT15-Promenade",
            "DT16-Bayfront",
            "DT17-Downtown",
            "DT18-Telok Ayer",
            "DT19-Chinatown",
            "DT20-Fort Canning",
            "DT21-Bencoolen",
            "DT22-Jalan Besar",
            "DT23-Bendemeer",
            "DT24-Geylang Bahru",
            "DT25-Mattar",
            "DT26-MacPherson",
            "DT27-Ubi",
            "DT28-Kaki Bukit",
            "DT29-Bedok North",
            "DT30-Bedok Reservoir",
            "DT31-Tampines West",
            "DT32-Tampines",
            "DT33-Tampines East",
            "DT34-Upper Changi",
            "DT35-Expo",
            "DT36-Xilin",
            "DT37-Sungei Bedok",
            "EW1-Pasir Ris",
            "EW2-Tampines",
            "EW3-Simei",
            "EW4-Tanah Merah",
            "EW5-Bedok",
            "EW6-Kembangan",
            "EW7-Eunos",
            "EW8-Paya Lebar",
            "EW9-Aljunied",
            "EW10-Kallang",
            "EW11-Lavender",
            "EW12-Bugis",
            "EW13-City Hall",
            "EW14-Raffles Place",
            "EW15-Tanjong Pagar",
            "EW16-Outram Park",
            "EW17-Tiong Bahru",
            "EW18-Redhill",
            "EW19-Queenstown",
            "EW20-Commonwealth",
            "EW21-Buona Vista",
            "EW22-Dover",
            "EW23-Clementi",
            "EW24-Jurong East",
            "EW25-Chinese Garden",
            "EW26-Lakeside",
            "EW27-Boon Lay",
            "EW28-Pioneer",
            "EW29-Joo Koon",
            "EW30-Gul Circle",
            "EW31-Tuas Crescent",
            "EW32-Tuas West-Road",
            "EW33-Tuas Link",
            "NS1-Jurong East",
            "NS2-Bukit Batok",
            "NS3-Bukit Gombak",
            "NS4-Choa Chu-Kang",
            "NS5-Yew Tee",
            "NS7-Kranji",
            "NS8-Marsiling",
            "NS9-Woodlands",
            "NS10-Admiralty",
            "NS11-Sembawang",
            "NS13-Yishun",
            "NS14-Khatib",
            "NS15-Yio Chu Kang",
            "NS16-Ang Mo Kio",
            "NS17-Bishan",
            "NS18-Braddell",
            "NS19-Toa Payoh",
            "NS20-Novena",
            "NS21-Newton",
            "NS22-Orchard",
            "NS23-Somerset",
            "NS24-Dhoby Ghaut",
            "NS25-City Hall",
            "NS26-Raffles Place",
            "NS27-Marina Bay",
            "NS28-Marina South-Pier",
            "CG1-Expo",
            "CG2-Changi Airport",
            "NE1-HarbourFront",
            "NE3-Outram Park",
            "NE4-Chinatown",
            "NE5-Clarke Quay",
            "NE6-Dhoby Ghaut",
            "NE7-Little India",
            "NE8-Farrer Park",
            "NE9-Boon Keng",
            "NE10-Potong Pasir",
            "NE11-Woodleigh",
            "NE12-Serangoon",
            "NE13-Kovan",
            "NE14-Hougang",
            "NE15-Buangkok",
            "NE16-Sengkang",
            "NE17-Punggol"});
            this.cbTo.Location = new System.Drawing.Point(160, 436);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(217, 33);
            this.cbTo.TabIndex = 5;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(403, 324);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(383, 326);
            this.txtSummary.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 231);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(45, 532);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(134, 60);
            this.btnMap.TabIndex = 8;
            this.btnMap.Text = "Show Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnShowNotification
            // 
            this.btnShowNotification.Location = new System.Drawing.Point(603, 30);
            this.btnShowNotification.Name = "btnShowNotification";
            this.btnShowNotification.Size = new System.Drawing.Size(160, 47);
            this.btnShowNotification.TabIndex = 9;
            this.btnShowNotification.Text = "Show Notification";
            this.btnShowNotification.UseVisualStyleBackColor = true;
            this.btnShowNotification.Click += new System.EventHandler(this.btnShowNotification_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(12, 627);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(121, 30);
            this.btnFeedback.TabIndex = 10;
            this.btnFeedback.Text = "<Feedback>";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(798, 662);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnShowNotification);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.btnStartNavigation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Welcome to G.W Travel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartNavigation;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnShowNotification;
        private System.Windows.Forms.Button btnFeedback;
    }
}

