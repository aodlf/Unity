using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour // mono로 동작, 유니티 기본 동작, 자동상속
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void KeyControll()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += Vector3.left * 0.1f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += Vector3.right * 0.1f;
        }
    }

    // Update is called once per frame // 반복
    void Update()
    {
        KeyControll();
    }
        
}
