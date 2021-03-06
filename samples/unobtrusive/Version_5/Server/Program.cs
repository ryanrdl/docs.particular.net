﻿using NServiceBus;

class Program
{
    public static void Main()
    {
        BusConfiguration busConfiguration = new BusConfiguration();

        busConfiguration.EnableInstallers();
        busConfiguration.UsePersistence<InMemoryPersistence>();
        busConfiguration.UseDataBus<FileShareDataBus>()
            .BasePath(@"..\..\..\DataBusShare\");
        busConfiguration.RijndaelEncryptionService();

        busConfiguration.ApplyCustomConventions();

        using (IBus bus = Bus.Create(busConfiguration).Start())
        {
            CommandSender.Start(bus);
        }
    }
}

