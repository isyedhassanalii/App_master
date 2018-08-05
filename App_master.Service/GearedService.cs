using App_master.Data.Repository;
using App_master.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_master.Service
{
    public interface IGearedService {
        IEnumerable<Geared> GetGeared();

        Geared GetGeared(int id);

        void CreateGeared(Geared geared);
        void DeleteGeared(int id);

        void UpdateGeared(Geared geared);
    }
     public class GearedService:IGearedService
    {
        private readonly IGearedRepository gearedRepository;
        public GearedService(IGearedRepository gearedRepository)
        {
            this.gearedRepository = gearedRepository;
        }

        #region IGearedService members
        public void CreateGeared(Geared geared)
        {
            gearedRepository.Add(geared);
        }

        public void DeleteGeared(int id)
        {
            var gr = gearedRepository.GetById("id");
            gearedRepository.Delete(gr);
        }

        public IEnumerable<Geared> GetGeared()
        {
            var gr = gearedRepository.GetAll();
            return gr;
        }

        public Geared GetGeared(int id)
        {
            var gr = gearedRepository.GetById("id");
            return gr;
        }

        public void UpdateGeared(Geared geared)
        {
            gearedRepository.Update(geared);
        }
        #endregion
    }
}
