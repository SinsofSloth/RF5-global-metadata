[Serializable]
public class BulletGroundEffect : BulletSubModule // TypeDefIndex: 6465
{
	// Fields
	[SerializeField] // RVA: 0x15CB20 Offset: 0x15CC21 VA: 0x15CB20
	private float height; // 0x1C
	[SerializeField] // RVA: 0x15CB30 Offset: 0x15CC31 VA: 0x15CB30
	private EffectID effectID; // 0x20
	[SerializeField] // RVA: 0x15CB40 Offset: 0x15CC41 VA: 0x15CB40
	private float interval; // 0x24
	private float m_currentElapsed; // 0x28

	// Methods

	// RVA: 0x20674B0 Offset: 0x20675B1 VA: 0x20674B0 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2067530 Offset: 0x2067631 VA: 0x2067530 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x20677C0 Offset: 0x20678C1 VA: 0x20677C0
	public void .ctor() { }
}

