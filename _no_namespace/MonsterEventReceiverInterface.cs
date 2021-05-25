public interface MonsterEventReceiverInterface // TypeDefIndex: 8093
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TameStart() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void TameEnd() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnRestraint() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnRelease() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnGrap() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnThrow() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnHearFootSteps() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnHitAttack() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void BeforeTakeDamage(ref DamageInfo damageInfo) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnChangeModel() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnFreeze() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void OnBlow() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnKnockBack() { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void OnDead() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnEndActionScript() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void OnEndAnimEventDamageState() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void OnEndAnimEventDeadState() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void OnEndAnimEventGetupState() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void OnEndAnimEventJumpStart() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void OnEndAnimEventJumpEnd() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnEndAnimEventMadnessState() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void OnEndAnimEventHappyState() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void OnEndAnimEventWait_2State() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void OnEndAnimEventSleepStart() { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void OnEndAnimEventSleepEnd() { }
}

