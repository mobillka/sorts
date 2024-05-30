namespace sorts
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
            txtMin = new TextBox();
            txtMax = new TextBox();
            txtCount = new TextBox();
            txtArray = new TextBox();
            pictureBox = new PictureBox();
            btnGenerate = new Button();
            btnMergeSort = new Button();
            btnQuickSort = new Button();
            btnIntroSort = new Button();
            lbsort = new Label();
            lbminA = new Label();
            lbmaxA = new Label();
            lbN = new Label();
            btnSave = new Button();
            btnRead = new Button();
            groupBox1 = new GroupBox();
            rbDesc = new RadioButton();
            rbAsc = new RadioButton();
            rbRand = new RadioButton();
            lbdepth = new Label();
            txtDepth = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMin
            // 
            txtMin.Font = new Font("Segoe UI", 11F);
            txtMin.Location = new Point(103, 12);
            txtMin.Margin = new Padding(1);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(103, 27);
            txtMin.TabIndex = 0;
            txtMin.Text = "1";
            // 
            // txtMax
            // 
            txtMax.Font = new Font("Segoe UI", 11F);
            txtMax.Location = new Point(103, 45);
            txtMax.Margin = new Padding(1);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(103, 27);
            txtMax.TabIndex = 1;
            txtMax.Text = "50";
            // 
            // txtCount
            // 
            txtCount.Font = new Font("Segoe UI", 11F);
            txtCount.Location = new Point(104, 78);
            txtCount.Margin = new Padding(1);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(103, 27);
            txtCount.TabIndex = 2;
            txtCount.Text = "200";
            // 
            // txtArray
            // 
            txtArray.Location = new Point(5, 146);
            txtArray.Margin = new Padding(1);
            txtArray.Multiline = true;
            txtArray.Name = "txtArray";
            txtArray.ScrollBars = ScrollBars.Vertical;
            txtArray.Size = new Size(1297, 227);
            txtArray.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(5, 379);
            pictureBox.Margin = new Padding(1);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1295, 316);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Microsoft Sans Serif", 12F);
            btnGenerate.Location = new Point(401, 10);
            btnGenerate.Margin = new Padding(1);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(105, 31);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Font = new Font("Microsoft Sans Serif", 12F);
            btnMergeSort.Location = new Point(727, 18);
            btnMergeSort.Margin = new Padding(1);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(105, 31);
            btnMergeSort.TabIndex = 6;
            btnMergeSort.Text = "MergeSort";
            btnMergeSort.UseVisualStyleBackColor = true;
            btnMergeSort.Click += btnMergeSort_Click;
            // 
            // btnQuickSort
            // 
            btnQuickSort.Font = new Font("Microsoft Sans Serif", 12F);
            btnQuickSort.Location = new Point(842, 18);
            btnQuickSort.Margin = new Padding(1);
            btnQuickSort.Name = "btnQuickSort";
            btnQuickSort.Size = new Size(105, 31);
            btnQuickSort.TabIndex = 7;
            btnQuickSort.Text = "QuickSort";
            btnQuickSort.UseVisualStyleBackColor = true;
            btnQuickSort.Click += btnQuickSort_Click;
            // 
            // btnIntroSort
            // 
            btnIntroSort.Font = new Font("Microsoft Sans Serif", 12F);
            btnIntroSort.Location = new Point(957, 18);
            btnIntroSort.Margin = new Padding(1);
            btnIntroSort.Name = "btnIntroSort";
            btnIntroSort.Size = new Size(105, 31);
            btnIntroSort.TabIndex = 8;
            btnIntroSort.Text = "IntroSort";
            btnIntroSort.UseVisualStyleBackColor = true;
            btnIntroSort.Click += btnIntroSort_Click;
            // 
            // lbsort
            // 
            lbsort.AutoSize = true;
            lbsort.Font = new Font("Segoe UI", 32F);
            lbsort.Location = new Point(686, 50);
            lbsort.Margin = new Padding(1, 0, 1, 0);
            lbsort.Name = "lbsort";
            lbsort.Size = new Size(398, 59);
            lbsort.TabIndex = 9;
            lbsort.Text = "  не відсортований";
            lbsort.TextAlign = ContentAlignment.MiddleCenter;
            lbsort.Click += lbsort_Click;
            // 
            // lbminA
            // 
            lbminA.AutoSize = true;
            lbminA.Font = new Font("Segoe UI", 12F);
            lbminA.Location = new Point(14, 12);
            lbminA.Margin = new Padding(1, 0, 1, 0);
            lbminA.Name = "lbminA";
            lbminA.Size = new Size(78, 21);
            lbminA.TabIndex = 10;
            lbminA.Text = "min elem:";
            lbminA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbmaxA
            // 
            lbmaxA.AutoSize = true;
            lbmaxA.Font = new Font("Segoe UI", 12F);
            lbmaxA.Location = new Point(12, 45);
            lbmaxA.Margin = new Padding(1, 0, 1, 0);
            lbmaxA.Name = "lbmaxA";
            lbmaxA.Size = new Size(80, 21);
            lbmaxA.TabIndex = 11;
            lbmaxA.Text = "max elem:";
            lbmaxA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbN
            // 
            lbN.AutoSize = true;
            lbN.Font = new Font("Segoe UI", 12F);
            lbN.Location = new Point(30, 78);
            lbN.Margin = new Padding(1, 0, 1, 0);
            lbN.Name = "lbN";
            lbN.Size = new Size(63, 21);
            lbN.TabIndex = 12;
            lbN.Text = "arr size:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(401, 43);
            btnSave.Margin = new Padding(1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 31);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save to File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Microsoft Sans Serif", 12F);
            btnRead.Location = new Point(401, 76);
            btnRead.Margin = new Padding(1);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(105, 31);
            btnRead.TabIndex = 14;
            btnRead.Text = "Read from File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDesc);
            groupBox1.Controls.Add(rbAsc);
            groupBox1.Controls.Add(rbRand);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(225, 4);
            groupBox1.Margin = new Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(149, 100);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "generation type";
            // 
            // rbDesc
            // 
            rbDesc.AutoSize = true;
            rbDesc.Font = new Font("Segoe UI", 12F);
            rbDesc.Location = new Point(18, 67);
            rbDesc.Margin = new Padding(1);
            rbDesc.Name = "rbDesc";
            rbDesc.Size = new Size(107, 25);
            rbDesc.TabIndex = 2;
            rbDesc.TabStop = true;
            rbDesc.Text = "descending";
            rbDesc.UseVisualStyleBackColor = true;
            // 
            // rbAsc
            // 
            rbAsc.AutoSize = true;
            rbAsc.Font = new Font("Segoe UI", 12F);
            rbAsc.Location = new Point(18, 45);
            rbAsc.Margin = new Padding(1);
            rbAsc.Name = "rbAsc";
            rbAsc.Size = new Size(98, 25);
            rbAsc.TabIndex = 1;
            rbAsc.TabStop = true;
            rbAsc.Text = "ascending";
            rbAsc.UseVisualStyleBackColor = true;
            // 
            // rbRand
            // 
            rbRand.AutoSize = true;
            rbRand.Font = new Font("Segoe UI", 12F);
            rbRand.Location = new Point(18, 22);
            rbRand.Margin = new Padding(1);
            rbRand.Name = "rbRand";
            rbRand.Size = new Size(83, 25);
            rbRand.TabIndex = 0;
            rbRand.TabStop = true;
            rbRand.Text = "random";
            rbRand.UseVisualStyleBackColor = true;
            // 
            // lbdepth
            // 
            lbdepth.AutoSize = true;
            lbdepth.Font = new Font("Segoe UI", 12F);
            lbdepth.Location = new Point(399, 114);
            lbdepth.Margin = new Padding(1, 0, 1, 0);
            lbdepth.Name = "lbdepth";
            lbdepth.Size = new Size(140, 21);
            lbdepth.TabIndex = 17;
            lbdepth.Text = "depth of recursion:";
            // 
            // txtDepth
            // 
            txtDepth.Font = new Font("Segoe UI", 11F);
            txtDepth.Location = new Point(559, 114);
            txtDepth.Margin = new Padding(1);
            txtDepth.Name = "txtDepth";
            txtDepth.ReadOnly = true;
            txtDepth.Size = new Size(46, 27);
            txtDepth.TabIndex = 16;
            txtDepth.Text = "200";
            txtDepth.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 655);
            Controls.Add(lbdepth);
            Controls.Add(txtDepth);
            Controls.Add(groupBox1);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(lbN);
            Controls.Add(lbmaxA);
            Controls.Add(lbminA);
            Controls.Add(lbsort);
            Controls.Add(btnIntroSort);
            Controls.Add(btnQuickSort);
            Controls.Add(btnMergeSort);
            Controls.Add(btnGenerate);
            Controls.Add(pictureBox);
            Controls.Add(txtArray);
            Controls.Add(txtCount);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Font = new Font("Segoe UI", 9F);
            HelpButton = true;
            Margin = new Padding(1);
            MaximumSize = new Size(1327, 756);
            MinimumSize = new Size(799, 404);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMin;
        private TextBox txtMax;
        private TextBox txtCount;
        private TextBox txtArray;
        private PictureBox pictureBox;
        private Button btnGenerate;
        private Button btnMergeSort;
        private Button btnQuickSort;
        private Button btnIntroSort;
        private Label lbsort;
        private Label lbminA;
        private Label lbmaxA;
        private Label lbN;
        private Button btnSave;
        private Button btnRead;
        private GroupBox groupBox1;
        private RadioButton rbDesc;
        private RadioButton rbAsc;
        private RadioButton rbRand;
        private Label lbdepth;
        private TextBox txtDepth;
    }
}
