[Serializable]
public class BulletCurve : BulletSubModule // TypeDefIndex: 6463
{
	// Fields
	[SerializeField] // RVA: 0x15CAB0 Offset: 0x15CBB1 VA: 0x15CAB0
	public Vector3 speed; // 0x1C
	[SerializeField] // RVA: 0x15CAC0 Offset: 0x15CBC1 VA: 0x15CAC0
	public float duration; // 0x28

	// Methods

	// RVA: 0x2065FC0 Offset: 0x20660C1 VA: 0x2065FC0 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2066100 Offset: 0x2066201 VA: 0x2066100 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2066520 Offset: 0x2066621 VA: 0x2066520
	public void .ctor() { }
}

