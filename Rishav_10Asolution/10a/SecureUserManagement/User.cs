public class User
{
    // Properties required by Task 1 [cite: 44]
    public string Username { get; set; }
    public string HashedPassword { get; set; }

    // Additional sensitive data for Task 2 (Data Encryption) [cite: 24, 51]
    public string EncryptedEmail { get; set; }
}