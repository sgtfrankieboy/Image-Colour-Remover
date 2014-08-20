using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;

namespace VisualBounds.Imaging.ColourRemover
{
    public partial class FrmMain : Form
    {
        public char[] AllowedCharacters = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
        public Image source;
        public Image preview;
        public bool saved = true;

        public FrmMain()
        {
            InitializeComponent();
        }


        public Color HexToColor(string hex)
        {
            try
            {
                return ColorTranslator.FromHtml("#" + hex);
            }
            catch { return picColour.BackColor; }
        }

        private static String ColorToHex(System.Drawing.Color c)
        {
            return c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void txtHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
                return;
            if (!AllowedCharacters.Contains(char.ToUpper(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void picColour_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.AnyColor = true;
            cd.AllowFullOpen = true;
            cd.Color = picColour.BackColor;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picColour.BackColor = cd.Color;
                txtHex.Text = ColorToHex(cd.Color);
            }
        }

        private void txtHex_TextChanged(object sender, EventArgs e)
        {
            picColour.BackColor = HexToColor(txtHex.Text);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                if (MessageBox.Show("You have an unsafed image opened!\nDo you want to save it?", "Image Colour Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    btnSave_Click(this, e);
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Image Colour Remover - Load Image";
            ofd.Filter = "All Images|*.bmp;*.gif;*.jpeg;*.jpg;*.png;*.tiff|Bitmap|*.bmp|Graphical Interchange Format|*.gif|JPEG|*.jpeg;*.jpg|Portable Network Graphic|*.png|Tagged Image File Format|*.tiff";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    source = Image.FromFile(ofd.FileName);
                    preview = source;
                    picPreview.BackgroundImage = preview;

                    txtOpen.Text = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Unable to load the image!", "Image Colour Remover - Error");
                    txtOpen.Text = "";
                    source = null;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Image Colour Remover - Save Image";
            sfd.Filter = "All Images|*.bmp;*.emf;*.exif;*.gif;*.ico;*.jpg;*.jpeg;*.png;*.tiff;*.wmf|Bitmap|*.bmp|Enhanced Windows Metafile|*.emf|Exchangeable Image Information File|*.exif|Graphical Interchange Format|*.gif|Icon|*.ico|JPEG|*.jpg;*.jpeg|Portable Network Graphic|*.png|Tagged Image File Format|*.tiff|Windows Metafile|*.wmf|All Files|*.*";
            sfd.FileName = txtOpen.Text;
            sfd.AddExtension = true;
            sfd.AutoUpgradeEnabled = true;
            sfd.CheckFileExists = false;
            sfd.CheckPathExists = false;
            sfd.CreatePrompt = false;
            sfd.DefaultExt = ".png";
            sfd.OverwritePrompt = true;
            sfd.ValidateNames = true;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                preview.Save(sfd.FileName);
                if (MessageBox.Show("Image Saved!\nWant to open it?", "Image Colour Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Bitmap map = new Bitmap(preview);
            map.MakeTransparent(picColour.BackColor);
            preview = (Image)map;
            picPreview.BackgroundImage = preview;
            saved = false;
        }

        private void txtOpen_TextChanged(object sender, EventArgs e)
        {
            if (txtOpen.Text == "")
            {
                btnRemove.Enabled = false;
                btnSave.Enabled = false;
                btnRevert.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
                btnSave.Enabled = true;
                btnRevert.Enabled = true;
            }
        }

        Bitmap screen;
        bool down;

        private void picPreview_MouseDown(object sender, MouseEventArgs e)
        {
            screen = Win32APICall.GetDesktop();
            down = true;
        }

        private void picPreview_MouseUp(object sender, MouseEventArgs e)
        {
            if (screen == null)
            {
                screen = Win32APICall.GetDesktop();
            }
            picColour.BackColor = screen.GetPixel(MousePosition.X, MousePosition.Y);
            txtHex.Text = ColorToHex(picColour.BackColor);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                btnRemove_Click(null, null);
            down = false;
        }

        private void picPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (screen != null && down)
            {
                picColour.BackColor = screen.GetPixel(MousePosition.X, MousePosition.Y);
                txtHex.Text = ColorToHex(picColour.BackColor);
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    btnRemove_Click(null, null);
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to revert the image to the original?", "Image Colour Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                preview = source;
                picPreview.BackgroundImage = preview;
                saved = true;
            }
        }

        private void picPreview_Click(object sender, EventArgs e)
        {

        }


    }
}
