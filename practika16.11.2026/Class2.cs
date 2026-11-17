using System;

namespace praktika16._11._2026
{
    public class User
    {
        public int Id;
        public double Data;
        public string Username;
        public string Email;
        public User(int id, int data, string username, string email)
        {
            Id = id;
            Data = data;
            Username = username;
            Email = email;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} | Имя: {Username} | Email: {Email} | Data: {Data}");
        }
    }
}