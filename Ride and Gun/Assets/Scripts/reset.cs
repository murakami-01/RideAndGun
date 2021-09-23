using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CharacterController cc = GetComponent<CharacterController>();
        cc.enabled = false;
        cc.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
