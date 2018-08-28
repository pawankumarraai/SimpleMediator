﻿using System.Threading.Tasks;
using SimpleMediator.Core;

namespace SimpleMediator.Commands
{
    public abstract class CommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : IRequest<Unit>
    {
        public async Task<Unit> HandleAsync(TCommand request)
        {
            await HandleCommandAsync(request);
            return Unit.Result;
        }

        protected abstract Task HandleCommandAsync(TCommand command);
    }
}
