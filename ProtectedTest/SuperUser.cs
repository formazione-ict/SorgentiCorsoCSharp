using System;
namespace ProtectedTest
{
    public class SuperUser : ProtectedBaseClass.User
    {
        public SuperUser()
        {
        }

        public void Test()
        {
            base.age = 10;
            base.firstName = "Mario";
        }

        public int GetAge() {
            return base.age;
        }

        public int Height
        {
            get;
            set;
        }
    }
}
