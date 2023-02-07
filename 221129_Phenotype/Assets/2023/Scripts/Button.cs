using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    public bool playAura = true; //파티클 제어 bool
    public ParticleSystem particleObject; //파티클시스템
    Animator anim = null;
    public int countClick = 0;
    
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            countClick += 1;
            if (countClick >= 1)
            {
                ButtonIdle();
            }
            if(countClick >= 2 )
            {
                FalseButton();
            }
          
        }      
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(countClick >= 1)
            {
                ButtonIdle1();
            }
            if(countClick >= 2)
            {
                TrueButton();
            }
            if(countClick >= 2)
            {
                countClick = 0;
            }
        }
    }

    public void TrueButton()
    {
        anim.SetBool("FalseButton", false);
    }
    public void FalseButton()
    {
        anim.SetBool("FalseButton", true);
       
      
            
    }
   

    public void ButtonIdle1()
    {
        anim.SetBool("IsButton", false);
    }
    public void ButtonIdle()
    {
        anim.SetBool("IsButton",true);
        

    }

 

    void Start()
    {
        playAura = true;
        particleObject.Play();
    }


    void Update()
    {
       

        if (transform.localPosition.x <= -10.4934f)
        {

            //playAura = true;
            //if (!particleObject.isPlaying)
            //    particleObject.Play();
            //Debug.Log("불꺼짐");
        }
        else
        { 
            //playAura = false;
            //if (particleObject.isPlaying)
            //    particleObject.Stop();
            //Debug.Log("불남");
        }
    }
}
