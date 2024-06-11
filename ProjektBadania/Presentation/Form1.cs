using Microsoft.EntityFrameworkCore;
using ProjektBadania.Domain.Entities;
using ProjektBadania.Infrastructure;
using System.ComponentModel;

namespace ProjektBadania
{
    public partial class Form1 : Form
    {
        private readonly ExaminationsContext _dbContext;

        public Form1(ExaminationsContext context)
        {
            InitializeComponent();
            _dbContext = context;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();

            _dbContext.ExaminationTypes.Load();
            _dbContext.Patients.Load();
            _dbContext.Examinations.Load();

            examinationTypeBindingSource.DataSource = _dbContext.ExaminationTypes.Local.ToBindingList();
            patientBindingSource.DataSource = _dbContext.Patients.Local.ToBindingList();
            examinationBindingSource.DataSource = _dbContext.Examinations.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _dbContext.Dispose();
            //this._dbContext = nameof;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dbContext.SaveChanges();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            dataGridView3.Refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.Cancel = true;
            e.ThrowException = true;
        }
    }
}
