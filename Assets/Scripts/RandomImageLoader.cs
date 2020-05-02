using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomImageLoader : MonoBehaviour
{
    [SerializeField] Image backgroundImage;
    [SerializeField] Sprite[] images;

    void Start()
    {
        backgroundImage.sprite = GetRandomImage();
    }

    private Sprite GetRandomImage()
    {
        int randomNumber = Random.Range(0, images.Length);
        return images[randomNumber];
    }
}