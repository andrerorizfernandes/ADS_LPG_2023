using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public class MyCustomClass
    {
        //1. atributo privado com getter e setter
        private int age;
        public void SetAge(int pAge)
        {
            age = pAge;
        }

        public int GetAge()
        {
            return age;
        }

        //2. propertie
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //3. auto-propertie
        public int Number { get; set; }

        public int Multiply(int pNumber)
        {
            return (Number * pNumber);
        }

        public MyCustomClass()
        {
            Number = 0;
        }
    }
}
