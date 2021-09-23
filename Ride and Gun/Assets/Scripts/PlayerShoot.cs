using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    /// <summary>
    /// プレイヤーが攻撃するためのプログラム
    /// </summary>

    public GameObject bullet;
    public AudioClip clip;
    private Vector3 position;
    private new AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            //弾丸生成
            position = this.gameObject.transform.position + (this.transform.rotation * new Vector3(0,0.13f,0)) ;
            Instantiate(bullet, position, this.transform.rotation);
            audio.PlayOneShot(clip);


        }

    }
}
