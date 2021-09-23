using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    /// <summary>
    /// 敵の行動用のプログラム
    /// </summary>

    private Vector3 position;
    private AudioSource audi;
    private Vector3 playerposition;

    public GameObject prediction;
    public GameObject player;
    public GameObject gun;
    public GameObject bullet;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        audi = GetComponent<AudioSource>();

        StartCoroutine("move");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator move()
    {
        while (true)
        {
            playerposition = player.transform.position;

            if ((Vector3.Distance(this.gameObject.transform.position, player.transform.position)) <= 20.0f)
            {
                //プレイヤーのほうを向き、拳銃を向け、予測線出す
                Vector3 dir = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
                this.transform.LookAt(dir);
                gun.gameObject.transform.LookAt(new Vector3(dir.x, player.transform.position.y, dir.z));
                prediction.SetActive(true);

                yield return new WaitForSeconds(2);

                //銃弾発射、予測線を消す
                prediction.SetActive(false);
                position = gun.gameObject.transform.position + (this.gameObject.transform.rotation * new Vector3(0, 0.13f, 0));
                GameObject instance = Instantiate(bullet, position, gun.gameObject.transform.rotation);
                audi.PlayOneShot(clip);

                yield return new WaitForSeconds(0.5f);

            }
            yield return null;
        }
    }
}
