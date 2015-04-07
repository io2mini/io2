﻿using System;
using Common.Messages;
using Common.Messages.Generators;

namespace Common.Components
{
    /// <summary>
    /// Informacja ogólna: ComputatonalClient nie może być rozpatrywany jako SystemComponent (jako taki)
    /// Należy rozważyć bardziej szczegółową hierarchię komponentów.
    /// </summary>
    public class ComputationalClient : SystemComponent
    {
        public ComputationalClient() : base() { }

        public void SendSolveRequestMessage()
        {
            SolveRequest msg = SolveRequestGenerator.Generate();
            // TODO: Wywołaj odpowiednią metodę do wysyłania wiadomości do serwera.
        }
    }
}
