public class StateMachineWorkerManager : SingletonMonoBehaviour<StateMachineWorkerManager> // TypeDefIndex: 6878
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15FEE0 Offset: 0x15FFE1 VA: 0x15FEE0
	private Action UpdateEvent; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15FEF0 Offset: 0x15FFF1 VA: 0x15FEF0
	private Action FixedUpdateEvent; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15FF00 Offset: 0x160001 VA: 0x15FF00
	private Action LateUpdateEvent; // 0x28

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DAD0 Offset: 0x19DBD1 VA: 0x19DAD0
	// RVA: 0x224B4A0 Offset: 0x224B5A1 VA: 0x224B4A0
	public void add_UpdateEvent(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DAE0 Offset: 0x19DBE1 VA: 0x19DAE0
	// RVA: 0x224AB60 Offset: 0x224AC61 VA: 0x224AB60
	public void remove_UpdateEvent(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DAF0 Offset: 0x19DBF1 VA: 0x19DAF0
	// RVA: 0x224B550 Offset: 0x224B651 VA: 0x224B550
	public void add_FixedUpdateEvent(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DB00 Offset: 0x19DC01 VA: 0x19DB00
	// RVA: 0x224AC10 Offset: 0x224AD11 VA: 0x224AC10
	public void remove_FixedUpdateEvent(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DB10 Offset: 0x19DC11 VA: 0x19DB10
	// RVA: 0x224B600 Offset: 0x224B701 VA: 0x224B600
	public void add_LateUpdateEvent(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DB20 Offset: 0x19DC21 VA: 0x19DB20
	// RVA: 0x224ACC0 Offset: 0x224ADC1 VA: 0x224ACC0
	public void remove_LateUpdateEvent(Action value) { }

	// RVA: 0x224B6B0 Offset: 0x224B7B1 VA: 0x224B6B0
	private void Update() { }

	// RVA: 0x224B6D0 Offset: 0x224B7D1 VA: 0x224B6D0
	private void FixedUpdate() { }

	// RVA: 0x224B6F0 Offset: 0x224B7F1 VA: 0x224B6F0
	private void LateUpdate() { }

	// RVA: 0x224B710 Offset: 0x224B811 VA: 0x224B710
	public void .ctor() { }
}

