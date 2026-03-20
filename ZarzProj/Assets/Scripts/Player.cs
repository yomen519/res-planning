

using UnityEngine;

[System.Serializable]
public class Player 
{
 [SerializeField]  public  string Name { get; set; }
 [SerializeField]  public  string email { get; set; }
    [SerializeField] public Texture2D Avatar { get; set; }

    public Player(string name,string Email, Texture2D avatar)
    {
        Name = name;
        email = Email;
        Avatar = avatar;
    }
}
