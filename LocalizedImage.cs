using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocalizedImage : MonoBehaviour {

    public static LocalizedImage Instance;

    [SerializeField]
    public string key;

    private Image print_img;
    [SerializeField]
    private Image img_kor;
    [SerializeField]
    private Image img_eng;
    
    void Start () 
    {
        if (Instance == null) {
            
            Instance = this;
        
        } else if (Instance != this)
        {
            Destroy (gameObject);
        }
        DontDestroyOnLoad (gameObject);
    
        print_img.sprite = img_kor.sprite;
    }

    private void OnEnable()
    {
        print_img = GetComponent<Image> ();
        img_kor = img_kor.GetComponent<Image>();
        img_eng = img_eng.GetComponent<Image>();
        ReloadImg();
    }

    public void ReloadImg()
    {
        if(key.Equals("kor"))
        {
            print_img.sprite= img_kor.sprite;
        }
        if(key.Equals("eng"))
        {
            print_img.sprite = img_eng.sprite;
        }
    }
    void OnValidate()
    {
        ReloadImg();
    }
    
}