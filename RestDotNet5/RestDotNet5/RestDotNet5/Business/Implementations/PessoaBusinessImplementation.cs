using RestDotNet5.Model;
using RestDotNet5.Model.Context;
using RestDotNet5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RestDotNet5.Business.Implementations
{
    public class PessoaBusinessImplementation : IPessoaBusiness
    {
        private readonly IPessoaRepository _repository;

        public PessoaBusinessImplementation(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public List<Pessoa> FindAll()
        {
            return _repository.FindAll();
        }

        public Pessoa FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Pessoa Create(Pessoa pessoa)
        {
            return _repository.Create(pessoa);
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return _repository.Update(pessoa);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
