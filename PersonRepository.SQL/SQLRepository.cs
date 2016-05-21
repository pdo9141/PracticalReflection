using System;
using System.Collections.Generic;
using PersonRepository.Interface;
using PeopleViewer.SharedObjects;

namespace PersonRepository.SQL
{
    public class SQLRepository : IPersonRepository
    {
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

        private DataPerson GetDataPerson(PeopleEntities context, string lastName)
        {
            throw new NotImplementedException();
        }

        private Person GetPersonFromDataPerson(DataPerson dataPerson)
        {
            throw new NotImplementedException();
        }
    }
}
