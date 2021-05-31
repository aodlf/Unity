using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour
{
    bool m_isToggleOn;
    string m_id = "아이디를 입력하세요";
    string m_pass = "1234"; 
    void OnGUI()
    {
        if(GUI.Button(new Rect((Screen.width - 150)/2, (Screen.height - 50)/2, 150, 50), "START"))
        {
            Debug.Log("Start game");
        }
        GUILayout.BeginArea(new Rect(10, Screen.height - 400, 200, 400), GUI.skin.box);
        GUILayout.Space(20);
        GUILayout.Button("START", GUILayout.Width(100), GUILayout.Height(60));
        m_isToggleOn = GUILayout.Toggle(m_isToggleOn, "무적모드");
        if(m_isToggleOn)
        {
            GUILayout.Label("무적모드 활성화");
        }
        m_id = GUILayout.TextField(m_id);
        m_pass = GUILayout.PasswordField(m_pass, '*');
        GUILayout.EndArea();

        GUILayout.BeginArea(new Rect(Screen.width - 400 - 10, Screen.height - 400, 200, 400), GUI.skin.box);
        GUILayout.EndArea();
    }
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1280, 720, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
