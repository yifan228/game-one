using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TransitionScene : MonoBehaviour
{
    public string ToLoadScene;
    public string areaTransName;
    public float waitTime = 1f;
    private bool shouldLoadAfterFade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldLoadAfterFade == true)
        {
            waitTime -= Time.deltaTime;
            if (waitTime <= 0f)
            {
                shouldLoadAfterFade = false;
                SceneManager.LoadScene(ToLoadScene);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            ex.instance.areaTransName = areaTransName;
            shouldLoadAfterFade = true;
            uiFade.instance.FadeToBlack();
        }
    }
}
