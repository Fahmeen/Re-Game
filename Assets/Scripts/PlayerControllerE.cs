using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerControllerE : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private int count;

    public static string k_ButtonNameSubmit
    {
        get;
        internal set;
    }

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("tagged"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            winText.text = "Congratulations! You made it!";
        }
    }
}
