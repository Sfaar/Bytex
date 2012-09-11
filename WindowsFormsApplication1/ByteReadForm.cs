using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ns7.sadh.ByteReader
{
    /// <summary>
    /// my class
    /// </summary>
    public partial class ByteReadForm : Form
    {
        #region fields
        private string fileNamePath;
        private long fileVisibilitySize;
        private bool _topLabelTextChanged;
        /// <summary>
        /// name of application
        /// </summary>
        public static string ICENAME = "Sfaar Byte Reader";
        #endregion

        #region constructors
        /// <summary>
        /// this form is the form for bytereader
        /// </summary>
        public ByteReadForm()
        {
            InitializeComponent();
            fileVisibilitySize = 0;
            fileVisibilitySelector.SelectedIndex = 0;
            notifyIcon1.ShowBalloonTip(int.MaxValue, ICENAME, 
                "Application by iceSapphire\n\n"+"Read any file in byte format &" +
                "\nWatch that in hexadecimal.\n\n"+
                "Khan Muhammad Nafee Mostafa Sadh\n<nafsadh@yahoo.com>", ToolTipIcon.None);
            TopLabelTextChanged = false;
            this.Text = ICENAME;
            fileNameExtensionLabel.Text = "";
        }
        #endregion

        #region properties
        public string FileNamePath
        {
            get { return fileNamePath; }
            set { fileNamePath = value; }
        }
        public long FileVisibilitySize
        {
            get { return fileVisibilitySize; }
            set { fileVisibilitySize = value; }
        }

        public bool TopLabelTextChanged
        {
            get { return _topLabelTextChanged; }
            set { _topLabelTextChanged = value; }
        }
        #endregion

        #region ByteReader Methods

        void byteRead()
        {
            if (FileNamePath == "")
            {
                notifyIcon1.ShowBalloonTip(1024, ICENAME, "No File Selected", ToolTipIcon.Info);
                return;
            }
            if (TopLabelTextChanged)
            {
                this.topLabel.Text = " Byte  Number     "
                    + "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F"
                    + "    Text Within"
                    + " Byte                             "
                    + "                                  ";
                TopLabelTextChanged = false;
            }
            try
            {
                FileStream fileStream =
                    new FileStream(FileNamePath, FileMode.Open, FileAccess.Read);
                long fileLength = fileStream.Length;
                string filesName = fileNameExtract();
                this.Text = string.Format(ICENAME+" : " + fileNamePath);
                fileNameExtensionLabel.Text = filesName;
                fileSizeLabel.Text = fileSize((double)fileLength);
                fileSizeLabel.ToolTipText = fileLength.ToString("N00") + " bytes";
                notifyIcon1.ShowBalloonTip(1024,
                    "Byte Reading : " + fileSizeLabel.Text,
                    filesName, ToolTipIcon.None);

                hexadecimalInBox(fileStream, fileVisibilitySize);

                notifyIcon1.ShowBalloonTip(1024, ICENAME, filesName, ToolTipIcon.None);

            }
            catch (ArgumentNullException)
            {
                return;
            }
            catch (FileNotFoundException)
            {
                return;
            }
            catch (FormatException)
            {
                notifyIcon1.ShowBalloonTip(1024, ICENAME + " : Error",
                      "The file selected has a name with unsupported format!",
                      ToolTipIcon.Error);
                MessageBox.Show("The file selected has a name with unsupported format!");               
            }
        }

        void hexadecimalInBox(FileStream fileStream, long visibilityLength)
        {
            int nCols = 16;
            long nBytesToRead = fileStream.Length;
            if (visibilityLength != 0 && nBytesToRead > visibilityLength)
                nBytesToRead = visibilityLength;
            long nLines = (nBytesToRead / nCols);
            string[] lines = new string[nLines + 1];

            StringBuilder nextLine = new StringBuilder(" ", 4 * nCols + 4 + 16 + 32);
            StringBuilder nextText = new StringBuilder("    ", nCols + 16);

            for (long i = 0; i < nLines; i++)
            {
                nextLine.Append(i.ToString("X011") + "0    ");

                for (int j = 0; j < nCols; j++)
                {
                    int nextByte = fileStream.ReadByte();
                    if (nextByte < 0)
                        break;
                    nextLine.Append(" " + nextByte.ToString("X02"));
                    if (32 < nextByte && nextByte < 127) nextText.Append((char)nextByte);
                    else nextText.Append(".");
                }
                nextLine.Append(nextText);
                lines[i] = nextLine.ToString();
                nextLine.Remove(1, nextLine.Length - 1);
                nextText.Remove(4, 16);
            }
            {
                nextLine.Append(nLines.ToString("X011") + "0    ");

                for (int j = 0; j < (int)(nBytesToRead % 16); j++)
                {
                    int nextByte = fileStream.ReadByte();
                    if (nextByte < 0)
                        break;
                    nextLine.Append(" " + nextByte.ToString("X02"));
                    if (32 < nextByte && nextByte < 127) nextText.Append((char)nextByte);
                    else nextText.Append(".");
                }
                for (int j = (int)(nBytesToRead % 16); j < 16; j++)
                {
                    nextLine.Append("   ");
                } nextLine.Append(nextText);
                lines[nLines] = nextLine.ToString();
            }
            fileStream.Close();
            notifyIcon1.ShowBalloonTip(1024,
                "Bytes Read : " + fileSizeLabel.Text,
                fileNameExtensionLabel.Text, ToolTipIcon.None);
            xBox.Lines = lines;
        }

        #endregion

        #region xTRA
        #region textFileView

        void textFileReadWrite()
        {
            string filesName = fileNameExtract();
            topLabel.Text = "Reading Text File : " + filesName;
            TopLabelTextChanged = true;
            try
            {
                FileStream fileStream = new FileStream(FileNamePath, FileMode.Open, FileAccess.Read);
                long fileLength = fileStream.Length;
                fileStream.Close();
                this.Text = string.Format(ICENAME + " : " + FileNamePath);
                notifyIcon1.ShowBalloonTip(1024, ICENAME+" : Reading Text File", filesName, ToolTipIcon.None);
                xBox.Lines = File.ReadAllLines(FileNamePath);
                fileSizeLabel.Text = fileSize(fileLength);
                fileSizeLabel.ToolTipText = fileLength + " bytes";
                fileNameExtensionLabel.Text = filesName;
                topLabel.Text = "Text File : \"" + filesName + "\" (" + xBox.Lines.Length + " lines)";
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
                notifyIcon1.ShowBalloonTip(1024, ICENAME + " : Error!",
                    "File Not found : " + FileNamePath, ToolTipIcon.Error);
            }
            catch (FormatException)
            {
                notifyIcon1.ShowBalloonTip(1024, ICENAME + " : Error",
                      "The file selected has a name with unsupported format!",
                      ToolTipIcon.Error);
                MessageBox.Show("The file selected has a name with unsupported format!");
            }
        }

        #endregion

        #region executable file view

        void exeFileView()
        {
            topLabel.Text = "";
            TopLabelTextChanged = true;

        }

        #endregion

        #region Refresh
        private void refresh()
        {
            this.Text = ICENAME;
            xBox.Text = "";
            fileNameExtensionLabel.Text = "";
            fileSizeLabel.Text = "0 (select a file)";
            FileNamePath = "";
            if (TopLabelTextChanged)
            {
                this.topLabel.Text = " Byte  Number     "
                    + "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F"
                    + "    Text Within"
                    + " Byte                             "
                    + "                                  ";
                TopLabelTextChanged = false;
            }
        }
        #endregion
        
        #endregion

        #region methods
        private string fileNameExtract()
        {
            return fileNamePath.Substring(
                fileNamePath.LastIndexOf('\\') + 1);

        }

        string fileSize(double size)
        {
            if (size < 1024)
            {
                return size + " B";
            }
            else size /= 1024;
            if (size < 1024)
            {
                return size.ToString("N03") + " kB";
            }
            else size /= 1024;
            if (size < 1024)
            {
                return size.ToString("N03") + " MB";
            }
            else size /= 1024;
            if (true)
            {
                return size.ToString("N03") + " GB";
            }
        }

        #endregion

        #region needNot
        void hexReadFile(Stream fileStream)
        {
            string str = "00 02 04 06 08 10 12 14   16 18 20 22 24 26 28 30\n\n";
            int b;
            xBox.Text = str;
            while (true)
            {
                int i = 0;
                do
                {
                    b = (int)fileStream.ReadByte();
                    if (b == -1) return;
                    xBox.AppendText(toHexCode((byte)b));
                    i++;
                } while (i < 8);
                xBox.AppendText("  ");
                do
                {
                    b = (int)fileStream.ReadByte();
                    if (b == -1) return;
                    xBox.AppendText(toHexCode((byte)b));
                    i++;
                } while (i < 16);
                xBox.AppendText("\n");
            }
        }

        String toHexCode(byte num)
        {
            int Y = num % 16;
            int X = (num / 16) % 16;
            string str = toHexadecimal(X).ToString() + toHexadecimal(Y).ToString() + " ";
            return str;
        }

        char toHexadecimal(int digit)
        {
            if (digit > 15) return ' ';
            if (digit < 0) return ' ';
            if (digit < 10)
                return (char)(digit + (int)'0');
            else
                return (char)(digit - 10 + (int)'A');

        }
        #endregion

        #region events

        private void SelectFileEvent(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            FileNamePath = openFileDialog.FileName;
            byteRead();
        }

        private void SaveInFileEvent(object sender, EventArgs e)
        {
            FileStream newFile = new FileStream(FileNamePath + ".ns7-bytex", FileMode.Create, FileAccess.Write);
            newFile.Close();
            File.AppendAllText(newFile.Name, xBox.Text);

            notifyIcon1.ShowBalloonTip(10 * 1024, "Context Saved",
                "Context of textbox is saved in file : \n\""
                + newFile.Name + "\"", ToolTipIcon.Info);
        }

        private void AboutEvent(object sender, EventArgs e)
        {
            AboutBox1 ax = new AboutBox1();
            ax.Visible = true;
        }

        private void SelectFontEvent(object sender, EventArgs e)
        {
            fontDialog1.Font = xBox.Font;
            fontDialog1.ShowDialog();
            xBox.Font = fontDialog1.Font;
            topLabel.Font = fontDialog1.Font;
        }

        private void FileVisibilitySelected(object sender, EventArgs e)
        {
            switch (fileVisibilitySelector.SelectedIndex)
            {
                case 0: FileVisibilitySize = 0;
                    break;
                case 1: FileVisibilitySize = 1024;
                    break;
                case 2: FileVisibilitySize = 65536;
                    break;
                case 3: FileVisibilitySize = 1024 * 1024;
                    break;
            }
            byteRead();
        }

        private void OpenTextEvent(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            FileNamePath = openFileDialog.FileName;
            textFileReadWrite();
        }

        private void ExeFileOpenEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Not Supported Yet");
        }

        private void RefreshEvent(object sender, EventArgs e)
        {
            refresh();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButton1.ShowDropDown();
        }

        #endregion

        #region dragDrop
        private void DragEnterEvent(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DragDropEvent(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            FileNamePath = s[0];
            byteRead();
        }
        #endregion
    }
}
