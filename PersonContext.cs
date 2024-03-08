namespace Percobaan1.Models
{
    public class PersonContext
    {
        public List<Person> ListPerson ()
        {
            List<Person> list1 = new List<Person>();
            Object[,] arrayPerson = new object[,] {
                {1, "Pandu", "Cibubur", "pandupan@gmail.com" },
                {2, "Erika", "Yogyakarta", "nataliasafe@gmail.com" },
                {3, "Salma", "Madiun", "salmabila@gmail.com" }
            };
            for (int i = 0; i < arrayPerson.GetLength(0); i++)
            {
                list1.Add(new Person()
                {
                    id_person = int.Parse(arrayPerson[i, 0].ToString()),
                    name = arrayPerson[i, 1].ToString(),
                    address = arrayPerson[i, 2].ToString(),
                    email = arrayPerson[i, 3].ToString(),

                });
            }
            return list1;
        }
    }
}
