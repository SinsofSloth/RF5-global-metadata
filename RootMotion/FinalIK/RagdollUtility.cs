[RequireComponent] // RVA: 0x148C70 Offset: 0x148D71 VA: 0x148C70
public class RagdollUtility : MonoBehaviour // TypeDefIndex: 9530
{
	// Fields
	[TooltipAttribute] // RVA: 0x17BEF0 Offset: 0x17BFF1 VA: 0x17BEF0
	public IK ik; // 0x18
	[TooltipAttribute] // RVA: 0x17BF30 Offset: 0x17C031 VA: 0x17BF30
	public float ragdollToAnimationTime; // 0x20
	[TooltipAttribute] // RVA: 0x17BF70 Offset: 0x17C071 VA: 0x17BF70
	public bool applyIkOnRagdoll; // 0x24
	[TooltipAttribute] // RVA: 0x17BFB0 Offset: 0x17C0B1 VA: 0x17BFB0
	public float applyVelocity; // 0x28
	[TooltipAttribute] // RVA: 0x17BFF0 Offset: 0x17C0F1 VA: 0x17BFF0
	public float applyAngularVelocity; // 0x2C
	private Animator animator; // 0x30
	private RagdollUtility.Rigidbone[] rigidbones; // 0x38
	private RagdollUtility.Child[] children; // 0x40
	private bool enableRagdollFlag; // 0x48
	private AnimatorUpdateMode animatorUpdateMode; // 0x4C
	private IK[] allIKComponents; // 0x50
	private bool[] fixTransforms; // 0x58
	private float ragdollWeight; // 0x60
	private float ragdollWeightV; // 0x64
	private bool fixedFrame; // 0x68
	private bool[] disabledIKComponents; // 0x70

	// Properties
	private bool isRagdoll { get; }
	private bool ikUsed { get; }

	// Methods

	// RVA: 0x291CD70 Offset: 0x291CE71 VA: 0x291CD70
	public void EnableRagdoll() { }

	// RVA: 0x291CE40 Offset: 0x291CF41 VA: 0x291CE40
	public void DisableRagdoll() { }

	// RVA: 0x291D020 Offset: 0x291D121 VA: 0x291D020
	public void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ABD10 Offset: 0x1ABE11 VA: 0x1ABD10
	// RVA: 0x291CFA0 Offset: 0x291D0A1 VA: 0x291CFA0
	private IEnumerator DisableRagdollSmooth() { }

	// RVA: 0x291D6B0 Offset: 0x291D7B1 VA: 0x291D6B0
	private void Update() { }

	// RVA: 0x291D900 Offset: 0x291DA01 VA: 0x291D900
	private void FixedUpdate() { }

	// RVA: 0x291DA20 Offset: 0x291DB21 VA: 0x291DA20
	private void LateUpdate() { }

	// RVA: 0x291DD50 Offset: 0x291DE51 VA: 0x291DD50
	private void AfterLastIK() { }

	// RVA: 0x291DAA0 Offset: 0x291DBA1 VA: 0x291DAA0
	private void AfterAnimation() { }

	// RVA: 0x291DCB0 Offset: 0x291DDB1 VA: 0x291DCB0
	private void OnFinalPose() { }

	// RVA: 0x291DE00 Offset: 0x291DF01 VA: 0x291DE00
	private void RagdollEnabler() { }

	// RVA: 0x291CDB0 Offset: 0x291CEB1 VA: 0x291CDB0
	private bool get_isRagdoll() { }

	// RVA: 0x291DD90 Offset: 0x291DE91 VA: 0x291DD90
	private void RecordVelocities() { }

	// RVA: 0x291DB50 Offset: 0x291DC51 VA: 0x291DB50
	private bool get_ikUsed() { }

	// RVA: 0x291CEF0 Offset: 0x291CFF1 VA: 0x291CEF0
	private void StoreLocalState() { }

	// RVA: 0x291D9A0 Offset: 0x291DAA1 VA: 0x291D9A0
	private void FixTransforms(float weight) { }

	// RVA: 0x291E5E0 Offset: 0x291E6E1 VA: 0x291E5E0
	private void OnDestroy() { }

	// RVA: 0x291E710 Offset: 0x291E811 VA: 0x291E710
	public void .ctor() { }
}

