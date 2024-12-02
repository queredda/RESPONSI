using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace responsi
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5432; Username=postgres; Password=steven; database=responsi mahsa";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            LoadData();
        }

        private void LoadData()
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = "select * from karyawan, departemen WHERE karyawan.id_dep = departemen.id_dep;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbDep.Text) || cbDep.SelectedIndex == -1 || string.IsNullOrEmpty(tbNama.Text))
            {
                MessageBox.Show("Silakan lengkapi nama dan departemen terlebih dahulu.");
                return;
            }
            string nama = tbNama.Text;
            string inisial = nama.Length >= 2 ? nama.Substring(0, 2).ToUpper() : nama.ToUpper();
            string id_dep = cbDep.Text;
            string id_karyawan = inisial + "_" + id_dep;
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "SELECT * FROM add_karyawan(@in_id_karyawan, @in_nama, @in_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", id_karyawan);
                cmd.Parameters.AddWithValue("@in_nama", nama);
                cmd.Parameters.AddWithValue("@in_id_dep", id_dep);
                int statusCode = (int)cmd.ExecuteScalar();
                if (statusCode == 201)
                {
                    MessageBox.Show("[201] Created");
                    LoadData();
                    return;
                }
                if (statusCode == 409)
                {
                    throw new Exception("[409] User already exist");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }
            finally { conn.Close(); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dataGridView1.Rows[e.RowIndex];
                tbNama.Text = r.Cells["nama"].Value.ToString();
                cbDep.SelectedItem = r.Cells["id_dep"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tbNama.Text;
                if (r == null)
                {
                    MessageBox.Show("Silakan pilih karyawan terlebih dahulu.");
                    return;
                }
                string id_dep = cbDep.Text;

                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "SELECT * FROM edit_karyawan(@in_id_karyawan, @in_nama, @in_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", r.Cells["id_karyawan"].Value);
                cmd.Parameters.AddWithValue("@in_nama", nama);
                cmd.Parameters.AddWithValue("@in_id_dep", id_dep);
                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 200)
                {
                    MessageBox.Show("[200] Edit success", "Success");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception("[404] karyawan tidak ditemukan");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally { conn.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Silakan pilih karyawan terlebih dahulu.");
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "SELECT * FROM delete_karyawan(@in_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", r.Cells["id_karyawan"].Value);
                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 204)
                {
                    MessageBox.Show("[204] Delete success", "Success");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception("[404] Karyawan tidak ditemukan");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            { conn.Close(); }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
