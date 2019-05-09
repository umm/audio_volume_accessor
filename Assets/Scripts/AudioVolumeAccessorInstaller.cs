using Zenject;

namespace AudioVolumeAccessor
{
    public class AudioVolumeAccessorInstaller : MonoInstaller<AudioVolumeAccessorInstaller>
    {
        public override void InstallBindings()
        {
#if UNITY_ANDROID
            Container.BindInterfacesTo<AndroidAudioVolumeAccessor>().AsCached();
#else
            Container.BindInterfacesTo<NotSupportPlatformAudioVolumeAccessor>().AsCached();
#endif
        }
    }
}