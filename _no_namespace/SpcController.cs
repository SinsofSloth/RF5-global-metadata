public class SpcController : HumanController, InteractionInterface, FocusInterface // TypeDefIndex: 6787
{
	// Fields
	[SerializeField] // RVA: 0x15F860 Offset: 0x15F961 VA: 0x15F860
	public bool IsFirstRotate; // 0x238
	public Quaternion ShortPlayRotation; // 0x23C
	private bool IsGrounder; // 0x24C
	private LookAtState lookAtState; // 0x250
	public Transform ShortPlayLookAtTarget; // 0x258
	private GameObject lookAtGameObject; // 0x260
	public bool IsLookTarget; // 0x268
	[SerializeField] // RVA: 0x15F870 Offset: 0x15F971 VA: 0x15F870
	public int lookTargetNpcId; // 0x26C
	public float lookAtSpeed; // 0x270
	public bool IsWakeupAnim; // 0x274
	public bool IsSleepAnim; // 0x275
	private float headWeight; // 0x278
	private float clampWeightHead; // 0x27C
	private float orgClampWeightHead; // 0x280
	[SerializeField] // RVA: 0x15F880 Offset: 0x15F981 VA: 0x15F880
	public string focusName; // 0x288
	[SerializeField] // RVA: 0x15F890 Offset: 0x15F991 VA: 0x15F890
	public int NpcId; // 0x290
	[SerializeField] // RVA: 0x15F8A0 Offset: 0x15F9A1 VA: 0x15F8A0
	public bool IsReached; // 0x294
	[SerializeField] // RVA: 0x15F8B0 Offset: 0x15F9B1 VA: 0x15F8B0
	public Vector3 NavTargetPoint; // 0x298
	[SerializeField] // RVA: 0x15F8C0 Offset: 0x15F9C1 VA: 0x15F8C0
	public bool calcPath; // 0x2A4
	[SerializeField] // RVA: 0x15F8D0 Offset: 0x15F9D1 VA: 0x15F8D0
	public float calcTime; // 0x2A8
	[SerializeField] // RVA: 0x15F8E0 Offset: 0x15F9E1 VA: 0x15F8E0
	public int pointcount; // 0x2AC
	[SerializeField] // RVA: 0x15F8F0 Offset: 0x15F9F1 VA: 0x15F8F0
	public bool chkpointcount; // 0x2B0
	[SerializeField] // RVA: 0x15F900 Offset: 0x15FA01 VA: 0x15F900
	public int rndpointcount; // 0x2B4
	private Vector3 PrevPosition; // 0x2B8
	public Vector3 lookatRotate; // 0x2C4
	public NpcAnimState SpcAnimState; // 0x2D0
	[SerializeField] // RVA: 0x15F910 Offset: 0x15FA11 VA: 0x15F910
	public bool IsSlowdown; // 0x2D4
	[SerializeField] // RVA: 0x15F920 Offset: 0x15FA21 VA: 0x15F920
	public bool IsStop; // 0x2D5
	[SerializeField] // RVA: 0x15F930 Offset: 0x15FA31 VA: 0x15F930
	public bool IsHurry; // 0x2D6
	[SerializeField] // RVA: 0x15F940 Offset: 0x15FA41 VA: 0x15F940
	public float ShortPlayMoveSpeed; // 0x2D8
	[SerializeField] // RVA: 0x15F950 Offset: 0x15FA51 VA: 0x15F950
	public float ShortPlayLocomotion; // 0x2DC
	[SerializeField] // RVA: 0x15F960 Offset: 0x15FA61 VA: 0x15F960
	public float ShortPlayTargetMoveSpeed; // 0x2E0
	[SerializeField] // RVA: 0x15F970 Offset: 0x15FA71 VA: 0x15F970
	public float ShortPlayTargetLocomotion; // 0x2E4
	private float CurrentFadeAlpha; // 0x2E8
	private bool IsFadeOut; // 0x2EC
	public float CharFadeTime; // 0x2F0
	private bool forceDisable; // 0x2F4
	private Transform itemPoint_Right; // 0x2F8
	private Transform itemPoint_Left; // 0x300
	private Transform itemPoint_Floor; // 0x308
	public Vector3 ItemPoint_Floor_Position; // 0x310
	private LookAtIK lookAtIK; // 0x320
	public bool focusable; // 0x328

	// Properties
	private Vector3 lookat { get; }
	public bool ForceDisable { get; set; }
	public Transform ItemPoint_Right { get; }
	public Transform ItemPoint_Left { get; }
	public Transform ItemPoint_Floor { get; }
	public LookAtIK LookAtIK { get; }
	public override float LookIKWeight { set; }
	protected override bool KeepAnimatorControllerStateOnDisable { get; }
	public bool Focusable { get; set; }
	public string ItemInteractionButtonHint { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x2118440 Offset: 0x2118541 VA: 0x2118440
	private Vector3 get_lookat() { }

	// RVA: 0x2118460 Offset: 0x2118561 VA: 0x2118460
	public bool get_ForceDisable() { }

	// RVA: 0x2118470 Offset: 0x2118571 VA: 0x2118470
	public void set_ForceDisable(bool value) { }

	// RVA: 0x21184E0 Offset: 0x21185E1 VA: 0x21184E0
	public Transform get_ItemPoint_Right() { }

	// RVA: 0x21185B0 Offset: 0x21186B1 VA: 0x21185B0
	public Transform get_ItemPoint_Left() { }

	// RVA: 0x2118680 Offset: 0x2118781 VA: 0x2118680
	public Transform get_ItemPoint_Floor() { }

	// RVA: 0x21187A0 Offset: 0x21188A1 VA: 0x21187A0
	public LookAtIK get_LookAtIK() { }

	// RVA: 0x21187C0 Offset: 0x21188C1 VA: 0x21187C0 Slot: 38
	public override void set_LookIKWeight(float value) { }

	// RVA: 0x21187D0 Offset: 0x21188D1 VA: 0x21187D0 Slot: 37
	protected override bool get_KeepAnimatorControllerStateOnDisable() { }

	// RVA: 0x21187E0 Offset: 0x21188E1 VA: 0x21187E0 Slot: 11
	protected override void Awake() { }

	// RVA: 0x21187B0 Offset: 0x21188B1 VA: 0x21187B0
	public void SetupLookAtIK() { }

	// RVA: 0x2118D30 Offset: 0x2118E31 VA: 0x2118D30 Slot: 40
	protected override void Update() { }

	// RVA: 0x2119910 Offset: 0x2119A11 VA: 0x2119910
	public void SetShortPlayMovePosition(Vector3 _targetPosition, float _moveSpeed, float _locomotion) { }

	// RVA: 0x2119D70 Offset: 0x2119E71 VA: 0x2119D70
	public void ShortPlay() { }

	// RVA: 0x2118C90 Offset: 0x2118D91 VA: 0x2118C90
	public void FadeNpc() { }

	// RVA: 0x211A0F0 Offset: 0x211A1F1 VA: 0x211A0F0
	public void FadeInStandby() { }

	// RVA: 0x211A190 Offset: 0x211A291 VA: 0x211A190
	public void FadeInEnd() { }

	[IteratorStateMachineAttribute] // RVA: 0x19CF80 Offset: 0x19D081 VA: 0x19CF80
	// RVA: 0x211A240 Offset: 0x211A341 VA: 0x211A240
	public IEnumerator FadeInNpc(UnityAction _fadeEndAction) { }

	[IteratorStateMachineAttribute] // RVA: 0x19CFF0 Offset: 0x19D0F1 VA: 0x19CFF0
	// RVA: 0x211A310 Offset: 0x211A411 VA: 0x211A310
	public IEnumerator FadeOutNpc(UnityAction _fadeEndAction) { }

	// RVA: 0x211A3E0 Offset: 0x211A4E1 VA: 0x211A3E0
	private bool CheckGrounderCanEnable() { }

	// RVA: 0x211A4B0 Offset: 0x211A5B1 VA: 0x211A4B0 Slot: 62
	public override void SetGrounderIKWeight(float weight) { }

	// RVA: 0x2119BE0 Offset: 0x2119CE1 VA: 0x2119BE0
	public void SetGrounderEnabled(bool enable) { }

	// RVA: 0x2119CB0 Offset: 0x2119DB1 VA: 0x2119CB0
	public void ResetGrounderPosition() { }

	// RVA: 0x211A4C0 Offset: 0x211A5C1 VA: 0x211A4C0 Slot: 73
	public override void OnFalling() { }

	// RVA: 0x211A4D0 Offset: 0x211A5D1 VA: 0x211A4D0 Slot: 18
	public override void OnSwitchActorBase(bool on) { }

	// RVA: 0x211A6D0 Offset: 0x211A7D1 VA: 0x211A6D0
	public void SetShortPlayAnim(bool shortplay) { }

	// RVA: 0x211A760 Offset: 0x211A861 VA: 0x211A760
	public void ShortPlayExit(bool switchNpc = True) { }

	// RVA: 0x21193D0 Offset: 0x21194D1 VA: 0x21193D0
	public void UpdateMovePosition() { }

	// RVA: 0x211AAF0 Offset: 0x211ABF1 VA: 0x211AAF0
	protected void SetAnimationState(int animIdx) { }

	// RVA: 0x211AB30 Offset: 0x211AC31 VA: 0x211AB30
	public void SettingGrounderIK() { }

	// RVA: 0x211AB40 Offset: 0x211AC41 VA: 0x211AB40
	private bool CheckUseGroundIK() { }

	// RVA: 0x2118D70 Offset: 0x2118E71 VA: 0x2118D70
	public void UpdateOnGround() { }

	// RVA: 0x2119030 Offset: 0x2119131 VA: 0x2119030
	private void UpdateLookAtRotation() { }

	// RVA: 0x211AC70 Offset: 0x211AD71 VA: 0x211AC70
	public void LookAtTargetShortPlay(Quaternion q) { }

	[IteratorStateMachineAttribute] // RVA: 0x19D060 Offset: 0x19D161 VA: 0x19D060
	// RVA: 0x211AEB0 Offset: 0x211AFB1 VA: 0x211AEB0
	public IEnumerator LookAtTargetShortPlayEnd() { }

	// RVA: 0x211AF60 Offset: 0x211B061 VA: 0x211AF60
	private void ResetGroundIK() { }

	// RVA: 0x2119AB0 Offset: 0x2119BB1 VA: 0x2119AB0
	public void AnimationStart(NpcAnimState animState, bool IsShortPlayCalled) { }

	// RVA: 0x211B010 Offset: 0x211B111 VA: 0x211B010
	private void StartAnimationState(NpcAnimState state) { }

	// RVA: 0x211B140 Offset: 0x211B241 VA: 0x211B140
	public void PlaySE(Object obj) { }

	// RVA: 0x211B260 Offset: 0x211B361 VA: 0x211B260
	private bool CheckLookAtRotation() { }

	// RVA: 0x2119310 Offset: 0x2119411 VA: 0x2119310
	private void UpdateLookAtIK() { }

	// RVA: 0x211B350 Offset: 0x211B451 VA: 0x211B350 Slot: 79
	protected override void UpdateLookIK() { }

	// RVA: 0x211A0A0 Offset: 0x211A1A1 VA: 0x211A0A0
	public void LookAtIKWeightReset() { }

	// RVA: 0x211B450 Offset: 0x211B551 VA: 0x211B450
	public void SetShortPlayLookAtTarget(Transform tr, float speed = 1) { }

	// RVA: 0x211B4D0 Offset: 0x211B5D1 VA: 0x211B4D0
	public void SetShortPlayLookAtTargetVector(Vector3 target, float speed = 1) { }

	// RVA: 0x211B4B0 Offset: 0x211B5B1 VA: 0x211B4B0
	private float GetSpeed(float speed) { }

	// RVA: 0x211B680 Offset: 0x211B781 VA: 0x211B680 Slot: 103
	public bool get_Focusable() { }

	// RVA: 0x211B740 Offset: 0x211B841 VA: 0x211B740
	private void set_Focusable(bool value) { }

	// RVA: 0x211B750 Offset: 0x211B851 VA: 0x211B750 Slot: 50
	protected override void ResetMovement() { }

	// RVA: 0x211B7F0 Offset: 0x211B8F1 VA: 0x211B7F0 Slot: 109
	public ushort GetInteractionType() { }

	// RVA: 0x211B800 Offset: 0x211B901 VA: 0x211B800 Slot: 102
	public string GetFocusName() { }

	// RVA: 0x211B810 Offset: 0x211B911 VA: 0x211B810
	public string get_ItemInteractionButtonHint() { }

	// RVA: 0x211B860 Offset: 0x211B961 VA: 0x211B860 Slot: 106
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x211B870 Offset: 0x211B971 VA: 0x211B870 Slot: 107
	public int get_FocusPriority() { }

	// RVA: 0x211B880 Offset: 0x211B981 VA: 0x211B880 Slot: 108
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x211B890 Offset: 0x211B991 VA: 0x211B890 Slot: 101
	public string GetInteractionButtonHint() { }

	// RVA: 0x211B8E0 Offset: 0x211B9E1 VA: 0x211B8E0 Slot: 104
	public void OnFocus() { }

	// RVA: 0x211B8F0 Offset: 0x211B9F1 VA: 0x211B8F0 Slot: 105
	public void OffFocus() { }

	// RVA: 0x211B900 Offset: 0x211BA01 VA: 0x211B900 Slot: 98
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x211B910 Offset: 0x211BA11 VA: 0x211B910 Slot: 97
	public void DoInteraction(HumanController character) { }

	// RVA: 0x211B920 Offset: 0x211BA21 VA: 0x211B920
	public Vector3 GetTargetPosition(GameObject childPoint) { }

	// RVA: 0x211BB10 Offset: 0x211BC11 VA: 0x211BB10
	public void PlayEmotionEffect(EmotionType emotionType, float dispTime) { }

	// RVA: 0x211BD10 Offset: 0x211BE11 VA: 0x211BD10
	public void SetAnimIdx(int idx) { }

	// RVA: 0x211BD80 Offset: 0x211BE81 VA: 0x211BD80
	public void ChangeModel(VariationNo modelType, HairType hairType) { }

	// RVA: 0x211BE20 Offset: 0x211BF21 VA: 0x211BE20 Slot: 99
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x211BE30 Offset: 0x211BF31 VA: 0x211BE30 Slot: 100
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x211BE40 Offset: 0x211BF41 VA: 0x211BE40
	public void .ctor() { }

	// RVA: 0x211BF50 Offset: 0x211C051 VA: 0x211BF50 Slot: 110
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x211BF60 Offset: 0x211C061 VA: 0x211BF60 Slot: 111
	private Transform FocusInterface.get_transform() { }
}

