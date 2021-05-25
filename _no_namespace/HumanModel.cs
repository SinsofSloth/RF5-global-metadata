public class HumanModel : CharacterModel // TypeDefIndex: 6660
{
	// Fields
	[SerializeField] // RVA: 0x15E8D0 Offset: 0x15E9D1 VA: 0x15E8D0
	private string AssetName; // 0x68
	[SerializeField] // RVA: 0x15E8E0 Offset: 0x15E9E1 VA: 0x15E8E0
	protected BipedIK bipedIk; // 0x70
	[SerializeField] // RVA: 0x15E8F0 Offset: 0x15E9F1 VA: 0x15E8F0
	protected GrounderBipedIK grounderBipedIk; // 0x78
	[SerializeField] // RVA: 0x15E900 Offset: 0x15EA01 VA: 0x15E900
	protected HumanModel.HumanArm leftArm; // 0x80
	[SerializeField] // RVA: 0x15E910 Offset: 0x15EA11 VA: 0x15E910
	protected SpringManager springManager; // 0x88
	[SerializeField] // RVA: 0x15E920 Offset: 0x15EA21 VA: 0x15E920
	private HumanJoint[] humanJoints; // 0x90
	[SerializeField] // RVA: 0x15E930 Offset: 0x15EA31 VA: 0x15E930
	protected HumanModelSocket[] HumanSockets; // 0x98
	[SerializeField] // RVA: 0x15E940 Offset: 0x15EA41 VA: 0x15E940
	protected ConstraintWeightPreset constraintWeightPreset; // 0xA0
	private Vector3 PastPosition; // 0xA8
	[SerializeField] // RVA: 0x15E950 Offset: 0x15EA51 VA: 0x15E950
	private bool m_IsPauseSpringBone; // 0xB4
	private const float SPRINTBONE_RESET_DISTANCE = 1;
	[CompilerGeneratedAttribute] // RVA: 0x15E960 Offset: 0x15EA61 VA: 0x15E960
	private bool <IsGrounderEnable>k__BackingField; // 0xB5
	[CompilerGeneratedAttribute] // RVA: 0x15E970 Offset: 0x15EA71 VA: 0x15E970
	private float <GrounderWeight>k__BackingField; // 0xB8

	// Properties
	public override Transform LookPoint { get; }
	public bool IsPauseSpringBone { get; set; }
	public SpringManager SpringManager { get; }
	public BipedIKSolvers IKSolver { get; }
	public IKSolverLookAt IKSolverLookAt { get; }
	public bool IsGrounderEnable { get; set; }
	public float GrounderWeight { get; set; }
	public HumanModel.HumanArm LeftArmIK { get; }

	// Methods

	// RVA: 0x20BD7C0 Offset: 0x20BD8C1 VA: 0x20BD7C0 Slot: 4
	public override Transform get_LookPoint() { }

	// RVA: 0x20BD800 Offset: 0x20BD901 VA: 0x20BD800 Slot: 5
	protected override void Awake() { }

	// RVA: 0x20BDBA0 Offset: 0x20BDCA1 VA: 0x20BDBA0 Slot: 6
	protected override void Start() { }

	// RVA: 0x20BDBD0 Offset: 0x20BDCD1 VA: 0x20BDBD0
	private void OnEnable() { }

	// RVA: 0x20BDDA0 Offset: 0x20BDEA1 VA: 0x20BDDA0 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x20BDDB0 Offset: 0x20BDEB1 VA: 0x20BDDB0
	public void Update() { }

	// RVA: 0x20BE010 Offset: 0x20BE111 VA: 0x20BE010
	public void LateUpdate() { }

	// RVA: 0x20BE310 Offset: 0x20BE411 VA: 0x20BE310
	public bool get_IsPauseSpringBone() { }

	// RVA: 0x20BE320 Offset: 0x20BE421 VA: 0x20BE320
	public void set_IsPauseSpringBone(bool value) { }

	// RVA: 0x20BE330 Offset: 0x20BE431 VA: 0x20BE330
	public SpringManager get_SpringManager() { }

	// RVA: 0x20BDA60 Offset: 0x20BDB61 VA: 0x20BDA60
	private bool ResetSpringBone() { }

	// RVA: 0x20BE340 Offset: 0x20BE441 VA: 0x20BE340
	public void InitSpringBone() { }

	// RVA: 0x20BE0C0 Offset: 0x20BE1C1 VA: 0x20BE0C0
	private void UpdateSpringBone() { }

	// RVA: 0x20BD830 Offset: 0x20BD931 VA: 0x20BD830
	public void GetComponentIK() { }

	// RVA: 0x20BE430 Offset: 0x20BE531 VA: 0x20BE430
	public void InitComponentIK() { }

	// RVA: 0x20BF150 Offset: 0x20BF251 VA: 0x20BF150
	public BipedIKSolvers get_IKSolver() { }

	// RVA: 0x20BC420 Offset: 0x20BC521 VA: 0x20BC420
	public IKSolverLookAt get_IKSolverLookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C620 Offset: 0x19C721 VA: 0x19C620
	// RVA: 0x20BF170 Offset: 0x20BF271 VA: 0x20BF170
	public bool get_IsGrounderEnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C630 Offset: 0x19C731 VA: 0x19C630
	// RVA: 0x20BF180 Offset: 0x20BF281 VA: 0x20BF180
	protected void set_IsGrounderEnable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C640 Offset: 0x19C741 VA: 0x19C640
	// RVA: 0x20BF190 Offset: 0x20BF291 VA: 0x20BF190
	public float get_GrounderWeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C650 Offset: 0x19C751 VA: 0x19C650
	// RVA: 0x20BF1A0 Offset: 0x20BF2A1 VA: 0x20BF1A0
	protected void set_GrounderWeight(float value) { }

	// RVA: 0x20BF1B0 Offset: 0x20BF2B1 VA: 0x20BF1B0
	public void SetGrounderBaseEnable(bool enable) { }

	// RVA: 0x20BF270 Offset: 0x20BF371 VA: 0x20BF270
	public void SetGrounderEnable(bool enable) { }

	// RVA: 0x20BF350 Offset: 0x20BF451 VA: 0x20BF350
	public void SetGrounderWeight(float weight) { }

	// RVA: 0x20BDCF0 Offset: 0x20BDDF1 VA: 0x20BDCF0
	public void ResetGrounderPosition() { }

	// RVA: 0x20BC3F0 Offset: 0x20BC4F1 VA: 0x20BC3F0
	public void SetLookAtWegith(float weight) { }

	// RVA: 0x20BF430 Offset: 0x20BF531 VA: 0x20BF430
	public void SetLookAtTarget(Transform target, Vector3 offset) { }

	// RVA: 0x20BF530 Offset: 0x20BF631 VA: 0x20BF530
	public bool IsEnableIK() { }

	// RVA: 0x20BF550 Offset: 0x20BF651 VA: 0x20BF550
	public void EnableIK() { }

	// RVA: 0x20BF570 Offset: 0x20BF671 VA: 0x20BF570
	public void DisableIK() { }

	// RVA: 0x20BF590 Offset: 0x20BF691 VA: 0x20BF590
	public void SetConstraintWeight(ConstraintPresetID presetId) { }

	// RVA: 0x20BF5B0 Offset: 0x20BF6B1 VA: 0x20BF5B0
	public HumanModel.HumanArm get_LeftArmIK() { }

	// RVA: 0x20BE000 Offset: 0x20BE101 VA: 0x20BE000
	private void UpdateArmIK() { }

	// RVA: 0x20BC3A0 Offset: 0x20BC4A1 VA: 0x20BC3A0
	public Transform GetJoint(HumanJointIDEnum jointId) { }

	// RVA: 0x20BF7D0 Offset: 0x20BF8D1 VA: 0x20BF7D0
	public void JointVisible(HumanJointIDEnum jointId, bool visible) { }

	// RVA: 0x20BF8D0 Offset: 0x20BF9D1 VA: 0x20BF8D0
	public bool IsJointVisible(HumanJointIDEnum jointId) { }

	// RVA: 0x20BDBB0 Offset: 0x20BDCB1 VA: 0x20BDBB0
	private void StartJoint() { }

	// RVA: 0x20BDDF0 Offset: 0x20BDEF1 VA: 0x20BDDF0
	private void UpdateJoint() { }

	// RVA: 0x20BDBC0 Offset: 0x20BDCC1 VA: 0x20BDBC0
	private void SocketStart() { }

	// RVA: 0x20BF9E0 Offset: 0x20BFAE1 VA: 0x20BF9E0
	public Transform GetSocket(HumanAttachIDEnum attachId) { }

	// RVA: 0x20BFA30 Offset: 0x20BFB31 VA: 0x20BFA30
	public Transform GetEquipItem(HumanAttachIDEnum attachId) { }

	// RVA: 0x20BFA80 Offset: 0x20BFB81 VA: 0x20BFA80
	public Transform EquipAttach(HumanAttachIDEnum attachId, Transform item, HumanAttachIDEnum left_attach = -1) { }

	// RVA: 0x20BFC60 Offset: 0x20BFD61 VA: 0x20BFC60
	public Transform EquipDetach(HumanAttachIDEnum attachId) { }

	// RVA: 0x20BFD80 Offset: 0x20BFE81 VA: 0x20BFD80
	public void SocketEraseOn(HumanAttachIDEnum attachId) { }

	// RVA: 0x20BFF70 Offset: 0x20C0071 VA: 0x20BFF70
	public void SocketEraseOff(HumanAttachIDEnum attachId) { }

	// RVA: 0x20C0160 Offset: 0x20C0261 VA: 0x20C0160
	public Transform[] EquipDetachAll() { }

	// RVA: 0x20C0310 Offset: 0x20C0411 VA: 0x20C0310
	public void .ctor() { }
}

