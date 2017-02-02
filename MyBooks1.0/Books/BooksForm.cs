using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml.Xsl;
using System.Xml;
using System.Xml.XPath;

namespace Books
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();

        }
        DataTable dt = null;
        XDocument xDoc;
        string pathInpXml, pathOutXml, pathHtml;
        int j;
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
        private void OpenXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "xml files (*.xml)|*.xml";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pathInpXml = op.FileName;
                    xDoc = XDocument.Load(op.FileName);
                    dtGr.DataSource = ReadXml(op);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
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

        private void Add_Click(object sender, EventArgs e)
        {
            ((DataTable)dtGr.DataSource).Rows.Add();
        }

        private void Remove_Click(object sender, EventArgs e)
        {

            int delet = dtGr.SelectedCells[0].RowIndex;
            dtGr.Rows.RemoveAt(delet);
        }
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pathOutXml = sfd.FileName;
                    DataTable dT = GetDataTableFromDGV(dtGr);
                    DataSet dS = new DataSet("bookstore");
                    dS.Tables.Add(dT);

                    dS.WriteXml(pathOutXml);

                    MessageBox.Show("Записано");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            j = dtGr.CurrentCell.ColumnIndex;
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (j == 0 || j == 1 || j == 2)
            {
                if (!(Char.IsLetter(e.KeyChar)))
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        MessageBox.Show("Введите строковое значение");
                    }


                }

            }
            if (j == 3)
            {
                {
                    if ((!(Char.IsDigit(e.KeyChar))) && e.KeyChar > 0)
                    {
                        if (e.KeyChar != (char)Keys.Back)
                        { e.Handled = true; }
                        MessageBox.Show("Введите численное значение");
                    }
                }
            }
        }

        private void dtGr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReportHTML_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();


            op.Filter = "html files (*.html)|*.html";


            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pathHtml = op.FileName;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

                XslTransform xslt = new XslTransform();
                xslt.Load("xslinclude.xsl");
                XPathDocument xpathdocument = new
                XPathDocument(pathOutXml);
                StreamWriter sw = new StreamWriter(pathHtml);
                XmlTextWriter writer = new XmlTextWriter(sw);
                writer.Formatting = Formatting.Indented;

                xslt.Transform(xpathdocument, null, writer, null);
                MessageBox.Show("Отчет создан");
            }
        }
    }
}


