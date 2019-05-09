using UnityEngine;

namespace AudioVolumeAccessor
{
    public class AndroidAudioVolumeAccessor : IAudioVolumeAccessor
    {
        private static readonly int ANDROID_STREAM_TYPE_MUSIC = 3;

        public int GetVolume()
        {
            var UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            var context = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            var audioManager = context.Call<AndroidJavaObject>("getSystemService", "audio");
            var isMute = audioManager.Call<bool>("isStreamMute", ANDROID_STREAM_TYPE_MUSIC);
            return isMute ? 0 : audioManager.Call<int>("getStreamVolume", ANDROID_STREAM_TYPE_MUSIC);
        }

        public void SetVolume(int volume)
        {
            var UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            var context = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            var audioManager = context.Call<AndroidJavaObject>("getSystemService", "audio");
            audioManager.Call("setStreamVolume", ANDROID_STREAM_TYPE_MUSIC, volume, 0);
        }
    }
}