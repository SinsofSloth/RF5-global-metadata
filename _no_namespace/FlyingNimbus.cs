public class FlyingNimbus : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 7553
{
	// Fields
	public string SpawnerName; // 0x18
	public Spline Spline; // 0x20
	public AnimationCurve animationCurve; // 0x28
	public FlyingNimbus.MoveType moveType; // 0x30
	public float TotalTime; // 0x34
	[SerializeField] // RVA: 0x167180 Offset: 0x167281 VA: 0x167180
	public float CurrentTime; // 0x38
	[SerializeField] // RVA: 0x167190 Offset: 0x167291 VA: 0x167190
	[RangeAttribute] // RVA: 0x167190 Offset: 0x167291 VA: 0x167190
	public float LerpValue; // 0x3C
	[SerializeField] // RVA: 0x1671E0 Offset: 0x1672E1 VA: 0x1671E0
	public Vector3 Rotation; // 0x40
	[HideInInspector] // RVA: 0x1671F0 Offset: 0x1672F1 VA: 0x1671F0
	public FlyingNimbus.Status IsStart; // 0x4C
	[HideInInspector] // RVA: 0x167200 Offset: 0x167301 VA: 0x167200
	public Vector3 ReturnPos; // 0x50
	[HideInInspector] // RVA: 0x167210 Offset: 0x167311 VA: 0x167210
	public FlyingNimbusEnter In0; // 0x60
	[HideInInspector] // RVA: 0x167220 Offset: 0x167321 VA: 0x167220
	public FlyingNimbusEnter In1; // 0x68
	public int EnterNo; // 0x70
	private float MovedDistance; // 0x74
	private Vector3 PrebPoint; // 0x78
	private CurveSample Sample; // 0x84
	private Quaternion target_rot; // 0xCC
	[HideInInspector] // RVA: 0x167230 Offset: 0x167331 VA: 0x167230
	public float MoveSign; // 0xDC
	private SphereCollider SphereCollider; // 0xE0
	[SerializeField] // RVA: 0x167240 Offset: 0x167341 VA: 0x167240
	private Vector3 Offset; // 0xE8

	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1D51D40 Offset: 0x1D51E41 VA: 0x1D51D40
	private void Awake() { }

	// RVA: 0x1D51E40 Offset: 0x1D51F41 VA: 0x1D51E40
	private void Start() { }

	// RVA: 0x1D51E50 Offset: 0x1D51F51 VA: 0x1D51E50
	private void Update() { }

	// RVA: 0x1D51FE0 Offset: 0x1D520E1 VA: 0x1D51FE0
	private void Update0() { }

	// RVA: 0x1D52310 Offset: 0x1D52411 VA: 0x1D52310
	private void Update1() { }

	// RVA: 0x1D52510 Offset: 0x1D52611 VA: 0x1D52510
	public void SetDirection() { }

	// RVA: 0x1D52540 Offset: 0x1D52641 VA: 0x1D52540 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1D52550 Offset: 0x1D52651 VA: 0x1D52550 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1D52560 Offset: 0x1D52661 VA: 0x1D52560 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1D52570 Offset: 0x1D52671 VA: 0x1D52570 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1D52580 Offset: 0x1D52681 VA: 0x1D52580 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1D526C0 Offset: 0x1D527C1 VA: 0x1D526C0 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1D527D0 Offset: 0x1D528D1 VA: 0x1D527D0 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1D52820 Offset: 0x1D52921 VA: 0x1D52820 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x1D52910 Offset: 0x1D52A11 VA: 0x1D52910 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1D52920 Offset: 0x1D52A21 VA: 0x1D52920 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1D52930 Offset: 0x1D52A31 VA: 0x1D52930 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1D529B0 Offset: 0x1D52AB1 VA: 0x1D529B0
	public ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID) { }

	// RVA: 0x1D529C0 Offset: 0x1D52AC1 VA: 0x1D529C0
	private bool CanPuton() { }

	// RVA: 0x1D525D0 Offset: 0x1D526D1 VA: 0x1D525D0
	protected void CallScript(string script_name) { }

	// RVA: 0x1D529D0 Offset: 0x1D52AD1 VA: 0x1D529D0
	public void EnableCollider(bool enable) { }

	// RVA: 0x1D52A80 Offset: 0x1D52B81 VA: 0x1D52A80 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D52A90 Offset: 0x1D52B91 VA: 0x1D52A90 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D52AA0 Offset: 0x1D52BA1 VA: 0x1D52AA0
	public void .ctor() { }

	// RVA: 0x1D52B80 Offset: 0x1D52C81 VA: 0x1D52B80 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1D52B90 Offset: 0x1D52C91 VA: 0x1D52B90 Slot: 18
	private Transform FocusInterface.get_transform() { }
}

