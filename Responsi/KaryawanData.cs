using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    internal class KaryawanData : Karyawan
    {
        private const string conn = "Host=localhost; Port=5432; Username=postgres; Password=steven; database=responsi mahsa";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
    }
}
