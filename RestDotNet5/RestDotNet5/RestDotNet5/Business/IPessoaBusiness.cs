using RestDotNet5.Model;
using System.Collections.Generic;

namespace RestDotNet5.Business
{
    public interface IPessoaBusiness
    {
        Pessoa Create(Pessoa pessoa);
        Pessoa FindByID(long id);
        List<Pessoa> FindAll();
        Pessoa Update(Pessoa pessoa);
        void Delete(long id);

    }
}
