#region

using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using QR_CodeGenerator.Models;
using QR_CodeGenerator.Service;
using QRCoder;

#endregion

namespace QR_CodeGenerator;


public partial class MainForm : Form
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "form control callback function names equals control names")]
    private readonly QrCodeGenService _qrCodeGen;
    private bool _qrCodeGenerated;
    private readonly RandomDataService _randomDataService;
    private readonly AppSettingsService _appSettingsService;

    public MainForm()
    {
        InitializeComponent();
        _qrCodeGen = new QrCodeGenService();
        _randomDataService = new RandomDataService();
        _appSettingsService = new AppSettingsService();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        _appSettingsService.LoadSettings();
        generateTextAndQRToolStripMenuItem.Checked = _appSettingsService.AppSettings.GenerateQRImage;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"Are you sure you want to exit the program?", "Quit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) Application.Exit();
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
        var form = new AboutApplication();
        form.ShowDialog(this);
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
        GenerateQRCode();
    }

    private void GenerateQRCode()
    {
        QRCodeGenerator.ECCLevel eccLevel = GetSelectEccLevel();
        Image qrImage = _qrCodeGen.GenerateQRImage(txtInputText.Text, eccLevel);
        _qrCodeGenerated = true;
        picBoxQR.Image = qrImage;
    }

    private QRCodeGenerator.ECCLevel GetSelectEccLevel()
    {
        RadioButton radioButton = null;
        foreach (Control control in grpBoxQuality.Controls)
            if (control is RadioButton { Checked: true } currentRadioButton)
            {
                radioButton = currentRadioButton;
                break;
            }

        if (radioButton == null) throw new InvalidDataException("No Radiobutton is selected, which should be impossible");

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

    private void ClearToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        ClearQRAndTextFiled();
    }

    private void ClearQRAndTextFiled()
    {
        _qrCodeGenerated = false;
        txtInputText.Text = "";
        picBoxQR.Image = picBoxQR.InitialImage;
    }


    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new SettingsForm();
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            var settings = form.ApplicationSettings;
            generateTextAndQRToolStripMenuItem.Checked = settings.GenerateQRImage;
        }
    }

    private void generateCNGRandomToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var settings = _appSettingsService.LoadSettings() ?? _appSettingsService.AppSettings;

        int length = settings.TextLength;

        switch (settings.RandomTextType)
        {
            case ApplicationSettingsModel.RandomDataType.Numeric:
                txtInputText.Text = _randomDataService.GetNumericRandom(length);
                break;
            case ApplicationSettingsModel.RandomDataType.Alphanumeric:
                txtInputText.Text = _randomDataService.GetRandomAlphaNumeric(length);
                break;
            case ApplicationSettingsModel.RandomDataType.Password:
                txtInputText.Text = _randomDataService.GetRandomPassword(length);
                break;
            case ApplicationSettingsModel.RandomDataType.Hexadecimal:
                txtInputText.Text = _randomDataService.GetRandomHex(length);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        if (settings.GenerateQRImage)
        {
            GenerateQRCode();
        }
    }

    private void generateTextAndQRToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var settings = _appSettingsService.LoadSettings() ?? _appSettingsService.AppSettings;

        if (settings.GenerateQRImage != generateTextAndQRToolStripMenuItem.Checked)
        {
            settings.GenerateQRImage= generateTextAndQRToolStripMenuItem.Checked;
            _appSettingsService.SaveSettings(settings);
        }
    }
}