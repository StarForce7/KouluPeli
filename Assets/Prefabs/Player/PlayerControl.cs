using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    Liike liik ;
    CharacterController CharCont;
    public GameObject bullet;
    public float NSpeed = 10;
    public float SSpeed = 30;
    float CSpeed = 10;
    Vector3 gVelo;
    float grav = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
        gVelo = Vector3.zero;
        liik = new Liike();
        liik.Enable();

        CharCont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveControl();
        GravityControl();
        if (liik.Player.Fire.triggered)
        {
            fire();
        }
    }

    void MoveControl()
    {
        CSpeed = liik.Player.SSpeedB.ReadValue<float>() > 0 ? SSpeed : NSpeed;
        Vector2 move = liik.Player.Move.ReadValue<Vector2>();
        Vector3 moveDirection = move.y * transform.forward + move.x * transform.right;
        CharCont.Move(moveDirection * CSpeed * Time.deltaTime);
    }
    void GravityControl()
    {
        gVelo.y += grav * Time.deltaTime;
        CharCont.Move(gVelo * Time.deltaTime);
    }

    void JumpControl()
    {

    }

    void fire()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
