# audio_volume_accessor
## Requirement
* Unity 2018
* [Zenject](https://github.com/modesttree/Zenject)

## Supported Platforms
* Android

## Install
```
yarn add "umm/audio_volume_accessor#^1.0.0"
```

And import Zenject (e.g: from [release page](https://github.com/modesttree/Zenject/releases))

## Usage
### Prepare ZenjectContext
* `(Project|Scene|GameObject)Context` を用意します
* 用意したContextの `PrefabInstaller` に項目に `AudioVolumeAccessorInstaller.prefab` を追加します

### Inject Accessor and call Method
* 以下のようなコードで使用します

```
using Zenject;

public class Sample
{
    [Inject] private IAudioVolumeAccessor AudioVolumeAccessor { get; set; }

    public int GetAudioVolume()
    {
        return this.AudioVolumeAccessor.GetAudioVolume();
    }
    
    public void SetAudioVolume(int volume)
    {
        this.AudioVolumeAccessor.SetAudioVolume(volume);
    }
}
```
