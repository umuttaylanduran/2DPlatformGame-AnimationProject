using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Animator animator;
    public float expDelay = 1f;
    bool patladimi;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            patladimi = true;
            StartCoroutine("AnimateAndWait");
            Destroy(gameObject,1f);
            
        }
    }

    public IEnumerator AnimateAndWait()
    {
        animator.SetBool("patladimi", true);

        yield return new WaitForSeconds(expDelay);
    }

}


