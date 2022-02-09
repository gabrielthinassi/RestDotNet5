using RestDotNet5.Model;
using System.Collections.Generic;
using System.Threading;

namespace RestDotNet5.Services.Implementations
{
    public class PessoaServiceImplementation : IPessoaService
    {
        private volatile int count;

        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }

        public void Delete(long id)
        {
            
        }

        public List<Pessoa> FindAll()
        {
            List<Pessoa> persons = new List<Pessoa>();
            for (int i = 0; i < 8; i++)
            {
                Pessoa person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Pessoa FindByID(long id)
        {
            return new Pessoa
            {
                Id = IncrementAndGet(),
                Nome = "Gabriel",
                Sobrenome = "Thinassi",
                Endereco = "Ioná Floriano - 169, Ubá - MG",
                Genero = "Masculino"
            };
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return pessoa;
        }

        private Pessoa MockPerson(int i)
        {
            return new Pessoa
            {
                Id = IncrementAndGet(),
                Nome = "Pessoa Nome" + i,
                Sobrenome = "Pessoa Sobrenome" + i,
                Endereco = "Pessoa Endereço" + i,
                Genero = "Masculino"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
