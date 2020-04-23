using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csv_tester
{
    public partial class CSVWriter : Form
    {
        private StringBuilder Data;
        private string FilePath = "C:\\Users\\3D Infotech.3DCA-LY520-12\\Desktop\\features.csv";
        public CSVWriter()
        {
            InitializeComponent();
            Data = new StringBuilder();
        }

        private void AddField_Click(object sender, EventArgs e)
        {
            CaptureInput();
            ItemNumber.Text = "";
            ItemDesc.Text = "";
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            txt.Text = Data.ToString();
        }

        private void CaptureInput()
        {
            Data.AppendLine(ItemNumber.Text + "," + ItemDesc.Text);
        }

        private void WriteToCSV_Click(object sender, EventArgs e)
        {
            File.AppendAllText(FilePath, Data.ToString());
            Clear();
            MessageBox.Show("Written to CSV!");
        }

        private void Clear()
        {
            txt.Text = "";
            Data.Clear();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            MessageBox.Show("Not implemented yet!");

        }
    }
}
