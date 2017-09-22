using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminLteWebformGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSource_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) txtSource.SelectAll();
            if (e.KeyCode == Keys.Enter)
            {
                if (chkEnableAutoGenWB.Checked)
                {
                    GenWebForm();
                }

            }
        }

        private void GenWebForm()
        {

            var source = txtSource.Lines;

            if (source != null)
            {
                source = source.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                var res = "";
                if (source != null)
                {

                    foreach (var s in source)
                    {

                        try
                        {
                            if (!s.Contains(";"))
                            {
                                if (s.Trim().ToLower() == "hr")
                                {
                                    res += File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "template" + Path.DirectorySeparatorChar + "wbhr.txt");
                                    continue;

                                }
                            }

                            var c = s.Split(';');

                            if (c.Length < 3)
                            {

                                continue;
                            }
                            else
                            {
                                string ts = "";

                                if (c[2].ToLower().Trim() == "tb")
                                {
                                    ts = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "template" + Path.DirectorySeparatorChar + "wbtb.txt");

                                    if (c.Length >= 7)
                                    {
                                        ts = ts.Replace("{TYPE}", "type=\"" + c[6].Trim().ToLower() + "\"");
                                    }
                                    else
                                    {
                                        ts = ts.Replace("{TYPE}", "");
                                    }

                                    if (c.Length >= 8)
                                    {
                                        if (c[7].Trim() == "*")
                                        {
                                            ts = ts.Replace("{REQ}", "required");
                                        }
                                        else {
                                             ts = ts.Replace("{REQ}", "");
                                        }
                                    }
                                    else
                                    {
                                        ts = ts.Replace("{REQ}", "");
                                    }
                                }

                                if (c[2].ToLower().Trim() == "ta")
                                {
                                    ts = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "template" + Path.DirectorySeparatorChar + "wbta.txt");
                                }
                                if (c[2].ToLower().Trim() == "ddl")
                                {
                                    ts = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "template" + Path.DirectorySeparatorChar + "wbddl.txt");
                                }
                                if (c[2].ToLower().Trim() == "btn")
                                {
                                    ts = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "template" + Path.DirectorySeparatorChar + "wbbtn.txt");
                                }
                                ts = ts.Replace("{CID}", c[0].Trim());
                                ts = ts.Replace("{EID}", System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(c[1].Trim().ToLower()));
                                var lt = 12;
                                var xs = 12;

                                if (c.Length >= 4)
                                {
                                    int.TryParse(c[3], out lt);

                                }
                                ts = ts.Replace("{LG}", lt + "");

                                if (c.Length >= 5)
                                {
                                    int.TryParse(c[4], out xs);

                                }
                                ts = ts.Replace("{XS}", xs + "");

                                if (c.Length >= 6)
                                {
                                    ts = ts.Replace("{PH}", c[5]);
                                }
                                else
                                {
                                    ts = ts.Replace("{PH}", "");
                                }

                                res += ts;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            continue;
                        }
                    }
                }

                string c1 = "", c2 = "";
                if (chkIncludeContainer.Checked)
                {
                    c1 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "template" + Path.DirectorySeparatorChar + "wbc1.txt");
                    c2 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "template" + Path.DirectorySeparatorChar + "wbc2.txt");
                }
                txtOutput.Text = c1 + res + c2;

            }
        }

        private void btnGen1_Click(object sender, EventArgs e)
        {
            GenWebForm();
        }

        #region COMPLETE

        private void txtOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) txtOutput.SelectAll();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "AdminLte Generate Settings File|*.ags|Text File|*.txt|Any File|*.*";
            saveFileDialog1.Title = "Save an AdminLte Generate Settings File";
            saveFileDialog1.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                File.WriteAllText(saveFileDialog1.FileName, txtSource.Text);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "AdminLte Generate Settings File|*.ags|Text File|*.txt|Any File|*.*";
            ofd.Title = "Open an AdminLte Generate Settings File";
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                txtSource.Text = File.ReadAllText(ofd.FileName);
            }
        }



        #endregion


    }
}
