using TMPro;
using UnityEngine;

public class StrawberryScript : MonoBehaviour
{
    public TextMeshPro strawbText;
    public GameObject textBox, strawberry, strawberry1, strawberry2, strawberry3, strawberry4, strawberry5, character, character2, ths, nx, ys, n;
    static public int strawbCount;
    static public int dia;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        dia = 35;
        strawbCount = 2;
        strawbText.text = "Perfect! Right where we need to be. And look! Another strawberry!";
        strawberry.SetActive(true);
        strawberry1.SetActive(true);
        strawberry2.SetActive(true);
        
    }
}
