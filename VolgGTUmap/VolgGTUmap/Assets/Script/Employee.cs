namespace Assets.Scripts
{
    public class Employee
    {

        //public int ID_employee { get; set; }

        public string FullName { get; set; }

        public string Position { get; set; }

        public string Link { get; set; }

        public string Audience { get; set; }

        public Employee(string fullName, string position, string link, string audience)
        {
          //  ID_employee = id_employee;
            FullName = fullName;
            Position = position;
            Link = link;
            Audience = audience;
        }
    }
}