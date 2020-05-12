using UnityEngine;

public class TestCLionLibWrapperScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("With CLion DLL : ");
        Debug.Log(CLionLibWrapper.my_add(42, 51));
        Debug.Log(CLionLibWrapper.my_mul(2, 3));
        Debug.Log(CLionLibWrapper.my_test(10, 100, 100));


        Debug.Log("With Visual Studio DLL : ");
        Debug.Log(VisualStudioLibWrapper.my_add(42, 51));
        Debug.Log(VisualStudioLibWrapper.my_mul(2, 3));

		
    }

    // Update is called once per frame
    void Update()
    {
    }
}