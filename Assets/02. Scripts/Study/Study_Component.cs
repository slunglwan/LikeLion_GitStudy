using UnityEngine;// UnityEngine�̶�� namespace�� ����Ѵٴ� ����

public class Study_Component : MonoBehaviour
//���������� Ŭ������
{
    public GameObject obj;
  //���������� ������Ÿ�� �����̸�
    public Transform objTf;
    public GameObject objCube;
    public Mesh msh;
    public Material mat;
    
    //public string changeName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    //Ÿ�� �Լ���
    {
        /*
        obj = GameObject.Find("Main Camera");
        */
        //     Ÿ��      ã�ڴ�.

        obj = GameObject.FindGameObjectWithTag("Player");

        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        //objTf.gameObject.SetActive(false);

        Debug.Log($"�̸� : {obj.name}"); //���ӿ�����Ʈ�� �̸�
        Debug.Log($"�±� : {obj.tag}"); //���ӿ�����Ʈ�� �±�
        Debug.Log($"��ġ : {obj.transform.position}"); //���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
        Debug.Log($"ȸ�� : {obj.transform.rotation}"); //���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
        Debug.Log($"��ġ : {obj.transform.localScale}"); //���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��
        Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");

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
