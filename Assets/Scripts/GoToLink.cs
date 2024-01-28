using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GoToLink : MonoBehaviour
{
    public Sprite normalState;
    public Sprite hoverState;
    public SpriteRenderer spriteRenderer;
    private string userLink;

    public string whoButtons;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        userLink = "";

        if(spriteRenderer != null && normalState != null)
        {
            spriteRenderer.sprite = normalState;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (whoButtons)
        {
            case "Maya":
                userLink = "https://www.linkedin.com/in/maya-harry-9133b41a9";
                break;
            case "Ned":
                userLink = "https://wakayrd.carrd.co/";
                break;
            case "Ralph":
                userLink = "https://www.linkedin.com/in/ralph-robes/";
                break;
            case "Elijah":
                userLink = "https://www.linkedin.com/in/elijah-tanimowo/";
                break;
            case "Peter":
                userLink = "https://itch.io/profile/peterzougasmusic";
                break;
        }

        
    }

    private void OnMouseDown()
    {
        Application.OpenURL(userLink);
    }
    private void OnMouseOver()
    {
        if(spriteRenderer != null && hoverState != null)
        {
            spriteRenderer.sprite = hoverState;
        }
    }

    private void OnMouseExit()
    {
        if (spriteRenderer != null && normalState != null)
        {
            spriteRenderer.sprite = normalState;
        }
    }
}
