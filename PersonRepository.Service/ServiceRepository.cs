using System;
using System.Collections.Generic;
using PersonRepository.Interface;
using PeopleViewer.SharedObjects;
using People.Service;

namespace PersonRepository.Service
{
    public class ServiceRepository : IPersonRepository
    {
        private IPersonService _serviceProxy;

        public IPersonService ServiceProxy { get; set; }

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
