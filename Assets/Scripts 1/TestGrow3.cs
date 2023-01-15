using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGrow3 : MonoBehaviour
{
    private Vector3 scaleChange;
    private float yValue;
    private int prevRepeatsValue;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        yValue = 0f;
        scaleChange = new Vector3(1.5f, yValue, 1.5f);
        //StartCoroutine(GrowFlower());
        this.gameObject.transform.localScale = scaleChange;
        prevRepeatsValue = animator.GetInteger("repeats");
    }

    

    // Update is called once per frame
    void Update()
    {
        if(animator.GetInteger("repeats")!= prevRepeatsValue)
        {
            yValue = yValue + 0.2f;
            scaleChange = new Vector3(1.5f, yValue, 1.5f);
            this.gameObject.transform.localScale = scaleChange;
            prevRepeatsValue = animator.GetInteger("repeats");
        }
       
    }
}