namespace BridgeMethod;

public class RemoteControl
{
    protected readonly IDevice Device;
        
    public RemoteControl(IDevice device)
    {
        Device = device;
    }
        
    public string TogglePower()
    {
        if (Device.IsEnabled())
        {
            Device.Disable();
        }
        else
        {
            Device.Enable();
        }
        
        return Device.IsEnabled() ? "Device is on" : "Device is off";
    }
    
    public string VolumeUp()
    {
        Device.SetVolume(Device.GetVolume() + 10);
        return $"Volume is at {Device.GetVolume()}";
    }
    
    public string VolumeDown()
    {
        Device.SetVolume(Device.GetVolume() - 10);
        return $"Volume is at {Device.GetVolume()}";
    }
    
    public string ChannelUp()
    {
        Device.SetChannel(Device.GetChannel() + 1);
        return $"Channel is at {Device.GetChannel()}";
    }
    
    public string ChannelDown()
    {
        Device.SetChannel(Device.GetChannel() - 1);
        return $"Channel is at {Device.GetChannel()}";
    }
    
}