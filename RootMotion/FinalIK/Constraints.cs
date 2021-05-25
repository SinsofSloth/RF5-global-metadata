[Serializable]
public class Constraints // TypeDefIndex: 9419
{
	// Fields
	public Transform transform; // 0x10
	public Transform target; // 0x18
	public Vector3 positionOffset; // 0x20
	public Vector3 position; // 0x2C
	[RangeAttribute] // RVA: 0x178E90 Offset: 0x178F91 VA: 0x178E90
	public float positionWeight; // 0x38
	public Vector3 rotationOffset; // 0x3C
	public Vector3 rotation; // 0x48
	[RangeAttribute] // RVA: 0x178EB0 Offset: 0x178FB1 VA: 0x178EB0
	public float rotationWeight; // 0x54

	// Methods

	// RVA: 0x273A1B0 Offset: 0x273A2B1 VA: 0x273A1B0
	public bool IsValid() { }

	// RVA: 0x2735900 Offset: 0x2735A01 VA: 0x2735900
	public void Initiate(Transform transform) { }

	// RVA: 0x2735AF0 Offset: 0x2735BF1 VA: 0x2735AF0
	public void Update() { }

	// RVA: 0x2736360 Offset: 0x2736461 VA: 0x2736360
	public void .ctor() { }
}

