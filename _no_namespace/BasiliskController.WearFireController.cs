public class BasiliskController.WearFireController // TypeDefIndex: 7815
{
	// Fields
	private BasiliskController.WearFireController.State CurrentState; // 0x10
	private ParticleSystem Effect; // 0x18
	private AttackCollider AttackCollider; // 0x20
	private Action[] UpdateStates; // 0x28
	private float Timer; // 0x30
	private float ToKeepOnTime; // 0x34
	private float ToOnTime; // 0x38
	private float ActiveColliderTimer; // 0x3C
	private bool IsColliderLock; // 0x40

	// Properties
	public bool IsOn { get; }
	public bool CanOff { get; }

	// Methods

	// RVA: 0x20D4880 Offset: 0x20D4981 VA: 0x20D4880
	public void .ctor(float toKeepOnTime, float toOnTime, ParticleSystem effect, AttackCollider attackCollider) { }

	// RVA: 0x20D4A80 Offset: 0x20D4B81 VA: 0x20D4A80
	public bool get_IsOn() { }

	// RVA: 0x20D4A90 Offset: 0x20D4B91 VA: 0x20D4A90
	public bool get_CanOff() { }

	// RVA: 0x20D4AA0 Offset: 0x20D4BA1 VA: 0x20D4AA0
	private void SetActiveEffect(bool isActive) { }

	// RVA: 0x20D4B30 Offset: 0x20D4C31 VA: 0x20D4B30
	private void SetEnable(bool isActive) { }

	// RVA: 0x20D4C00 Offset: 0x20D4D01 VA: 0x20D4C00
	public void SetAttackColliderEnable(bool isActive) { }

	// RVA: 0x20D4CC0 Offset: 0x20D4DC1 VA: 0x20D4CC0
	private void UpdateAttackCollider() { }

	// RVA: 0x20D4D90 Offset: 0x20D4E91 VA: 0x20D4D90
	public void Off(bool isForce = False) { }

	// RVA: 0x20D4DC0 Offset: 0x20D4EC1 VA: 0x20D4DC0
	public void On() { }

	// RVA: 0x20D4DE0 Offset: 0x20D4EE1 VA: 0x20D4DE0
	private void OffUpdate() { }

	// RVA: 0x20D4E50 Offset: 0x20D4F51 VA: 0x20D4E50
	private void KeepOnUpdate() { }

	// RVA: 0x20D4EB0 Offset: 0x20D4FB1 VA: 0x20D4EB0
	public void Update() { }
}

