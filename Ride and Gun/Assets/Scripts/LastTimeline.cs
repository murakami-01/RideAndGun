using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LastTimeline : MonoBehaviour
{
    private PlayableDirector director;
    private Component playermove;
    public GameObject player;
    public GameObject gun;
    public GameObject boss;
    public GameObject mob1;
    public GameObject mob2;
    public GameObject mob3;
    public GameObject mob4;
    public GameObject music1;
    public GameObject music2;
    public GameObject prediction;

    private void Awake()
    {
        director = GetComponent<PlayableDirector>();
        playermove = player.GetComponent<MainMove>();
        director.played += Director_Played;
        //director.stopped += Director_Stopped;
    }

    private void OnEnable()
    {
        director.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        Debug.Log("stopped!");
        //var script1 = mob1.GetComponent<MobMove>();
        //var script2 = mob2.GetComponent<MobMove>();
        //var script3 = mob3.GetComponent<MobMove>();
        //var script4 = mob4.GetComponent<MobMove>();
        //var scriptBoss = boss.GetComponent<BossMove>();
        var scriptPlayer = player.GetComponent<MainMove>();
        var scriptGun = gun.GetComponent<PlayerShoot>();

        //script1.enabled = true;
        //script2.enabled = true;
        //script3.enabled = true;
        //script4.enabled = true;
        //scriptBoss.enabled = true;
        scriptPlayer.enabled = true;
        scriptGun.enabled = true;
        music2.SetActive(true);
    }

    private void Director_Stopped(PlayableDirector obj)
    {
        Debug.Log("stopped!");
        //var script1 = mob1.GetComponent<MobMove>();
        //var script2 = mob2.GetComponent<MobMove>();
        //var script3 = mob3.GetComponent<MobMove>();
        //var script4 = mob4.GetComponent<MobMove>();
        //var scriptBoss = boss.GetComponent<BossMove>();
        var scriptPlayer = player.GetComponent<MainMove>();
        var scriptGun = gun.GetComponent<PlayerShoot>();

        //script1.enabled = true;
        //script2.enabled = true;
        //script3.enabled = true;
        //script4.enabled = true;
        //scriptBoss.enabled = true;
        scriptPlayer.enabled = true;
        scriptGun.enabled = true;
        music2.SetActive(true);

    }

    private void Director_Played(PlayableDirector obj)
    {
        //var script1 = mob1.GetComponent<MobMove>();
        //var script2 = mob2.GetComponent<MobMove>();
        //var script3 = mob3.GetComponent<MobMove>();
        //var script4 = mob4.GetComponent<MobMove>();
        //var scriptBoss = boss.GetComponent<BossMove>();
        var scriptPlayer = player.GetComponent<MainMove>();
        var scriptGun = gun.GetComponent<PlayerShoot>();

        mob1.SetActive(false);
        mob2.SetActive(false);
        //script3.enabled = false;
        //script4.enabled = false;
        //scriptBoss.enabled = false;
        //Debug.Log(script1.name);
        //Debug.Log(script2.name);
        scriptPlayer.enabled = false;
        scriptGun.enabled = false;
        music1.SetActive(false);
     }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        if (name == "Player")
        {
            director.Play();
        }
    }

}
