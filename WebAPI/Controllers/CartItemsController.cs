using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        ICartItemService _cartItemService;

        public CartItemsController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpPost("add")]
        public IActionResult Add(CartItem cartItem)
        {

            var result = _cartItemService.Add(cartItem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(CartItem cartItem)
        {
            var result = _cartItemService.Update(cartItem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycartitem")]
        public IActionResult GetById(int id)
        {
            var result = _cartItemService.GetByCartId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getuserbycartitem")]
        public IActionResult GetUserByCartItem(CartItem cartItem)
        {
            var result = _cartItemService.GetUserByCartItem(cartItem);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
