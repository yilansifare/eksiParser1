using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using HtmlAgilityPack;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace eksiParser
{
    public partial class Form1 : Form
    {
        sqlite_baglanti sql = new sqlite_baglanti();

        public Form1()
        {
            InitializeComponent();          
            //BackgroundWorker bgw;
        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sql.selectQuery("SELECT * FROM " + comboBox1.Text);
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DataGridViewColumn column = dataGridView1.Columns[2];
                column.Width = 500;
                MessageBox.Show("Listeleme Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
            }

        }


        //public static string dosyaYolu { get; set; }

        public void button_cek_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                
                if (textBox_adres.Text == null || textBox_adres.Text == "" || !textBox_adres.Text.StartsWith("https://eksisozluk.com/"))
                {
                    MessageBox.Show("Bir ekşi sözlük başlık adresi giriniz.");
                }

                else
                {
                    string baslik = textBox_adres.Text.Substring(textBox_adres.Text.LastIndexOf("/"));

                    string tablo_ismi = baslik + "_" + DateTime.Now.ToString();
                    tablo_ismi = tablo_ismi.Replace("/", "");
                    tablo_ismi = tablo_ismi.Replace("-", "_");
                    tablo_ismi = tablo_ismi.Replace(".", "_");
                    tablo_ismi = tablo_ismi.Replace(" ", "_");
                    tablo_ismi = tablo_ismi.Replace(":", "_");
                    tablo_ismi = tablo_ismi.Replace("?", "_");
                    tablo_ismi = tablo_ismi.Replace("=", "_");
                    tablo_ismi = "_" + tablo_ismi;
                    //dosyaYolu = System.IO.Path.Combine(dosyaYolu, dosyaismi);

                    sql.sorguFonk("CREATE TABLE " + tablo_ismi + " ([Id] INTEGER PRIMARY KEY AUTOINCREMENT, [entryID] numeric(0, 0) NULL, [entry] nvarchar(4000) , [yazar] nvarchar(100) NULL, [tarih] nvarchar(100) NULL)");


                    var getHtmlWeb = new HtmlWeb();

                    int id = 1;
                    int idx = 1;
                    int idy = 1;

                    var document1 = getHtmlWeb.Load(textBox_adres.Text);

                    int sayfaSayisi = 1;
                    HtmlNode sayfa = document1.DocumentNode.SelectSingleNode("//div//@data-pagecount");
                    if(sayfa != null)
                    sayfaSayisi = Int32.Parse(sayfa.GetAttributeValue("data-pagecount", ""));
                    


                    progressBar1.Visible = true;
                    progressBar1.Minimum = 1;
                    progressBar1.Maximum = sayfaSayisi;
                    progressBar1.Value = 1;
                    progressBar1.Step = 1;

                    for (int a = 1; a <= sayfaSayisi; a++)
                    {

                        var document = getHtmlWeb.Load(textBox_adres.Text + "?p=" + a);

                        foreach (HtmlAgilityPack.HtmlNode dataid in document.DocumentNode.SelectNodes("//li//@data-id"))
                        {
                            var entryID = dataid.GetAttributeValue("data-id", "");
                            sql.sorguFonk("INSERT INTO " + tablo_ismi + " (entryID) VALUES ('" + Int32.Parse(entryID) + "')");
                            var yazar = dataid.GetAttributeValue("data-author", "");
                            sql.sorguFonk("UPDATE " + tablo_ismi + " SET yazar= '" + yazar + "' WHERE Id='" + id + "'");
                            id++;
                        }

                        foreach (HtmlAgilityPack.HtmlNode entry in document.DocumentNode.SelectNodes("//ul[contains(@id,'entry-list')]//div[contains(@class,'content')]"))
                        {
                            //string entryx = entry.InnerText;"
                            entry.InnerHtml = entry.InnerHtml.Replace("<br>", "{1}");
                            var entryx = entry.InnerText.Replace("{1}", "<br>");
                            entryx = entryx.Replace("'", " ");
                            entryx = entryx.Replace("<br>", "\n");
                            sql.sorguFonk("UPDATE " + tablo_ismi + " SET entry= '" + entryx + "' WHERE Id='" + idx + "'");
                            idx++;
                        }

                        foreach (HtmlAgilityPack.HtmlNode tarih in document.DocumentNode.SelectNodes("//ul[contains(@id,'entry-list')]//a[contains(@class,'entry-date permalink')]"))
                        {
                            string tarihx = tarih.InnerText;
                            sql.sorguFonk("UPDATE " + tablo_ismi + " SET tarih= '" + tarihx + "' WHERE Id='" + idy + "'");
                            idy++;
                        }
                        progressBar1.PerformStep();
                    }
                    
                    MessageBox.Show("Entryler başarıyla çekildi.");
                    id = 1;
                    idx = 1;
                    idy = 1;
                    kombo();
                }
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kombo();
        }

        public void kombo()
        {
            try
            {
                DataTable dt = sql.selectQuery("SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY 1");
                List<string> my_list = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    string tablename = (string)row[0];
                    my_list.Add(tablename);
                }
                comboBox1.DataSource = my_list;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());

            }
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = comboBox1.Text;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Copy DataGridView results to clipboard
                    copyAlltoClipboard();

                    object misValue = System.Reflection.Missing.Value;
                    Excel.Application xlexcel = new Excel.Application();

                    xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                    Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                    // Paste clipboard results to worksheet range
                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                    // Delete blank column A and select cell A1
                    Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                    delRng.Delete(Type.Missing);
                    xlWorkSheet.get_Range("A1").Select();

                    // Save the excel file under the captured location from the SaveFileDialog
                    xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlexcel.DisplayAlerts = true;
                    xlWorkBook.Close(true, misValue, misValue);
                    xlexcel.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlexcel);

                    // Clear Clipboard and DataGridView selection
                    Clipboard.Clear();
                    dataGridView1.ClearSelection();

                    // Open the newly saved excel file
                    if (File.Exists(sfd.FileName))
                        System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
            catch (Exception ex)
            {               
                MessageBox.Show("Hata: " + ex.ToString());
            }

        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Hata " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button_xml_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML Documents (*.xml)|*.xml";
                sfd.FileName = comboBox1.Text;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var table = dataGridView1.DataSource as DataTable;
                    table.TableName = "Tablo";
                    var view = table.DefaultView;
                    view.ToTable().WriteXml(sfd.FileName);
                    if (File.Exists(sfd.FileName))
                        System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
            catch (Exception ex)
            {               
                MessageBox.Show("Hata " + ex.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("https://eksisozluk.com/biri/yilansi-fare");
            System.Diagnostics.Process.Start(sInfo);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("https://eksisozluk.com/biri/yilansi-fare");
            System.Diagnostics.Process.Start(sInfo);

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("https://eksisozluk.com/ek%C5%9Fi%20s%C3%B6zl%C3%BCk%20ba%C5%9Fl%C4%B1k%20yedekleyici");
            System.Diagnostics.Process.Start(sInfo);
        
        }
    }
}
