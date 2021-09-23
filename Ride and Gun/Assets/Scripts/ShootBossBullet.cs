using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBossBullet : MonoBehaviour
{
    /// <summary>
    ///íeä€Ç™ê∂ê¨Ç≥ÇÍÇΩèÍçáÇ…Ç∑ÇÆÇ…î≠éÀÇ≥ÇÍÇÈÉvÉçÉOÉâÉÄ 
    /// </summary>

    private Rigidbody rb;
    private float time;
    private Vector3 dir = new Vector3(0, 0, 1);
    public GameObject bullet;
    public GameObject explosion;
    public GameObject fire;
    private float firetime=-10;

    // Start is called before the first frame update
    void Start()
    {
        //íeä€î≠éÀ
        rb = GetComponent<Rigidbody>();
        rb.AddForce(this.transform.rotation * dir * 25f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        firetime += Time.deltaTime;

        if (time >= 3)
        {
            //3ïbå„Ç…íeä€îjâÛ
            Destroy(bullet);
        }
        if (firetime >= 3)
        {
            Destroy(explosion);
            Destroy(fire);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        if (name.Substring(0, 4) == "Road")
        {
            Vector3 position = new Vector3(this.gameObject.transform.position.x,0.3f,this.gameObject.transform.position.z);
            GameObject instance1 = Instantiate(explosion, position,this.gameObject.transform.rotation);
            GameObject instance2 = Instantiate(fire, position, this.gameObject.transform.rotation);
            firetime = 0;
        }
    }
}
