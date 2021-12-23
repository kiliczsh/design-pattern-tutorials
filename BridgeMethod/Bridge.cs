namespace BridgeMethod;

public static class Bridge
{
    public static void Test()
    {
        IDevice radio = new Radio(5, 10);
        IDevice television = new Television(6, 12);
        
        var remoteControl = new RemoteControl(television);
        var extendedRemoteControl = new ExtendedRemoteControl(radio);
        
        // remote control for television
        Console.WriteLine(remoteControl.TogglePower());
        Console.WriteLine(remoteControl.ChannelDown());
        Console.WriteLine(remoteControl.ChannelUp());
        Console.WriteLine(remoteControl.TogglePower());
        Console.WriteLine(remoteControl.VolumeDown());
        Console.WriteLine(remoteControl.VolumeUp());
        
        // Extended remote control for radio
        Console.WriteLine(extendedRemoteControl.Mute());
        Console.WriteLine(extendedRemoteControl.ChannelDown());
        Console.WriteLine(extendedRemoteControl.ChannelUp());
        Console.WriteLine(extendedRemoteControl.TogglePower());
        Console.WriteLine(extendedRemoteControl.VolumeDown());
        Console.WriteLine(extendedRemoteControl.VolumeUp());
        Console.WriteLine(extendedRemoteControl.TogglePower());
        
    }
}