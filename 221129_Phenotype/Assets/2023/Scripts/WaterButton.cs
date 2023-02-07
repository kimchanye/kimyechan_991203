using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterButton : MonoBehaviour
{
    public bool playAura = true; //파티클 제어 bool
    public ParticleSystem particleObject;

    void Start()
    {
        playAura = true;
        particleObject.Play();
    }
    void Update()
    {
       if (transform.eulerAngles.y <= 45.0f)
        {
            playAura = true;
        }
        else
        {
            playAura = false;
        }
        if (playAura == true)
        {
            StartWater();
        }
        else if (!playAura)
        {
            StopWater();
        }
    }
    public void StartWater()
    {
        if (!particleObject.isPlaying)
            particleObject.Play();
    }
    public void StopWater()
    {
        if (particleObject.isPlaying)
            particleObject.Stop();
    }
}
