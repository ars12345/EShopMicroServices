using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull
    {
    }
}

//mme lassal changement de nom
//mme ferrat recuperer dossier