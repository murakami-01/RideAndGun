using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMove : MonoBehaviour
{
    private const float carve = 0.2f;
    private const float speed = 1.8f;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);

        if (stickL != new Vector2(0, 0))
        {
            //倒している方向にカーブ
            if (stickL.x > 0)
            {
                this.gameObject.transform.rotation = this.gameObject.transform.rotation * Quaternion.Euler(new Vector3(0, carve, 0));
            }
            else
            {
                this.gameObject.transform.rotation = this.gameObject.transform.rotation * Quaternion.Euler(new Vector3(0, carve * -1, 0));
            }

        }

        if (OVRInput.Get(OVRInput.RawButton.LHandTrigger))
        {
            if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
            {
                //バック
                controller.Move(transform.TransformDirection(new Vector3(0, 0, -1)) * speed * Time.deltaTime);
            }
            else
            {
                //前進
                controller.Move(transform.TransformDirection(new Vector3(0, 0, 1)) * speed * Time.deltaTime);
            }

        }
    }
}
