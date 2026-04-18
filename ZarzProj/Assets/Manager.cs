using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Main game manager class (Singleton pattern)
public class Manager : MonoBehaviour
{
    // Static instance so it can be accessed globally
    public static Manager Instance { get; private set; }

    // List of players (max initial capacity = 4)
    [SerializeField] public List<Player> players = new List<Player>(4);

    // UI input field for entering player name
    public TMP_InputField playerName;

    // References to UI panels
    [SerializeField] GameObject GamePanel, LoginPanel;

    // Flag to skip login screen
    public bool DisableLogin = false;

    // Prefab for spawning player UI/game objects
    [SerializeField] GameObject playerPrefab;

    // Parent transform where player objects will be spawned
    [SerializeField] Transform playerSpawnPoint;

    // Called when the script instance is being loaded
    private void Awake()
    {
        // Add a default player (for testing/demo purposes)
        players.Add(new Player("Janusz", "wolfy2@wp.pl", null));

        // Assign singleton instance
        Instance = this;

        // If login is disabled, skip login UI and show game UI
        if (DisableLogin)
        {
            LoginPanel.SetActive(false);
            GamePanel.SetActive(true);
        }

        // Loop through all players and create their visual representations
        foreach (Player player in players)
        {
            // Instantiate player prefab under the spawn point
            GameObject newPlayer = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity, playerSpawnPoint);

            // Assign player data to the spawned object (via DemoCell component)
            newPlayer.GetComponent<DemoCell>().SetPlayer(player);
        }
    }

    // Method intended to add a new player (currently empty)
    public void AddPlayer()
    {
        // TODO: Implement logic for adding a new player
      
    }

    // Called once per frame
    void Update()
    {
   
    }
}