using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class cameraFollow : MonoBehaviour
{
    private Transform target;
    public Tilemap tilemap;
    private Vector3 BLLimit;
    private Vector3 TRLimit;
    private float halfHeight;
    private float halfWidth;
    //Start is called before the first frame update
    void Start()
    {
        target = ex.instance.transform;
        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight*Camera.main.aspect;
        BLLimit = tilemap.localBounds.min + new Vector3(halfWidth, halfHeight, 0);
        TRLimit = tilemap.localBounds.max - new Vector3(halfWidth, halfHeight, 0);
        ex.instance.setbound(tilemap.localBounds.min, tilemap.localBounds.max);
    }

    //Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, BLLimit.x, TRLimit.x), Mathf.Clamp(transform.position.y, BLLimit.y, TRLimit.y), transform.position.z);
    }
    
}
