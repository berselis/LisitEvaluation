using System;

namespace RegisterApp.ModelsDTOs
{
    public class EmployeeModel
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Offic { get; set; }
        public DateTime DateStart { get; set; }
    }
}
