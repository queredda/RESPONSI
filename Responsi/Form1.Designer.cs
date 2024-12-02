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
            lblNama = new Label();
            lblDept = new Label();
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
            label1.Font = new Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 70);
            label1.Name = "label1";
            label1.Size = new Size(305, 36);
            label1.TabIndex = 0;
            label1.Text = "Employee Management";
            label1.Click += label1_Click;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNama.Location = new Point(49, 167);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(161, 27);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Karyawan:";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDept.Location = new Point(49, 220);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(129, 27);
            lblDept.TabIndex = 2;
            lblDept.Text = "Departemen:";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(221, 167);
            tbNama.Margin = new Padding(3, 4, 3, 4);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(210, 27);
            tbNama.TabIndex = 3;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(221, 220);
            cbDep.Margin = new Padding(3, 4, 3, 4);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(210, 28);
            cbDep.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "ID Departemen:", "HR : Human Resource", "ENG : Engineering", "DEV : Developer", "PM : Product Manager", "FIN : Finance" });
            listBox1.Location = new Point(497, 123);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 144);
            listBox1.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(49, 275);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(145, 39);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(395, 275);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 39);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(221, 275);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(145, 39);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 335);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(651, 271);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(570, 275);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(130, 39);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 31);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 693);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(listBox1);
            Controls.Add(cbDep);
            Controls.Add(tbNama);
            Controls.Add(lblDept);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblNama;
        private Label lblDept;
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