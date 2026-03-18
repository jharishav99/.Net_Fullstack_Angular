using System;
using System.Collections.Generic;
using System.Linq;
using Serilog;

public class UserManager
{
    private List<User> _users = new List<User>();

    // Task 1: Register() method [cite: 45]
    public void Register(string username, string password, string email)
    {
        try
        {
            // Task 1: Password Hashing [cite: 18, 47]
            string hashedPassword = PasswordHasher.HashPassword(password);

            // Task 2: Encrypting sensitive data [cite: 24, 51]
            string encryptedEmail = EncryptionHelper.Encrypt(email);

            _users.Add(new User
            {
                Username = username,
                HashedPassword = hashedPassword,
                EncryptedEmail = encryptedEmail
            });

            Log.Information("User {Username} registered successfully", username); 
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Registration failed for {Username}", username); 
        }
    }

    // Task 1: Authenticate() method [cite: 45, 49]
    public bool Authenticate(string username, string password)
    {
        var user = _users.FirstOrDefault(u => u.Username == username);
        if (user == null) return false;

        string hashedInput = PasswordHasher.HashPassword(password);
        return user.HashedPassword == hashedInput; // Task 1 verify [cite: 20]
    }
}