using UnityEngine;

public class UiShop : MonoBehaviour
{

    private Transform container;
    private Transform shopitemTemplate;

    private void Awake()
    {
        container = transform.Find("container");
        shopitemTemplate = container.Find("shopitemTemplate");
        shopitemTemplate.gameObject.SetActive(false); 
    }


}
