namespace projekt_isi
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
            this.GetData = new System.Windows.Forms.Button();
            this.worldFiltr = new System.Windows.Forms.RadioButton();
            this.List = new System.Windows.Forms.ListView();
            this.PolandFiltr = new System.Windows.Forms.RadioButton();
            this.USAFilter = new System.Windows.Forms.RadioButton();
            this.UKFilter = new System.Windows.Forms.RadioButton();
            this.GerFilter = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExportDB = new System.Windows.Forms.Button();
            this.ViewData = new System.Windows.Forms.Button();
            this.ImportXML = new System.Windows.Forms.Button();
            this.ExportXML = new System.Windows.Forms.Button();
            this.ImportJSON = new System.Windows.Forms.Button();
            this.ExportJSON = new System.Windows.Forms.Button();
            this.ImportDB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(855, 165);
            this.GetData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(173, 30);
            this.GetData.TabIndex = 4;
            this.GetData.Text = "GetData";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // worldFiltr
            // 
            this.worldFiltr.AutoSize = true;
            this.worldFiltr.Location = new System.Drawing.Point(860, 80);
            this.worldFiltr.Name = "worldFiltr";
            this.worldFiltr.Size = new System.Drawing.Size(57, 19);
            this.worldFiltr.TabIndex = 8;
            this.worldFiltr.TabStop = true;
            this.worldFiltr.Text = "World";
            this.worldFiltr.UseVisualStyleBackColor = true;
            this.worldFiltr.CheckedChanged += new System.EventHandler(this.worldFiltr_CheckedChanged);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(12, 51);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(823, 505);
            this.List.TabIndex = 9;
            this.List.UseCompatibleStateImageBehavior = false;
            // 
            // PolandFiltr
            // 
            this.PolandFiltr.AutoSize = true;
            this.PolandFiltr.Location = new System.Drawing.Point(935, 80);
            this.PolandFiltr.Name = "PolandFiltr";
            this.PolandFiltr.Size = new System.Drawing.Size(62, 19);
            this.PolandFiltr.TabIndex = 10;
            this.PolandFiltr.TabStop = true;
            this.PolandFiltr.Text = "Poland";
            this.PolandFiltr.UseVisualStyleBackColor = true;
            this.PolandFiltr.CheckedChanged += new System.EventHandler(this.PolandFiltr_CheckedChanged);
            // 
            // USAFilter
            // 
            this.USAFilter.AutoSize = true;
            this.USAFilter.Location = new System.Drawing.Point(860, 105);
            this.USAFilter.Name = "USAFilter";
            this.USAFilter.Size = new System.Drawing.Size(47, 19);
            this.USAFilter.TabIndex = 11;
            this.USAFilter.TabStop = true;
            this.USAFilter.Text = "USA";
            this.USAFilter.UseVisualStyleBackColor = true;
            this.USAFilter.CheckedChanged += new System.EventHandler(this.USAFilter_CheckedChanged);
            // 
            // UKFilter
            // 
            this.UKFilter.AutoSize = true;
            this.UKFilter.Location = new System.Drawing.Point(935, 105);
            this.UKFilter.Name = "UKFilter";
            this.UKFilter.Size = new System.Drawing.Size(40, 19);
            this.UKFilter.TabIndex = 12;
            this.UKFilter.TabStop = true;
            this.UKFilter.Text = "UK";
            this.UKFilter.UseVisualStyleBackColor = true;
            this.UKFilter.CheckedChanged += new System.EventHandler(this.UKFilter_CheckedChanged);
            // 
            // GerFilter
            // 
            this.GerFilter.AutoSize = true;
            this.GerFilter.Location = new System.Drawing.Point(860, 130);
            this.GerFilter.Name = "GerFilter";
            this.GerFilter.Size = new System.Drawing.Size(73, 19);
            this.GerFilter.TabIndex = 13;
            this.GerFilter.TabStop = true;
            this.GerFilter.Text = "Germany";
            this.GerFilter.UseVisualStyleBackColor = true;
            this.GerFilter.CheckedChanged += new System.EventHandler(this.GerFilter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Top 50 Tracks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(855, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Area:";
            // 
            // ExportDB
            // 
            this.ExportDB.Location = new System.Drawing.Point(855, 279);
            this.ExportDB.Name = "ExportDB";
            this.ExportDB.Size = new System.Drawing.Size(173, 31);
            this.ExportDB.TabIndex = 16;
            this.ExportDB.Text = "Export to DB";
            this.ExportDB.UseVisualStyleBackColor = true;
            this.ExportDB.Click += new System.EventHandler(this.ExportDB_Click);
            // 
            // ViewData
            // 
            this.ViewData.Location = new System.Drawing.Point(746, 16);
            this.ViewData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewData.Name = "ViewData";
            this.ViewData.Size = new System.Drawing.Size(89, 30);
            this.ViewData.TabIndex = 17;
            this.ViewData.Text = "Refresh";
            this.ViewData.UseVisualStyleBackColor = true;
            this.ViewData.Click += new System.EventHandler(this.ViewData_Click);
            // 
            // 
            // FilterButton 
            // 
            this.filterButton.Location = new System.Drawing.Point(650, 16);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(89, 30);
            this.filterButton.TabIndex = 17;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.Filter_Click);
            // 
            // 
            // FilterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(550, 21);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(89, 30);
            this.filterTextBox.TabIndex = 17;
            // 
            // FilterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterLabel.Location = new System.Drawing.Point(440, 18);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(44, 21);
            this.filterLabel.TabIndex = 24;
            this.filterLabel.Text = "Artist origin:";
            // 
            // ImportXML
            // 
            this.ImportXML.Location = new System.Drawing.Point(855, 363);
            this.ImportXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImportXML.Name = "ImportXML";
            this.ImportXML.Size = new System.Drawing.Size(173, 30);
            this.ImportXML.TabIndex = 18;
            this.ImportXML.Text = "ImportXML";
            this.ImportXML.UseVisualStyleBackColor = true;
            this.ImportXML.Click += new System.EventHandler(this.ImportXML_Click);
            // 
            // ExportXML
            // 
            this.ExportXML.Location = new System.Drawing.Point(855, 397);
            this.ExportXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportXML.Name = "ExportXML";
            this.ExportXML.Size = new System.Drawing.Size(173, 30);
            this.ExportXML.TabIndex = 19;
            this.ExportXML.Text = "ExportXML";
            this.ExportXML.UseVisualStyleBackColor = true;
            this.ExportXML.Click += new System.EventHandler(this.ExportXML_Click);
            // 
            // ImportJSON
            // 
            this.ImportJSON.Location = new System.Drawing.Point(855, 491);
            this.ImportJSON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImportJSON.Name = "ImportJSON";
            this.ImportJSON.Size = new System.Drawing.Size(173, 30);
            this.ImportJSON.TabIndex = 20;
            this.ImportJSON.Text = "ImportJSON";
            this.ImportJSON.UseVisualStyleBackColor = true;
            this.ImportJSON.Click += new System.EventHandler(this.ImportJSON_Click);
            // 
            // ExportJSON
            // 
            this.ExportJSON.Location = new System.Drawing.Point(855, 525);
            this.ExportJSON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportJSON.Name = "ExportJSON";
            this.ExportJSON.Size = new System.Drawing.Size(173, 30);
            this.ExportJSON.TabIndex = 21;
            this.ExportJSON.Text = "ExportJSON";
            this.ExportJSON.UseVisualStyleBackColor = true;
            this.ExportJSON.Click += new System.EventHandler(this.ExportJSON_Click);
            // 
            // ImportDB
            // 
            this.ImportDB.Location = new System.Drawing.Point(855, 242);
            this.ImportDB.Name = "ImportDB";
            this.ImportDB.Size = new System.Drawing.Size(173, 31);
            this.ImportDB.TabIndex = 22;
            this.ImportDB.Text = "Import from DB";
            this.ImportDB.UseVisualStyleBackColor = true;
            this.ImportDB.Click += new System.EventHandler(this.ImportDB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(855, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(855, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "XML:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(855, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "JSON:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Export to DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExportDB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(855, 363);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "ImportXML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ImportXML_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(855, 397);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 30);
            this.button3.TabIndex = 19;
            this.button3.Text = "ExportXML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExportXML_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(855, 491);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 30);
            this.button4.TabIndex = 20;
            this.button4.Text = "ImportJSON";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ImportJSON_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(855, 525);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 30);
            this.button5.TabIndex = 21;
            this.button5.Text = "ExportJSON";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ExportJSON_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(855, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "XML:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(855, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "JSON:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 581);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImportDB);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ExportJSON);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ImportJSON);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ExportXML);
            this.Controls.Add(this.ImportXML);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewData);
            this.Controls.Add(this.ExportDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GerFilter);
            this.Controls.Add(this.UKFilter);
            this.Controls.Add(this.USAFilter);
            this.Controls.Add(this.PolandFiltr);
            this.Controls.Add(this.List);
            this.Controls.Add(this.worldFiltr);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button GetData;
        private RadioButton worldFiltr;
        private ListView List;
        private RadioButton PolandFiltr;
        private RadioButton USAFilter;
        private RadioButton UKFilter;
        private RadioButton GerFilter;
        private Label label1;
        private Label label2;
        private Button ExportDB;
        private Button ViewData;
        private Button ImportXML;
        private Button ExportXML;
        private Button ImportJSON;
        private Button ExportJSON;
        private Button ImportDB;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label6;
        private Label label7;
        private Button filterButton;
        private Label filterLabel;
        private TextBox filterTextBox;
    }
}