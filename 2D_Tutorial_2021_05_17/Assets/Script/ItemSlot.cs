using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    GameItem m_item;

    public bool isEmpty { get { return m_item = null; } }

    public void SetSlot(GameItem item)
    {
        m_item = item;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
