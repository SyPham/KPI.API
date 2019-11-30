using API.Data.Interface;
using API.Dtos;
using API.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Interface;
using Microsoft.Extensions.Logging;
using Service.Interface;
using Service.ViewModel.KPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Implementation
{
    public class AdminKPIService : IAdminKPIService
    {
        private IRepository<KPI, int> _kpiRepository;
        private readonly IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        private readonly ILogger<KPI> _logger;

        public AdminKPIService(IRepository<KPI, int> kpiRepository, IUnitOfWork unitOfWork, IMapper mapper, ILogger<KPI> logger)
        {
            _mapper = mapper;
            _kpiRepository = kpiRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public bool Add(KPI product)
        {
            try
            {
                _kpiRepository.Add(product);

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public void Delete(int id)
        {
            _kpiRepository.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<KPIViewModel> GetAll()
        {
            return _mapper.Map<List<KPIViewModel>>(_kpiRepository.FindAll());
        }

        public PagedResult<KPIViewModel> GetAllPaging(int? categoryID, string keyword, int page, int pageSize = 5)
        {
            var query = _kpiRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderByDescending(x => x.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
            var paginationSet = new PagedResult<KPIViewModel>()
            {
                Results = _mapper.Map<List<KPIViewModel>>(data),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public KPIViewModel GetById(int id)
        {
            return _mapper.Map<KPI, KPIViewModel>(_kpiRepository.FindById(id));
        }

        public void ImportExcel(string filePath, int categoryId)
        {
            throw new NotImplementedException();
        }
        public void Update(KPI product)
        {
            _kpiRepository.Update(product);
        }
        public void Save()
        {
            _unitOfWork.Commit();
        }




    }
}
