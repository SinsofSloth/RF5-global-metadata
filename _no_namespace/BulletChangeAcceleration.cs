[Serializable]
public class BulletChangeAcceleration : BulletSubModule // TypeDefIndex: 6458
{
	// Fields
	[SerializeField] // RVA: 0x15CA30 Offset: 0x15CB31 VA: 0x15CA30
	public float startTime; // 0x1C
	[SerializeField] // RVA: 0x15CA40 Offset: 0x15CB41 VA: 0x15CA40
	public float acceleration; // 0x20

	// Methods

	// RVA: 0x2064160 Offset: 0x2064261 VA: 0x2064160 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2064230 Offset: 0x2064331 VA: 0x2064230 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2064270 Offset: 0x2064371 VA: 0x2064270
	public void .ctor() { }
}

