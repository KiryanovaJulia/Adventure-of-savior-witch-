using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    public float _speed;
    public MeshRenderer _MeshRenderer;

    private Vector2 _meshoffset;

    void Start()
    {
        _MeshRenderer = GetComponent<MeshRenderer>();
        _meshoffset = _MeshRenderer.sharedMaterial.mainTextureOffset;
    }

    private void OnDisable()
    {
        _MeshRenderer.sharedMaterial.mainTextureOffset = _meshoffset;
    }

    // Update is called once per frame
    void Update()
    {

        var x = Mathf.Repeat(Time.time * _speed, 1);
        var offset = new Vector2(x, _meshoffset.y);

        _MeshRenderer.sharedMaterial.mainTextureOffset = offset;
    }
}
