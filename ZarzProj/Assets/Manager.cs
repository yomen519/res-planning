using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
   [SerializeField] public List<Player> players = new List<Player>(4);
    public TMP_InputField playerName;
    [SerializeField] GameObject GamePanel, LoginPanel;
    public bool DisableLogin = false; 
    private void Awake()
    {
        if (DisableLogin)
        {
            LoginPanel.SetActive(false);
            GamePanel.SetActive(true);
        }
    }
    public void AddPlayer()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
