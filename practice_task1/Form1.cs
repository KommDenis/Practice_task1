using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace practice_task1
{
    public partial class Form1 : Form
    {
        private readonly CustomNoSqlDb _db;

        public Form1()
        {
            InitializeComponent();
            _db = new CustomNoSqlDb("MyDatabase");
            LoadData();
        }

        private void LoadData()
        {
            var people = _db.GetAll("people").ToList();
            var peopleWithGuid = people.Select(p => new { Id = Guid.Parse(p.Id.ToString()), Name = p.Name, Age = p.Age, AddressIds = p.AddressIds }).ToList();
            dataGridView1.DataSource = peopleWithGuid;

            if (!dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns.Add("Id", "Id");
            }
            dataGridView1.Columns["Id"].Visible = false; // Приховати стовпець Id
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var document = new { Id = Guid.NewGuid(), Name = textBoxName.Text, Age = int.Parse(textBoxAge.Text), AddressIds = new List<Guid>() };
            _db.Insert(document, "people");
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value is Guid id)
                {
                    var document = new { Id = id, Name = textBoxName.Text, Age = int.Parse(textBoxAge.Text), AddressIds = selectedRow.Cells["AddressIds"].Value };
                    _db.Update(id, document, "people");
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
                    _db.Delete(id, "people");
                    LoadData();
                }
            }
        }

        private void buttonOpenAddresses_Click(object sender, EventArgs e)
        {
            var addressForm = new AddressForm();
            addressForm.Show();
        }

        private void buttonLinkAddress_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && Guid.TryParse(textBoxAddressId.Text, out Guid addressId))
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value is Guid id)
                {
                    var person = _db.GetById<dynamic>(id, "people");
                    if (person.AddressIds == null)
                    {
                        person.AddressIds = new List<Guid>();
                    }
                    person.AddressIds.Add(addressId);
                    _db.Update(id, person, "people");
                    LoadData();
                }
            }
        }
    }
}
