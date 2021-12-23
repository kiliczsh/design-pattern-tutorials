namespace BridgeMethod;

public class ExtendedRemoteControl : RemoteControl
{
    public ExtendedRemoteControl(IDevice device) : base(device)
    {
    }
        
    public string Mute()
    {
        Device.SetVolume(0);
        return $"Volume is at {Device.GetVolume()}";
    }
}