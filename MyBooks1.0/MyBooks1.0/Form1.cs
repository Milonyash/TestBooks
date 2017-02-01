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
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace MyBooks1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = null;
        XDocument xDoc;
        string name, name1;
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }

            }

            dt.TableName = "book";
            dt.Columns[0].ColumnName = "title";
            dt.Columns[1].ColumnName = "autor";
            dt.Columns[2].ColumnName = "category";
            dt.Columns[3].ColumnName = "price";
            //dt.Columns[4].ColumnName = "year";
            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }
        private void SaveXML_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ПК\Desktop\data.xml";
            DataTable dT = GetDataTableFromDGV(dtGr);
            DataSet dS = new DataSet("bookstore");
            dS.Tables.Add(dT);

            dS.WriteXml(path);

            MessageBox.Show("Записано");
        }

        private void ReportXML_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string path = @"C:\Users\ПК\Desktop\data.xml";

            openFileDialog1.Filter = "html files (*.html)|*.html";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            name1 = openFileDialog1.FileName;


                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                myStream.Close();
                XslTransform xslt = new XslTransform();
                xslt.Load("xslinclude.xsl");
                XPathDocument xpathdocument = new
                XPathDocument(path);
                StreamWriter sw = new StreamWriter(name1);
                XmlTextWriter writer = new XmlTextWriter(sw);
                writer.Formatting = Formatting.Indented;

                xslt.Transform(xpathdocument, null, writer, null);
                MessageBox.Show("Отчет создан");
            }
        }
        private DataTable ReadXml(OpenFileDialog op)
        {
            try
            {
                XDocument xDoc = XDocument.Load(op.FileName);
                dt = CreateTable();
                DataRow newRow = null;

                foreach (XElement elm in xDoc.Element("bookstore").Elements("book"))
                {
                    newRow = dt.NewRow();
                    XAttribute nameAttribute = elm.Attribute("category");
                    XElement bookAttribute = elm.Element("title");
                    XElement autorElement = elm.Element("author");
                    XElement priceElement = elm.Element("price");
                    if (nameAttribute != null && autorElement != null && priceElement != null)
                    {
                        dt.Rows.Add(bookAttribute.Value, autorElement.Value, nameAttribute.Value, priceElement.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        private DataTable CreateTable()
        {
            DataTable dt = new DataTable("Books");
            DataColumn colBook = new DataColumn("Книга", typeof(string));
            DataColumn colAutor = new DataColumn("Автор", typeof(string));
            DataColumn colCategory = new DataColumn("Категория", typeof(string));
            DataColumn colPrice = new DataColumn("Цена", typeof(string));

            dt.Columns.Add(colBook);
            dt.Columns.Add(colAutor);
            dt.Columns.Add(colCategory);
            dt.Columns.Add(colPrice);


            return dt;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int delet = dtGr.SelectedCells[0].RowIndex;
            dtGr.Rows.RemoveAt(delet);
        }

        private void OpenXML_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "xml files (*.xml)|*.xml";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                          name = openFileDialog1.FileName;
                          xDoc = XDocument.Load(openFileDialog1.FileName);
                          dtGr.DataSource = ReadXml(openFileDialog1);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
