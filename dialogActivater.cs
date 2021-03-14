using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogActivater : MonoBehaviour
{
    public string[] lines;
    private bool canActivate;
    public bool Ispreson = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canActivate == true && Input.GetButtonUp("Fire1") == true&&!dialogManager.instance.dialogBox.activeInHierarchy)
        {
            dialogManager.instance.showDialog(lines,Ispreson);
            ex.instance.CanMove = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canActivate = true;
        }
    }
    public void OnTriggeExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canActivate = false;
        }
    }
}
