public interface PartnerNPCEventReceiverInterface // TypeDefIndex: 8168
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnChangeShortPlay(bool isEnable) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnFreeze() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnBlow() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnKnockBack() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnDead() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void EndDamageAction() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnBadStatus(BadStatus badStatus, bool isEnable) { }
}

