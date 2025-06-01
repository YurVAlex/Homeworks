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
        "Barabas badass on Barbados",
        null
    };

    public static List<string> Combine { get; } = new()
    {
        "Friend in need is a friend indeed",
        "1232^ 655Ъ dfM@ -65++ :~} ",
        "  Test like a test  ",
        "Quasi-diagonal",
        "Hello World!",
        "",
        "\t\nSome text", 
        "\n\nText for test",
        null 
    };

}
