using UnityEngine;// UnityEngine이라는 namespace를 사용한다는 선언

public class Study_Component : MonoBehaviour
//접근제한자 클래스명
{
    public GameObject obj;
  //접근제한자 데이터타입 변수이름
    
    public string changeName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    //타입 함수명
    {
        obj = GameObject.Find("Main Camera");
        //     타입      찾겠다.
        obj.name = changeName;
    }
}
