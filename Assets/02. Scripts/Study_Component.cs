using UnityEngine;// UnityEngine�̶�� namespace�� ����Ѵٴ� ����

public class Study_Component : MonoBehaviour
//���������� Ŭ������
{
    public GameObject obj;
  //���������� ������Ÿ�� �����̸�
    
    public string changeName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    //Ÿ�� �Լ���
    {
        obj = GameObject.Find("Main Camera");
        //     Ÿ��      ã�ڴ�.
        obj.name = changeName;
    }
}
