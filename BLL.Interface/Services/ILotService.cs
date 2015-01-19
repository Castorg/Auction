using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;
using CustomORM;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;

namespace BLL.Interface.Services
{
    public interface ILotService
    {
        IUnitOfWork UnitOfWork { get; }
        ILotRepository Repository { get; }

        List<LotEntity> GetAll();
        void Insert(LotEntity entity);
        void Update(LotEntity entity);
        void Delete(LotEntity entity);

        LotEntity GetById(int id);

        List<LotEntity> GetLotEntityBySubMask(string mask);
    }
}
