﻿using MediatR;

namespace MvcBurger.Application.Features.Commands.Menus.Create
{
    public record CreateMenuRequest : IRequest<CreateMenuResponse>
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public decimal Price { get; init; }
        public string ImageUrl { get; init; }
    }



}

