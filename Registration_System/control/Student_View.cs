using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Registration_System.control
{
    public partial class Student_View : UserControl
    {
        //Database Connection
        public static readonly string con_string = "Data Source=LAPTOP-1JTL956L;Initial Catalog=regDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        public static SqlCommand cmd;
        public Student_View()
        {
            InitializeComponent();
        }

        private void Student_View_Load(object sender, EventArgs e)
        {
            string ser = "Select * from student_information WHERE activity = 'Active'";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewstudent, con_string);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from student_information WHERE activity = 'Active' and stud_name LIKE'%" + txtSearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewstudent, con_string);

            if (comboBoxSearchBy.SelectedIndex == 0)
            {
                string chg0 = "Select * from student_information WHERE activity = 'Active' and stud_id LIKE'%" + txtSearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg0, dataGridViewstudent, con_string);
            }

            if (comboBoxSearchBy.SelectedIndex == 1)
            {
                string chg2 = "Select * from student_information WHERE activity = 'Active' and stud_name LIKE'%" + txtSearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg2, dataGridViewstudent, con_string);
            }

            if (comboBoxSearchBy.SelectedIndex == 2)
            {
                string chg1 = "Select * from student_information WHERE activity = 'Active' and stud_year LIKE'%" + txtSearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg1, dataGridViewstudent, con_string);
            }

            if (comboBoxSearchBy.SelectedIndex == 3)
            {
                string chg2 = "Select * from student_information WHERE activity = 'Active' and stud_subject LIKE'%" + txtSearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg2, dataGridViewstudent, con_string);
            }


        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string ser = "Select * from student_information WHERE activity = 'Inactive'";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewstudent, con_string);
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            string ser1 = "Select * from student_information WHERE activity = 'Active'";
            Attendance.Attendance.DisplayAndSearchAllData(ser1, dataGridViewstudent, con_string);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewstudent.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf"; // Corrected filter format
                save.FileName = "Student List.pdf"; // Specify the default file name

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }

                    if (!ErrorMessage)
                    {
                        try
                        {
                            // Create a new document and set margins
                            Document document = new Document(PageSize.A4_LANDSCAPE, 20f, 20f, 20f, 20f);
                            
                            // Create a PdfWriter instance
                            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(save.FileName, FileMode.Create));

                            // Open the document
                            document.Open();

                            // Create a PdfPTable with the same number of columns as the DataGridView
                            PdfPTable pTable = new PdfPTable(dataGridViewstudent.Columns.Count);
                            pTable.DefaultCell.Padding = 4;
                            pTable.WidthPercentage = 120;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Add DataGridView headers to the PDF table
                            foreach (DataGridViewColumn col in dataGridViewstudent.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }

                            // Add DataGridView rows to the PDF table
                            foreach (DataGridViewRow viewRow in dataGridViewstudent.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value == null ? "" : dcell.Value.ToString()); // Handle null values
                                }
                            }

                            // Add the PDF table to the document
                            document.Add(pTable);

                            // Close the document
                            document.Close();

                            MessageBox.Show("Data Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting data: " + ex.Message, "Error");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No records found!", "Info");
            }
        }
    }
}
