﻿namespace Snippets4.Azure.Transports.AzureServiceBus
{
    using NServiceBus;

    class Usage
    {
        public Usage()
        {
            #region AzureServiceBusTransportWithAzure 5

            Configure.With()
                .UseTransport<AzureServiceBus>();

            #endregion
        }

        #region AzureServiceBusTransportWithAzureHost 5

        public class EndpointConfig : IConfigureThisEndpoint, UsingTransport<AzureServiceBus> { }

        #endregion
    }
}