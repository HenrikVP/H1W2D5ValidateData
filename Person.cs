namespace H1W2D5ValidateData
{
    internal class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }


        public int GetAge()
        {
            int age = DateTime.Now.Year - Birthday.Year;
            if (DateTime.Now.AddYears(-age) < Birthday) age--;
            return age;
        }
    }
}
