using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class StrawberryScript : MonoBehaviour, IPointerClickHandler
{
    static public bool checkpoint;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventdata)
    {
        print("checkpoint");
        checkpoint = true;
        gameObject.SetActive(false);
        
    }
}
