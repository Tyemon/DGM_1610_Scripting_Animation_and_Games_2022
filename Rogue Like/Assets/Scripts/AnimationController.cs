using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public Animator animSpeed;
    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
      animSpeed = GetComponent<Animator>(); 
      anim = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.P))
       PlayAnim();  

       if(Input.GetKeyDown(KeyCode.S))
       StopAnim();  
    }

    void PlayAnim()
    {
        animSpeed.speed = 1f;
        Debug.Log("Animation is playing");
    }
    void StopAnim()
    {
        animSpeed.speed = 0f;
        Debug.Log("Animation Stopped");
    }
}
