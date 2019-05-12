using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;
using CarServiceAPI.Repository;

namespace ObjectWCF
{
    public class CarService : ICarService
    {
        private readonly IRepositoryWrapper _repository;

        public CarService()
        {
            _repository = new RepositoryWrapper();
        }

        void InterfaceAuto.AddAuto(Auto auto)
        {
            _repository.AutoWriteRepository.Create(auto);
            _repository.AutoWriteRepository.SaveChanges();
        }

        void InterfaceAuto.UpdateAuto(Auto auto)
        {
            _repository.AutoWriteRepository.Update(auto);
        }

        void InterfaceAuto.DeleteAuto(int id)
        {
            if (_repository.AutoWriteRepository.Exists(id))
            {
                _repository.AutoWriteRepository.Delete(id);
                _repository.AutoWriteRepository.SaveChanges();
            }
        }

        IReadOnlyList<Auto> InterfaceAuto.GetAutoes()
        {
            return _repository.AutoReadRepository.GetAll();
        }

        Auto InterfaceAuto.GetAutoById(int id)
        {
            if (_repository.AutoReadRepository.Exists(id))
            {
                return _repository.AutoReadRepository.GetById(id);
            }

            return null;
        }

        List<Auto> InterfaceAuto.GetAutoesBySasiuId(int sasiuId)
        {
            if (_repository.SasiuReadRepository.Exists(sasiuId))
            {
                return _repository.AutoReadRepository.GetBySasiuId(sasiuId);
            }

            return null;
        }

        IReadOnlyList<Auto> InterfaceAuto.GetAutoesByCondition(Expression<Func<Auto, bool>> expression)
        {
            return _repository.AutoReadRepository.GetByCondition(expression);
        }




        void InterfaceClient.AddClient(Client client)
        {
            _repository.ClientWriteRepository.Create(client);
            _repository.ClientWriteRepository.SaveChanges();
        }

        void InterfaceClient.UpdateClient(Client client)
        {
            _repository.ClientWriteRepository.Update(client);
            _repository.ClientWriteRepository.SaveChanges();
        }

        void InterfaceClient.DeleteClient(int id)
        {
            if (_repository.ClientWriteRepository.Exists(id))
            {
                _repository.ClientWriteRepository.Delete(id);
                _repository.ClientWriteRepository.SaveChanges();
            }
        }

        IReadOnlyList<Client> InterfaceClient.GetClients()
        {
            return _repository.ClientReadRepository.GetAll();
        }

        Client InterfaceClient.GetClientById(int id)
        {
            if (_repository.ClientReadRepository.Exists(id))
            {
                return _repository.ClientReadRepository.GetById(id);
            }

            return null;
        }

        Client InterfaceClient.GetClientByAutoId(int autoId)
        {
            if (_repository.AutoReadRepository.Exists(autoId))
            {
                return _repository.ClientReadRepository.GetByAutoId(autoId);
            }

            return null;
        }

        IReadOnlyList<Client> InterfaceClient.GetClientsByCondition(Expression<Func<Client, bool>> expression)
        {
            return _repository.ClientReadRepository.GetByCondition(expression);
        }


        // Comanda



        void InterfaceComanda.AddComanda(Comanda comanda)
        {
            _repository.ComandaWriteRepository.Create(comanda);
            DetaliuComanda detaliuComanda = new DetaliuComanda(comanda);
            _repository.DetaliuWriteRepository.Create(detaliuComanda);
            _repository.ComandaWriteRepository.SaveChanges();
        }

        void InterfaceComanda.UpdateComanda(Comanda comanda)
        {
            _repository.ComandaWriteRepository.Update(comanda);
            _repository.ComandaWriteRepository.SaveChanges();
        }

        void InterfaceComanda.DeleteComanda(int id)
        {
            if (_repository.ComandaWriteRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.Delete(detaliuComanda.DetaliuComandaId);
                _repository.ComandaWriteRepository.Delete(id);
                _repository.ComandaWriteRepository.SaveChanges();
            }
        }

        IReadOnlyList<Comanda> InterfaceComanda.GetComandas()
        {
            return _repository.ComandaReadRepository.GetAll();
        }

        Comanda InterfaceComanda.GetComandaById(int id)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                return _repository.ComandaReadRepository.GetById(id);
            }

            return null;
        }

        IReadOnlyList<Comanda> InterfaceComanda.GetComandasByCondition(Expression<Func<Comanda, bool>> expression)
        {
            return _repository.ComandaReadRepository.GetByCondition(expression);
        }

        IReadOnlyList<Comanda> InterfaceComanda.GetComandasByClientId(int clientId)
        {
            if (_repository.ClientReadRepository.Exists(clientId))
            {
                return _repository.ComandaReadRepository.GetByClientId(clientId);
            }

            return null;
        }

        IReadOnlyList<Comanda> InterfaceComanda.GetComandasByAutoId(int autoId)
        {
            if (_repository.AutoReadRepository.Exists(autoId))
            {
                return _repository.ComandaReadRepository.GetByAutoId(autoId);
            }

            return null;
        }

        IReadOnlyList<Comanda> InterfaceComanda.GetComandasByStare(Stare stare)
        {
            return _repository.ComandaReadRepository.GetByStare(stare);
        }

        IReadOnlyList<Comanda> InterfaceComanda.GetComandasByMecanicId(int mecanicId)
        {
            if (_repository.MecanicReadRepository.Exists(mecanicId))
            {
                IReadOnlyList<DetaliuComanda> detaliuComandas = _repository.DetaliuReadRepository.GetByMecanicId(mecanicId);
                return (IReadOnlyList<Comanda>)_repository.ComandaReadRepository.GetAll().Where(c =>
                   detaliuComandas.Contains(_repository.DetaliuReadRepository.GetByComandaId(c.ComandaId)));
            }

            return null;

        }

        IReadOnlyList<Comanda> InterfaceComanda.GetComandasByOperatieId(int operatieId)
        {
            if (_repository.OperatieReadRepository.Exists(operatieId))
            {
                IReadOnlyList<DetaliuComanda> detaliuComandas =
                    _repository.DetaliuReadRepository.GetByOperatieId(operatieId);
                return (IReadOnlyList<Comanda>)_repository.ComandaReadRepository.GetAll().Where(c =>
                   detaliuComandas.Contains(_repository.DetaliuReadRepository.GetByComandaId(c.ComandaId)));
            }

            return null;
        }

        IReadOnlyList<Comanda> InterfaceComanda.GetComandasByMaterialId(int materialId)
        {
            if (_repository.MaterialWriteRepository.Exists(materialId))
            {
                IReadOnlyList<DetaliuComanda> detaliuComandas =
                    _repository.DetaliuReadRepository.GetByMaterialId(materialId);
                return (IReadOnlyList<Comanda>)_repository.ComandaReadRepository.GetAll().Where(c =>
                    detaliuComandas.Contains(_repository.DetaliuReadRepository.GetByComandaId(c.ComandaId)));
            }

            return null;
        }

        Comanda InterfaceComanda.GetComandaByImagineId(int imagineId)
        {
            if (_repository.ImagineWriteRepository.Exists(imagineId))
            {
                DetaliuComanda detaliuComanda =
                    _repository.DetaliuReadRepository.GetByImagineId(imagineId);
                return _repository.ComandaReadRepository.GetAll().FirstOrDefault(c =>
                    detaliuComanda.DetaliuComandaId == _repository.DetaliuReadRepository.GetByComandaId(c.ComandaId).DetaliuComandaId);
            }

            return null;
        }

        IReadOnlyList<Imagine> InterfaceComanda.GetImaginesByComandaId(int id)
        {
            if (_repository.ComandaWriteRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                return _repository.DetaliuReadRepository.GetAllImagesById(detaliuComanda.DetaliuComandaId);
            }

            return null;
        }

        void InterfaceComanda.AddComandaMecanic(int id, Mecanic mecanic)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.AddMecanic(detaliuComanda.DetaliuComandaId, mecanic);
                _repository.DetaliuWriteRepository.SaveChanges();

            }
        }

        void InterfaceComanda.AddComandaMaterial(int id, Material material)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.AddMaterial(detaliuComanda.DetaliuComandaId, material);
                _repository.DetaliuWriteRepository.SaveChanges();

            }
        }

        void InterfaceComanda.AddComandaOperatie(int id, Operatie operatie)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.AddOperatie(detaliuComanda.DetaliuComandaId, operatie);
                _repository.DetaliuWriteRepository.SaveChanges();

            }
        }

        void InterfaceComanda.RemoveComandaMecanic(int id, Mecanic mecanic)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.RemoveMecanic(detaliuComanda.DetaliuComandaId, mecanic);
                _repository.DetaliuWriteRepository.SaveChanges();
            }
        }

        void InterfaceComanda.RemoveComandaMaterial(int id, Material material)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.RemoveMaterial(detaliuComanda.DetaliuComandaId, material);
                _repository.DetaliuWriteRepository.SaveChanges();
            }
        }

        void InterfaceComanda.RemoveComandaOperatie(int id, Operatie operatie)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.RemoveOperatie(detaliuComanda.DetaliuComandaId, operatie);
                _repository.DetaliuWriteRepository.SaveChanges();
            }
        }


        // Material


        void InterfaceMaterial.AddMaterial(Material material)
        {
            _repository.MaterialWriteRepository.Create(material);
            _repository.MaterialWriteRepository.SaveChanges();
        }

        void InterfaceMaterial.UpdateMaterial(Material material)
        {
            _repository.MaterialWriteRepository.Update(material);
            _repository.MaterialWriteRepository.SaveChanges();
        }

        void InterfaceMaterial.DeleteMaterial(int id)
        {
            if (_repository.MaterialWriteRepository.Exists(id))
            {
                _repository.MaterialWriteRepository.Delete(id);
                _repository.MaterialWriteRepository.SaveChanges();
            }
        }

        IReadOnlyList<Material> InterfaceMaterial.GetMaterials()
        {
            return _repository.MaterialReadRepository.GetAll();
        }

        Material InterfaceMaterial.GetMaterialById(int id)
        {
            if (_repository.MaterialReadRepository.Exists(id))
            {
                return _repository.MaterialReadRepository.GetById(id);
            }

            return null;
        }

        IReadOnlyList<Material> InterfaceMaterial.GetMaterialsByCondition(Expression<Func<Material, bool>> expression)
        {
            return _repository.MaterialReadRepository.GetByCondition(expression);
        }

        // Mecanic


        void InterfaceMecanic.AddMecanic(Mecanic mecanic)
        {
            _repository.MecanicWriteRepository.Create(mecanic);
            _repository.MecanicWriteRepository.SaveChanges();
        }

        void InterfaceMecanic.UpdateMecanic(Mecanic mecanic)
        {
            _repository.MecanicWriteRepository.Update(mecanic);
            _repository.MecanicWriteRepository.SaveChanges();
        }

        void InterfaceMecanic.DeleteMecanic(int id)
        {
            if (_repository.MecanicWriteRepository.Exists(id))
            {
                _repository.MecanicWriteRepository.Delete(id);
                _repository.MecanicWriteRepository.SaveChanges();
            }
        }

        IReadOnlyList<Mecanic> InterfaceMecanic.GetMecanics()
        {
            return _repository.MecanicReadRepository.GetAll();
        }

        Mecanic InterfaceMecanic.GetMecanicById(int id)
        {
            if (_repository.MecanicReadRepository.Exists(id))
            {
                return _repository.MecanicReadRepository.GetById(id);
            }

            return null;
        }

        IReadOnlyList<Mecanic> InterfaceMecanic.GetMecanicsByCondition(Expression<Func<Mecanic, bool>> expression)
        {
            return _repository.MecanicReadRepository.GetByCondition(expression);
        }


        // Operatie



        void InterfaceOperatie.AddOperatie(Operatie operatie)
        {
            _repository.OperatieWriteRepository.Create(operatie);
            _repository.OperatieWriteRepository.SaveChanges();
        }

        void InterfaceOperatie.UpdateOperatie(Operatie operatie)
        {
            _repository.OperatieWriteRepository.Update(operatie);
            _repository.OperatieWriteRepository.SaveChanges();
        }

        void InterfaceOperatie.DeleteOperatie(int id)
        {
            if (_repository.OperatieWriteRepository.Exists(id))
            {
                _repository.OperatieWriteRepository.Delete(id);
                _repository.OperatieWriteRepository.SaveChanges();
            }
        }

        IReadOnlyList<Operatie> InterfaceOperatie.GetOperaties()
        {
            return _repository.OperatieReadRepository.GetAll();
        }

        Operatie InterfaceOperatie.GetOperatieById(int id)
        {
            if (_repository.OperatieReadRepository.Exists(id))
            {
                return _repository.OperatieReadRepository.GetById(id);
            }

            return null;
        }

        IReadOnlyList<Operatie> InterfaceOperatie.GetOperatiesByCondition(Expression<Func<Operatie, bool>> expression)
        {
            return _repository.OperatieReadRepository.GetByCondition(expression);
        }


        // Sasiu


        void InterfaceSasiu.AddSasiu(Sasiu sasiu)
        {
            _repository.SasiuWriteRepository.Create(sasiu);
            _repository.SasiuWriteRepository.SaveChanges();
        }

        void InterfaceSasiu.UpdateSasiu(Sasiu sasiu)
        {
            _repository.SasiuWriteRepository.Update(sasiu);
            _repository.SasiuWriteRepository.SaveChanges();
        }

        void InterfaceSasiu.DeleteSasiu(int id)
        {
            if (_repository.SasiuWriteRepository.Exists(id))
            {
                _repository.SasiuWriteRepository.Delete(id);
                _repository.SasiuWriteRepository.SaveChanges();
            }
        }

        IReadOnlyList<Sasiu> InterfaceSasiu.GetSasius()
        {
            return _repository.SasiuReadRepository.GetAll();
        }

        Sasiu InterfaceSasiu.GetSasiuById(int id)
        {
            if (_repository.SasiuReadRepository.Exists(id))
            {
                return _repository.SasiuReadRepository.GetById(id);
            }

            return null;
        }

        IReadOnlyList<Sasiu> InterfaceSasiu.GetSasiusByCondition(Expression<Func<Sasiu, bool>> expression)
        {
            return _repository.SasiuReadRepository.GetByCondition(expression);
        }


        // Imagine


        void InterfaceImagine.AddImagine(Imagine imagine)
        {
            _repository.ImagineWriteRepository.Create(imagine);
            _repository.ImagineWriteRepository.SaveChanges();
        }

        void InterfaceImagine.UpdateImagine(Imagine imagine)
        {
            _repository.ImagineWriteRepository.Update(imagine);
            _repository.ImagineWriteRepository.SaveChanges();
        }

        void InterfaceImagine.DeleteImagine(int id)
        {
            if (_repository.ImagineWriteRepository.Exists(id))
            {
                _repository.ImagineWriteRepository.Delete(id);
                _repository.ImagineWriteRepository.SaveChanges();
            }
        }

        IReadOnlyList<Imagine> InterfaceImagine.GetImagines()
        {
            return _repository.ImagineReadRepository.GetAll();
        }

        Imagine InterfaceImagine.GetImagineById(int id)
        {
            if (_repository.ImagineReadRepository.Exists(id))
            {
                return _repository.ImagineReadRepository.GetById(id);
            }

            return null;
        }

        IReadOnlyList<Imagine> InterfaceImagine.GetImaginesByCondition(Expression<Func<Imagine, bool>> expression)
        {
            return _repository.ImagineReadRepository.GetByCondition(expression);
        }
    }
}
