using App_master.Data.Repository;
using App_master.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_master.Service
{

    public interface IBannerService
    {
        IEnumerable<Banner> GetBanner();
       
        Banner GetBanner(int id);
     
        void CreateBanner(Banner banner);
        void DeleteBanner(int id);
   
        void UpdateBanner(Banner banner);
      
    }

   public class BannerService:IBannerService
    {
        private readonly IBannerRepository bannerRepository;
        public BannerService(IBannerRepository bannerRepository)
        {
            this.bannerRepository = bannerRepository;
        }

        #region IBannerService members
        public void CreateBanner(Banner banner)
        {
           bannerRepository.Add(banner);
          
        }

        public void DeleteBanner(int id)
        {
            var banner = bannerRepository.GetById("id");
            bannerRepository.Delete(banner);
        }

        public IEnumerable<Banner> GetBanner()
        {
           var banner = bannerRepository.GetAll();
            return banner;
        }

        public Banner GetBanner(int id)
        {
            var banner = bannerRepository.GetById("id");
            return banner;
        }

        public void UpdateBanner(Banner banner)
        {
            bannerRepository.Update(banner);
        }
        #endregion
    }
}
