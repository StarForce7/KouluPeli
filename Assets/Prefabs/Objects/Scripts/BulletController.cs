using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Rigidbody bullet;
    public float speed = 10;
    public Transform kamera;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("camera");
        
        bullet.velocity = obj.transform.forward * speed;
        Object.Destroy(gameObject,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
