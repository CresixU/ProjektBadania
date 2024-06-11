namespace ProjektBadania
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            patientBindingSource = new BindingSource(components);
            examinationTypeDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            examinationTypeBindingSource = new BindingSource(components);
            dateOfExaminationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            examinationBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            dataGridView3 = new DataGridView();
            nameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Pesel = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            HouseNumber = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examinationTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examinationBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 402);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 374);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Badania";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, nameDataGridViewTextBoxColumn, patientDataGridViewTextBoxColumn, examinationTypeDataGridViewTextBoxColumn, dateOfExaminationDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = examinationBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(789, 413);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            nameDataGridViewTextBoxColumn.MinimumWidth = 100;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // patientDataGridViewTextBoxColumn
            // 
            patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            patientDataGridViewTextBoxColumn.DataSource = patientBindingSource;
            patientDataGridViewTextBoxColumn.DisplayMember = "Name";
            patientDataGridViewTextBoxColumn.HeaderText = "Pacjęt";
            patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            patientDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            patientDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            patientDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Domain.Entities.Patient);
            // 
            // examinationTypeDataGridViewTextBoxColumn
            // 
            examinationTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            examinationTypeDataGridViewTextBoxColumn.DataPropertyName = "ExaminationType";
            examinationTypeDataGridViewTextBoxColumn.DataSource = examinationTypeBindingSource;
            examinationTypeDataGridViewTextBoxColumn.DisplayMember = "Name";
            examinationTypeDataGridViewTextBoxColumn.HeaderText = "Typ Badania";
            examinationTypeDataGridViewTextBoxColumn.Name = "examinationTypeDataGridViewTextBoxColumn";
            examinationTypeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            examinationTypeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            examinationTypeDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // examinationTypeBindingSource
            // 
            examinationTypeBindingSource.DataSource = typeof(Domain.Entities.ExaminationType);
            // 
            // dateOfExaminationDataGridViewTextBoxColumn
            // 
            dateOfExaminationDataGridViewTextBoxColumn.DataPropertyName = "DateOfExamination";
            dateOfExaminationDataGridViewTextBoxColumn.HeaderText = "Data badania";
            dateOfExaminationDataGridViewTextBoxColumn.Name = "dateOfExaminationDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Opis";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // examinationBindingSource
            // 
            examinationBindingSource.DataSource = typeof(Domain.Entities.Examination);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 374);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pacjęci";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn2, DateOfBirth, Pesel, Country, City, PostalCode, Street, HouseNumber });
            dataGridView3.DataSource = patientBindingSource;
            dataGridView3.Location = new Point(1, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(791, 373);
            dataGridView3.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // DateOfBirth
            // 
            DateOfBirth.DataPropertyName = "DateOfBirth";
            DateOfBirth.HeaderText = "Data urodzenia";
            DateOfBirth.Name = "DateOfBirth";
            // 
            // Pesel
            // 
            Pesel.DataPropertyName = "Pesel";
            Pesel.HeaderText = "PESEL";
            Pesel.Name = "Pesel";
            // 
            // Country
            // 
            Country.DataPropertyName = "Country";
            Country.HeaderText = "Kraj";
            Country.Name = "Country";
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "Miasto";
            City.Name = "City";
            // 
            // PostalCode
            // 
            PostalCode.DataPropertyName = "PostalCode";
            PostalCode.HeaderText = "Kod pocztowy";
            PostalCode.Name = "PostalCode";
            // 
            // Street
            // 
            Street.DataPropertyName = "Street";
            Street.HeaderText = "Ulica";
            Street.Name = "Street";
            // 
            // HouseNumber
            // 
            HouseNumber.DataPropertyName = "HouseNumber";
            HouseNumber.HeaderText = "Numer domu";
            HouseNumber.Name = "HouseNumber";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 374);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Typy badań";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = examinationTypeBindingSource;
            dataGridView2.Location = new Point(1, 1);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(791, 418);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Nazwa Typu Badania";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // button1
            // 
            button1.Location = new Point(664, 409);
            button1.Name = "button1";
            button1.Size = new Size(117, 32);
            button1.TabIndex = 1;
            button1.Text = "Zapisz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)examinationTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)examinationBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private BindingSource examinationBindingSource;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private BindingSource patientBindingSource;
        private DataGridView dataGridView2;
        private BindingSource examinationTypeBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Pesel;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn PostalCode;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn HouseNumber;
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn patientDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn examinationTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfExaminationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}
