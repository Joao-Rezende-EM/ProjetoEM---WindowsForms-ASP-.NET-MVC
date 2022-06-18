﻿using EM.Domain;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM.Repository
{
    public abstract class RepositorioAbstrato <T> where T : IEntidade
    {
        public abstract void Add(T aluno);
        public abstract void Update(T aluno);
        public abstract void Remove(T aluno);
        public abstract IEnumerable<T> GetAll();
        public abstract IEnumerable<T> Get(Expression < Func < T, bool >> predicate);
    }
}
