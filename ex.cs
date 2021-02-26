using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class ex : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRigidBody;
    public static ex instance;
    public string areaTransName;
    public Animator myAnime;
    private Vector3 BLLimit;
    private Vector3 TRLimit;
    //Start is called before the first frame update
    void Start()
    {
        
        if (instance == null)
        {
            instance = this;
            Debug.Log("aaa");
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("bbb");
        }
        DontDestroyOnLoad(gameObject);
        Debug.Log("ddd");

    }

    //Update is called once per frame
    void Update()
    {
        theRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

        if (theRigidBody.velocity.x < -0.1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(theRigidBody.velocity.x >0.1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = transform.rotation;
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, BLLimit.x, TRLimit.x), Mathf.Clamp(transform.position.y, BLLimit.y, TRLimit.y), 0f);

    }
    public void setbound(Vector3 botleft, Vector3 toprite)
    {
    BLLimit = botleft + new Vector3(.5f, .5f, 0f);
    TRLimit = toprite - new Vector3(.5f, .5f, 0f);
    }
}
