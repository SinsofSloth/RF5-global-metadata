[Serializable]
public class BulletChangeScale : BulletSubModule // TypeDefIndex: 6459
{
	// Fields
	[SerializeField] // RVA: 0x15CA50 Offset: 0x15CB51 VA: 0x15CA50
	public float starttime; // 0x1C
	[SerializeField] // RVA: 0x15CA60 Offset: 0x15CB61 VA: 0x15CA60
	public float endtime; // 0x20
	[SerializeField] // RVA: 0x15CA70 Offset: 0x15CB71 VA: 0x15CA70
	public Vector3 scale; // 0x24
	private Vector3 startScale; // 0x30

	// Methods

	// RVA: 0x2064280 Offset: 0x2064381 VA: 0x2064280 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x20643E0 Offset: 0x20644E1 VA: 0x20643E0 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2064520 Offset: 0x2064621 VA: 0x2064520
	public void .ctor() { }
}

