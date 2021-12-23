using System;
using System.Net;
using KRPC.Client;
using KRPC.Client.Services.KRPC;

class Program {
    public static void Main() {
        var connection = new Connection(
                   name: "Program",
                   address: IPAddress.Parse("127.0.0.1"),
                   rpcPort: 50000,
                   streamPort: 50001);

        var krpc = connection.KRPC();
        Console.WriteLine("KRPC online. Version " + krpc.GetStatus().Version);

        

        AutoLanding autoLanding = new AutoLanding(connection);
        autoLanding.run();
    }
}