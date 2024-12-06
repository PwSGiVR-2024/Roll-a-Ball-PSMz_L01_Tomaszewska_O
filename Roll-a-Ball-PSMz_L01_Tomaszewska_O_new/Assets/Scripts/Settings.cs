using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider volumeSlider;
    private float defaultVolume = 0.5f;

    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", defaultVolume);
        AudioListener.volume = volumeSlider.value;

        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void BackToMenu(GameObject settingsPanel)
    {
        settingsPanel.SetActive(false);
    }
}
