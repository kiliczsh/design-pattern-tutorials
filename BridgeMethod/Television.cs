namespace BridgeMethod;

public class Television : IDevice
{
    private int _channel;
    private int _volumeLevel;

    public Television(int channel, int volumeLevel)
    {
        _channel = channel;
        _volumeLevel = volumeLevel;
    }

    private int VolumeLevel
    {
        get => _volumeLevel;
        set => _volumeLevel = value < 0 ? 0 : value > 100 ? 100 : value;
    }

    private bool IsOn { get; set; }

    private int Channel
    {
        get => _channel;
        set => _channel = value < 0 ? 0 : value > 10 ? 10 : value;
    }

    public void Enable()
    {
        IsOn = true;
    }

    public void Disable()
    {
        IsOn = false;
    }

    public bool IsEnabled()
    {
        return IsOn;
    }

    public int GetVolume()
    {
        return VolumeLevel;
    }

    public void SetVolume(int volume)
    {
        VolumeLevel = volume;
    }

    public void SetChannel(int channel)
    {
        Channel = channel;
    }

    public int GetChannel()
    {
        return Channel;
    }
}