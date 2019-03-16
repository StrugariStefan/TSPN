using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;
using CarServiceAPI.Repository;

namespace CarServiceAPI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IRepositoryWrapper repo = new RepositoryWrapper();
            repo.MecanicWriteRepository.Create(new Mecanic("Strugari", "Stefan"));
            repo.MecanicWriteRepository.SaveChanges();
            IReadOnlyList<Mecanic> mecanics = repo.MecanicReadRepository.GetAll();
            foreach (var mecanic in mecanics)
            {
                Console.WriteLine(mecanic);
            }
        }
    }
}
