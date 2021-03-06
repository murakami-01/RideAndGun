using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    /// <summary>
    ///弾丸が生成された場合にすぐに発射されるプログラム 
    /// </summary>
    
    private Rigidbody rb;
    private float time;
    private Vector3 dir = new Vector3(0, 0, 1);
    public GameObject bullet ;

    // Start is called before the first frame update
    void Start()
    {
        //弾丸発射
        rb = GetComponent<Rigidbody>();
        rb.AddForce(this.transform.rotation * dir * 75f,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time>= 3)
        {
            //3秒後に弾丸破壊
            Destroy(bullet);
        }
    }
}
