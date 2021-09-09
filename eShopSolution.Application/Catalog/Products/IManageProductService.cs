using eShopSolution.ViewModel.Catalog.Common;
using eShopSolution.ViewModel.Catalog.ProductImages;
using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Catalog.Products.Manage;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<bool> UpdatePrice(int productId,decimal price);
        Task AddViewCount(int productId);
        Task<bool> UpdateStock(int product, int addQuatity);
        Task<int> Delete(int productId);
        Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ImageProductViewModel>> GetListImage(int productId);
    }
}
