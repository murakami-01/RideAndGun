using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    /// <summary>
    ///’eŠÛ‚ª¶¬‚³‚ê‚½ê‡‚É‚·‚®‚É”­Ë‚³‚ê‚éƒvƒƒOƒ‰ƒ€ 
    /// </summary>
    
    private Rigidbody rb;
    private float time;
    private Vector3 dir = new Vector3(0, 0, 1);
    public GameObject bullet ;

    // Start is called before the first frame update
    void Start()
    {
        //’eŠÛ”­Ë
        rb = GetComponent<Rigidbody>();
        rb.AddForce(this.transform.rotation * dir * 75f,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time>= 3)
        {
            //3•bŒã‚É’eŠÛ”j‰ó
            Destroy(bullet);
        }
    }
}
