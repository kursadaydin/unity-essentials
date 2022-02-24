using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

   public Button button_start;
    void Start()
    {

        var root = GetComponent<UIDocument>().rootVisualElement;
       button_start = root.Q<Button>("button-start");
       button_start.clicked +=(StartButtonPressed);

    }

    void StartButtonPressed() {
       int counter = 0;
       Debug.Log("Button Pressed" + counter);
       counter++;
    }
}
