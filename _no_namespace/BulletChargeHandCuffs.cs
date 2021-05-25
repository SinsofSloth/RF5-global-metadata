[Serializable]
public class BulletChargeHandCuffs : BulletHandCuffs // TypeDefIndex: 6461
{
	// Fields
	protected const float HandCuffsHitEffectScale = 2.5;
	private const EffectID SuccessEffectID = 404;
	private const SoundID SuccessSoundID = 1726;
	[SerializeField] // RVA: 0x15CAA0 Offset: 0x15CBA1 VA: 0x15CAA0
	public OnGroundItemPickupCollider pickupCollider; // 0x28

	// Methods

	// RVA: 0x2064860 Offset: 0x2064961 VA: 0x2064860 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2064900 Offset: 0x2064A01 VA: 0x2064900 Slot: 13
	protected override bool Judge(CharacterBase chara) { }

	// RVA: 0x2065370 Offset: 0x2065471 VA: 0x2065370 Slot: 14
	public override void OnSuccess(CharacterBase chara, Vector3 point, Vector3 normal) { }

	// RVA: 0x2065600 Offset: 0x2065701 VA: 0x2065600
	public void .ctor() { }
}

