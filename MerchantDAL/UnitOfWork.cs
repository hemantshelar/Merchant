using DAL.DbEntities;
using MerchantDAL.DbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantDAL
{
    public class UnitOfWork
    {
        //Storing it here for unit testing.
        private static readonly string connectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=MerchantsDb;Integrated Security=True";
        MerchantDbContext _dbContext = new MerchantDbContext(connectionString);

        public IRepository<Merchant> MerchantRepository;
        public IRepository<Address> AddressRepository;
       

        public UnitOfWork()
        {
            MerchantRepository = new Repository<Merchant>(_dbContext);
            AddressRepository = new Repository<Address>(_dbContext);
        }


        public void SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
