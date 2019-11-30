using API.Dtos;
using API.Models;
using Service.ViewModel.KPI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IAdminKPIService: IDisposable
    {
        List<KPIViewModel> GetAll();

        PagedResult<KPIViewModel> GetAllPaging(int? categoryID, string keyword, int page, int pageSize = 5);

        bool Add(KPI product);

        void Update(KPI product);

        void Delete(int id);

        KPIViewModel GetById(int id);

        void ImportExcel(string filePath, int categoryId);

        void Save();
    }
}
