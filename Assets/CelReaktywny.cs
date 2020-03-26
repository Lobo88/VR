using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelReaktywny : MonoBehaviour
{
    public void ReactToHit() { 
        BaseAi behavior = GetComponent<BaseAi>();
        if (behavior != null) {
            behavior.SetAlive(false); 
        } StartCoroutine(Die()); 
    }

    private IEnumerator Die() { 
        this.transform.Rotate(-90, 0, 0);
        transform.localPosition= new Vector3(transform.localPosition.x, 0, transform.localPosition.z);
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
}
