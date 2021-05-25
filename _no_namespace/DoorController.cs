[ExecuteAlways] // RVA: 0x1464A0 Offset: 0x1465A1 VA: 0x1464A0
public class DoorController : MonoBehaviour // TypeDefIndex: 7428
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1665F0 Offset: 0x1666F1 VA: 0x1665F0
	private DoorController.State <m_State>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x166600 Offset: 0x166701 VA: 0x166600
	private DoorController.State <m_PrevState>k__BackingField; // 0x1C
	[SerializeField] // RVA: 0x166610 Offset: 0x166711 VA: 0x166610
	public Place Place; // 0x20
	[SerializeField] // RVA: 0x166620 Offset: 0x166721 VA: 0x166620
	private Transform Door_R; // 0x28
	[SerializeField] // RVA: 0x166630 Offset: 0x166731 VA: 0x166630
	private Quaternion CloseRotation_R; // 0x30
	[SerializeField] // RVA: 0x166640 Offset: 0x166741 VA: 0x166640
	private Quaternion OpenRotation_R; // 0x40
	[SerializeField] // RVA: 0x166650 Offset: 0x166751 VA: 0x166650
	private Transform Door_L; // 0x50
	[SerializeField] // RVA: 0x166660 Offset: 0x166761 VA: 0x166660
	private Quaternion CloseRotation_L; // 0x58
	[SerializeField] // RVA: 0x166670 Offset: 0x166771 VA: 0x166670
	private Quaternion OpenRotation_L; // 0x68
	[SerializeField] // RVA: 0x166680 Offset: 0x166781 VA: 0x166680
	private AnimationCurve AnimationCurve; // 0x78
	[SerializeField] // RVA: 0x166690 Offset: 0x166791 VA: 0x166690
	private float AnimTime; // 0x80
	private const float CloseDelayTime = 6;
	[CompilerGeneratedAttribute] // RVA: 0x1666A0 Offset: 0x1667A1 VA: 0x1666A0
	private bool <IsForward>k__BackingField; // 0x84
	[SerializeField] // RVA: 0x1666B0 Offset: 0x1667B1 VA: 0x1666B0
	private BoxCollider BoxCollider; // 0x88
	private HashSet<ActorController> InSideCollisions; // 0x90
	private HashSet<ActorController> OpenedCharacters; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x1666C0 Offset: 0x1667C1 VA: 0x1666C0
	private float <ElapsedTime>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x1666D0 Offset: 0x1667D1 VA: 0x1666D0
	private float <DoorAlpha>k__BackingField; // 0xA4
	private static bool prev_FLAG_ALLDOOR_CLOSED; // 0x0
	private static bool doorOpenEvent; // 0x1
	private List<ActorController> DeleteList; // 0xA8

	// Properties
	private DoorController.State m_State { get; set; }
	private DoorController.State m_PrevState { get; set; }
	private bool IsForward { get; set; }
	private float ElapsedTime { get; set; }
	private float DoorAlpha { get; set; }
	private bool IsOpened { get; }
	private bool IsClosed { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A0DA0 Offset: 0x1A0EA1 VA: 0x1A0DA0
	// RVA: 0x1CEC4F0 Offset: 0x1CEC5F1 VA: 0x1CEC4F0
	private DoorController.State get_m_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0DB0 Offset: 0x1A0EB1 VA: 0x1A0DB0
	// RVA: 0x1CEC500 Offset: 0x1CEC601 VA: 0x1CEC500
	private void set_m_State(DoorController.State value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0DC0 Offset: 0x1A0EC1 VA: 0x1A0DC0
	// RVA: 0x1CEC510 Offset: 0x1CEC611 VA: 0x1CEC510
	private DoorController.State get_m_PrevState() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0DD0 Offset: 0x1A0ED1 VA: 0x1A0DD0
	// RVA: 0x1CEC520 Offset: 0x1CEC621 VA: 0x1CEC520
	private void set_m_PrevState(DoorController.State value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0DE0 Offset: 0x1A0EE1 VA: 0x1A0DE0
	// RVA: 0x1CEC530 Offset: 0x1CEC631 VA: 0x1CEC530
	private bool get_IsForward() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0DF0 Offset: 0x1A0EF1 VA: 0x1A0DF0
	// RVA: 0x1CEC540 Offset: 0x1CEC641 VA: 0x1CEC540
	private void set_IsForward(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0E00 Offset: 0x1A0F01 VA: 0x1A0E00
	// RVA: 0x1CEC550 Offset: 0x1CEC651 VA: 0x1CEC550
	private float get_ElapsedTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0E10 Offset: 0x1A0F11 VA: 0x1A0E10
	// RVA: 0x1CEC560 Offset: 0x1CEC661 VA: 0x1CEC560
	private void set_ElapsedTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0E20 Offset: 0x1A0F21 VA: 0x1A0E20
	// RVA: 0x1CEC570 Offset: 0x1CEC671 VA: 0x1CEC570
	private float get_DoorAlpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0E30 Offset: 0x1A0F31 VA: 0x1A0E30
	// RVA: 0x1CEC580 Offset: 0x1CEC681 VA: 0x1CEC580
	private void set_DoorAlpha(float value) { }

	// RVA: 0x1CEC590 Offset: 0x1CEC691 VA: 0x1CEC590
	private bool ChangeState(DoorController.State state) { }

	// RVA: 0x1CECAB0 Offset: 0x1CECBB1 VA: 0x1CECAB0
	private bool get_IsOpened() { }

	// RVA: 0x1CECAD0 Offset: 0x1CECBD1 VA: 0x1CECAD0
	private bool get_IsClosed() { }

	// RVA: 0x1CECAF0 Offset: 0x1CECBF1 VA: 0x1CECAF0
	public void DoOpen(bool isForward) { }

	// RVA: 0x1CECB40 Offset: 0x1CECC41 VA: 0x1CECB40
	public void DoClose() { }

	// RVA: 0x1CECBD0 Offset: 0x1CECCD1 VA: 0x1CECBD0
	public void ImmediateClose() { }

	// RVA: 0x1CECBF0 Offset: 0x1CECCF1 VA: 0x1CECBF0
	private void Update() { }

	// RVA: 0x1CEC620 Offset: 0x1CEC721 VA: 0x1CEC620
	private void Close_Enter() { }

	// RVA: 0x1CED6E0 Offset: 0x1CED7E1 VA: 0x1CED6E0
	private void Close_Update() { }

	// RVA: 0x1CEC750 Offset: 0x1CEC851 VA: 0x1CEC750
	private void AnimOpen_Enter() { }

	// RVA: 0x1CED6F0 Offset: 0x1CED7F1 VA: 0x1CED6F0
	private void AnimOpen_Update(float deltaTime) { }

	// RVA: 0x1CEC7F0 Offset: 0x1CEC8F1 VA: 0x1CEC7F0
	private void Open_Enter() { }

	// RVA: 0x1CEDA50 Offset: 0x1CEDB51 VA: 0x1CEDA50
	private void Open_Update() { }

	// RVA: 0x1CECA00 Offset: 0x1CECB01 VA: 0x1CECA00
	private void DelayClose_Enter() { }

	// RVA: 0x1CEDA60 Offset: 0x1CEDB61 VA: 0x1CEDA60
	private void DelayClose_Update() { }

	// RVA: 0x1CECA10 Offset: 0x1CECB11 VA: 0x1CECA10
	private void AnimClose_Enter() { }

	// RVA: 0x1CEDAB0 Offset: 0x1CEDBB1 VA: 0x1CEDAB0
	private void AnimClose_Update(float deltaTime) { }

	// RVA: 0x1CEDE00 Offset: 0x1CEDF01 VA: 0x1CEDE00
	private void UpdateCollision() { }

	// RVA: 0x1CEE0C0 Offset: 0x1CEE1C1 VA: 0x1CEE0C0
	private static bool TimeCheck(int hour, int start, int end) { }

	// RVA: 0x1CEE110 Offset: 0x1CEE211 VA: 0x1CEE110
	public static bool CanOpenByTime(Place placeid, bool isNeedLove) { }

	// RVA: 0x1CED2D0 Offset: 0x1CED3D1 VA: 0x1CED2D0
	public static bool CanOpen(Place placeid, ActorID actorID) { }

	// RVA: 0x1CEE5B0 Offset: 0x1CEE6B1 VA: 0x1CEE5B0
	private void Reset() { }

	// RVA: 0x1CEE610 Offset: 0x1CEE711 VA: 0x1CEE610
	public void .ctor() { }

	// RVA: 0x1CEE700 Offset: 0x1CEE801 VA: 0x1CEE700
	private static void .cctor() { }
}

