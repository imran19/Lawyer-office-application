﻿using System;
using System.Collections.Generic;
using NSI.BLL.Interfaces;
using NSI.DC.PricingPackageRepository;
using NSI.Repository.Interfaces;

namespace NSI.BLL
{
    public class PricingPackageManipulation:IPricingPackageManipulation
    {
        private readonly IPricingPackageRepository _pricingPackageRepository;

        public PricingPackageManipulation(IPricingPackageRepository picingPackageRepository)
        {
            _pricingPackageRepository = picingPackageRepository;
        }

        public PricingPackageDto GetPricingPackage(int pricingPackageId)
        {
            return _pricingPackageRepository.GetPricingPackage(pricingPackageId);
        }

        public IEnumerable<PricingPackageDto> GetPricingPackages()
        {
            return _pricingPackageRepository.GetAllPricingPackages();
        }

        public IEnumerable<PricingPackageDto> GetActivePricingPackages()
        {
            return _pricingPackageRepository.GetActivePricingPackages();
        }
        public PricingPackageDto SavePricingPackage(PricingPackageDto pricingPackage)
        {
            return _pricingPackageRepository.SavePricingPackage(pricingPackage);
        }

        public bool DeletePricingPackageById(int pricingPackageId)
        {
            return _pricingPackageRepository.DeletePricingPackage(pricingPackageId);
        }

        public PricingPackageDto GetUserPricingPackage(int userId)
        {
            return _pricingPackageRepository.GetUserPricingPackage(userId);
        }

    }
}
