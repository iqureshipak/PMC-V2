using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        //IEventsRepository events { get; }
        //IReservationsRepository reservations { get; }  
        //IUserRepository users { get; }
        //IRoleRepository roles { get; }
        //IUserRoleRepository userRoles { get; }
        //ICountryRepository countries { get; }
        //IGenderRepository genders { get; }
        //IPhotoRepository photo { get; }
        //IParentResourcesRepository parentResources { get; }
        //IChildResourcesRepository childResources { get; }
        //IClientRepository clients { get; }
        void Save();
    }
}
