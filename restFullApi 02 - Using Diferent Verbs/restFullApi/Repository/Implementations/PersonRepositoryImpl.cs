﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using restFullApi.model;
//using restFullApi.model.Context;

//namespace restFullApi.Repository.Implementations
//{
//    public class PersonRepositoryImpl : IPersonRepository
//    {
//        private MySQLContext _context;

//        public PersonRepositoryImpl(MySQLContext context)
//        {
//            _context = context;
//        }

//        //private volatile int count;

//        public Person Create(Person person)
//        {
//            try
//            {
//                _context.Add(person);
//                _context.SaveChanges();
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }
//            return person;
//        }

//        public void Delete(long id)
//        {
//            var result = _context.person.SingleOrDefault(p => p.Id.Equals(id));

//            try
//            {
//                if (result != null) _context.person.Remove(result);
//                _context.SaveChanges();
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }

//        }

//        public List<Person> FindAll()
//        {
//            return _context.person.ToList();
//        }

//        public Person FindById(long id)
//        {
//            return _context.person.SingleOrDefault(p => p.Id.Equals(id));
//        }

//        public Person Update(Person person)
//        {
//            if (!Exist(person.Id)) return null;

//            var result = _context..SingleOrDefault(p => p.Id.Equals(person.Id));

//            try
//            {
//                _context.Entry(result).CurrentValues.SetValues(person);
//                _context.SaveChanges();
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }
//            return person;
//        }

//        public bool Exist(long? id)
//        {
//            return _context.Person.Any(p => p.Id.Equals(id));
//        }
//    }
//}
