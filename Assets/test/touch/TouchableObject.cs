using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TouchScript.Gestures;

public class TouchableObject : MonoBehaviour
{
    private TapGesture m_tapGesture;

    private void Awake()
    {
        if(m_tapGesture == null)
            m_tapGesture = gameObject.AddComponent<TapGesture>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnEnable()
    {
        m_tapGesture.Tapped += OnTapped;
    }

    private void OnDisable()
    {
        m_tapGesture.Tapped -= OnTapped;
    }

    private void OnTapped(object sender, EventArgs args)
    {
        Vector3 newScale = new Vector3(2, 2, 1);
        transform.localScale = newScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
