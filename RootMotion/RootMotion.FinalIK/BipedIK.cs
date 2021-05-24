[HelpURLAttribute] // RVA: 0x148390 Offset: 0x148491 VA: 0x148390
[AddComponentMenu] // RVA: 0x148390 Offset: 0x148491 VA: 0x148390
public class BipedIK : SolverManager // TypeDefIndex: 9412
{
	// Fields
	public BipedReferences references; // 0x38
	public BipedIKSolvers solvers; // 0x40

	// Methods

	[ContextMenu] // RVA: 0x1AA230 Offset: 0x1AA331 VA: 0x1AA230
	// RVA: 0x2734A40 Offset: 0x2734B41 VA: 0x2734A40
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AA270 Offset: 0x1AA371 VA: 0x1AA270
	// RVA: 0x2734A90 Offset: 0x2734B91 VA: 0x2734A90
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x1AA2B0 Offset: 0x1AA3B1 VA: 0x1AA2B0
	// RVA: 0x2734AE0 Offset: 0x2734BE1 VA: 0x2734AE0
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x1AA2F0 Offset: 0x1AA3F1 VA: 0x1AA2F0
	// RVA: 0x2734B30 Offset: 0x2734C31 VA: 0x2734B30
	private void ASThread() { }

	// RVA: 0x2734B80 Offset: 0x2734C81 VA: 0x2734B80
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x2734CB0 Offset: 0x2734DB1 VA: 0x2734CB0
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x2734D50 Offset: 0x2734E51 VA: 0x2734D50
	public void SetIKPositionWeight(AvatarIKGoal goal, float weight) { }

	// RVA: 0x2734DE0 Offset: 0x2734EE1 VA: 0x2734DE0
	public void SetIKRotationWeight(AvatarIKGoal goal, float weight) { }

	// RVA: 0x2734E70 Offset: 0x2734F71 VA: 0x2734E70
	public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition) { }

	// RVA: 0x2734F10 Offset: 0x2735011 VA: 0x2734F10
	public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation) { }

	// RVA: 0x2734FB0 Offset: 0x27350B1 VA: 0x2734FB0
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x2735040 Offset: 0x2735141 VA: 0x2735040
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x27350E0 Offset: 0x27351E1 VA: 0x27350E0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes) { }

	// RVA: 0x2735110 Offset: 0x2735211 VA: 0x2735110
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	// RVA: 0x2735140 Offset: 0x2735241 VA: 0x2735140
	public void SetSpinePosition(Vector3 spinePosition) { }

	// RVA: 0x2735170 Offset: 0x2735271 VA: 0x2735170
	public void SetSpineWeight(float weight) { }

	// RVA: 0x2734C20 Offset: 0x2734D21 VA: 0x2734C20
	public IKSolverLimb GetGoalIK(AvatarIKGoal goal) { }

	// RVA: 0x27351A0 Offset: 0x27352A1 VA: 0x27351A0
	public void InitiateBipedIK() { }

	// RVA: 0x27351B0 Offset: 0x27352B1 VA: 0x27351B0
	public void UpdateBipedIK() { }

	// RVA: 0x27351C0 Offset: 0x27352C1 VA: 0x27351C0
	public void SetToDefaults() { }

	// RVA: 0x2735510 Offset: 0x2735611 VA: 0x2735510 Slot: 6
	protected override void FixTransforms() { }

	// RVA: 0x27355C0 Offset: 0x27356C1 VA: 0x27355C0 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x2735960 Offset: 0x2735A61 VA: 0x2735960 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x2735EA0 Offset: 0x2735FA1 VA: 0x2735EA0
	public void LogWarning(string message) { }

	// RVA: 0x2735EE0 Offset: 0x2735FE1 VA: 0x2735EE0
	public void .ctor() { }
}

