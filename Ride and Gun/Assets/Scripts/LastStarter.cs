using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastStarter : MonoBehaviour
{
    public GameObject player;
    public GameObject gun;
    //public GameObject boss;
    public GameObject mob1;
    public GameObject mob2;
    //public GameObject mob3;
    //public GameObject mob4;
    public GameObject music2;

    // Start is called before the first frame update
    void Start()
    {
        //var script1 = mob1.GetComponent<MobMove>();
        //var script2 = mob2.GetComponent<MobMove>();
        //var script3 = mob3.GetComponent<MobMove>();
        //var script4 = mob4.GetComponent<MobMove>();
        //var scriptBoss = boss.GetComponent<BossMove>();
        var scriptPlayer = player.GetComponent<MainMove>();
        var scriptGun = gun.GetComponent<PlayerShoot>();

        //mob1.SetActive(true);
        //mob2.SetActive(true);
        //script3.enabled = true;
        //script4.enabled = true;
        //scriptBoss.enabled = true;
        scriptPlayer.enabled = true;
        scriptGun.enabled = true;
        music2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
