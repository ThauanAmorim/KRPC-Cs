using System;
using System.Net;
using KRPC.Client;
using KRPC.Client.Services.KRPC;
public class AutoLanding {

    private Connection connection;
    public AutoLanding(Connection connection) {
        this.connection = connection;
    }

    public void run() {
        Console.WriteLine(connection.KRPC().GetClientName());
    }
}