using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Collections
    {
       

        SortedList<string,Student> L = new SortedList<string,Student>();

        public void f()
        {
            AddMockData();

            foreach(var student in L )
            {
                Console.WriteLine(student.Value.Nume + ": " + student.Value.Nota);
            }
        }

        private void AddMockData()
        {
            L.Add("Silviu",
                new Student
                {
                    Nume = "Silviu",
                    Nota = 9
                }
                );
            L.Add("Andrei",
                 new Student
                 {
                     Nume = "Andrei",
                     Nota = 6
                 }
                 );
            L.Add("Ion",
                new Student
                {
                    Nume = "Ion",
                    Nota = 3
                }
                );
        }
    }
}
