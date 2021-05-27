using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingTest : MonoBehaviour
{
    Ray m_ray;
    RaycastHit m_rayHit;

    GameObject GetClickObject()
    {
        m_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(m_ray, out m_rayHit, 1000f))
        {
            return m_rayHit.collider.gameObject;
        }
        return null;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
