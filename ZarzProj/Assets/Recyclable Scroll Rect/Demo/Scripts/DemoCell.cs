using UnityEngine;
using UnityEngine.UI;
using PolyAndCode.UI;
using System.Xml.Serialization;

//Cell class for demo. A cell in Recyclable Scroll Rect must have a cell class inheriting from ICell.
//The class is required to configure the cell(updating UI elements etc) according to the data during recycling of cells.
//The configuration of a cell is done through the DataSource SetCellData method.
//Check RecyclableScrollerDemo class
public class DemoCell : MonoBehaviour, ICell
{
    //UI
    public Text nameLabel;
    public Text idLabel;
    public Player myPlayer; 
    public string Content; 


    //Model
    private ContactInfo _contactInfo;
    private int _cellIndex;

    private void Start()
    {
        //Can also be done in the inspector
        GetComponent<Button>().onClick.AddListener(ButtonListener);
    }

    //This is called from the SetCell method in DataSource
    public void ConfigureCell(ContactInfo contactInfo,int cellIndex)
    {
        _cellIndex = cellIndex;
        _contactInfo = contactInfo;

 //       nameLabel.text = contactInfo.Name;
  //      idLabel.text = contactInfo.id;
    }
    public void SetPlayer(Player player)
    {
        nameLabel.text = player.Name;
        idLabel.text = player.email;
        myPlayer = player;
     
    }

    private void ButtonListener()
    {
        Debug.Log("Index : " + _cellIndex +  ", Name : " + _contactInfo.Name  );
      
        
    }
    public void AssignPlayer()
    {
        GetComponentInParent<RecyclableScrollRect>().transform.parent.gameObject.SetActive(false);
        GetComponentInParent<TaskConfigurator>().SetPlayer(myPlayer); Destroy(gameObject);
    }
}
