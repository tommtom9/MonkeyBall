using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
    private Camera camera;
    private bool canClick = false;
    private bool open = false;

    [SerializeField]
    private GameObject levels;
    [SerializeField]
    private GameObject credits;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void levelSelector()
    {
            Debug.Log("hey");
            if (open)
            {
                levels.SetActive(true);
                open = false;
            }
            else
            {
                if (!open)
                {
                    levels.SetActive(false);
                    open = true;
                }
            }
    }

    public void lvl1() 
    {
        Application.LoadLevel("1");
    }

    public void lvl2()
    {
        Application.LoadLevel("2");
    }
    public void lvl3()
    {
        Application.LoadLevel("3");
    }
    public void lvl4()
    {
        Application.LoadLevel("4");
    }
    public void lvl5()
    {
        Application.LoadLevel("5");
    }
    public void lvl6()
    {
        Application.LoadLevel("6");
    }
    public void lvl7()
    {
        Application.LoadLevel("7");
    }
    public void lvl8()
    {
        Application.LoadLevel("8");
    }

    public void quit()
    {
        Application.Quit();
    }
}

