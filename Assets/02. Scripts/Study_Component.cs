using UnityEngine;// UnityEngine이라는 namespace를 사용한다는 선언

public class Study_Component : MonoBehaviour
//접근제한자 클래스명
{
    public GameObject obj;
  //접근제한자 데이터타입 변수이름
    public Transform objTf;
    public GameObject objCube;
    public Mesh msh;
    public Material mat;
    
    //public string changeName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    //타입 함수명
    {
        /*
        obj = GameObject.Find("Main Camera");
        */
        //     타입      찾겠다.

        obj = GameObject.FindGameObjectWithTag("Player");

        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        //objTf.gameObject.SetActive(false);

        Debug.Log($"이름 : {obj.name}"); //게임오브젝트의 이름
        Debug.Log($"태그 : {obj.tag}"); //게임오브젝트의 태그
        Debug.Log($"위치 : {obj.transform.position}"); //게임오브젝트의 Transform 컴포넌트의 위치
        Debug.Log($"회전 : {obj.transform.rotation}"); //게임오브젝트의 Transform 컴포넌트의 회전
        Debug.Log($"위치 : {obj.transform.localScale}"); //게임오브젝트의 Transform 컴포넌트의 크기
        Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");

        //obj.GetComponent<MeshRenderer>().enabled = false;
        //obj.SetActive(false);

        //obj.name = changeName;

        objCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //CreateCube();
    }

    private void CreateCube()
    {
        objCube = new GameObject("CUBE");
        objCube.AddComponent<MeshFilter>();
        objCube.GetComponent<MeshFilter>().mesh = msh;
        objCube.AddComponent<MeshRenderer>();
        objCube.GetComponent<MeshRenderer>().material = mat;
        objCube.AddComponent<BoxCollider>();
    }
}
