public class BulletScriptPlayer : BulletSubModule // TypeDefIndex: 6474
{
	// Fields
	[SerializeField] // RVA: 0x15CCA0 Offset: 0x15CDA1 VA: 0x15CCA0
	public BulletScriptPlayType playtype; // 0x1C
	[SerializeField] // RVA: 0x15CCB0 Offset: 0x15CDB1 VA: 0x15CCB0
	public string scriptName; // 0x20

	// Methods

	// RVA: 0x206C750 Offset: 0x206C851 VA: 0x206C750 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x206C840 Offset: 0x206C941 VA: 0x206C840 Slot: 10
	public override void OnHit(BulletBase bullet) { }

	// RVA: 0x206C900 Offset: 0x206CA01 VA: 0x206C900 Slot: 11
	public override void OnDead(BulletBase bullet) { }

	// RVA: 0x206C8B0 Offset: 0x206C9B1 VA: 0x206C8B0
	private void Play(BulletBase bullet) { }

	// RVA: 0x206C970 Offset: 0x206CA71 VA: 0x206C970
	public void .ctor() { }
}

