﻿using backend.Repositories.Interfaces;
using Integration_Class_Library.TenderingEntity.Interfaces;
using Integration_Class_Library.TenderingEntity.Models;
using System.Collections.Generic;

namespace Integration_Class_Library.TenderingEntity.Services
{
    public class MedicineService
    {
        IMedicineRepository medicineRepository;
        IMedicineInventoryRepository medicineInventoryRepository;

        public MedicineService(IMedicineRepository medicineRepository, IMedicineInventoryRepository medicineInventoryRepository)
        {
            this.medicineRepository = medicineRepository;
            this.medicineInventoryRepository = medicineInventoryRepository;
        }

        public List<Medicine> GetAll() => medicineRepository.GetAll();

        public bool Save(Medicine medicine)
        {
            return (medicineRepository.Save(medicine));
        }

        public Medicine GetByID(int id)
        {
            return medicineRepository.GetByID(id);
        }

        public Medicine GetByNameAndDose(string name, int dose)
        {
            return medicineRepository.GetByNameAndDose(name, dose);
        }

        public bool DeleteMedicine(int id)
        {
            Medicine medicineToDelete = medicineRepository.GetByID(id);
            if (medicineToDelete == null) return false;

            medicineRepository.Delete(medicineToDelete);
            return true;
        }

        public bool ProcessOrder(Medicine medicine, int quantity)
        {
            //CheckIfAvailable -> Update inventory
            if (medicineRepository.MedicineExists(medicine))
            {
                MedicineInventory inventory = new MedicineInventory(medicine.Id, quantity);
                return (medicineInventoryRepository.Update(inventory));
            }

            return false;
        }

        public bool MedicineExists(Medicine medicine)
        {
            return medicineRepository.MedicineExists(medicine);
        }
    }
}
