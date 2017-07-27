using SisseLogimine.Model;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SisseLogimine.Klassid
{
public class LoginClass
{
    IMessageService _service = new MessageService();
    public void SisseLogimine(string Login, string Password)
    {
        using (LoginDbContext _context = new LoginDbContext())
        {
            var name = _context.LoginTable.FirstOrDefault(u => u.Name == Login);

            if (!string.IsNullOrEmpty(Login) || !string.IsNullOrEmpty(Password))
            {
                if (name != null)
                {
                    string hashedpassword = GenerateSHA256Hash(Password, name.Salt);
                    if (name.Hash == hashedpassword)
                        _service.MessageInfo("Sisse logitud!", "Info");
                    else
                        _service.MessageError("Vale parool!", "Viga");
                }
                else
                {
                    _service.MessageError("Sellist kasutajad " + Login + " ei ole olemas!", "Viga");
                }
            }
            else
            {
                _service.MessageExclamation("Sisestage andmed!", "Sõnum");
            }
        }
    }

    public void Registreerimine(string Login, string Password)
    {

        using (LoginDbContext _context = new LoginDbContext())
        {
            LoginTable loginTable = new LoginTable()
            {
                Name = Login
            };
            if (!string.IsNullOrEmpty(Login) || !string.IsNullOrEmpty(Password))
            {
                string _salt = CreateSalt(10);
                loginTable.Salt = _salt;
                loginTable.Hash = GenerateSHA256Hash(Password, _salt);
                try
                {
                    _context.LoginTable.Add(loginTable);
                    _context.SaveChanges();
                    _service.MessageInfo("Registreeritud", "Info");
                }
                catch (Exception ex)
                {
                    _service.MessageError(ex.Message, "Viga");
                }
            }
            else
            {
                _service.MessageExclamation("Sisestage andmed!", "Sõnum");
            }
        }
    }

    private string CreateSalt(int size)
    {
        var rng = new RNGCryptoServiceProvider();
        var buffer = new byte[size];
        rng.GetBytes(buffer);
        return Convert.ToBase64String(buffer);
    }

    private string GenerateSHA256Hash(string input, string salt)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
        SHA256Managed sha256hashstring = new SHA256Managed();
        byte[] hash = sha256hashstring.ComputeHash(bytes);

        return ByteArrayToHexString(hash);
    }

    private static string ByteArrayToHexString(byte[] hash)
    {
        StringBuilder hex = new StringBuilder(hash.Length * 2);
        foreach (byte b in hash)
        {
            hex.AppendFormat("{0:x2}", b);
        }
        return hex.ToString();
    }
}
}
