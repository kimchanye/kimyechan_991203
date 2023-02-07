using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gasrange : MonoBehaviour
{
    public bool playAura = true; //파티클 제어 bool
    public ParticleSystem particleObject; //파티클시스템


    void Start()
    {
        playAura = true;
        particleObject.Play();
    }


    void Update()
    {


        if (transform.eulerAngles.y <= 180.0f)
        {

            playAura = true;
            if (!particleObject.isPlaying)
                particleObject.Play();
        }
        else
        {
            playAura = false;
            if (particleObject.isPlaying)
                particleObject.Stop();
        }






    }
}
