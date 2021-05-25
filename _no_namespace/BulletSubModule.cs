[Serializable]
public abstract class BulletSubModule : MonoBehaviour, IBulletModule // TypeDefIndex: 6477
{
	// Fields
	[SerializeField] // RVA: 0x15CD00 Offset: 0x15CE01 VA: 0x15CD00
	public bool enabled; // 0x18

	// Methods

	// RVA: 0x206D160 Offset: 0x206D261 VA: 0x206D160 Slot: 7
	public virtual void OnSetup(BulletBase bullet) { }

	// RVA: 0x206D170 Offset: 0x206D271 VA: 0x206D170 Slot: 8
	public virtual void OnUpdate(BulletBase bullet) { }

	// RVA: 0x206D180 Offset: 0x206D281 VA: 0x206D180 Slot: 9
	public virtual void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x206D190 Offset: 0x206D291 VA: 0x206D190 Slot: 10
	public virtual void OnHit(BulletBase bullet) { }

	// RVA: 0x206D1A0 Offset: 0x206D2A1 VA: 0x206D1A0 Slot: 11
	public virtual void OnDead(BulletBase bullet) { }

	// RVA: 0x206D1B0 Offset: 0x206D2B1 VA: 0x206D1B0 Slot: 12
	public virtual void DoExtension(BulletBase bullet) { }

	// RVA: 0x2060EB0 Offset: 0x2060FB1 VA: 0x2060EB0
	protected void .ctor() { }
}

