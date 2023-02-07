using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim = null;
    public GameObject Timer;
   
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void Push()
    {
        anim.SetBool("IsPush", true);    
        
    }
    public void Row()
    {
        anim.SetBool("IsPush", false);
        
    }   
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Push();
            Timer.GetComponent<Timer>().SetTimerOn();
            

        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Row();
           
        }
    }
}

   

