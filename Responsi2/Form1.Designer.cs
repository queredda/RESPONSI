namespace responsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNama = new TextBox();
            cbDep = new ComboBox();
            listBox1 = new ListBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dataGridView1 = new DataGridView();
            btnLoad = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(247, 51);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee Management App";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 125);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 165);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Departemen:";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(157, 122);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(241, 23);
            tbNama.TabIndex = 3;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(157, 165);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(241, 23);
            cbDep.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID Departemen:", "HR : Human Resource", "ENG : Engineering", "DEV : Developer", "PM : Product Manager", "FIN : Finance" });
            listBox1.Location = new Point(483, 125);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(130, 109);
            listBox1.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(43, 206);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(127, 25);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(339, 206);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 25);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(193, 206);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(127, 25);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(570, 203);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(525, 472);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(88, 25);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 520);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(listBox1);
            Controls.Add(cbDep);
            Controls.Add(tbNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNama;
        private ComboBox cbDep;
        private ListBox listBox1;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dataGridView1;
        private Button btnLoad;
        private PictureBox pictureBox1;
    }
}