﻿using NHibernate.Criterion;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Integration.Spec;
using SQFramework.Data.Pagging;
using SQFramework.Spring.Data.Hibernate;

namespace ControleDeEstoque.Integration.Impl
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository<Categoria>
    {
        public PageMessage<Categoria> ListarCategorias(int startIndex, int pageSize, string orderProperty, bool orderAscending)
        {
            var criteria = DetachedCriteria.For<Categoria>();

            return Page<Categoria>(criteria, startIndex, pageSize, orderProperty, orderAscending);
        }
    }
}