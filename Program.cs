using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static string Encrypt(string text, int shift)
    {
            string result = "";

            foreach(char c in text){
                    if(char.IsLetter(c)){

                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        char encryptedChar = (char)(((c - offset + shift) % 26) + offset);
                        result += encryptedChar;

                    } else result += c;
            }
            return result;
    }

     static string Decrypt(string text, int shift)
    {
        return Encrypt(text, 26 - shift);
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Enter test to be encrypted: ");
        string text = Console.ReadLine();

        Console.WriteLine("Enter the shifting number: ");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(text, shift);

        Console.WriteLine($"Encrypted text: {encryptedText}");

        string decryptedText = Decrypt(encryptedText, shift);

        Console.WriteLine($"Decrypted text: {decryptedText}");
    }
}