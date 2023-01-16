using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            IResult result = BusinessRules.Run(CheckIfProductNameExists(product.Name));
            if (result == null)
            {
                _productDal.Add(product);
                return new SuccessResult(Messages.ProductAdded);
            }
            return new ErrorResult();
        }

        public IResult Delete(Product product)
        {
            if (product != null)
            {
                _productDal.Delete(product);
                return new SuccessResult(Messages.ProductDeleted);
            }
            return new ErrorResult();
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId == id),Messages.CategoryIdinProductListed);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.Id==productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(double min, double max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.Price >= min && p.Price <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            IResult result = BusinessRules.Run(CheckIfProductNameExists(product.Name));
            if (result != null)
            {
                _productDal.Update(product);
                return new SuccessResult(Messages.ProductUpdated);
            }
            return new ErrorResult();
        }

        private IResult CheckIfProductNameExists(string name)
        {
            var result = _productDal.GetAll(a => a.Name == name).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
