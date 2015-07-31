using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vodafone.Data.Infrastructure;
using Vodafone.Data.Repositories;
using Vodafone.Model.Models;

namespace Vodafone.Service
{
    public interface ISubCategoryService
    {
        IEnumerable<SubCategory> GetSubCategories();
        IEnumerable<SubCategory> GetCategorySubCategories(string categoryName, string subCategoryName = null);
        SubCategory GetSubCategory(int id);
        void CreateSubCategory(SubCategory subCategory);
        void SaveSubCategory();
    }
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository subCategoriesRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public SubCategoryService(ISubCategoryRepository subCategoriesRepository, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.subCategoriesRepository = subCategoriesRepository;
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ISubCategoryService Members

        public IEnumerable<SubCategory> GetSubCategories()
        {
            var subCategories = subCategoriesRepository.GetAll();
            return subCategories;
        }

        public IEnumerable<SubCategory> GetCategorySubCategories(string categoryName, string subCategoryName = null)
        {
            var category = categoryRepository.GetCategoryByName(categoryName);
            return category.SubCategories.Where(s => s.Name.ToLower().Contains(subCategoryName.ToLower().Trim()));
        }

        public SubCategory GetSubCategory(int id)
        {
            var gadget = subCategoriesRepository.GetById(id);
            return gadget;
        }

        public void CreateSubCategory(SubCategory subCategory)
        {
            subCategoriesRepository.Add(subCategory);
        }

        public void SaveSubCategory()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
