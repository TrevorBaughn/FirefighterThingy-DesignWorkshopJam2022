using UnityEngine;

public class Room : MonoBehaviour
{
    public int[] position;
    public GameObject doorNorth;
    public GameObject floorNorth;
    public GameObject doorSouth;
    public GameObject floorSouth;
    public GameObject doorWest;
    public GameObject floorWest;
    public GameObject doorEast;
    public GameObject floorEast;
    public GameObject fireSpawner;

    public bool[] doors = {true, true, true, true};

    public GameObject[] westObjects;
    public GameObject[] southObjects;

    void Start()
    {
        doorNorth.SetActive(!doors[0]);
        floorNorth.SetActive(doors[0]);
        doorEast.SetActive(!doors[1]);
        floorEast.SetActive(doors[1]);
        if (doorSouth != null)
        {
            doorSouth.SetActive(!doors[2]);
            floorSouth.SetActive(doors[2]);
        }
        if (doorWest != null)
        {
            doorWest.SetActive(!doors[3]);
            floorWest.SetActive(doors[3]);
        }
    }
}
