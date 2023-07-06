﻿using RateForProfessor.Context;
using RateForProfessor.Entities;
using RateForProfessor.Repositories.Interfaces;

namespace RateForProfessor.Repositories
{
    public class UniversityRepository: IUniversityRepository
    {
        private readonly AppDbContext _dbContext;

        public UniversityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<UniversityEntity> GetAllUniversites()
        {
            var universitet = _dbContext.Universities.ToList();
            return universitet;
        }

        public UniversityEntity GetUniversityById(int id)
        {
            var universiteti = _dbContext.Universities.Find(id);
            return universiteti;
        }

        public UniversityEntity GetUniversityByName(string name)
        {
            var universiteti = _dbContext.Universities.FirstOrDefault(u => u.Name == name);
            return universiteti;
        }

        public UniversityEntity CreateUniversity(UniversityEntity university)
        {
            _dbContext.Universities.Add(university);
            _dbContext.SaveChanges();
            return university;
        }

        public void UpdateUniversity(UniversityEntity university)
        {
            var UniversityId = university.UniversityId;
            var oldUniversity = _dbContext.Universities.Find(UniversityId);
            _dbContext.Entry(oldUniversity).CurrentValues.SetValues(university);
            _dbContext.SaveChanges();
            Console.WriteLine("University: " + oldUniversity.Name + " Updated Successful!");
        }

        public void DeleteUniversity(int id)
        {
            var universiteti = _dbContext.Universities.Find(id);
            _dbContext.Universities.Remove(universiteti);
            _dbContext.SaveChanges();
            Console.WriteLine("University: "+universiteti.Name+" Deleted Successful!");
        }
    }
}
