using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 1f;
    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        Vector3 dir = new Vector3(stickL.x, 0, stickL.y);
        if (stickL != new Vector2(0,0))
        {
            controller.Move(this.gameObject.transform.rotation * (dir * speed) *Time.deltaTime);
        }


    }

}
