namespace AudioVolumeAccessor
{
    public interface IAudioVolumeAccessor
    {
        int GetVolume();
        void SetVolume(int volume);
    }
}