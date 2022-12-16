using System.Security.Cryptography;
using System.Text;

namespace QR_CodeGenerator.Service;

public class RandomDataService
{
    private readonly RandomNumberGenerator _numberGenerator;
    private const string AlphanumericPool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private const string PasswordPool = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$&?+%*^";

    public RandomDataService()
    {
        _numberGenerator = RandomNumberGenerator.Create();
    }

    public string GetRandomPassword(int length)
    {
        byte[] bufferBytes = new byte[length * 4];
        _numberGenerator.GetBytes(bufferBytes);
        var sb = new StringBuilder();

        for (int i = 0; i < bufferBytes.Length; i += 4)
        {
            int rndInt = Math.Abs(BitConverter.ToInt32(bufferBytes, i));
            sb.Append(PasswordPool[rndInt % PasswordPool.Length]);
        }

        return sb.ToString();
    }

    public string GetRandomAlphaNumeric(int length)
    {
        byte[] bufferBytes = new byte[length * 4];
        _numberGenerator.GetBytes(bufferBytes);
        var sb = new StringBuilder();

        for (int i = 0; i < bufferBytes.Length; i += 4)
        {
            int rndInt = Math.Abs(BitConverter.ToInt32(bufferBytes, i));
            sb.Append(AlphanumericPool[rndInt % AlphanumericPool.Length]);
        }

        return sb.ToString();
    }

    public string GetNumericRandom(int length)
    {
        var sb = new StringBuilder();
        byte[] bufferBytes = new byte[length];
        _numberGenerator.GetBytes(bufferBytes);

        int index = 0;
        while (index < length)
        {
            byte b = bufferBytes[index];
            sb.Append(b % 10);
            index++;
        }

        return sb.ToString();
    }

    public string GetRandomHex(int length)
    {
        byte[] bufferBytes = new byte[length];
        _numberGenerator.GetBytes(bufferBytes);
        return ByteArrayToHexString(bufferBytes);
    }



    private string ByteArrayToHexString(byte[] data)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (byte num in data)
            stringBuilder.AppendFormat("{0:X2}", (object)num);
        return stringBuilder.ToString();
    }

}