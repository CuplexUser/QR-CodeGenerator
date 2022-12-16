using QR_CodeGenerator.Service;
using QR_CodeGenerator.Models;

namespace QR_CodeGenerator
{
    public partial class SettingsForm : Form
    {
        private readonly AppSettingsService _appSettingsService;

        public ApplicationSettingsModel ApplicationSettings { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
            _appSettingsService = new AppSettingsService();

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            RestoreSettings();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UpdateSettingsFromControlState();
            _appSettingsService.SaveSettings(ApplicationSettings);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSettingsFromControlState()
        {
            Guid settingsId = _appSettingsService.AppSettings?.Id ?? Guid.NewGuid();
            var settings = new ApplicationSettingsModel
            {
                GenerateQRImage = chkBoxGenerateQR.Checked,
                TextLength = Convert.ToInt32(numericStringGenLength.Value),
                RandomTextType = GetDataTypeFromSelection(),
                ModifiedDate = DateTime.Now,
                Id = settingsId
            };

            ApplicationSettings = settings;
        }

        private void RestoreSettings()
        {
            var settings = _appSettingsService.LoadSettings() ?? _appSettingsService.AppSettings;

            numericStringGenLength.Value = settings.TextLength;
            chkBoxGenerateQR.Checked = settings.GenerateQRImage;
            switch (settings.RandomTextType)
            {
                case ApplicationSettingsModel.RandomDataType.Numeric:
                    rdNumeric.Checked = true;
                    break;
                case ApplicationSettingsModel.RandomDataType.Alphanumeric:
                    rdAlphanumeric.Checked = true;
                    break;
                case ApplicationSettingsModel.RandomDataType.Password:
                    rdPassword.Checked = true;
                    break;
                case ApplicationSettingsModel.RandomDataType.Hexadecimal:
                    rdHex.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            ApplicationSettings = settings;
        }

        private ApplicationSettingsModel.RandomDataType GetDataTypeFromSelection()
        {
            RadioButton radioButton = null;
            foreach (Control control in flowPanelRandomDataType.Controls)
            {
                if (control is RadioButton { Checked: true } rdSelected)
                {
                    radioButton = rdSelected;
                    break;
                }
            }
            if (radioButton == null)
                throw new ArgumentOutOfRangeException($"No Radiobutton was selected");

            switch (radioButton.Tag)
            {
                case "Hex":
                    return ApplicationSettingsModel.RandomDataType.Hexadecimal;
                case "Numeric":
                    return ApplicationSettingsModel.RandomDataType.Numeric;
                case "Alpha":
                    return ApplicationSettingsModel.RandomDataType.Alphanumeric;
                case "Password":
                    return ApplicationSettingsModel.RandomDataType.Password;
                default:
                    break;
            }

            return ApplicationSettingsModel.RandomDataType.Password;
        }
    }
}
