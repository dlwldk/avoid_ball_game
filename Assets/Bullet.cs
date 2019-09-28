using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    float checkTime = 2.0f;
    float delta = 0.0f;
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.checkTime)
        {
            float randomX = Random.Range(0, 15); //랜덤하게 위치
            float randomZ = Random.Range(0, 15); //랜덤하게 위치

            Instantiate(bullet, new Vector3(randomX, 10, randomZ), Quaternion.identity); //하늘에서 공 bullet 떨어뜨림
            this.delta = 0;
        }
    }


}
