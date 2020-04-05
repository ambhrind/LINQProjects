using System;
using System.Collections.Generic;
using System.Text;

namespace LINQProjects
{
    public class EnumerateSpecificFields
    {
        private string firstName, middleName, lastName;
        private int age;
        private string gender;

        public EnumerateSpecificFields(string fNAme, string mName, string lNAme, int age, string gender)
        {
            firstName = fNAme;
            middleName = mName;
            lastName = lNAme;
            this.age = age;
            this.gender = gender;
        }

        /// <summary>
        /// This only provides the capability to iterate the names and not the other fields
        /// </summary>
        public IEnumerable<string> Names
        {
            get
            {
                yield return firstName;
                yield return middleName;
                yield return lastName;
            }
        }
    }
}
