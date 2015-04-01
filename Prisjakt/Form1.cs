using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace Prisjakt
{
    public partial class MainForm : Form
    {
        private Database database;

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            UpdateGroups();
            PrintLastUpdated();
            this.FormClosing += MainForm_FormClosing;
        }

        private void UpdateGroups()
        {
            comboBoxGroups.Items.Clear();
            comboBoxArticle.Items.Clear();

            foreach (string group in database.GetGroups())
                comboBoxGroups.Items.Add(group);
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxArticle.Items.Clear();

            foreach (Article article in database.GetArticles(comboBoxGroups.SelectedItem.ToString()))
                comboBoxArticle.Items.Add(article.GetName());
        }

        private void comboBoxArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Article article = database.GetArticle(comboBoxGroups.SelectedItem.ToString(), comboBoxArticle.SelectedItem.ToString());

            textBoxName.Text = article.GetName();
            textBoxID.Text = article.GetID().ToString();
            textBoxCategoryID.Text = article.GetCategoryID().ToString();
            textBoxGroup.Text = comboBoxGroups.SelectedItem.ToString();
            textBoxRank.Text = article.GetRank().ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int ID = 0;
            long categoryID = 0;
            if (!textBoxID.Text.Equals(""))
                ID = int.Parse(textBoxID.Text);
            if (!textBoxCategoryID.Text.Equals(""))
                categoryID = long.Parse(textBoxCategoryID.Text);
                
            database.AddArticle(textBoxGroup.Text, ID, categoryID, textBoxName.Text, int.Parse(textBoxRank.Text));
            
            textBoxID.ResetText(); textBoxCategoryID.ResetText(); textBoxName.ResetText();
            UpdateGroups();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Article article = database.GetArticle(textBoxGroup.Text, textBoxName.Text);

            article.EditArticle(int.Parse(textBoxID.Text), long.Parse(textBoxCategoryID.Text),
                                textBoxName.Text, int.Parse(textBoxRank.Text));
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            database.RemoveArticle(comboBoxGroups.SelectedItem.ToString(),
                                   comboBoxArticle.SelectedItem.ToString());

            UpdateGroups();
        }

        private void buttonUpdatePrices_Click(object sender, EventArgs e)
        {
            int updated = UpdateAllPrices();
            MessageBox.Show(updated + " articles updated.");

            if (updated != 0)
            {
                database.SetLastUpdated(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                PrintLastUpdated();
            }
        }        
        
        // Updates the price of an article to its currently lowest price
        private void UpdatePrice(Article article)
        {
            int price = 0;
            // TEMP FIX
            if (article.GetID() != -1)
            {
                if (article.GetID() != 0)
                    price = GetLowestPrice(article.GetID());
                else price = GetLowestPrice(article.GetCategoryID());
            }

            article.UpdatePrice(price);
        }

        // Fetches and returns the lowest price of an article
        public int GetLowestPrice(int ID)
        {
            string webContents = GetPageSource("http://www.prisjakt.nu/produkt.php?p=" + ID);
            string expr = "class=\"pris\" >(.+):-<";            
            string match = MatchExpr(expr, webContents);

            if (match.Equals(""))
                return -1;

            int index = match.IndexOf('&');
            if (index != -1)
                match = match.Remove(index, 6);
            
            return int.Parse(match);
        }

        // Fetches and returns the lowest price of all articles within the specified category
        public int GetLowestPrice(long categoryID)
        {
            string webContents = GetPageSource("http://www.prisjakt.nu/kategori.php?l=s" + categoryID + "&o=produkt_pris_inkmoms");
            string expr = "expansion_data\\['prod'\\]\\['data'\\] = {\"\\d+\":\\[\"\\d+\",\"\\d+\",\"\\d+\\.\\d+\",\"\\d+\",\"\\d+\\.\\d+\",\"\\d+\",\"(\\d+)\\.\\d+\"]";
            string match = MatchExpr(expr, webContents);

            if (match.Equals(""))
                return -1;

            return int.Parse(match);
        }

        // Updates the price on every article
        private int UpdateAllPrices()
        {
            progressBar.Value = 0;
            progressBar.Maximum = database.GetNrArticles();
            progressBar.Visible = true;

            foreach (string group in database.GetGroups())
            {
                foreach (Article article in database.GetArticles(group))
                {
                    UpdatePrice(article);
                    progressBar.Value++;
                }
            }

            progressBar.Visible = false;
            return progressBar.Value;
        }     
        
        // Prints the last update
        private void PrintLastUpdated()
        {
            labelLastUpdated.Text = "Last updated:\n" + database.GetLastUpdated();
        }
        
        // Returns the page source as a string
        private string GetPageSource(string URL)
        {
            WebClient webClient = new WebClient();
            string strSource = webClient.DownloadString(URL);
            webClient.Dispose();

            return strSource;
        }    
        
        // Matches an expression and returns if successful
        private string MatchExpr(string expr, string text)
        {
            Match m = Regex.Match(text, expr);

            if (m.Success)
                return m.Groups[1].Value;
            else
            {
                Console.WriteLine("No match!");
                return "";
            }
        }    
        
        // Saves data to disk
        private void SaveData()
        {
            Stream stream = File.Open("prisjakt.dat", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            bformatter.Serialize(stream, database);
            stream.Close();
        }
        
        // Loads data from disk
        private void LoadData()
        {
            try
            {
                Stream stream = File.Open("prisjakt.dat", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();

                database = (Database) bformatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                database = new Database();
            }
        }

        // Exports data to Excel
        private void ExportToExcel()
        {
            try
            {
                Excel.Application oXL;
                Excel._Workbook oWB;
                Excel._Worksheet oSheet;

                oXL = new Excel.Application();
                oXL.DisplayAlerts = false;

                oWB = (Excel._Workbook) oXL.Workbooks.Add(Missing.Value);
                oSheet = (Excel._Worksheet) oWB.ActiveSheet;
                
                int row = 1;

                foreach (string group in database.GetGroups())
                {
                    oSheet.Cells[row, 1].Font.Bold = true;
                    oSheet.Cells[row++, 1] = group;
                    Excel.Range oRng = oSheet.get_Range("A" + row, "D" + (row + (database.GetArticles(group).Count - 1)));

                    foreach (Article article in database.GetArticles(group))
                    {
                        oSheet.Cells[row, 1] = article.GetName();
                        // TEMP FIX
                        if (article.GetPrice() != 0)
                        {
                            int priceDifference = article.GetPrice() - article.GetPreviousPrice();
                            oSheet.Cells[row, 2] = article.GetPrice();
                            oSheet.Cells[row, 3] = priceDifference;
                            if (priceDifference < 0)
                            {
                                oSheet.Cells[row, 2].Interior.Color = Color.Green;
                                oSheet.Cells[row, 3].Interior.Color = Color.Green;
                            }
                            else if (priceDifference > 0)
                            {
                                oSheet.Cells[row, 2].Interior.Color = Color.Red;
                                oSheet.Cells[row, 3].Interior.Color = Color.Red;
                            }
                            else
                            {
                                oSheet.Cells[row, 2].Interior.Color = Color.Yellow;
                                oSheet.Cells[row, 3].Interior.Color = Color.Yellow;
                            }
                        }
                        if (article.GetRank() != 0)
                            oSheet.Cells[row, 4] = article.GetRank();
                        row++;
                    }                    

                    oRng.Sort(oRng.Columns[4, Type.Missing], Excel.XlSortOrder.xlAscending,
                        oRng.Columns[2, Type.Missing], Type.Missing, Excel.XlSortOrder.xlAscending,
                        Type.Missing, Excel.XlSortOrder.xlAscending,
                        Excel.XlYesNoGuess.xlNo, Type.Missing, Type.Missing,
                        Excel.XlSortOrientation.xlSortColumns, Excel.XlSortMethod.xlPinYin,
                        Excel.XlSortDataOption.xlSortNormal, Excel.XlSortDataOption.xlSortNormal,
                        Excel.XlSortDataOption.xlSortNormal);

                    row++;
                }

                oSheet.Rows.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                oSheet.Columns.AutoFit();

                if (Directory.GetCurrentDirectory().EndsWith(@"\"))
                    oWB.SaveAs("prisjakt.xls", Excel.XlFileFormat.xlWorkbookNormal, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Excel.XlSaveAsAccessMode.xlExclusive, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                else oWB.SaveAs(Directory.GetCurrentDirectory() + @"\prisjakt.xls", Excel.XlFileFormat.xlWorkbookNormal, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Excel.XlSaveAsAccessMode.xlExclusive, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
  
                oWB.Close(true);
                oXL.Quit();               
            }
            catch (Exception e)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, e.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, e.Source);

                System.Console.WriteLine(errorMessage, "Error");
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
