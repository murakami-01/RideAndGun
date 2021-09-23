using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : EnemyMove
{
    /// <summary>
    /// bossの行動用プログラム
    /// </summary>

    // Start is called before the first frame update

    private Vector3 posi;
    private AudioSource aud;
 

    public override void Start()
    {
        prediction.SetActive(false);
        this.aud = GetComponent<AudioSource>();

        StartCoroutine("Move");

    }

    public override void Set()
    {
        Vector3 dir = new Vector3(player.transform.position.x, player.transform.position.y-1.5f, player.transform.position.z);
        this.transform.LookAt(dir); 
        prediction.SetActive(true);
    }

    public override void Shoot()
    {
        prediction.SetActive(false);
        posi = this.gameObject.transform.position + (this.gameObject.transform.rotation * new Vector3(0, 1.5f, 1.5f));
        GameObject instance = Instantiate(bullet, this.posi, gun.gameObject.transform.rotation);
        this.aud.PlayOneShot(clip);
    }

    public override IEnumerator Move()
    {
        while (true)
        {
            if (Vector3.Distance(this.gameObject.transform.position, player.transform.position) <= 20.0f)
            {
                Set();
                yield return new WaitForSeconds(1.5f);

                Shoot();
                yield return new WaitForSeconds(0.5f);
            }
            yield return null;
        }
    }
}
