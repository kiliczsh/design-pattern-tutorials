namespace BridgeMethod;

public interface IDevice
{
    void Enable();
    void Disable();
    bool IsEnabled();
    int GetVolume();
    void SetVolume(int volume);
    void SetChannel(int channel);
    int GetChannel();
}