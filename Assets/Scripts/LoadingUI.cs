using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingUI : MonoBehaviour
{
    public float dotsAppearingspeed;
    public float rotationSpeed = 10f;
    public TextMeshProUGUI loading;
    public RectTransform loadingIcon;

    private float timer;
    private int dotcount = 0;
    private void Update()
    {
        
        
        timer += Time.deltaTime;

        if (timer >= dotsAppearingspeed)
        {
            timer = 0f;
            
            dotcount++;
            if (dotcount > 3)
            {
                dotcount = 0;
            }

            loading.text = "Loading" + new string('.', dotcount);
        }
        
        
        loadingIcon.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
