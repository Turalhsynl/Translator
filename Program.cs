class program
{
    class Dictionary
    {
        public Dictionary<string, string> translate = new Dictionary<string, string>();

        public string this[string word]
        {
            get
            {
                try
                {
                    return translate[word];
                }
                catch (KeyNotFoundException)
                {
                    return "Word couldn't found";
                }
            }
            set
            {
                translate[word] = value;
            }
        }
    }
    static void Main(string[] args)
    {
        Dictionary dic = new Dictionary();

        dic["adam"] = "people";

        Console.WriteLine($"adam: {dic["adam"]}");
    }
}