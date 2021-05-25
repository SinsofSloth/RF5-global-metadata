public class BulletHandCuffs : BulletSubModule // TypeDefIndex: 6466
{
	// Fields
	private const EffectID HitEffectID = 405;
	private const SoundID HitSoundID = 214;
	protected Character m_Owner; // 0x20

	// Methods

	// RVA: 0x20677E0 Offset: 0x20678E1 VA: 0x20677E0 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2067840 Offset: 0x2067941 VA: 0x2067840
	public void OnHit(CharacterBase chara, Vector3 point, Vector3 normal) { }

	// RVA: 0x2067B20 Offset: 0x2067C21 VA: 0x2067B20 Slot: 13
	protected virtual bool Judge(CharacterBase chara) { }

	// RVA: 0x2067D90 Offset: 0x2067E91 VA: 0x2067D90 Slot: 14
	public virtual void OnSuccess(CharacterBase chara, Vector3 point, Vector3 normal) { }

	// RVA: 0x2067900 Offset: 0x2067A01 VA: 0x2067900
	public void OnMiss(CharacterBase chara, Vector3 point, Vector3 normal) { }

	// RVA: 0x2065610 Offset: 0x2065711 VA: 0x2065610
	public void .ctor() { }
}

