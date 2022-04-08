using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IEventsRepository _events;
        private IReservationsRepository _reservations;
        private IUserRepository _users;
        private IRoleRepository _roles;
        private IUserRoleRepository _userRoles;
        private ICountryRepository _countries;
        private IGenderRepository _genders;
        private IPhotoRepository _photo;
        private IParentResourcesRepository _parentResources;
        private IChildResourcesRepository _childResources;
        private IClientRepository _clients;
        public IEventsRepository events
        {
            get
            {
                if (_events == null)
                {
                    _events = new EventsRepository(_repoContext);
                }
                return _events;
            }
        }
        public IReservationsRepository reservations
        {
            get
            {
                if (_reservations == null)
                {
                    _reservations = new ReservationsRepository(_repoContext);
                }
                return _reservations;
            }
        }
        public IUserRepository users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_repoContext);
                }
                return _users;
            }
        }
        public IRoleRepository roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RoleRepository(_repoContext);
                }
                return _roles;
            }
        }
        public IUserRoleRepository userRoles
        {
            get
            {
                if (_userRoles == null)
                {
                    _userRoles = new UserRoleRepository(_repoContext);
                }
                return _userRoles;
            }
        }
        public ICountryRepository countries
        {
            get
            {
                if (_countries == null)
                {
                    _countries = new CountryRepository(_repoContext);
                }
                return _countries;
            }
        }
        public IGenderRepository genders
        {
            get
            {
                if (_genders == null)
                {
                    _genders = new GenderRepository(_repoContext);
                }
                return _genders;
            }
        }
        public IPhotoRepository photo
        {
            get
            {
                if (_photo == null)
                {
                    _photo = new PhotoRepository(_repoContext);
                }
                return _photo;
            }
        }
        public IParentResourcesRepository parentResources
        {
            get
            {
                if (_parentResources == null)
                {
                    _parentResources = new ParentResourcesRepository(_repoContext);
                }
                return _parentResources;
            }
        }
        public IChildResourcesRepository childResources
        {
            get
            {
                if (_childResources == null)
                {
                    _childResources = new ChildResourcesRepository(_repoContext);
                }
                return _childResources;
            }
        }
        public IClientRepository clients
        {
            get
            {
                if (_clients == null)
                {
                    _clients = new ClientRepository(_repoContext);
                }
                return _clients;
            }
        }
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
