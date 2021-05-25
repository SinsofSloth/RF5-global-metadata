[RequiredByNativeCodeAttribute] // RVA: 0xE8890 Offset: 0xE8991 VA: 0xE8890
public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 3472
{
	// Methods

	// RVA: 0x1B00C10 Offset: 0x1B00D11 VA: 0x1B00C10 Slot: 4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1B00C20 Offset: 0x1B00D21 VA: 0x1B00C20 Slot: 5
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1B00C30 Offset: 0x1B00D31 VA: 0x1B00C30 Slot: 6
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1B00C40 Offset: 0x1B00D41 VA: 0x1B00C40 Slot: 7
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1B00C50 Offset: 0x1B00D51 VA: 0x1B00C50 Slot: 8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1B00C60 Offset: 0x1B00D61 VA: 0x1B00C60 Slot: 9
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x1B00C70 Offset: 0x1B00D71 VA: 0x1B00C70 Slot: 10
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x1B00C80 Offset: 0x1B00D81 VA: 0x1B00C80 Slot: 11
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1B00C90 Offset: 0x1B00D91 VA: 0x1B00C90 Slot: 12
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1B00CA0 Offset: 0x1B00DA1 VA: 0x1B00CA0 Slot: 13
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1B00CB0 Offset: 0x1B00DB1 VA: 0x1B00CB0 Slot: 14
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1B00CC0 Offset: 0x1B00DC1 VA: 0x1B00CC0 Slot: 15
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1B00CD0 Offset: 0x1B00DD1 VA: 0x1B00CD0 Slot: 16
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x1B00CE0 Offset: 0x1B00DE1 VA: 0x1B00CE0 Slot: 17
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x1B00CF0 Offset: 0x1B00DF1 VA: 0x1B00CF0
	protected void .ctor() { }
}

