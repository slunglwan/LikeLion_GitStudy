using UnityEngine;

public class Study_GameObject : MonoBehaviour
{
    public GameObject prefab;
    //public GameObject destroyedObj;

    public Vector3 pos;
    public Quaternion rot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("�����Ǿ����ϴ�.");
        CreateAmongUS();

        //Destroy(destroyedObj, 5f); // n�� �Ŀ� �ı��ϴ� ���
    }

    private void OnDestroy()
    {
        Debug.Log("�ı��Ǿ����ϴ�.");
    }

    /// <summary>
    /// ���� ĳ���͸� �����ϰ� �̸��� �����ϴ� ���
    /// </summary>
    public void CreateAmongUS()
    {
        GameObject obj = Instantiate(prefab,pos,rot);
        obj.name = "���� ĳ����";

        Transform objTf = obj.transform;
        int childCount = obj.transform.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {childCount}��");
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(childCount-1).name}");
    }
}
