using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    private AudioManager audioM;
    // Start is called before the first frame update

    public void ChangeVolume() {
        audioM = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        audioM.AdjustTheme("Theme", volumeSlider.value);
    }
}

