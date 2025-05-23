using UnityEngine;

public class Study_LookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    public GameObject bulletPrefab; //총알 프리펩
    public Transform firePos; //발사 위치

    public float timer;
    public float cooldownTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        turretHead.LookAt(targetTf);

        //타이머 기능
        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
