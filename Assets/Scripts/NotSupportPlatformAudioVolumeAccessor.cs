using UnityEngine;

namespace AudioVolumeAccessor
{
    public class NotSupportPlatformAudioVolumeAccessor : IAudioVolumeAccessor
    {
        public int GetVolume()
        {
            Debug.LogWarning($"Not support this platform: {Application.platform.ToString()}");
            return 0;
        }

        public void SetVolume(int volume)
        {
            Debug.LogWarning($"Not support this platform: {Application.platform.ToString()}");
        }
    }
}