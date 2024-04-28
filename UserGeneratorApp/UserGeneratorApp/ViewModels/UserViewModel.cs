namespace UserGeneratorApp.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {
        }

        public UserViewModel(string name, string email, string gender, DateTime image) : this()
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
            this.BirthDay = image;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
    }
   
}
