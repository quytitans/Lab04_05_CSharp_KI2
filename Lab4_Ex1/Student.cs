namespace Lab4_Ex1
{
    public class Student: Person
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string programEnrolled { get; set; }

        public override string ToString()
        {
            return $"{"Student",10} {"|",10} {name,15} {"|",10} {email,30} {"|",10}";
        }
    }
}