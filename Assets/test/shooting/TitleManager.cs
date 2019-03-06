using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;

public class TitleManager : MonoBehaviour
{
    private TapGesture m_tapGesture;
    private void Awake()
    {
        if(m_tapGesture == null)
            m_tapGesture = gameObject.AddComponent<TapGesture>();
    }

    private void OnTapped(object sender, System.EventArgs e)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Shooting-Main");
    }

    private void OnEnable()
    {
        m_tapGesture.Tapped += OnTapped; 
    }

    private void OnDisable()
    {
        m_tapGesture.Tapped -= OnTapped; 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
