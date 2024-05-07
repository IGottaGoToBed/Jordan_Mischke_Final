using UnityEngine;
using UnityEngine.UI;

public class PlayerSizeController : MonoBehaviour
{
    public Slider playerSizeSlider; 
    public GameObject player;

    private void Start()
    {
        playerSizeSlider.onValueChanged.AddListener(SetPlayerSize);
    }

    private void SetPlayerSize(float size)
    {
        player.transform.localScale = new Vector3(size, size, size);
    }
}