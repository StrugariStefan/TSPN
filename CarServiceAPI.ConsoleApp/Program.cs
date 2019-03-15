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
            
            RepositoryWrapper.Repository.MecanicWriteRepository.Create(new Mecanic("Strugari", "Stefan"));
            RepositoryWrapper.Repository.MecanicWriteRepository.SaveChanges();
            IReadOnlyList<Mecanic> mecanics = RepositoryWrapper.Repository.MecanicReadRepository.GetAll();
            foreach (var mecanic in mecanics)
            {
                Console.WriteLine(mecanic);
            }
        }
    }
}
