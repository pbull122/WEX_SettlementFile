using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WEX_SettlementFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                ReadFile(path);
            }
            else
            {
                MessageBox.Show("You have to select a file!");
            }
            
        }

        static void ReadFile(string path) 
        {
            string outFile = @"C:\work\WEXOutFile.csv";
            int count = 0;
            string line, sub;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    using (StreamWriter sw = new StreamWriter(outFile))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            sub = line.Substring(0, 2);
                            if (sub == "02")
                            {
                                count = 0;
                                sw.WriteLine();
                                string x = line.Substring(0, 2);
                                sw.Write(x + ", ");
                                x = line.Substring(2, 15);
                                sw.Write(x + ", ");
                                x = line.Substring(17, 17);
                                sw.Write(x + ", ");
                                x = line.Substring(33, 6);
                                sw.Write(x + ", ");
                                x = line.Substring(39, 16);
                                sw.Write(x + ", ");
                                x = line.Substring(55, 2);
                                sw.Write(x + ", ");
                                x = line.Substring(57, 6);
                                sw.Write(x + ", ");
                                x = line.Substring(63, 8);
                                sw.Write(x + ", ");
                                x = line.Substring(71, 8);
                                sw.Write(x + ", ");
                                x = line.Substring(79, 15);
                                sw.Write(x + ", ");
                                sw.WriteLine();
                                sw.WriteLine("Type, BatchNum, CardNum, Tran Code, Tran Date, Dollars, DET SEQ Num, Card Type, Gallons,  WEX Fee, Product Code, Discount," +
                                    " Manual Flag, Batch Num, WEX Manual Flag, Microfilm Number, Fed Tax, State Tax, Other Tax, Total Tax, Ntwk Mkrt Code, Tran Time, Gross-Net, Price-ADJ");
                            }
                            else if (sub == "03")
                            {

                                string target = line.Substring(0, 2);
                                sw.Write(target + ",");
                                target = line.Substring(2, 5);
                                sw.Write(target + ",");
                                target = line.Substring(7, 19);
                                sw.Write(target + ",");
                                target = line.Substring(26, 2);
                                sw.Write(target + ",");
                                target = line.Substring(28, 8);
                                sw.Write(target + ",");
                                target = line.Substring(36, 9);
                                sw.Write(target + ",");
                                target = line.Substring(45, 10);
                                sw.Write(target + ",");
                                target = line.Substring(64, 4);
                                sw.Write(target + ",");
                                target = line.Substring(68, 9);
                                sw.Write(target + ",");
                                target = line.Substring(77, 7);
                                sw.Write(target + ",");
                                target = line.Substring(84, 2);
                                sw.Write(target + ",");
                                target = line.Substring(90, 7);
                                sw.Write(target + ", ");
                                target = line.Substring(97, 1);
                                sw.Write(target + ", ");
                                target = line.Substring(98, 6);
                                sw.Write(target + ", ");
                                target = line.Substring(104, 1);
                                sw.Write(target + ", ");
                                target = line.Substring(105, 15);
                                sw.Write(target + ", ");
                                target = line.Substring(120, 7);
                                sw.Write(target + ", ");
                                target = line.Substring(127, 7);
                                sw.Write(target + ", ");
                                target = line.Substring(134, 7);
                                sw.Write(target + ", ");
                                target = line.Substring(141, 7);
                                sw.Write(target + ", ");
                                target = line.Substring(148, 3);
                                sw.Write(target + ", ");
                                target = line.Substring(151, 6);
                                sw.Write(target + ", ");
                                target = line.Substring(157, 1);
                                sw.Write(target+ ", ");
                                target = line.Substring(158, 7);
                                sw.Write(target);
                                sw.WriteLine();
                            }
                            /* sw.WriteLine("Summ Type, Summ Merch No, Summ Gross Sales, Summ Trans Count, Summ Trans Total, Summ Trans WEX Fee, Summ Chbk WEX Fee," +
                                 " Summ Chbk Count, Summ Chbk Total, Summ Net Sales, Summ Total WEX Fee, Summ Tot Gallons Units, Merch Summ Tot Discount, Merch Summ Fed Tax, Merch Summ State Tax,  Merch Summ Other Tax," +
                                 "Merch Summ Total Tax");*/
                            if (sub == "07" || sub == "08" || sub == "09" || sub == "10")
                            {

                                if (count < 1)
                                {
                                    sw.WriteLine();
                                    sw.WriteLine("Summ Type, Summ Merch No, Summ Gross Sales, Summ Trans Count, Summ Trans Total, Summ Trans WEX Fee, Summ Chbk WEX Fee," +
                                " Summ Chbk Count, Summ Chbk Total, Summ Net Sales, Summ Total WEX Fee, Summ Tot Gallons Units, Merch Summ Tot Discount, Merch Summ Fed Tax, Merch Summ State Tax,  Merch Summ Other Tax," +
                                "Merch Summ Total Tax");
                                }

                                string t2 = line.Substring(0, 2);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(3, 15);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(17, 13);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(30, 10);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(40, 13);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(53, 11);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(64, 11);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(75, 10);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(85, 13);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(98, 13);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(111, 11);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(122, 12);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(134, 11);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(145, 11);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(156, 11);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(167, 11);
                                sw.Write(t2 + ", ");
                                t2 = line.Substring(178, 11);
                                sw.Write(t2);
                                sw.WriteLine();

                                count++;

                            }
                        }
                        sw.WriteLine();

                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                        sfd.FilterIndex = 2;
                        sfd.RestoreDirectory = true;
                        

                        sw.Dispose();
                        sw.Close();
                    }
                    sr.Close();
                    sr.Dispose();
                }
                

                MessageBox.Show("Your file has been delivered to " + outFile);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has Occured: " + ex.Message);
            }

            

            Application.Exit();

        }
    }
}
