namespace Generics_Sample
{
    public class AllInfoUser : IUserInfo
    {
        public AllInfoUser()
        {
        }

        public AllInfoUser(string Family, string uName, int uAge)
        {
            this.Family = Family;
            Name = uName;
            Age = uAge;
        }

        public string Family { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            var s = string.Format("Info about User: \n{0} {1} {2}\n", Name, Family, Age);
            return s;
        }
    }
}