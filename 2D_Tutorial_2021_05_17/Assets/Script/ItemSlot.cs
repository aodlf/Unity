using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    GameItem m_item;

    public bool IsEmpty { get { return m_item = null; } }
    bool m_isSelect;
    [SerializeField]
    Inventory m_myInven;
    public bool IsSelect { get { return m_isSelect; } set { m_isSelect = value; } }
    public void InitSlot(Inventory inven)
    {
        m_myInven = inven;
    }
    public void SetSlot(GameItem item)
    {
        m_item = item;
    }
    public void OnSelect()
    {
        m_myInven.OnSelectSlot(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
