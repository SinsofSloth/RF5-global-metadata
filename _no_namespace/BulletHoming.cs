[Serializable]
public class BulletHoming : BulletSubModule // TypeDefIndex: 6467
{
	// Fields
	private const float HomingInductiveMax = 100;
	[SerializeField] // RVA: 0x15CB50 Offset: 0x15CC51 VA: 0x15CB50
	private float starttime; // 0x1C
	[SerializeField] // RVA: 0x15CB60 Offset: 0x15CC61 VA: 0x15CB60
	private float range; // 0x20
	[SerializeField] // RVA: 0x15CB70 Offset: 0x15CC71 VA: 0x15CB70
	public float inductive; // 0x24
	private Collider target; // 0x28
	private Character targetChara; // 0x30

	// Methods

	// RVA: 0x2068DB0 Offset: 0x2068EB1 VA: 0x2068DB0 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2068ED0 Offset: 0x2068FD1 VA: 0x2068ED0 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2069350 Offset: 0x2069451 VA: 0x2069350
	public void .ctor() { }
}

