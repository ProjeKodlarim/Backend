using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CartItemManager : ICartItemService
    {
        ICartItemDal _cartItemDal;

        public CartItemManager(ICartItemDal cartItemDal)
        {
            _cartItemDal = cartItemDal;
        }

        public IResult Add(CartItem cartItem)
        {
            _cartItemDal.Add(cartItem);
            return new SuccessResult(Messages.cartItemAdded);
        }

        public IDataResult<CartItem> GetByCartId(int userId)
        {
            var result=_cartItemDal.Get(c=>c.UserId == userId);
            return new SuccessDataResult<CartItem>(result, "");
        }

        public IDataResult<CartItem> GetUserByCartItem(CartItem cartItem)
        {
            var result = _cartItemDal.Get(c => c.UserId == cartItem.UserId && c.ProductId==cartItem.ProductId);
            return new SuccessDataResult<CartItem>(result, "");
        }

        public IResult Update(CartItem cartItem)
        {
            _cartItemDal.Update(cartItem);
            return new SuccessResult(Messages.cartItemsUpdated);
        }
    }
}
