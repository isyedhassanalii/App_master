using App_master.Data.Repository;
using App_master.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_master.Service
{
    public interface IStructuredService {

        IEnumerable<Structured> GetStructured();

        Structured GetStructured(int id);

        void CreateStructured(Structured structured);
        void DeleteStructured(int id);

        void UpdateStructured(Structured structured);
    }
    public class StructuredService : IStructuredService
    {
        private readonly IStructuredRepository structuredRepository;

        public StructuredService(IStructuredRepository structuredRepository)
        {
            this.structuredRepository = structuredRepository;
        }
        #region IStructuredService members
        public void CreateStructured(Structured structured)
        {
            structuredRepository.Add(structured);
        }

        public void DeleteStructured(int id)
        {
            var str = structuredRepository.GetById("id");
            structuredRepository.Delete(str);
        }

        public IEnumerable<Structured> GetStructured()
        {
             var a =structuredRepository.GetAll();
            return a;
        }

        public Structured GetStructured(int id)
        {
            var st = structuredRepository.GetById("id");
            return st;
        }

        public void UpdateStructured(Structured structured)
        {
            structuredRepository.Update(structured);
        }
        #endregion
    }
}
