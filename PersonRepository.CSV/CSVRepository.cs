﻿using System;
using System.Collections.Generic;
using PersonRepository.Interface;
using PeopleViewer.SharedObjects;

namespace PersonRepository.CSV
{
    public class CSVRepository : IPersonRepository
    {
        string path;

        public CSVRepository()
        { }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
