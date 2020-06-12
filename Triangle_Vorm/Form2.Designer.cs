namespace Triangle_Vorm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtAtext = new System.Windows.Forms.Label();
            this.txtBtext = new System.Windows.Forms.Label();
            this.txtCtext = new System.Windows.Forms.Label();
            this.txtHtext = new System.Windows.Forms.Label();
            this.heightCheckbox = new System.Windows.Forms.CheckBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtA.Location = new System.Drawing.Point(118, 298);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(79, 23);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtB.Location = new System.Drawing.Point(118, 325);
            this.txtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(79, 23);
            this.txtB.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtC.Location = new System.Drawing.Point(118, 352);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(79, 23);
            this.txtC.TabIndex = 2;
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtH.Location = new System.Drawing.Point(118, 379);
            this.txtH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(79, 23);
            this.txtH.TabIndex = 3;
            this.txtH.TextChanged += new System.EventHandler(this.txtH_TextChanged);
            // 
            // txtAtext
            // 
            this.txtAtext.AutoSize = true;
            this.txtAtext.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtext.Location = new System.Drawing.Point(12, 301);
            this.txtAtext.Name = "txtAtext";
            this.txtAtext.Size = new System.Drawing.Size(84, 20);
            this.txtAtext.TabIndex = 4;
            this.txtAtext.Text = "Сторона A";
            // 
            // txtBtext
            // 
            this.txtBtext.AutoSize = true;
            this.txtBtext.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBtext.Location = new System.Drawing.Point(12, 328);
            this.txtBtext.Name = "txtBtext";
            this.txtBtext.Size = new System.Drawing.Size(83, 20);
            this.txtBtext.TabIndex = 5;
            this.txtBtext.Text = "Сторона B";
            // 
            // txtCtext
            // 
            this.txtCtext.AutoSize = true;
            this.txtCtext.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtext.Location = new System.Drawing.Point(12, 355);
            this.txtCtext.Name = "txtCtext";
            this.txtCtext.Size = new System.Drawing.Size(83, 20);
            this.txtCtext.TabIndex = 6;
            this.txtCtext.Text = "Сторона C";
            // 
            // txtHtext
            // 
            this.txtHtext.AutoSize = true;
            this.txtHtext.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHtext.Location = new System.Drawing.Point(12, 382);
            this.txtHtext.Name = "txtHtext";
            this.txtHtext.Size = new System.Drawing.Size(58, 20);
            this.txtHtext.TabIndex = 7;
            this.txtHtext.Text = "Высота";
            this.txtHtext.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // heightCheckbox
            // 
            this.heightCheckbox.AutoSize = true;
            this.heightCheckbox.Enabled = false;
            this.heightCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightCheckbox.Location = new System.Drawing.Point(88, 409);
            this.heightCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heightCheckbox.Name = "heightCheckbox";
            this.heightCheckbox.Size = new System.Drawing.Size(131, 21);
            this.heightCheckbox.TabIndex = 8;
            this.heightCheckbox.Text = "Прямоугольный";
            this.heightCheckbox.UseVisualStyleBackColor = true;
            // 
            // launchButton
            // 
            this.launchButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.Location = new System.Drawing.Point(76, 434);
            this.launchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(152, 41);
            this.launchButton.TabIndex = 9;
            this.launchButton.Text = "Рассчитать";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(293, 279);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Поле";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 214;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(315, 486);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.heightCheckbox);
            this.Controls.Add(this.txtHtext);
            this.Controls.Add(this.txtCtext);
            this.Controls.Add(this.txtBtext);
            this.Controls.Add(this.txtAtext);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Треугольник";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label txtAtext;
        private System.Windows.Forms.Label txtBtext;
        private System.Windows.Forms.Label txtCtext;
        private System.Windows.Forms.Label txtHtext;
        private System.Windows.Forms.CheckBox heightCheckbox;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}