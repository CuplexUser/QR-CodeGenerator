using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using QR_CodeGenerator.Service;
using QRCoder;

namespace QR_CodeGenerator;

public partial class MainForm : Form
{
    private readonly QrCodeGenService _qrCodeGen;
    private bool _qrCodeGenerated;

    public MainForm()
    {
        InitializeComponent();
        _qrCodeGen = new QrCodeGenService();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ClearQRAndTextFiled();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (saveImgDialog.ShowDialog(this) == DialogResult.OK)
        {
            string filePath = saveImgDialog.FileName;
            SaveQRImageToFile(filePath);
        }
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (saveImgDialog.ShowDialog(this) == DialogResult.OK)
        {
            string filePath = saveImgDialog.FileName;
            SaveQRImageToFile(filePath);
        }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CopyQRImageToClipboard();
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void clearToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ClearQRAndTextFiled();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearQRAndTextFiled();
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        QRCodeGenerator.ECCLevel eccLevel = GetSelectEccLevel();
        Image qrImage = _qrCodeGen.GenerateQRImage(txtInputText.Text, eccLevel);
        _qrCodeGenerated = true;
        picBoxQR.Image = qrImage;
    }

    private QRCodeGenerator.ECCLevel GetSelectEccLevel()
    {
        RadioButton? radioButton = null;
        foreach (Control control in grpBoxQuality.Controls)
            if (control is RadioButton { Checked: true } currentRadioButton)
            {
                radioButton = currentRadioButton;
                break;
            }

        if (radioButton == null) throw new InvalidDataException("No Checkbox is selected, which should be imposible");

        return (radioButton.Tag as string) switch
        {
            "H" => QRCodeGenerator.ECCLevel.H,
            "L" => QRCodeGenerator.ECCLevel.L,
            "M" => QRCodeGenerator.ECCLevel.M,
            "Q" => QRCodeGenerator.ECCLevel.Q,
            _ => QRCodeGenerator.ECCLevel.Q
        };
    }

    private void pnlPicBox_Resize(object sender, EventArgs e)
    {
        int maxLength = Math.Min(pnlPicBox.Size.Width, pnlPicBox.Size.Height);

        picBoxQR.SizeMode = PictureBoxSizeMode.Zoom;
        picBoxQR.Size = new Size(maxLength, maxLength);

        picBoxQR.Location = new Point((pnlPicBox.Width - maxLength) / 2, (pnlPicBox.Height - maxLength) / 2);
    }

    private void CopyQRImageToClipboard()
    {
        if (_qrCodeGenerated)
        {
            Clipboard.Clear();
            Clipboard.SetImage(picBoxQR.Image);
        }
    }

    private void SaveQRImageToFile(string filepath)
    {
        if (string.IsNullOrEmpty(filepath)) return;

        var jpegRegex = new Regex(@"^(jpg)|(jpeg)$");
        string extenstion = Path.GetExtension(filepath);

        ImageFormat imgFormat = ImageFormat.Png;
        if (jpegRegex.IsMatch(extenstion)) imgFormat = ImageFormat.Jpeg;

        picBoxQR.Image.Save(filepath, imgFormat);
    }

    private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
    {
        saveImgDialog.FileName = "QrCode.jpg";

        if (saveImgDialog.ShowDialog(this) == DialogResult.OK)
        {
            string filePath = saveImgDialog.FileName;
            try
            {
                SaveQRImageToFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Image could not be saved! Error:\n{ex.Message}", "QR image not saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(@"Image was saved successfully", @"QR image saved", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CopyQRImageToClipboard();
    }

    private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        ClearQRAndTextFiled();
    }

    private void ClearQRAndTextFiled()
    {
        _qrCodeGenerated = false;
        txtInputText.Text = "";
        picBoxQR.Image = picBoxQR.InitialImage;
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {

    }
}