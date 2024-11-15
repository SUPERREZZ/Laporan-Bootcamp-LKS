using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laporan1
{
    public partial class Form1 : Form
    {
        SekolahDBEntities db = new SekolahDBEntities();
        public Form1()
        {
            InitializeComponent();
            load();
            loadButton();
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == datagridview.Columns["btnUbah"].Index)
            {
                var selectedRow = datagridview.Rows[e.RowIndex];
                int id = (int) selectedRow.Cells["ID"].Value;
                var data = db.Students.FirstOrDefault(d => d.ID == id);
                if (data != null)
                {
                    IDtb.Text = Convert.ToString(data.ID);
                    namatb.Text = data.Nama;
                    sekolahcb.SelectedValue = data.SekolahID;
                    kotacb.SelectedValue = data.KotaID;
                }

            }
            if (e.RowIndex >= 0 && e.ColumnIndex == datagridview.Columns["btnHapus"].Index)
            {
                var selectedRow = datagridview.Rows[e.RowIndex];
                int id = (int)selectedRow.Cells["ID"].Value;
                var data = db.Students.FirstOrDefault(d => d.ID == id);
                if (data != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"Apakah Anda yakin ingin menghapus data siswa dengan nama {data.Nama} ?", 
                        "Konfirmasi",                            
                        MessageBoxButtons.YesNo,                  
                        MessageBoxIcon.Question                   
);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    db.Students.Remove(data);
                    db.SaveChanges();
                    load();
                }
            }
        }
        private void load()
        {
            namatb.Text = "";
            IDtb.Text = "";
            sekolahcb.DataSource = db.Sekolahs.ToList<Sekolah>();
            sekolahcb.DisplayMember = "Nama";
            sekolahcb.ValueMember = "ID";
            sekolahcb.SelectedIndex = -1;

            kotacb.DataSource = db.Kotas.ToList<Kota>();
            kotacb.DisplayMember = "Nama";
            kotacb.ValueMember = "ID";
            kotacb.SelectedIndex = -1;

            datagridview.DataSource = db.Students.ToList<Student>().Select(n => new 
            {
                ID = n.ID,
                Nama = n.Nama,
                Sekolah = n.Sekolah.Nama,
                Kota = n.Kota.Nama,
            }).ToList();
            
        }
        
        private void loadButton()
        {
            DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
            btnUbah.HeaderText = "Edit";
            btnUbah.Name = "btnUbah";
            btnUbah.Text = "Ubah";
            btnUbah.UseColumnTextForButtonValue = true;
            datagridview.Columns.Add(btnUbah);


            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
            btnHapus.HeaderText = "Hapus";
            btnHapus.Name = "btnHapus";
            btnHapus.Text = "Hapus";
            btnHapus.UseColumnTextForButtonValue = true;
            datagridview.Columns.Add(btnHapus);
        }

        private void Simpanbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(namatb.Text) && sekolahcb.Items != null && kotacb.Items != null )
            {
                if (string.IsNullOrWhiteSpace(IDtb.Text))
                {
                    Student student = new Student
                    {
                        Nama = namatb.Text,
                        KotaID = Convert.ToInt32(kotacb.SelectedValue),
                        SekolahID = Convert.ToInt32(sekolahcb.SelectedValue)
                    };
                    db.Students.Add(student);
                }
                else 
                {
                    int id = Convert.ToInt32(IDtb.Text);
                    var check = db.Students.FirstOrDefault(s => s.ID == id );
                    DialogResult result = MessageBox.Show(
                        $"Apakah Anda yakin ingin mengupdate data siswa {check.Nama} dengan  {namatb.Text} ?",
                        "Konfirmasi",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    check.Nama = namatb.Text;
                    check.KotaID = Convert.ToInt32(kotacb.SelectedValue);
                    check.SekolahID = Convert.ToInt32(sekolahcb.SelectedValue);
                }
                db.SaveChanges();
            }
            load();
        }
    }
}
