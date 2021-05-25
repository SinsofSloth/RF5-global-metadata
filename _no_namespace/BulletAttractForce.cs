[Serializable]
public class BulletAttractForce : BulletSubModule // TypeDefIndex: 6457
{
	// Fields
	[SerializeField] // RVA: 0x15CA00 Offset: 0x15CB01 VA: 0x15CA00
	public float radius; // 0x1C
	[SerializeField] // RVA: 0x15CA10 Offset: 0x15CB11 VA: 0x15CA10
	public float power; // 0x20
	[SerializeField] // RVA: 0x15CA20 Offset: 0x15CB21 VA: 0x15CA20
	public TargetAlliance alliance; // 0x24

	// Methods

	// RVA: 0x20607D0 Offset: 0x20608D1 VA: 0x20607D0 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2060910 Offset: 0x2060A11 VA: 0x2060910 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2060D40 Offset: 0x2060E41 VA: 0x2060D40
	private void AddForce(BulletBase bullet, Character chara) { }

	// RVA: 0x2060E80 Offset: 0x2060F81 VA: 0x2060E80
	public void .ctor() { }
}

