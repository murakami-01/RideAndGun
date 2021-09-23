using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMove : MonoBehaviour
{
    /// <summary>
    /// �G�̍s���p�̊��v���O����
    /// </summary>

    private Vector3 position;
    private AudioSource audi;

    public GameObject prediction;
    public GameObject player;
    public GameObject gun;
    public GameObject bullet;
    public AudioClip clip;


    // Start is called before the first frame update

    public virtual void Start()
    {
        prediction.SetActive(false);
        audi = GetComponent<AudioSource>();

        StartCoroutine("Move");
    }

    public virtual void Set()
    {
        //�v���C���[�̂ق��������A���e�������A�\�����o��
        Vector3 dir = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
        this.transform.LookAt(dir);
        gun.gameObject.transform.LookAt(new Vector3(dir.x, player.transform.position.y, dir.z));
        prediction.SetActive(true);
    }

    public virtual void Shoot()
    {
        prediction.SetActive(false);
        position = gun.gameObject.transform.position + (this.gameObject.transform.rotation * new Vector3(0, 0.13f, 0));
        GameObject instance = Instantiate(bullet, position, gun.gameObject.transform.rotation);
        audi.PlayOneShot(clip);
    }

    public virtual IEnumerator Move()
    {
        while (true)
        {

            if ((Vector3.Distance(this.gameObject.transform.position, player.transform.position)) <= 20.0f)
            {
                Set();
                yield return new WaitForSeconds(1.3f);

                Shoot();
                yield return new WaitForSeconds(0.2f);
            }

            yield return null;
        }
    }
}
