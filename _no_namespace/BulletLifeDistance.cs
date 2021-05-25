[Serializable]
public class BulletLifeDistance : BulletSubModule // TypeDefIndex: 6470
{
	// Fields
	[SerializeField] // RVA: 0x15CC00 Offset: 0x15CD01 VA: 0x15CC00
	public float maxDistance; // 0x1C
	private float currentDistance; // 0x20
	private Vector3 curentPosition; // 0x24

	// Methods

	// RVA: 0x2069DA0 Offset: 0x2069EA1 VA: 0x2069DA0 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2069E90 Offset: 0x2069F91 VA: 0x2069E90 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2069FE0 Offset: 0x206A0E1 VA: 0x2069FE0
	public void .ctor() { }
}

