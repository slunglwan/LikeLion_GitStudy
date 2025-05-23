using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotSpeed = 30f; //���� �ӵ�
    public float revolutionSpeed = 100f; // ���� �ӵ�

    public Transform targetPlanet;
    public bool isRevolution = false;

    // Update is called once per frame
    void Update()
    {
        //�ڱ� �ڽ��� ȸ���ϴ� ���
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
        
        if (isRevolution == true)
        {
            // �����ϴ� ���
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed*Time.deltaTime);
        }
    }
}
