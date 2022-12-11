using QRCoder;
using System.Reflection.Emit;

namespace QR_CodeGenerator.Service
{
    public class QrCodeGenService
    {
        public QrCodeGenService()
        {

        }

        public Image GenerateQRImage(string value, QRCodeGenerator.ECCLevel errorCorrectionLevel, int pixelsPerModule = 20)
        {
            var qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(value, errorCorrectionLevel);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(pixelsPerModule);
            return qrCodeImage;

        }
    }
}