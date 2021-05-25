[Serializable]
public class BulletSearchSphere : BulletSubModule // TypeDefIndex: 6475
{
	// Fields
	[SerializeField] // RVA: 0x15CCC0 Offset: 0x15CDC1 VA: 0x15CCC0
	public float radius; // 0x1C
	[SerializeField] // RVA: 0x15CCD0 Offset: 0x15CDD1 VA: 0x15CCD0
	public TargetAlliance alliance; // 0x20
	[SerializeField] // RVA: 0x15CCE0 Offset: 0x15CDE1 VA: 0x15CCE0
	public float interval; // 0x24
	private int m_count; // 0x28

	// Methods

	// RVA: 0x206C9E0 Offset: 0x206CAE1 VA: 0x206C9E0 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x206CAD0 Offset: 0x206CBD1 VA: 0x206CAD0 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x206CE10 Offset: 0x206CF11 VA: 0x206CE10
	public void .ctor() { }
}

