class lesson_9
{
    static void Main()
    {
	    Console.WriteLine(GetLastHalf("I love CSharp!"));
	    Console.WriteLine(GetLastHalf("1234567890"));
	    Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
    }
    static string GetLastHalf(string text)
{
    return text.Substring(text.Length / 2).Replace(" ", "");
}
    /*static string GetLastHalf(string text)
    {
        
        return text.Replace( " ", "") text.Remove(0, text.Length/2);

    }*/
    public static string GetLastHalf(string text)
    {
        // Удаляем пробелы из строки
        string noSpaces = text.Replace(" ", "");

        // Находим индекс начала второй половины
        int startIndex = noSpaces.Length / 2;

        // Возвращаем вторую половину строки
        return noSpaces.Substring(startIndex);
    }
}

/*var c = "blya";
var a = c.Length;
Console.WriteLine(a);*/