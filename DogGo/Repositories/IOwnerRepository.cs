using DogGo.Models;
using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        //Owner DeleteOwner();
        Owner AddOwner(Owner owner);
        //Owner UpdateOwner();
    }
}
