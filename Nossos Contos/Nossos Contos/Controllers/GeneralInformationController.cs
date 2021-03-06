﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nossos_Contos.Entities;
using Nossos_Contos.Models;
using Nossos_Contos.Models.MongoDB;


namespace Nossos_Contos.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class GeneralInformationController : Base.BaseController
    {

        public GeneralInformationController(DatabaseSettings databaseSettings) : base(databaseSettings)
        {

        }

        [HttpPost]
        public Entities.GeneralInformation Create(Entities.GeneralInformation generalInformation)
        {
            return generalInformationRepository.Create(generalInformation);
        }


        [HttpGet]
        public List<Entities.GeneralInformation> GetGeneralInformation()
        {
            return generalInformationRepository.Find(g => true);
        }


    }
}