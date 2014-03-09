/*

Initial code from tutorial at http://code.tutsplus.com/tutorials/how-to-add-your-own-tools-to-unitys-editor--active-10047

I've followed this excellent editor extension tutorial to get a stard on tile-based editing in Unity. My own additions
are on the way.  Aside from getting around some deprecated functions in the tutorial, all I've done so far is ensure 
there isn't any division by zero.  

*/

using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    public float width = 10.0f;
    public float height = 10.0f;

	public Color color = Color.white;

    private const float MinGridSpace = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDrawGizmos() {
        Vector3 pos = Camera.current.transform.position;
		Gizmos.color = color;

        // Ensure no division by zero, causing infinite grid lines and crashing unity
        if (width < MinGridSpace) width = MinGridSpace;
        if (height < MinGridSpace) height = MinGridSpace;

        for (float y = pos.y - 800.0f; y < pos.y + 800.0f; y += height) {
            Gizmos.DrawLine(new Vector3(-1000000.0f, Mathf.Floor(y / height) * height, 0.0f),
                new Vector3(1000000.0f, Mathf.Floor(y / height) * height, 0.0f));
        }
        for (float x = pos.x - 1200.0f; x < pos.x + 1200.0f; x += width) {
            Gizmos.DrawLine(new Vector3(Mathf.Floor(x / width) * width, -1000000.0f, 0.0f),
                new Vector3(Mathf.Floor(x / width) * width, 1000000.0f, 0.0f));
        }

    }
}
