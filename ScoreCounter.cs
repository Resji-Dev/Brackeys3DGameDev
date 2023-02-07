using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]private Transform _transform;
    [SerializeField]private TextMeshProUGUI scoreText;
    [SerializeField]private Movement _movementScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = _transform.position.z.ToString("0");
        
    }
}
