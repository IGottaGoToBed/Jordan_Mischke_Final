using UnityEngine;
using UnityEngine.UI;

public class SaveInputValue : MonoBehaviour
{
    public InputField nameInputField;

    private string savedValue; 

    public void SaveValue()
    {
        savedValue = nameInputField.text; 
        Debug.Log("Value saved: " + savedValue);
    }
}