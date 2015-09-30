using System;

class CensorEmail
{
	static void Main()
	{
		string input = "My name is Pesho Peshev. " +
		               "I am from Sofia, my email is: " +
		               "pesho.peshev@email.bg " +
		               "(not pesho.peshev@email.com). " +
		               "Test: pesho.meshev@email.bg, " +
		               "pesho.peshev@email.bg";

		string emailToCensor = "pesho.peshev@email.bg";
		string username = emailToCensor.Substring(0, emailToCensor.IndexOf('@'));
		string censoredEmail = emailToCensor.Replace(username, new string('*', username.Length));
		input = input.Replace(emailToCensor, censoredEmail);
        Console.WriteLine(input);
	}
}