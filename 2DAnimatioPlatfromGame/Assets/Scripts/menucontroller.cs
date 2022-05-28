using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menucontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayButton()
    {
        StartCoroutine("PlayCoroutine");
    }

    IEnumerator PlayCoroutine()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("SampleScene");
    }
 
}
