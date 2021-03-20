using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public int health;//目前生命值
    public int numOfHeart ;//總生命值

    public Image[] Hearts ;
    public Sprite Poo;//目前生命值要放的圖
    public Sprite emptyPoo;//總生命值要放的圖

    public Image image;
    public Canvas canvas;
    
    
    void Start()
    {
        Hearts = new Image[numOfHeart];
        
        for (int i = 0; i < Hearts.Length; i++)
        {
            Hearts[i] = Instantiate(image);
            Hearts[i].GetComponent<Transform>().parent =canvas.transform ;
            Hearts[i].GetComponent<RectTransform>().offsetMax = new Vector2(-280+40*i, -50);//裡面的參數可能要先量好Ｑ
            Hearts[i].GetComponent<RectTransform>().offsetMin = new Vector2(0+i * 40, -50);
            //Hearts[i].GetComponent<RectTransform>().anchoredPosition = new Vector2(10, -50);
            Hearts[i].GetComponent<RectTransform>().sizeDelta = new Vector2(Hearts[i].GetComponent<RectTransform>().sizeDelta.x, 40);
        }//這個東西牽扯到canvas的機制，我還沒全部搞清楚，我是try&error找規則再寫參數，先做出來ㄏㄏ。
    }

    // Update is called once per frame
    void Update()
    {
   
        if (health > numOfHeart)
        {
            health = numOfHeart;
        }
        for (int i = 0; i <Hearts.Length; i++)
        {
            if (i < numOfHeart)
            {
                Hearts[i].enabled = true;

                if (i < health)
                {
                    Hearts[i].sprite = Poo;
                }
                else
                {
                    Hearts[i].sprite = emptyPoo;
                }
            }
            else
            {
                Hearts[i].enabled = false;
            }
            
        }
    }
}
