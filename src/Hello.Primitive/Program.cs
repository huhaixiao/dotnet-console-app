namespace Hello.Primitive
{
    class Snippets
    {
        private int _Age;
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
            }
        }
        public Snippets()
        {
            Console.WriteLine("Snippet constructed");
        }
        public async Task run()
        {
            await getTodo();
            logPrimitives();
        }
        public void logPrimitives()
        {
            int integer = 6;
            long longInteger = 666;
            float height = 1.7F;
            double age = 34.8D;
            decimal money = 2.002M;
            bool isMale = true;
            bool isFemale = false;
            char tag = 'M';
            string tagg = "M";

            Console.WriteLine($"Primitives {integer} {longInteger} {height} {age} {money} {isMale} {isFemale} {tag} {tagg}");
        }
        public async Task getTodo()
        {
            // Console.WriteLine("try make a api call");
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(5);
                try
                {
                    string apiUrl = "https://jsonplaceholder.typicode.com/todos/1";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(content);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occured: {ex.Message}");
                }
            }
        }
    }
}