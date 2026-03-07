using UnityEngine;

public class GrabbyCube : Interactable
{
    public override void Start()
    {
        base.Start();
    }

    protected override void InitializeStates() { }

    public void Grabbed(Vector3 position)
    {
        Vector3 dir = position - transform.position;
        float mag = dir.magnitude;
        mag = Mathf.Clamp(mag, 0f, 10f);
        dir = dir.normalized * mag * 10;
        rigidBody.linearVelocity = dir;
        rigidBody.angularVelocity *= 0.99f;
    }

    public void Ungrabbed()
    {
        rigidBody.linearVelocity = Vector3.zero;
    }
}
