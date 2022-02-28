﻿using Discount.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Api.GrpcServices
{
    public class DiscountGrpcServices
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoService;

        public DiscountGrpcServices(DiscountProtoService.DiscountProtoServiceClient discountProtoService)
        {
            _discountProtoService = discountProtoService;
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRepeat = new GetDiscountRequest { ProductName = productName };
            return await _discountProtoService.GetDiscountAsync(discountRepeat);
        }
    }
}