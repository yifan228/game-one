using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entrance : MonoBehaviour
{
    public string areaTransName;
    // Start is called before the first frame update
    void Start()
    {
        if(areaTransName == ex.instance.areaTransName)
        {
            ex.instance.transform.position = transform.position;
        }
        uiFade.instance.FadeFromBlack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
