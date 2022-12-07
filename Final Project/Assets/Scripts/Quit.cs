using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


public class Quit : MonoBehaviour
{
    private VisualElement frame;
    private Button button;

    void OnEnable()
    {
        // get the UIDocument component (make sure this name matches!)
        var uiDocument = GetComponent<UIDocument>();
        // get the rootVisualElement (the frame component)
        var rootVisualElement = uiDocument.rootVisualElement;
        frame = rootVisualElement.Q<VisualElement>("Frame");
        // get the button, which is nested in the frame
        button = frame.Q<Button>("Button");
        // create event listener that calls ChangeCamera() when pressed
        button.RegisterCallback<ClickEvent>(ev => Quitgame());
    }

    public void Quitgame() {
        Application.Quit();
    }
}
