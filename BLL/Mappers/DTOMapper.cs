using AutoMapper;
using BLL.Interface.Entities;
using CustomORM;

namespace BLL.Mappers
{
    public static class DTOMapper
    {
        static DTOMapper()
        {
            #region Lot
            Mapper.CreateMap<Lot, LotEntity>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LotId))
               .ForMember(dest => dest.CurrentCost, opt => opt.MapFrom(src => src.CurrentCost))
               .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
               .ForMember(dest => dest.StoreId, opt => opt.MapFrom(src => src.Store.StoreId));
            Mapper.CreateMap<LotEntity, Lot>()
                .ForMember(dest => dest.LotId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CurrentCost, opt => opt.MapFrom(src => src.CurrentCost))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Store, opt => opt.MapFrom(src => new Store{StoreId = src.StoreId}));
            #endregion
            #region Store
            Mapper.CreateMap<Store, StoreEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.StoreId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Addres, opt => opt.MapFrom(src => src.Addres));
            Mapper.CreateMap<StoreEntity, Store>()
               .ForMember(dest => dest.StoreId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Addres, opt => opt.MapFrom(src => src.Addres));
            #endregion
            #region Role
            Mapper.CreateMap<Role, RoleEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RoleId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
            Mapper.CreateMap<RoleEntity, Role>()
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            #endregion
            #region User

            Mapper.CreateMap<User, UserEntity>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Name));


            Mapper.CreateMap<UserEntity, User>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.UserName));

            #endregion
        }
        public static LotEntity ToLotEntity(this Lot lot)
        {
            return Mapper.Map<Lot, LotEntity>(lot);
        }
        public static Lot ToLot(this LotEntity lotEntity)
        {
            return Mapper.Map<LotEntity, Lot>(lotEntity);
        }


        public static Store ToStore(this StoreEntity storeEntity)
        {
            return Mapper.Map<StoreEntity, Store>(storeEntity);
        }
        public static StoreEntity ToStoreEntity(this Store store)
        {
            return Mapper.Map<Store, StoreEntity>(store);
        }


        public static Role ToRole(this RoleEntity roleEntity)
        {
            return Mapper.Map<RoleEntity, Role>(roleEntity);
        }
        public static RoleEntity ToRoleEntity(this Role role)
        {
            return Mapper.Map<Role, RoleEntity>(role);
        }


        public static User ToUser(this UserEntity userEntity)
        {
            return Mapper.Map<UserEntity, User>(userEntity);
        }
        public static UserEntity ToUserEntity(this User user)
        {
            return Mapper.Map<User, UserEntity>(user);
        }
    }
}
