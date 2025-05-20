using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1,  number2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = AddMethod();
        int minusResult = MinusMethod();

        Debug.Log($"더한 값 : {addResult} / 뺀 값 {minusResult}");
    }

    int AddMethod()
    {
        //지역 변수 result
        int result = number1 + number2;

        return result;
    }

    int MinusMethod()
    {
        //지역 변수 result
        int result = number1 - number2;

        return result;
    }
}
