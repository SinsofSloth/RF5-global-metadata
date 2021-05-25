[Serializable]
public class BulletChangeSpeed : BulletSubModule // TypeDefIndex: 6460
{
	// Fields
	[SerializeField] // RVA: 0x15CA80 Offset: 0x15CB81 VA: 0x15CA80
	public float startTime; // 0x1C
	[SerializeField] // RVA: 0x15CA90 Offset: 0x15CB91 VA: 0x15CA90
	public float speed; // 0x20

	// Methods

	// RVA: 0x20645C0 Offset: 0x20646C1 VA: 0x20645C0 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2064690 Offset: 0x2064791 VA: 0x2064690 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2064850 Offset: 0x2064951 VA: 0x2064850
	public void .ctor() { }
}

