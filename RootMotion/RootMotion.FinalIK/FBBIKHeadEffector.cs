public class FBBIKHeadEffector : MonoBehaviour // TypeDefIndex: 9458
{
	// Fields
	[TooltipAttribute] // RVA: 0x17A750 Offset: 0x17A851 VA: 0x17A750
	public FullBodyBipedIK ik; // 0x18
	[LargeHeader] // RVA: 0x17A790 Offset: 0x17A891 VA: 0x17A790
	[TooltipAttribute] // RVA: 0x17A790 Offset: 0x17A891 VA: 0x17A790
	[RangeAttribute] // RVA: 0x17A790 Offset: 0x17A891 VA: 0x17A790
	public float positionWeight; // 0x20
	[TooltipAttribute] // RVA: 0x17A810 Offset: 0x17A911 VA: 0x17A810
	[RangeAttribute] // RVA: 0x17A810 Offset: 0x17A911 VA: 0x17A810
	public float bodyWeight; // 0x24
	[TooltipAttribute] // RVA: 0x17A870 Offset: 0x17A971 VA: 0x17A870
	[RangeAttribute] // RVA: 0x17A870 Offset: 0x17A971 VA: 0x17A870
	public float thighWeight; // 0x28
	[TooltipAttribute] // RVA: 0x17A8D0 Offset: 0x17A9D1 VA: 0x17A8D0
	public bool handsPullBody; // 0x2C
	[LargeHeader] // RVA: 0x17A910 Offset: 0x17AA11 VA: 0x17A910
	[TooltipAttribute] // RVA: 0x17A910 Offset: 0x17AA11 VA: 0x17A910
	[RangeAttribute] // RVA: 0x17A910 Offset: 0x17AA11 VA: 0x17A910
	public float rotationWeight; // 0x30
	[TooltipAttribute] // RVA: 0x17A990 Offset: 0x17AA91 VA: 0x17A990
	[RangeAttribute] // RVA: 0x17A990 Offset: 0x17AA91 VA: 0x17A990
	public float bodyClampWeight; // 0x34
	[TooltipAttribute] // RVA: 0x17A9F0 Offset: 0x17AAF1 VA: 0x17A9F0
	[RangeAttribute] // RVA: 0x17A9F0 Offset: 0x17AAF1 VA: 0x17A9F0
	public float headClampWeight; // 0x38
	[TooltipAttribute] // RVA: 0x17AA50 Offset: 0x17AB51 VA: 0x17AA50
	[RangeAttribute] // RVA: 0x17AA50 Offset: 0x17AB51 VA: 0x17AA50
	public float bendWeight; // 0x3C
	[TooltipAttribute] // RVA: 0x17AAB0 Offset: 0x17ABB1 VA: 0x17AAB0
	public FBBIKHeadEffector.BendBone[] bendBones; // 0x40
	[LargeHeader] // RVA: 0x17AAF0 Offset: 0x17ABF1 VA: 0x17AAF0
	[TooltipAttribute] // RVA: 0x17AAF0 Offset: 0x17ABF1 VA: 0x17AAF0
	[RangeAttribute] // RVA: 0x17AAF0 Offset: 0x17ABF1 VA: 0x17AAF0
	public float CCDWeight; // 0x48
	[TooltipAttribute] // RVA: 0x17AB70 Offset: 0x17AC71 VA: 0x17AB70
	[RangeAttribute] // RVA: 0x17AB70 Offset: 0x17AC71 VA: 0x17AB70
	public float roll; // 0x4C
	[TooltipAttribute] // RVA: 0x17ABD0 Offset: 0x17ACD1 VA: 0x17ABD0
	[RangeAttribute] // RVA: 0x17ABD0 Offset: 0x17ACD1 VA: 0x17ABD0
	public float damper; // 0x50
	[TooltipAttribute] // RVA: 0x17AC30 Offset: 0x17AD31 VA: 0x17AC30
	public Transform[] CCDBones; // 0x58
	[LargeHeader] // RVA: 0x17AC70 Offset: 0x17AD71 VA: 0x17AC70
	[TooltipAttribute] // RVA: 0x17AC70 Offset: 0x17AD71 VA: 0x17AC70
	[RangeAttribute] // RVA: 0x17AC70 Offset: 0x17AD71 VA: 0x17AC70
	public float postStretchWeight; // 0x60
	[TooltipAttribute] // RVA: 0x17ACF0 Offset: 0x17ADF1 VA: 0x17ACF0
	public float maxStretch; // 0x64
	[TooltipAttribute] // RVA: 0x17AD30 Offset: 0x17AE31 VA: 0x17AD30
	public float stretchDamper; // 0x68
	[TooltipAttribute] // RVA: 0x17AD70 Offset: 0x17AE71 VA: 0x17AD70
	public bool fixHead; // 0x6C
	[TooltipAttribute] // RVA: 0x17ADB0 Offset: 0x17AEB1 VA: 0x17ADB0
	public Transform[] stretchBones; // 0x70
	[LargeHeader] // RVA: 0x17ADF0 Offset: 0x17AEF1 VA: 0x17ADF0
	public Vector3 chestDirection; // 0x78
	[RangeAttribute] // RVA: 0x17AE30 Offset: 0x17AF31 VA: 0x17AE30
	public float chestDirectionWeight; // 0x84
	public Transform[] chestBones; // 0x88
	public IKSolver.UpdateDelegate OnPostHeadEffectorFK; // 0x90
	private Vector3 offset; // 0x98
	private Vector3 headToBody; // 0xA4
	private Vector3 shoulderCenterToHead; // 0xB0
	private Vector3 headToLeftThigh; // 0xBC
	private Vector3 headToRightThigh; // 0xC8
	private Vector3 leftShoulderPos; // 0xD4
	private Vector3 rightShoulderPos; // 0xE0
	private float shoulderDist; // 0xEC
	private float leftShoulderDist; // 0xF0
	private float rightShoulderDist; // 0xF4
	private Quaternion chestRotation; // 0xF8
	private Quaternion headRotationRelativeToRoot; // 0x108
	private Quaternion[] ccdDefaultLocalRotations; // 0x118
	private Vector3 headLocalPosition; // 0x120
	private Quaternion headLocalRotation; // 0x12C
	private Vector3[] stretchLocalPositions; // 0x140
	private Quaternion[] stretchLocalRotations; // 0x148
	private Vector3[] chestLocalPositions; // 0x150
	private Quaternion[] chestLocalRotations; // 0x158
	private int bendBonesCount; // 0x160
	private int ccdBonesCount; // 0x164
	private int stretchBonesCount; // 0x168
	private int chestBonesCount; // 0x16C

	// Methods

	// RVA: 0x273B670 Offset: 0x273B771 VA: 0x273B670
	private void Start() { }

	// RVA: 0x273BA00 Offset: 0x273BB01 VA: 0x273BA00
	private void OnStoreDefaultLocalState() { }

	// RVA: 0x273BED0 Offset: 0x273BFD1 VA: 0x273BED0
	private void OnFixTransforms() { }

	// RVA: 0x273C2A0 Offset: 0x273C3A1 VA: 0x273C2A0
	private void OnPreRead() { }

	// RVA: 0x273CC20 Offset: 0x273CD21 VA: 0x273CC20
	private void SpineBend() { }

	// RVA: 0x273CF70 Offset: 0x273D071 VA: 0x273CF70
	private void CCDPass() { }

	// RVA: 0x273D310 Offset: 0x273D411 VA: 0x273D310
	private void Iterate(int iteration) { }

	// RVA: 0x273DD70 Offset: 0x273DE71 VA: 0x273DD70
	private void OnPostUpdate() { }

	// RVA: 0x273C940 Offset: 0x273CA41 VA: 0x273C940
	private void ChestDirection() { }

	// RVA: 0x273DF80 Offset: 0x273E081 VA: 0x273DF80
	private void PostStretching() { }

	// RVA: 0x273DC30 Offset: 0x273DD31 VA: 0x273DC30
	private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset) { }

	// RVA: 0x273DA90 Offset: 0x273DB91 VA: 0x273DA90
	private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance) { }

	// RVA: 0x273E2F0 Offset: 0x273E3F1 VA: 0x273E2F0
	private void OnDestroy() { }

	// RVA: 0x273E5E0 Offset: 0x273E6E1 VA: 0x273E5E0
	public void .ctor() { }
}

