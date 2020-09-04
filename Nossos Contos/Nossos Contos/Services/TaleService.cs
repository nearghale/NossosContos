﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nossos_Contos.Services
{
    public class TaleService
    {
        private Repositories.MongoDB.PersistentRepository<Entities.Tale> _taleRepository;
        private Repositories.MongoDB.PersistentRepository<Entities.Account> _accountRepository;


        public TaleService(Repositories.MongoDB.PersistentRepository<Entities.Account> accountRepository, Repositories.MongoDB.PersistentRepository<Entities.Tale> taleRepository)
        {

            _taleRepository = taleRepository;
            _accountRepository = accountRepository;

        }

        public Entities.Tale Create(Entities.Account account, Entities.Tale tale)
        {
            var newTale = new Entities.Tale();
            newTale.Author = account.UserName;
            newTale.Genre = tale.Genre;
            newTale.id = tale.id;
            newTale.IDUser = tale.IDUser;
            newTale.MinimumAge = tale.MinimumAge;
            newTale.NumberComplaints = tale.NumberComplaints;
            newTale.NumberViews = tale.NumberViews;
            newTale.TaleText = tale.TaleText;
            newTale.Title = tale.Title;

            return _taleRepository.Create(newTale);

        }

        public List<Entities.Tale> GetTalesAuthor(string id)
        {

            return _taleRepository.Find(t => t.IDUser == id);

        }

    }
}
