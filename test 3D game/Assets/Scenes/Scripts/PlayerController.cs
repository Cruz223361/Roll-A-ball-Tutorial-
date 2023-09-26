using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winText;

    private int _count;

    private Rigidbody _PlayerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _PlayerRigidbody = GetComponent<Rigidbody>();
        _count = 0;
        countText.text = "count: " + _count.ToString();
        winText.gameObject.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
          
    {



        float horizontalInput;
        float VerticalInput;

        horizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, VerticalInput);
        _PlayerRigidbody.AddForce(movement);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("pickups"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 1;

           
            
            countText.text = "count:" + _count.ToString();

            if (_count >= 8)
            {
                winText.gameObject.SetActive(true);
            }
             
            
            
        }

    }   
}
       
        
        
        