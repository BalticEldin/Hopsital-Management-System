namespace Hospital_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnAddPatient = new Button();
            btnAddDiagnosis = new Button();
            btnFullHistory = new Button();
            btnHospital = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnExit = new Button();
            labelIndecator1 = new Label();
            labelIndecator2 = new Label();
            labelIndecator3 = new Label();
            labelIndecator4 = new Label();
            panel1 = new Panel();
            btnSave = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboGender = new ComboBox();
            txtBlood = new TextBox();
            txtAny = new TextBox();
            txtPid = new TextBox();
            txtAge = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            comboBxWardType = new ComboBox();
            comboBxWard = new ComboBox();
            txtBxMedicines = new TextBox();
            txtBxDiagonosis = new TextBox();
            txtBxSymptoms = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label11 = new Label();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = SystemColors.ActiveCaption;
            btnAddPatient.Location = new Point(57, 69);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(177, 37);
            btnAddPatient.TabIndex = 0;
            btnAddPatient.Text = "Add New Patient Record";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // btnAddDiagnosis
            // 
            btnAddDiagnosis.BackColor = SystemColors.ActiveCaption;
            btnAddDiagnosis.Location = new Point(57, 131);
            btnAddDiagnosis.Name = "btnAddDiagnosis";
            btnAddDiagnosis.Size = new Size(177, 37);
            btnAddDiagnosis.TabIndex = 1;
            btnAddDiagnosis.Text = "Add Diagnosis Information";
            btnAddDiagnosis.UseVisualStyleBackColor = false;
            btnAddDiagnosis.Click += btnAddDiagnosis_Click;
            // 
            // btnFullHistory
            // 
            btnFullHistory.BackColor = SystemColors.ActiveCaption;
            btnFullHistory.Location = new Point(57, 192);
            btnFullHistory.Name = "btnFullHistory";
            btnFullHistory.Size = new Size(177, 37);
            btnFullHistory.TabIndex = 2;
            btnFullHistory.Text = "Full History of the Patient";
            btnFullHistory.UseVisualStyleBackColor = false;
            btnFullHistory.Click += btnFullHistory_Click;
            // 
            // btnHospital
            // 
            btnHospital.BackColor = SystemColors.ActiveCaption;
            btnHospital.Location = new Point(57, 254);
            btnHospital.Name = "btnHospital";
            btnHospital.Size = new Size(177, 37);
            btnHospital.TabIndex = 3;
            btnHospital.Text = "Hospital Information";
            btnHospital.UseVisualStyleBackColor = false;
            btnHospital.Click += btnHospital_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 25);
            label1.Name = "label1";
            label1.Size = new Size(142, 26);
            label1.TabIndex = 4;
            label1.Text = "CONTROLER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(261, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(612, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(383, 25);
            label2.Name = "label2";
            label2.Size = new Size(402, 38);
            label2.TabIndex = 6;
            label2.Text = "Hospital Management System";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(103, 320);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 36);
            btnExit.TabIndex = 7;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // labelIndecator1
            // 
            labelIndecator1.AutoSize = true;
            labelIndecator1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold);
            labelIndecator1.Location = new Point(2, 68);
            labelIndecator1.Name = "labelIndecator1";
            labelIndecator1.Size = new Size(49, 38);
            labelIndecator1.TabIndex = 8;
            labelIndecator1.Text = ">>";
            // 
            // labelIndecator2
            // 
            labelIndecator2.AutoSize = true;
            labelIndecator2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold);
            labelIndecator2.Location = new Point(1, 132);
            labelIndecator2.Name = "labelIndecator2";
            labelIndecator2.Size = new Size(49, 38);
            labelIndecator2.TabIndex = 9;
            labelIndecator2.Text = ">>";
            // 
            // labelIndecator3
            // 
            labelIndecator3.AutoSize = true;
            labelIndecator3.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold);
            labelIndecator3.Location = new Point(2, 193);
            labelIndecator3.Name = "labelIndecator3";
            labelIndecator3.Size = new Size(49, 38);
            labelIndecator3.TabIndex = 10;
            labelIndecator3.Text = ">>";
            // 
            // labelIndecator4
            // 
            labelIndecator4.AutoSize = true;
            labelIndecator4.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold);
            labelIndecator4.Location = new Point(1, 255);
            labelIndecator4.Name = "labelIndecator4";
            labelIndecator4.Size = new Size(49, 38);
            labelIndecator4.TabIndex = 11;
            labelIndecator4.Text = ">>";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboGender);
            panel1.Controls.Add(txtBlood);
            panel1.Controls.Add(txtAny);
            panel1.Controls.Add(txtPid);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(261, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 331);
            panel1.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(263, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9F);
            label10.Location = new Point(308, 100);
            label10.Name = "label10";
            label10.Size = new Size(68, 17);
            label10.TabIndex = 15;
            label10.Text = "Patient ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9F);
            label9.Location = new Point(213, 205);
            label9.Name = "label9";
            label9.Size = new Size(216, 17);
            label9.TabIndex = 14;
            label9.Text = "Any Major Dissease Suffered Earlier";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9F);
            label8.Location = new Point(304, 61);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 13;
            label8.Text = "Blood Group";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9F);
            label7.Location = new Point(318, 19);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F);
            label6.Location = new Point(28, 149);
            label6.Name = "label6";
            label6.Size = new Size(28, 17);
            label6.TabIndex = 11;
            label6.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F);
            label5.Location = new Point(17, 106);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 10;
            label5.Text = "Contact ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F);
            label4.Location = new Point(14, 64);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F);
            label3.Location = new Point(20, 18);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female" });
            comboGender.Location = new Point(382, 15);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(216, 23);
            comboGender.TabIndex = 7;
            // 
            // txtBlood
            // 
            txtBlood.Location = new Point(382, 58);
            txtBlood.Name = "txtBlood";
            txtBlood.Size = new Size(216, 23);
            txtBlood.TabIndex = 6;
            // 
            // txtAny
            // 
            txtAny.Location = new Point(28, 237);
            txtAny.Name = "txtAny";
            txtAny.Size = new Size(570, 23);
            txtAny.TabIndex = 5;
            // 
            // txtPid
            // 
            txtPid.Location = new Point(382, 98);
            txtPid.Name = "txtPid";
            txtPid.Size = new Size(216, 23);
            txtPid.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(73, 146);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(216, 23);
            txtAge.TabIndex = 3;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(73, 103);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(216, 23);
            txtContact.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(73, 61);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(216, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(73, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 23);
            txtName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBxWardType);
            panel2.Controls.Add(comboBxWard);
            panel2.Controls.Add(txtBxMedicines);
            panel2.Controls.Add(txtBxDiagonosis);
            panel2.Controls.Add(txtBxSymptoms);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(262, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 331);
            panel2.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(263, 280);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBxWardType
            // 
            comboBxWardType.FormattingEnabled = true;
            comboBxWardType.Items.AddRange(new object[] { "General\t", "Duo ", "Single", "None" });
            comboBxWardType.Location = new Point(439, 208);
            comboBxWardType.Name = "comboBxWardType";
            comboBxWardType.Size = new Size(121, 23);
            comboBxWardType.TabIndex = 12;
            // 
            // comboBxWard
            // 
            comboBxWard.FormattingEnabled = true;
            comboBxWard.Items.AddRange(new object[] { "Yes", "No" });
            comboBxWard.Location = new Point(439, 165);
            comboBxWard.Name = "comboBxWard";
            comboBxWard.Size = new Size(121, 23);
            comboBxWard.TabIndex = 11;
            // 
            // txtBxMedicines
            // 
            txtBxMedicines.Location = new Point(80, 239);
            txtBxMedicines.Name = "txtBxMedicines";
            txtBxMedicines.Size = new Size(100, 23);
            txtBxMedicines.TabIndex = 10;
            // 
            // txtBxDiagonosis
            // 
            txtBxDiagonosis.Location = new Point(80, 202);
            txtBxDiagonosis.Name = "txtBxDiagonosis";
            txtBxDiagonosis.Size = new Size(100, 23);
            txtBxDiagonosis.TabIndex = 9;
            // 
            // txtBxSymptoms
            // 
            txtBxSymptoms.Location = new Point(80, 167);
            txtBxSymptoms.Name = "txtBxSymptoms";
            txtBxSymptoms.Size = new Size(100, 23);
            txtBxSymptoms.TabIndex = 8;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Comic Sans MS", 9F);
            label16.Location = new Point(343, 211);
            label16.Name = "label16";
            label16.Size = new Size(84, 17);
            label16.TabIndex = 7;
            label16.Text = "Type of Ward";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Comic Sans MS", 9F);
            label15.Location = new Point(340, 167);
            label15.Name = "label15";
            label15.Size = new Size(99, 17);
            label15.TabIndex = 6;
            label15.Text = "Ward Required ?";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 9F);
            label14.Location = new Point(6, 242);
            label14.Name = "label14";
            label14.Size = new Size(56, 17);
            label14.TabIndex = 5;
            label14.Text = "Medicine";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 9F);
            label13.Location = new Point(5, 205);
            label13.Name = "label13";
            label13.Size = new Size(61, 17);
            label13.TabIndex = 4;
            label13.Text = "Diagnosis";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 9F);
            label12.Location = new Point(3, 168);
            label12.Name = "label12";
            label12.Size = new Size(67, 17);
            label12.TabIndex = 3;
            label12.Text = "Symptom's";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(580, 65);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 9F);
            label11.Location = new Point(156, 44);
            label11.Name = "label11";
            label11.Size = new Size(24, 17);
            label11.TabIndex = 0;
            label11.Text = "Pid";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView2);
            panel3.Location = new Point(260, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(613, 331);
            panel3.TabIndex = 14;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(18, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(579, 278);
            dataGridView2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(251, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(624, 331);
            panel4.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(585, 297);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(885, 368);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelIndecator4);
            Controls.Add(labelIndecator3);
            Controls.Add(labelIndecator2);
            Controls.Add(labelIndecator1);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnHospital);
            Controls.Add(btnFullHistory);
            Controls.Add(btnAddDiagnosis);
            Controls.Add(btnAddPatient);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPatient;
        private Button btnAddDiagnosis;
        private Button btnFullHistory;
        private Button btnHospital;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnExit;
        private Label labelIndecator1;
        private Label labelIndecator2;
        private Label labelIndecator3;
        private Label labelIndecator4;
        private Panel panel1;
        private Label label3;
        private ComboBox comboGender;
        private TextBox txtBlood;
        private TextBox txtAny;
        private TextBox txtPid;
        private TextBox txtAge;
        private TextBox txtContact;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnSave;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label11;
        private Button button1;
        private ComboBox comboBxWardType;
        private ComboBox comboBxWard;
        private TextBox txtBxMedicines;
        private TextBox txtBxDiagonosis;
        private TextBox txtBxSymptoms;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Panel panel3;
        private DataGridView dataGridView2;
        private Panel panel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}