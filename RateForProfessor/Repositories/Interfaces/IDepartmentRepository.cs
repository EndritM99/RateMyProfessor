﻿using RateForProfessor.Entities;

namespace RateForProfessor.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        public List<DepartmentEntity> GetAllDepartments();

        public DepartmentEntity GetDepartmentById(int id);

        public List<DepartmentEntity> GetDepartmentsByUniversity(int universityId);

        public DepartmentEntity CreateDepartment(DepartmentEntity department);

        public void UpdateDepartment(DepartmentEntity department);

        public void DeleteDepartment(int id);
        public DepartmentEntity GetDepartmentByName(string name);
        
    }
}
