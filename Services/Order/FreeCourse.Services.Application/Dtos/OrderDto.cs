﻿using FreeCourse.Services.Order.Domain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Application.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public AddressDto Address { get; private set; }

        public string BuyerId { get; set; }


        private readonly List<OrderItemDto> _orderItems;
    }
}
