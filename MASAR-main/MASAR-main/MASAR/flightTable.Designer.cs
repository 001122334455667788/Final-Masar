namespace MASAR
{
    partial class flightTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flightTable));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.planeID = new System.Windows.Forms.TextBox();
            this.pilotID = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.source = new System.Windows.Forms.ComboBox();
            this.destination = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "MASAR Airline Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOURCE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Flight Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "plane ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Destination";
            // 
            // planeID
            // 
            this.planeID.BackColor = System.Drawing.Color.White;
            this.planeID.ForeColor = System.Drawing.Color.Black;
            this.planeID.Location = new System.Drawing.Point(203, 361);
            this.planeID.Name = "planeID";
            this.planeID.Size = new System.Drawing.Size(171, 27);
            this.planeID.TabIndex = 11;
            // 
            // pilotID
            // 
            this.pilotID.BackColor = System.Drawing.Color.White;
            this.pilotID.ForeColor = System.Drawing.Color.Black;
            this.pilotID.Location = new System.Drawing.Point(203, 404);
            this.pilotID.Name = "pilotID";
            this.pilotID.Size = new System.Drawing.Size(171, 27);
            this.pilotID.TabIndex = 13;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.White;
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(203, 213);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(171, 27);
            this.id.TabIndex = 14;
            this.id.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(798, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 59);
            this.button2.TabIndex = 15;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(798, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 59);
            this.button1.TabIndex = 16;
            this.button1.Text = "RECORD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(295, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(342, 39);
            this.label7.TabIndex = 17;
            this.label7.Text = "RECORD NEW FLIGHT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pilot ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(950, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // source
            // 
            this.source.FormattingEnabled = true;
            this.source.Items.AddRange(new object[] {
            "United States",
            "Egypt",
            "Albania",
            "Andorra",
            "Australia",
            "Chile\t",
            "Italy\t",
            "Jamaica\t",
            "Japan\t",
            "Jordan\t",
            "Kazakhstan\t",
            "Kenya\t",
            "Kiribati\t",
            "North Korea\t",
            "South Korea\t",
            "Kuwait\t",
            "Kyrgyzstan",
            "Laos\t",
            "Latvia\t",
            "Lebanon\t",
            "Lesotho",
            "Liberia\t",
            "Libya\t",
            "Liechtenstein\t",
            "Lithuania\t",
            "Luxembourg",
            "Macedonia\t",
            "Madagascar\t",
            "Malawi\t",
            "Malaysia\t",
            "Maldives\t",
            "Mali\t",
            "Malta\t",
            "Marshall Islands\t",
            "Martinique\t",
            "Mauritania\t",
            "Mauritius\t",
            "Mexico\t",
            "Micronesia",
            "Moldova",
            "Monaco"});
            this.source.Location = new System.Drawing.Point(203, 263);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(171, 28);
            this.source.TabIndex = 54;
            // 
            // destination
            // 
            this.destination.FormattingEnabled = true;
            this.destination.Items.AddRange(new object[] {
            "United States",
            "Egypt",
            "Albania",
            "Andorra",
            "Australia",
            "Chile\t",
            "Italy\t",
            "Jamaica\t",
            "Japan\t",
            "Jordan\t",
            "Kazakhstan\t",
            "Kenya\t",
            "Kiribati\t",
            "North Korea\t",
            "South Korea\t",
            "Kuwait\t",
            "Kyrgyzstan",
            "Laos\t",
            "Latvia\t",
            "Lebanon\t",
            "Lesotho",
            "Liberia\t",
            "Libya\t",
            "Liechtenstein\t",
            "Lithuania\t",
            "Luxembourg",
            "Macedonia\t",
            "Madagascar\t",
            "Malawi\t",
            "Malaysia\t",
            "Maldives\t",
            "Mali\t",
            "Malta\t",
            "Marshall Islands\t",
            "Martinique\t",
            "Mauritania\t",
            "Mauritius\t",
            "Mexico\t",
            "Micronesia",
            "Moldova",
            "Monaco"});
            this.destination.Location = new System.Drawing.Point(203, 316);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(171, 28);
            this.destination.TabIndex = 55;
            // 
            // flightTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(977, 548);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.source);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.pilotID);
            this.Controls.Add(this.planeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "flightTable";
            this.Text = "flightTable";
            this.Load += new System.EventHandler(this.flightTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox planeID;
        private TextBox pilotID;
        private TextBox id;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label4;
        private Label label8;
        private ComboBox source;
        private ComboBox destination;
    }
}