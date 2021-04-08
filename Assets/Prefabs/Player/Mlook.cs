using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mlook : MonoBehaviour
{
    Liike liik;
    public Transform player;
    float cRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        liik = new Liike();
        liik.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseLook = liik.Player.Look.ReadValue<Vector2>() * Time.deltaTime * 100;

        player.Rotate(0,mouseLook.x,0);
        // gameObject.transform.Rotate(-mouseLook.y,0,0);
        cRotation -= mouseLook.y;
        cRotation = Mathf.Clamp(cRotation,-90,90);
        transform.localRotation = Quaternion.Euler( cRotation,0,0);
    }
}
