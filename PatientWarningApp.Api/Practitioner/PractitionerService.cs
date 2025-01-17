﻿using System;
using System.Collections.Generic;
using PatientWarningApp.Api.Practitioner.Interfaces;
using PatientWarningApp.Api.Practitioner.Models;

namespace PatientWarningApp.Api.Practitioner
{
    public class PractitionerService : IPractitionerService
    {
        private readonly IPractitionerRepository _practitionerRepository;

        public PractitionerService(IPractitionerRepository practitionerRepository)
        {
            _practitionerRepository = practitionerRepository;
        }

        public PractitionerModel Create(PractitionerModel model)
        {
            var result = _practitionerRepository.Create(model.ToEntity());
            return result.ToModel();
        }

        public PractitionerModel Delete(PractitionerModel model)
        {
            var result = _practitionerRepository.Delete(model.ToEntity());
            return result.ToModel();
        }

        public PractitionerModel Read(int id)
        {
            var result = _practitionerRepository.Read(id);
            return result.ToModel();
        }

        public List<PractitionerModel> ReadAll()
        {
            throw new NotImplementedException();
        }

        public PractitionerModel Update(PractitionerModel model)
        {
            var result = _practitionerRepository.Update(model.ToEntity());
            return result.ToModel();
        }
    }
}
