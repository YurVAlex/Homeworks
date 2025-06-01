namespace Homework08;

public class TestCases
{
    public static List<string> Palindromes { get; } = new()
    {
        "Муза, ранясь шилом опыта, ты помолишься на разум",
        "O, a kak Uwakov lil vo kawu kakao!",
        "А роза упала на лапу Азора...",
        "Some men interpret nine memos",
        "saippuakivikauppias ",
        "---===LOL===---",
        "2002",
        "1",
        "a",
        "",
        " ",
        "*",
        "bad",
        "start",
        "@#$%^&&*",
        "Barabas badass by Barbados",
        null
    };

    public static List<string> Combine { get; } = new()
    {
        "Friend in need is a friend indeed",
        "1232^ 655Ъ dfM@ -65++ :~} ",
        "Test like a test    ",
        "Quasi-diagonal",
        "Hello World!",
        "",
        "Some text for test\t with tab",
        "Some text for test\nwith new line",
        null 
    };

    public static List<string> VariousCases { get; } = new()
    {
         "hello world", "HELLO WORLD", "Hello World", "tEsT cAse",
         "  spaced   words  ", "  SPACED   WORDS  ", "  Spaced-Words  ",
         "привет ^&*", "ПРИВЕТ 007", "Привет - Мир", "Привет ~Мир", "",
         "\tпривет мир", "\n ПРИВЕТ МИР", "\t\nпривет мир", "\n7Привет ?Мир",
         null
    };
}
