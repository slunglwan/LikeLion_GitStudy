using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotSpeed = 30f; //자전 속도
    public float revolutionSpeed = 100f; // 공전 속도

    public Transform targetPlanet;
    public bool isRevolution = false;

    // Update is called once per frame
    void Update()
    {
        //자기 자신이 회전하는 기능
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
        
        if (isRevolution == true)
        {
            // 공전하는 기능
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed*Time.deltaTime);
        }
    }
}
