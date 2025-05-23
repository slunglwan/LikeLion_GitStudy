using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        Debug.Log($"현재 z축의 값은 {this.transform.position.z}");

        this.transform.position += Vector3.forward;

        Debug.Log($"현재 z축의 값은 {this.transform.position.z}");
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed *Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed *Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed *Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed *Time.deltaTime;
        }
        */

        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        //딱 떨어지는 값
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized;
        Debug.Log($"현재 입력 : {normalDir}");

        transform.position += normalDir * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + normalDir);
    }
}
