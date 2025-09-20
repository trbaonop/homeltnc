using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class TextProcessor
{
    private string text;

   
    public void Input()
    {
        Console.WriteLine("Nhap doan van ban:");
        text = Console.ReadLine();
    }

    public void NormalizeText()
    {
        if (string.IsNullOrWhiteSpace(text)) return;

        text = Regex.Replace(text, @"\s+", " ").Trim();

        string[] sentences = Regex.Split(text, @"(?<=[\.!\?])\s+");
        for (int i = 0; i < sentences.Length; i++)
        {
            sentences[i] = sentences[i].Trim();
            if (!string.IsNullOrEmpty(sentences[i]))
            {
                sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
            }
        }
        text = string.Join(" ", sentences);
    }

    public int CountWords()
    {
        if (string.IsNullOrWhiteSpace(text)) return 0;
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    public int CountDistinctWords()
    {
        if (string.IsNullOrWhiteSpace(text)) return 0;
        string[] words = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Distinct().Count();
    }

    public Dictionary<string, int> WordFrequency()
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();
        if (string.IsNullOrWhiteSpace(text)) return freq;

        string[] words = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }
        return freq;
    }

    public void DisplayText()
    {
        Console.WriteLine("\nVan ban da chuan hoa:");
        Console.WriteLine(text);
    }

    public void DisplayWordFrequency()
    {
        var freq = WordFrequency();
        Console.WriteLine("\nThong ke tan suat tu:");
        Console.WriteLine("{0,-15} {1}", "Tu", "So lan xuat hien");
        Console.WriteLine(new string('-', 30));
        foreach (var kvp in freq)
        {
            Console.WriteLine("{0,-15} {1}", kvp.Key, kvp.Value);
        }
    }
}

class Program
{
    static void Main()
    {
        TextProcessor tp = new TextProcessor();
        tp.Input();

        tp.NormalizeText();
        tp.DisplayText();

        Console.WriteLine($"\nTong so tu: {tp.CountWords()}");
        Console.WriteLine($"So tu khac nhau: {tp.CountDistinctWords()}");

        tp.DisplayWordFrequency();
    }
}
