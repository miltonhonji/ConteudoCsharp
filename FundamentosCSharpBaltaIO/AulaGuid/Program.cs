using System;

namespace AulaGuid
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            //id.ToString();
            id = new Guid("bef6dfa3-021c-416b-9689-aa775e3d124c");
            id = new Guid();
            Console.WriteLine(id);
        }
    }
}
