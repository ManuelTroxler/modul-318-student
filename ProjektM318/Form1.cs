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
        bool changed = true;
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
                abfahrtsstation.Visible = true;
                abfahrtszeit.Visible = true;
                abfahrtszone.Visible = true;
                ankunftsstation.Visible = true;
                ankunftszeit.Visible = true;
                ankunftszone.Visible = true;
                verspätung.Visible = true;
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
            changed = false;
            String change = "";
            change = txtvon.Text;
            txtvon.Text = txtbis.Text;
            txtbis.Text = change;
            lbankunft.Visible = false;
            lbabfahrt.Visible = false;
            changed = true;
        }

        private void txtvon_TextChanged(object sender, EventArgs e)
        {
            if (changed == true)
            {
                lbabfahrt.Items.Clear();
                lbabfahrt.Visible = true;
                SwissTransport.Transport stationquery = new SwissTransport.Transport();
                var station = stationquery.GetStations(txtvon.Text);
                foreach (var stat in station.StationList)
                {
                    lbabfahrt.Items.Add(stat.Name);
                }
            }
        }

        private void txtbis_TextChanged(object sender, EventArgs e)
        {
            if (changed == true)
            {
                lbankunft.Items.Clear();
                lbankunft.Visible = true;
                SwissTransport.Transport stationquery = new SwissTransport.Transport();
                var station = stationquery.GetStations(txtbis.Text);
                foreach (var stat in station.StationList)
                {
                    lbankunft.Items.Add(stat.Name);
                }
            }
        }

        private void btnhaltestellesearch_Click(object sender, EventArgs e)
        {
            dgverbindungen.Rows.Clear();
            SwissTransport.Transport stationboard = new SwissTransport.Transport();
            var station = stationboard.GetStationBoard(txthaltestelle.Text);
            foreach (var stat in station.Entries)
            {
                DataGridViewRow row = (DataGridViewRow) dgverbindungen.Rows[0].Clone();
                row.Cells[0].Value = txthaltestelle.Text;
                row.Cells[1].Value = stat.Stop.Departure.ToShortTimeString();
                row.Cells[1].Value = row.Cells[1].Value + " h";
                row.Cells[2].Value = stat.Stop.Platform;
                ankunftsstation.Visible = false;
                ankunftszeit.Visible = false;
                ankunftszone.Visible = false;
                verspätung.Visible = false;
                dgverbindungen.Rows.Add(row);
            }
        }

        private void txthaltestelle_TextChanged(object sender, EventArgs e)
        {
            lbhaltestelle.Items.Clear();
            lbhaltestelle.Visible = true;
            //lbhaltestelle.
            SwissTransport.Transport stationquery = new SwissTransport.Transport();
            var station = stationquery.GetStations(txthaltestelle.Text);
            foreach (var stat in station.StationList)
            {
                lbhaltestelle.Items.Add(stat.Name);
            }
        }

        private void txtvon_Leave(object sender, EventArgs e)
        {
            //lbabfahrt.Visible = false;
        }

        private void txtbis_Leave(object sender, EventArgs e)
        {
            //lbankunft.Visible = false;
        }

        private void txthaltestelle_Leave(object sender, EventArgs e)
        {
            //lbhaltestelle.Visible = false;
        }

        private void lbabfahrt_Enter(object sender, EventArgs e)
        {
            lbabfahrt.Visible = true;
        }

        private void lbabfahrt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = lbabfahrt.SelectedItem.ToString();
            txtvon.Text = selected;
            lbabfahrt.Visible = false;
        }

        private void lbhaltestelle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = lbhaltestelle.SelectedItem.ToString();
            txthaltestelle.Text = selected;
            lbhaltestelle.Visible = false;
        }

        private void lbankunft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = lbankunft.SelectedItem.ToString();
            txtbis.Text = selected;
            lbankunft.Visible = false;
        }

        private void btnvonmap_Click(object sender, EventArgs e)
        {
            string map = "https://www.google.ch/maps/place/" + txtvon.Text;
            System.Diagnostics.Process.Start(map);
        }

        private void btnbismap_Click(object sender, EventArgs e)
        {
            string map = "https://www.google.ch/maps/place/" + txtbis.Text;
            System.Diagnostics.Process.Start(map);
        }

        private void btnhaltestellemap_Click(object sender, EventArgs e)
        {
            string map = "https://www.google.ch/maps/place/" + txthaltestelle.Text;
            System.Diagnostics.Process.Start(map);
        }
    }
}
