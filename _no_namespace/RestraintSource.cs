[Serializable]
public class RestraintSource // TypeDefIndex: 6807
{
	// Fields
	[SerializeField] // RVA: 0x15FAD0 Offset: 0x15FBD1 VA: 0x15FAD0
	public Transform sourceTransform; // 0x10
	[SerializeField] // RVA: 0x15FAE0 Offset: 0x15FBE1 VA: 0x15FAE0
	[RangeAttribute] // RVA: 0x15FAE0 Offset: 0x15FBE1 VA: 0x15FAE0
	public float weight; // 0x18

	// Methods

	// RVA: 0x232C4D0 Offset: 0x232C5D1 VA: 0x232C4D0
	public void .ctor() { }

	// RVA: 0x232C510 Offset: 0x232C611 VA: 0x232C510
	public void .ctor(Transform source, float _weight) { }

	// RVA: 0x232C560 Offset: 0x232C661 VA: 0x232C560
	public void .ctor(RestraintSource source) { }
}

