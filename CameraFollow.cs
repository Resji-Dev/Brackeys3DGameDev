using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]private Transform _position;
    [SerializeField]private Vector3 _offset;
    [SerializeField]private Transform _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _position.position = _player.position + _offset;
    }
}
