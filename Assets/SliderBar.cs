using System;
using System.Collections;
using System.Collections.Generic;
using Controllers.Player;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using Update = Unity.VisualScripting.Update;


public class SliderBar : MonoBehaviour
{
    public Text gemText;
    
    [SerializeField] public TextMeshProUGUI gemTextMeshPro;
    public GemManager gemManager;
    public Slider _bar;
    public PlayerPhysicsController _playerPhysicsController;
    public static SliderBar instance;
    private void Awake()
    {
        _bar = GameObject.Find("Slider").GetComponent<Slider>();
        instance = this;
    }
    
    private void Start()
    {
      
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            
            Debug.Log("+++");
            _bar.value += 2;
            
            
            // barChange = (barAmount * 5) / 100;
            // _bar.value += barChange;
            // _bar.value = _bar.value;
        }

    }

    void Update()
    {
        if (gemManager.gem20 == true)
        {
            Debug.Log("20 gem win");
            gemText.text = " 20 gem win";
            gemTextMeshPro.text = " 20 gem win";
        }
        if (gemManager.gem50 == true)
        {
            Debug.Log("50 gem win");
            gemText.text = " 50 gem win";
            gemTextMeshPro.text = " 50 gem win";
        }
        if (gemManager.gem100 == true)
        {
            Debug.Log("100 gem win");
            gemText.text = " 100 gem win";
            gemTextMeshPro.text = " 100 gem win";
        }
        
        
        
    }
}
