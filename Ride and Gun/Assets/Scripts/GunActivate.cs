using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunActivate : MonoBehaviour
{
    public GameObject gun;
    // Start is called before the first frame update
    void Start()
    {
        var script = gun.GetComponent<PlayerShoot>();
        script.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
