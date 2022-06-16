using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;


    private float fillSpeed = 0.5f;
    private float targetProgress = 0;


    private void Awake() {
        slider = gameObject.GetComponent<Slider>();
        particleSys = GameObject.Find("Progress Bar Particles").GetComponent<ParticleSystem>();
    }
    // Start is called before the first frame update
    public void StartProgress(float speed)
    {
        fillSpeed = speed;
        IncrementProgress(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress) {
            slider.value += fillSpeed * Time.deltaTime;
            if (!particleSys.isPlaying) {
                particleSys.Play();
            }

        } else {
            particleSys.Stop();
        }
        
    }

    // add progress to the bar
    public void IncrementProgress(float newProgress) {
        targetProgress = slider.value + newProgress;
    }

    public void reset() {
        slider.value = 0;
        targetProgress = 0;
    }
}
