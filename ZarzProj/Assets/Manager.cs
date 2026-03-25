using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public static Manager Instance { get; private set; }
    [SerializeField] public List<Player> players = new List<Player>(4);
    public TMP_InputField playerName;
    [SerializeField] GameObject GamePanel, LoginPanel;
    public bool DisableLogin = false;

    [SerializeField] GameObject playerPrefab;
    [SerializeField] Transform playerSpawnPoint;
    private void Awake()
    {
        players.Add(new Player (  "Janusz",  "wolfy2@wp.pl",  null ));
        Instance = this;
        if (DisableLogin)
        {
            LoginPanel.SetActive(false);
            GamePanel.SetActive(true);
        }

        foreach(Player player in players)
        {
            GameObject newPlayer = Instantiate(playerPrefab,Vector3.zero, Quaternion.identity, playerSpawnPoint);
            newPlayer.GetComponent<DemoCell>().SetPlayer(player);
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
