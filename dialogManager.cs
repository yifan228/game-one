using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialogManager : MonoBehaviour
{
    public Text dialogText;
    public Text nameText;
    public GameObject dialogBox;
    public GameObject nameBox;
    public string[] dialogLine;
    public int currentLine;
    public static dialogManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogBox.activeInHierarchy)
        {
            
            if (Input.GetButtonUp("Fire1"))
            {
                //dialogText.text = dialogLine[currentLine];
                if (currentLine >=dialogLine.Length)
                {
                    dialogBox.SetActive(false);
                    Debug.Log("fuck");
                    ex.instance.CanMove = true;
                }
                else
                {
                    checkIfName();

                    dialogText.text = dialogLine[currentLine];
                    currentLine++;
                    
                    Debug.Log("gggggg");
                }
                
            }
        }
    }
    public void showDialog(string[] newLines,bool isperson)
    {
        dialogLine = newLines;
        currentLine = 0;

        checkIfName();

        dialogText.text = dialogLine[currentLine];
        dialogBox.SetActive(true);
        nameBox.SetActive(isperson);
    }
    public void checkIfName()
    {
        if (dialogLine[currentLine].StartsWith("n-"))
        {
            nameText.text = dialogLine[currentLine].Replace("n-"," ");
            currentLine++;
        }
    }
}
