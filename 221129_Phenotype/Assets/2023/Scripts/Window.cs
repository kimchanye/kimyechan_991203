using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    // Start is called before the first frame update
    public bool playAura = true; //��ƼŬ ���� bool
    public ParticleSystem particleObject; //��ƼŬ�ý���


    void Start()
    {
        playAura = true;
        particleObject.Play();
    }


    void Update()
    {


        //if (transform.position.z <= 0.2f)
        //{

        //    playAura = true;
        //    if (!particleObject.isPlaying)
        //        particleObject.Play();
            
        //}
        //else
        //{
        //    playAura = false;
        //    if (particleObject.isPlaying)
        //        particleObject.Stop();
            
        //}
        
    }
}
