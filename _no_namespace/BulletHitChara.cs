[Serializable]
public class BulletHitChara : BulletHitModule<CharacterBase> // TypeDefIndex: 6454
{
	// Fields
	[SerializeField] // RVA: 0x15C9C0 Offset: 0x15CAC1 VA: 0x15C9C0
	public BulletHitAlliance hitAlliance; // 0x58
	[SerializeField] // RVA: 0x15C9D0 Offset: 0x15CAD1 VA: 0x15C9D0
	public BulletHitCharaEvent hitEventType; // 0x5C
	[SerializeField] // RVA: 0x15C9E0 Offset: 0x15CAE1 VA: 0x15C9E0
	public BulletHitChara.HitEvent onHitEvent; // 0x60

	// Methods

	// RVA: 0x2067F20 Offset: 0x2068021 VA: 0x2067F20 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2067FB0 Offset: 0x20680B1 VA: 0x2067FB0 Slot: 13
	public override bool OnHit(BulletBase bullet, CharacterBase chara, Vector3 point, Vector3 normal) { }

	// RVA: 0x20681F0 Offset: 0x20682F1 VA: 0x20681F0
	private bool CheckAlliance(CharacterBase owner, CharacterBase chara) { }

	// RVA: 0x20682D0 Offset: 0x20683D1 VA: 0x20682D0
	private void TakeDamage(BulletBase bullet, CharacterBase other, Vector3 point, Vector3 normal) { }

	// RVA: 0x2068940 Offset: 0x2068A41 VA: 0x2068940
	public void .ctor() { }
}

