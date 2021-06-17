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

namespace Ass02
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        private string currentFileName = "";
        private string lastSavedText = "";
    
        // Get user Type
        public void GetUsername(string inUserName, string inUserType) {
            UserLabel.Text = "User Name: " + inUserName;
            UserLabel.ToolTipText = "User Name: " + inUserName;
            // limit the function of view type
            if (inUserType == "View") {
                richTextBox1.ReadOnly = true;
                newToolStripMenuItem.Enabled = false;
                TBtnNew.Enabled = false;
                MenuItemSave.Enabled = false;
                TBtnSave.Enabled = false;
                MenuItemSaveAs.Enabled = false;
                SaveAsTSBtn.Enabled = false;
                MenuItemCut.Enabled = false;
                LBtnCut.Enabled = false;
                MenuItemCopy.Enabled = false;
                LBtnCopy.Enabled = false;
                MenuItemPaste.Enabled = false;
                LBtnPaste.Enabled = false;
                TBtnBold.Enabled = false;
                TBtnItalic.Enabled = false;
                TBtnUnderLine.Enabled = false;
                FontSizeBox.Enabled = false;
            }
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FontSizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //toolStrip1-frontnum-8
            //set the front size
            int j = Convert.ToInt32(FontSizeBox.Text);
            Font defaultFont = richTextBox1.Font;
            Font newFont;
            Font oldFont = richTextBox1.SelectionFont;
            if (oldFont == null)
            {
                newFont = defaultFont;
            }
            
            richTextBox1.SelectionFont = new Font(oldFont.FontFamily, j, oldFont.Style);
        }


        private void StripMenuItemExit_Click(object sender, EventArgs e)
        {
            // close the application
            Application.Exit();
        }

        private void LBtnCut_Click(object sender, EventArgs e)
        {
            //Cut tool button Click
            richTextBox1.Cut();
        }

        private void MenuItemCut_Click(object sender, EventArgs e)
        {
            //Cut Menu Item Click
            richTextBox1.Cut();
        }

        private void MenuItemCopy_Click(object sender, EventArgs e)
        {
            //Copy Menu Item Click
            richTextBox1.Copy();
        }

        private void MenuItemPaste_Click(object sender, EventArgs e)
        {
            //Paste Menu Item Click
            richTextBox1.Paste();
        }

        private void LBtnCopy_Click(object sender, EventArgs e)
        {
            //Copy left tool button Click
            richTextBox1.Copy();
        }

        private void LBtnPaste_Click(object sender, EventArgs e)
        {
            //Paste left tool button Click
            richTextBox1.Paste();
        }

        private void TBtnAbout_Click(object sender, EventArgs e)
        {
            // About top button Click
            About ab = new About();
            ab.Show();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            // About Menu Item Click
            About ab = new About();
            ab.Show();
        }

        private void TBtnBold_Click(object sender, EventArgs e)
        {
            //Bold top button Click and Bold Function
            Font defaultFont = richTextBox1.Font;
            Font newFont;
            Font oldFont = richTextBox1.SelectionFont;
            if (oldFont == null)
            {
                newFont = defaultFont;
            }
            else if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void TBtnItalic_Click(object sender, EventArgs e)
        {
            // Italic top button and Italic  Function
            Font defaultFont = richTextBox1.Font;
            Font newFont;
            Font oldFont = richTextBox1.SelectionFont;
            if (oldFont == null)
            {
                newFont = defaultFont;
            }
            else if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void TBtnUnderLine_Click(object sender, EventArgs e)
        {
            // Under Line top button and Under Line Function
            Font defaultFont = richTextBox1.Font;
            Font newFont;
            Font oldFont = richTextBox1.SelectionFont;
            if (oldFont == null)
            {
                newFont = defaultFont;
            }
            else if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void TBtnNew_Click(object sender, EventArgs e)
        {
            // New Top button Item Click
            newFile();
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            // New Menu Item Click 
            newFile();
        }

        //New file function
        private void newFile()
        {
            if (richTextBox1.Text != lastSavedText)
            {
                DialogResult result = MessageBox.Show("Your document has not saved ! Do you insist to leave?", "Waring", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    richTextBox1.Clear();
                    currentFileName = "";
                    lastSavedText = "";
                }
            }
            else
            {
                richTextBox1.Clear();
                currentFileName = "";
                lastSavedText = "";
            }
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            // Open Menu Item Click 
            openfile();
        }

        private void TBtnOpen_Click(object sender, EventArgs e)
        {
            // Open Top button Click 
            openfile();
        }

        //Open file decide the situation
        private void openfile()
        {
            if (richTextBox1.Text != lastSavedText)
            {
                DialogResult result = MessageBox.Show("Your document has not saved ! Do you insist to leave? ", "Waring", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    openfileFunction();
                }
            }
            else
            {
                openfileFunction();
            }
        }
        //Open file function
        private void openfileFunction()
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Select the file";
            openfile.DefaultExt = "*.rtf";
            openfile.Filter = "RTF Files|*.rtf";

            if (openfile.ShowDialog() == DialogResult.OK && openfile.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.LoadFile(openfile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Waring");
                    richTextBox1.LoadFile(openfile.FileName, RichTextBoxStreamType.PlainText);
                }

                // Get Current file name
                currentFileName = openfile.FileName;
                // Refresh the content of lastSavedText
                lastSavedText = richTextBox1.Text;
            }
        }

        private void TBtnSave_Click(object sender, EventArgs e)
        {
            // Save Top button Click
            saveFile();
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            // Save Menu Item Click
            saveFile();
        }

        //save 
        private void saveFile()
        {
            if (currentFileName == "")
            {
                //No file saved  
                saveFileAs();
            }
            else
            {
                //refresh lastSavedText
                lastSavedText = richTextBox1.Text;
                //save file
                richTextBox1.SaveFile(currentFileName);
                MessageBox.Show("Saved Successful!", "Information");
            }

        }

        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            // Save as Tool Scrip Item Click
            saveFileAs();
        }

        private void TBtnSaveAs_Click(object sender, EventArgs e)
        {
            // Save as Tool Scrip Item Click
            saveFileAs();
        }

        //Save as function
        private void saveFileAs()
        {
            //save file function
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save file as..";
            sfd.DefaultExt = "*.rtf";
            sfd.Filter = "RTF Files|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                currentFileName = sfd.FileName;
                lastSavedText = richTextBox1.Text;
                richTextBox1.SaveFile(sfd.FileName);
                MessageBox.Show("Saved Successful!!", "Information");
            }
        }

        // Log out Function
        private void MenuItemLogOut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != lastSavedText)
            {
                DialogResult result = MessageBox.Show("Your document has not saved ! Do you insist to leave?", "Waring", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // open login
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
            }
            else
            {
                //open login form
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }
    }
}
