using RestDotNet5.Model;
using System.Collections.Generic;

namespace RestDotNet5.Repository
{
    public interface IPessoaRepository
    {
        Pessoa Create(Pessoa pessoa);
        Pessoa FindByID(long id);
        List<Pessoa> FindAll();
        Pessoa Update(Pessoa pessoa);
        void Delete(long id);

        bool Exists(long id);

    }
}
