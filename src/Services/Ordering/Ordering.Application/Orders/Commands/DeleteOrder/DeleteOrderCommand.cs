﻿using FluentValidation;

namespace Ordering.Application.Orders.Commands.DeleteOrder
{
    public record class DeleteOrderCommand(Guid OrderId) : ICommand<DeleteOrderResult>;
    public record class DeleteOrderResult(bool isSuccess);

    public class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderCommandValidator()
        {
            RuleFor(x => x.OrderId).NotEmpty().WithMessage("OrderId is required");
        }
    }
}
