using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Utils
{
    public static class QRUtils
    {
        public static Base64QRCode CreateBase64QR(string txtDataQR)
        {
            QRCodeGenerator _qrCode = new QRCodeGenerator();
            QRCodeData _qrCodeData = _qrCode.CreateQrCode(txtDataQR, QRCodeGenerator.ECCLevel.M);
            return new Base64QRCode(_qrCodeData);
        }
    }
}
