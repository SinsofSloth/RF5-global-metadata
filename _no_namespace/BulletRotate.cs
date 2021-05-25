public class BulletRotate : BulletSubModule // TypeDefIndex: 6473
{
	// Fields
	[SerializeField] // RVA: 0x15CC70 Offset: 0x15CD71 VA: 0x15CC70
	public float starttime; // 0x1C
	[SerializeField] // RVA: 0x15CC80 Offset: 0x15CD81 VA: 0x15CC80
	public float endtime; // 0x20
	[SerializeField] // RVA: 0x15CC90 Offset: 0x15CD91 VA: 0x15CC90
	public Vector3 rotate; // 0x24
	private Quaternion startRotate; // 0x30

	// Methods

	// RVA: 0x206C200 Offset: 0x206C301 VA: 0x206C200 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x206C340 Offset: 0x206C441 VA: 0x206C340 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x206C6C0 Offset: 0x206C7C1 VA: 0x206C6C0
	public void .ctor() { }
}

