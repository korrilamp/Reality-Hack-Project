using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RepeatsCounterScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Animator animator;
    public Text txt;

    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (txt.text != "Good job!")
        {
            txt.text = animator.GetInteger("repeats").ToString();
        }
        if (animator.GetInteger("repeats") ==5)
        {
            StartCoroutine(waiter());
            
            
        }
    }

    IEnumerator waiter()
    {


        //Wait for 2 seconds
        yield return new WaitForSeconds(3);
        txt.text = "Good job!";
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);

    }
}
