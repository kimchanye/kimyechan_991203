using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gasrange : MonoBehaviour
{
    public bool playAura = true; //��ƼŬ ���� bool
    public ParticleSystem particleObject; //��ƼŬ�ý���


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
