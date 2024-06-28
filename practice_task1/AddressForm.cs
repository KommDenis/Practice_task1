using System;
using System.Linq;
using System.Windows.Forms;

namespace practice_task1
{
    public partial class AddressForm : Form
    {
        private readonly CustomNoSqlDb _db;

        public AddressForm()
        {
            InitializeComponent();
            _db = new CustomNoSqlDb("MyDatabase");
            LoadData();
        }

        private void LoadData()
        {
            var addresses = _db.GetAll("addresses").ToList();
            dataGridView1.DataSource = addresses;

            if (!dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns.Add("Id", "Id");
            }
            //dataGridView1.Columns["Id"].Visible = false; // Приховати стовпець Id
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var document = new { Id = Guid.NewGuid(), Street = textBoxStreet.Text, City = textBoxCity.Text };
            _db.Insert(document, "addresses");
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value is Guid id)
                {
                    var document = new { Id = id, Street = textBoxStreet.Text, City = textBoxCity.Text };
                    _db.Update(id, document, "addresses");
                    LoadData();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value is Guid id)
                {
                    _db.Delete(id, "addresses");
                    LoadData();
                }
            }
        }
    }
}
