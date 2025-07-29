using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;
using BooklyBookStoreApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooklyBookStoreApp.Persistence.Repositorires
{
    public class FavoriteRepository : RepositoryBase<Favorites>, IFavoriteRepository
    {
        public FavoriteRepository(AppDbContext context) : base(context)
        {
        }

        public void CreateFavorite(Favorites favorites) => Create(favorites);

        public IQueryable<Favorites> GetAll(bool trackChanges) => FindAll(trackChanges);
       
    }
}
