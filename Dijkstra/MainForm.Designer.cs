namespace Dijkstra
{
    partial class MainForm
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
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathFinish = new System.Windows.Forms.ComboBox();
            this.pathStart = new System.Windows.Forms.ComboBox();
            this.RunSearch = new System.Windows.Forms.Button();
            this.ImportData = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.Filename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.path = new System.Windows.Forms.TextBox();
            this.pathLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.controlsPanel.SuspendLayout();
            this.resultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.label3);
            this.controlsPanel.Controls.Add(this.label2);
            this.controlsPanel.Controls.Add(this.pathFinish);
            this.controlsPanel.Controls.Add(this.pathStart);
            this.controlsPanel.Controls.Add(this.RunSearch);
            this.controlsPanel.Controls.Add(this.ImportData);
            this.controlsPanel.Controls.Add(this.Browse);
            this.controlsPanel.Controls.Add(this.Filename);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsPanel.Location = new System.Drawing.Point(0, 0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(614, 120);
            this.controlsPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Финиш";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Исходная точка";
            // 
            // pathFinish
            // 
            this.pathFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pathFinish.FormattingEnabled = true;
            this.pathFinish.Location = new System.Drawing.Point(238, 76);
            this.pathFinish.Name = "pathFinish";
            this.pathFinish.Size = new System.Drawing.Size(234, 21);
            this.pathFinish.TabIndex = 6;
            // 
            // pathStart
            // 
            this.pathStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pathStart.FormattingEnabled = true;
            this.pathStart.Location = new System.Drawing.Point(238, 42);
            this.pathStart.Name = "pathStart";
            this.pathStart.Size = new System.Drawing.Size(234, 21);
            this.pathStart.TabIndex = 5;
            // 
            // RunSearch
            // 
            this.RunSearch.Location = new System.Drawing.Point(478, 42);
            this.RunSearch.Name = "RunSearch";
            this.RunSearch.Size = new System.Drawing.Size(124, 55);
            this.RunSearch.TabIndex = 4;
            this.RunSearch.Text = "Поиск";
            this.RunSearch.UseVisualStyleBackColor = true;
            this.RunSearch.Click += new System.EventHandler(this.RunSearch_Click);
            // 
            // ImportData
            // 
            this.ImportData.Location = new System.Drawing.Point(15, 42);
            this.ImportData.Name = "ImportData";
            this.ImportData.Size = new System.Drawing.Size(124, 55);
            this.ImportData.TabIndex = 3;
            this.ImportData.Text = "Загрузить исходные данные";
            this.ImportData.UseVisualStyleBackColor = true;
            this.ImportData.Click += new System.EventHandler(this.ImportData_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(529, 13);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Выбрать ...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(145, 15);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(378, 20);
            this.Filename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл исходных данных";
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.path);
            this.resultsPanel.Controls.Add(this.pathLength);
            this.resultsPanel.Controls.Add(this.label5);
            this.resultsPanel.Controls.Add(this.label4);
            this.resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsPanel.Location = new System.Drawing.Point(0, 120);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(614, 79);
            this.resultsPanel.TabIndex = 1;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(89, 37);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(513, 20);
            this.path.TabIndex = 3;
            // 
            // pathLength
            // 
            this.pathLength.Location = new System.Drawing.Point(89, 10);
            this.pathLength.Name = "pathLength";
            this.pathLength.Size = new System.Drawing.Size(513, 20);
            this.pathLength.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Путь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Длинна пути";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 199);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.controlsPanel);
            this.Name = "MainForm";
            this.Text = "Алгоритм Дейкстры";
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pathFinish;
        private System.Windows.Forms.ComboBox pathStart;
        private System.Windows.Forms.Button RunSearch;
        private System.Windows.Forms.Button ImportData;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.OpenFileDialog OpenDataFileDialog;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox pathLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

