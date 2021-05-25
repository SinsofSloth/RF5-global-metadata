[Serializable]
public class InteractionEffector // TypeDefIndex: 9507
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17B750 Offset: 0x17B851 VA: 0x17B750
	private FullBodyBipedEffector <effectorType>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17B760 Offset: 0x17B861 VA: 0x17B760
	private bool <isPaused>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x17B770 Offset: 0x17B871 VA: 0x17B770
	private InteractionObject <interactionObject>k__BackingField; // 0x18
	private Poser poser; // 0x20
	private IKEffector effector; // 0x28
	private float timer; // 0x30
	private float length; // 0x34
	private float weight; // 0x38
	private float fadeInSpeed; // 0x3C
	private float defaultPositionWeight; // 0x40
	private float defaultRotationWeight; // 0x44
	private float defaultPull; // 0x48
	private float defaultReach; // 0x4C
	private float defaultPush; // 0x50
	private float defaultPushParent; // 0x54
	private float defaultBendGoalWeight; // 0x58
	private float resetTimer; // 0x5C
	private bool positionWeightUsed; // 0x60
	private bool rotationWeightUsed; // 0x61
	private bool pullUsed; // 0x62
	private bool reachUsed; // 0x63
	private bool pushUsed; // 0x64
	private bool pushParentUsed; // 0x65
	private bool bendGoalWeightUsed; // 0x66
	private bool pickedUp; // 0x67
	private bool defaults; // 0x68
	private bool pickUpOnPostFBBIK; // 0x69
	private Vector3 pickUpPosition; // 0x6C
	private Vector3 pausePositionRelative; // 0x78
	private Quaternion pickUpRotation; // 0x84
	private Quaternion pauseRotationRelative; // 0x94
	private InteractionTarget interactionTarget; // 0xA8
	private Transform target; // 0xB0
	private List<bool> triggered; // 0xB8
	private InteractionSystem interactionSystem; // 0xC0
	private bool started; // 0xC8

	// Properties
	public FullBodyBipedEffector effectorType { get; set; }
	public bool isPaused { get; set; }
	public InteractionObject interactionObject { get; set; }
	public bool inInteraction { get; }
	public float progress { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AB4D0 Offset: 0x1AB5D1 VA: 0x1AB4D0
	// RVA: 0x2BEC8C0 Offset: 0x2BEC9C1 VA: 0x2BEC8C0
	public FullBodyBipedEffector get_effectorType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB4E0 Offset: 0x1AB5E1 VA: 0x1AB4E0
	// RVA: 0x2BEC8D0 Offset: 0x2BEC9D1 VA: 0x2BEC8D0
	private void set_effectorType(FullBodyBipedEffector value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB4F0 Offset: 0x1AB5F1 VA: 0x1AB4F0
	// RVA: 0x2BEC8E0 Offset: 0x2BEC9E1 VA: 0x2BEC8E0
	public bool get_isPaused() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB500 Offset: 0x1AB601 VA: 0x1AB500
	// RVA: 0x2BEC8F0 Offset: 0x2BEC9F1 VA: 0x2BEC8F0
	private void set_isPaused(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB510 Offset: 0x1AB611 VA: 0x1AB510
	// RVA: 0x2BEC900 Offset: 0x2BECA01 VA: 0x2BEC900
	public InteractionObject get_interactionObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB520 Offset: 0x1AB621 VA: 0x1AB520
	// RVA: 0x2BEC910 Offset: 0x2BECA11 VA: 0x2BEC910
	private void set_interactionObject(InteractionObject value) { }

	// RVA: 0x2BEC920 Offset: 0x2BECA21 VA: 0x2BEC920
	public bool get_inInteraction() { }

	// RVA: 0x2BEC990 Offset: 0x2BECA91 VA: 0x2BEC990
	public void .ctor(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2BECA20 Offset: 0x2BECB21 VA: 0x2BECA20
	public void Initiate(InteractionSystem interactionSystem) { }

	// RVA: 0x2BECAF0 Offset: 0x2BECBF1 VA: 0x2BECAF0
	private void StoreDefaults() { }

	// RVA: 0x2BECC70 Offset: 0x2BECD71 VA: 0x2BECC70
	public bool ResetToDefaults(float speed) { }

	// RVA: 0x2BED160 Offset: 0x2BED261 VA: 0x2BED160
	public bool Pause() { }

	// RVA: 0x2BED2F0 Offset: 0x2BED3F1 VA: 0x2BED2F0
	public bool Resume() { }

	// RVA: 0x2BED3B0 Offset: 0x2BED4B1 VA: 0x2BED3B0
	public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt) { }

	// RVA: 0x2BEDAD0 Offset: 0x2BEDBD1 VA: 0x2BEDAD0
	public void Update(Transform root, float speed) { }

	// RVA: 0x2BEF140 Offset: 0x2BEF241 VA: 0x2BEF140
	public float get_progress() { }

	// RVA: 0x2BEE780 Offset: 0x2BEE881 VA: 0x2BEE780
	private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause) { }

	// RVA: 0x2BEE9C0 Offset: 0x2BEEAC1 VA: 0x2BEE9C0
	private void PickUp(Transform root) { }

	// RVA: 0x2BEEF70 Offset: 0x2BEF071 VA: 0x2BEEF70
	public bool Stop() { }

	// RVA: 0x2BEF270 Offset: 0x2BEF371 VA: 0x2BEF270
	public void OnPostFBBIK() { }
}

