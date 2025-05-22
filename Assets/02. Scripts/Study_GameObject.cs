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
        Debug.Log("생성되었습니다.");
        CreateAmongUS();

        //Destroy(destroyedObj, 5f); // n초 후에 파괴하는 기능
    }

    private void OnDestroy()
    {
        Debug.Log("파괴되었습니다.");
    }

    /// <summary>
    /// 어몽어스 캐릭터를 생성하고 이름을 설정하는 기능
    /// </summary>
    public void CreateAmongUS()
    {
        GameObject obj = Instantiate(prefab,pos,rot);
        obj.name = "어몽어스 캐릭터";

        Transform objTf = obj.transform;
        int childCount = obj.transform.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {childCount}개");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(childCount-1).name}");
    }
}
