using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerEnterdostuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //this.gameObject.SetActive(false); initial test
        SceneManager.LoadScene(2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
