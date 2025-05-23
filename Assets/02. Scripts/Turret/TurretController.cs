using UnityEngine;

public class TurretController : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    public GameObject bulletPrefab; //�Ѿ� ������
    public Transform firePos; //�߻� ��ġ

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

        //Ÿ�̸� ���
        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
