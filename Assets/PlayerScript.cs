using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();   
        
   }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("isWalking", true);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetTrigger("isFiring");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("isReload",true);
        }




    }
}
