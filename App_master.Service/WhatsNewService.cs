using App_master.Data.Repository;
using App_master.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_master.Service
{
    public interface IWhatsNewService
    {
       
            IEnumerable<WhatsNew> GetWhatsNew();

            WhatsNew  GetWhatsNew(int id);

            void CreateWhatsNew(WhatsNew whatsnew);
            void DeleteWhatsNew(int id);

            void UpdateWhatsNew(WhatsNew whatsnew);

        
    }

    public class WhatsNewService:IWhatsNewService
    {
        private readonly IWhatsNewRepository whatsnewRepository;
        public WhatsNewService(IWhatsNewRepository whatsnewRepository)
        {
            this.whatsnewRepository = whatsnewRepository;
        }

        #region IBannerService members
        public void CreateWhatsNew(WhatsNew whatsnew)
        {
            whatsnewRepository.Add(whatsnew);
        }

        public void DeleteWhatsNew(int id)
        {
            var whats = whatsnewRepository.GetById("id");
            whatsnewRepository.Delete(whats);
        }

        public IEnumerable<WhatsNew> GetWhatsNew()
        {
            var a = whatsnewRepository.GetAll();
            return a;
        }

        public WhatsNew GetWhatsNew(int id)
        {
            var whats = whatsnewRepository.GetById("id");
            return whats;
        }

        public void UpdateWhatsNew(WhatsNew whatsnew)
        {
            whatsnewRepository.Update(whatsnew);
        }
        #endregion
    }
}
