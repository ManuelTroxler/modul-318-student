using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektM318
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgverbindungen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dgverbindungen.Rows.Clear();
            SwissTransport.Transport connection = new SwissTransport.Transport();
            var connect = connection.GetConnections(txtvon.Text, txtbis.Text);
            foreach(var conn in connect.ConnectionList)
            {
                //dgverbindungen.Rows.Add(); conn.From.Departure
                DataGridViewRow row = (DataGridViewRow) dgverbindungen.Rows[0].Clone();
                row.Cells[0].Value = txtvon.Text;
                row.Cells[1].Value = DateTime.Parse(conn.From.Departure).ToString("HH:mm");
                row.Cells[1].Value = row.Cells[1].Value + " h";
                row.Cells[2].Value = conn.From.Platform;
                row.Cells[3].Value = txtbis.Text;
                row.Cells[4].Value = DateTime.Parse(conn.To.Arrival).ToString("HH:mm");
                row.Cells[4].Value = row.Cells[4].Value + " h";
                row.Cells[5].Value = conn.To.Platform;
                row.Cells[6].Value = conn.To.Delay;
                dgverbindungen.Rows.Add(row);
            }
        }

        private void btnwechsel_Click(object sender, EventArgs e)
        {
            String change = "";
            change = txtvon.Text;
            txtvon.Text = txtbis.Text;
            txtbis.Text = change;
        }

        private void txtvon_TextChanged(object sender, EventArgs e)
        {
            //lbabfahrt.Visible = true;

        }

        private void txtbis_TextChanged(object sender, EventArgs e)
        {
            //lbankunft.Visible = true;
        }
    }
}
