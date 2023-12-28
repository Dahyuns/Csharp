using System;
using System.Collections;
using System.Collections.Generic;

public class User
{
    private string? NickName { get; }

    public User(string? nickname)
    {
        NickName = nickname;
    }

    public override string? ToString()
    {
        return NickName;
    }

    static void Main()
    {
        string? nickname = Console.ReadLine();
        User user = new User(nickname);

        if (!string.IsNullOrWhiteSpace(nickname))
            Console.WriteLine($"당신의 닉네임은 {user}입니다.");
        else if (string.IsNullOrWhiteSpace(nickname))
            Console.WriteLine("닉네임이 없습니다");
    }
}




