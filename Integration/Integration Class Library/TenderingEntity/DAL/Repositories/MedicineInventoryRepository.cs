﻿using Integration_Class_Library.TenderingEntity.Interfaces;
using Integration_Class_Library.TenderingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Integration_Class_Library.TenderingEntity.DAL.Repositories
{
    public class MedicineInventoryRepository : IMedicineInventoryRepository
    {
        private readonly MedicineDbContext _dataContext;

        public MedicineInventoryRepository(MedicineDbContext dataContext) => _dataContext = dataContext;

        public bool CheckMedicineQuantity(MedicineInventory medicineInventory)
        {
            if (_dataContext.MedicineInventory.Any(m => m.MedicineId.Equals(medicineInventory.MedicineId) 
            && m.Quantity >= medicineInventory.Quantity)) return true;
            return false;
        }

        public void Delete(MedicineInventory entity)
        {
            _dataContext.MedicineInventory.Remove(entity);
            _dataContext.SaveChanges();
        }

        public List<MedicineInventory> GetAll()
        {
            return _dataContext.MedicineInventory.ToList();
        }

        public bool Save(MedicineInventory entity)
        {
            _dataContext.MedicineInventory.Add(entity);
            _dataContext.SaveChanges();
            return true;
        }

        public bool Update(MedicineInventory entity)
        {
            MedicineInventory result = _dataContext.MedicineInventory.SingleOrDefault(m => m.MedicineId.Equals(entity.MedicineId));
            if (result != null)
            {
                result.Quantity += entity.Quantity;
                if (result.Quantity < 0) return false;
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }

       
    }
}
