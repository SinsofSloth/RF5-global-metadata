public class MobTravelerManager : SingletonMonoBehaviour<MobTravelerManager> // TypeDefIndex: 6721
{
	// Fields
	private const int ArrayNum = 16;
	private const ActorID ActorStartID = 33;
	private const float m_ActivateDistance = 40;
	private Register<ActorID, MobTravelerController> m_Register; // 0x18
	[TupleElementNamesAttribute] // RVA: 0x15EFF0 Offset: 0x15F0F1 VA: 0x15EFF0
	private List<ValueTuple<CharID, VariationNo, HairType>> m_CharaList; // 0x20
	private static Dictionary<CharID, float> m_MoveSpeedRateDic; // 0x0
	[SerializeField] // RVA: 0x15F0B0 Offset: 0x15F1B1 VA: 0x15F0B0
	private bool m_isShow; // 0x28
	[SerializeField] // RVA: 0x15F0C0 Offset: 0x15F1C1 VA: 0x15F0C0
	private List<Transform> m_StartPointList; // 0x30
	[SerializeField] // RVA: 0x15F0D0 Offset: 0x15F1D1 VA: 0x15F0D0
	[RangeAttribute] // RVA: 0x15F0D0 Offset: 0x15F1D1 VA: 0x15F0D0
	private float m_BaseMoveSpeedRate; // 0x38
	public Dictionary<ActorID, MobTravelerName> m_NameDictionary; // 0x40
	private int m_PositionIndex; // 0x48
	private int m_PositionIndexInc; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x15F120 Offset: 0x15F221 VA: 0x15F120
	private int <MaleNum>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x15F130 Offset: 0x15F231 VA: 0x15F130
	private int <FemaleNum>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x15F140 Offset: 0x15F241 VA: 0x15F140
	private bool <IsBaseCreated>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x15F150 Offset: 0x15F251 VA: 0x15F150
	private bool <IsModelCreated>k__BackingField; // 0x59
	[CompilerGeneratedAttribute] // RVA: 0x15F160 Offset: 0x15F261 VA: 0x15F160
	private bool <IsShowBase>k__BackingField; // 0x5A
	[CompilerGeneratedAttribute] // RVA: 0x15F170 Offset: 0x15F271 VA: 0x15F170
	private bool <IsInTown>k__BackingField; // 0x5B

	// Properties
	public bool Show { get; }
	private int MaleNum { get; set; }
	private int FemaleNum { get; set; }
	private int TotalNum { get; }
	public bool IsBaseCreated { get; set; }
	public bool IsModelCreated { get; set; }
	public bool IsShowBase { get; set; }
	public bool IsInTown { get; set; }
	public bool IsAvailable { get; }
	public bool IsActivityTime { get; }
	public bool IsTimeOver { get; }
	public float MoveSpeedRate { get; }

	// Methods

	// RVA: 0x1CBF3F0 Offset: 0x1CBF4F1 VA: 0x1CBF3F0
	public bool get_Show() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CAD0 Offset: 0x19CBD1 VA: 0x19CAD0
	// RVA: 0x1CBF400 Offset: 0x1CBF501 VA: 0x1CBF400
	private int get_MaleNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CAE0 Offset: 0x19CBE1 VA: 0x19CAE0
	// RVA: 0x1CBF410 Offset: 0x1CBF511 VA: 0x1CBF410
	private void set_MaleNum(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CAF0 Offset: 0x19CBF1 VA: 0x19CAF0
	// RVA: 0x1CBF420 Offset: 0x1CBF521 VA: 0x1CBF420
	private int get_FemaleNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CB00 Offset: 0x19CC01 VA: 0x19CB00
	// RVA: 0x1CBF430 Offset: 0x1CBF531 VA: 0x1CBF430
	private void set_FemaleNum(int value) { }

	// RVA: 0x1CBF440 Offset: 0x1CBF541 VA: 0x1CBF440
	private int get_TotalNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CB10 Offset: 0x19CC11 VA: 0x19CB10
	// RVA: 0x1CBF450 Offset: 0x1CBF551 VA: 0x1CBF450
	public bool get_IsBaseCreated() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CB20 Offset: 0x19CC21 VA: 0x19CB20
	// RVA: 0x1CBF460 Offset: 0x1CBF561 VA: 0x1CBF460
	protected void set_IsBaseCreated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CB30 Offset: 0x19CC31 VA: 0x19CB30
	// RVA: 0x1CBF470 Offset: 0x1CBF571 VA: 0x1CBF470
	public bool get_IsModelCreated() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CB40 Offset: 0x19CC41 VA: 0x19CB40
	// RVA: 0x1CBF480 Offset: 0x1CBF581 VA: 0x1CBF480
	protected void set_IsModelCreated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CB50 Offset: 0x19CC51 VA: 0x19CB50
	// RVA: 0x1CBF490 Offset: 0x1CBF591 VA: 0x1CBF490
	public bool get_IsShowBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CB60 Offset: 0x19CC61 VA: 0x19CB60
	// RVA: 0x1CBF4A0 Offset: 0x1CBF5A1 VA: 0x1CBF4A0
	protected void set_IsShowBase(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CB70 Offset: 0x19CC71 VA: 0x19CB70
	// RVA: 0x1CBF4B0 Offset: 0x1CBF5B1 VA: 0x1CBF4B0
	public bool get_IsInTown() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CB80 Offset: 0x19CC81 VA: 0x19CB80
	// RVA: 0x1CBF4C0 Offset: 0x1CBF5C1 VA: 0x1CBF4C0
	protected void set_IsInTown(bool value) { }

	// RVA: 0x1CBF4D0 Offset: 0x1CBF5D1 VA: 0x1CBF4D0
	public bool get_IsAvailable() { }

	// RVA: 0x1CBF5B0 Offset: 0x1CBF6B1 VA: 0x1CBF5B0
	public bool get_IsActivityTime() { }

	// RVA: 0x1CBF6A0 Offset: 0x1CBF7A1 VA: 0x1CBF6A0
	public bool get_IsTimeOver() { }

	// RVA: 0x1CBF790 Offset: 0x1CBF891 VA: 0x1CBF790
	public float get_MoveSpeedRate() { }

	// RVA: 0x1CBEC30 Offset: 0x1CBED31 VA: 0x1CBEC30
	public bool Regist(ActorID actorID, MobTravelerController controller) { }

	// RVA: 0x1CBEF90 Offset: 0x1CBF091 VA: 0x1CBEF90
	public bool Remove(ActorID actorID) { }

	// RVA: 0x1CBFB50 Offset: 0x1CBFC51 VA: 0x1CBFB50
	public MobTravelerController Get(ActorID actorID) { }

	// RVA: 0x1CBD640 Offset: 0x1CBD741 VA: 0x1CBD640
	public void OnUpdate() { }

	// RVA: 0x1CBFC10 Offset: 0x1CBFD11 VA: 0x1CBFC10
	public void Init() { }

	// RVA: 0x1CC0190 Offset: 0x1CC0291 VA: 0x1CC0190
	private bool IsFemale(CharID charID) { }

	// RVA: 0x1CBFD10 Offset: 0x1CBFE11 VA: 0x1CBFD10
	public void ResetAll() { }

	// RVA: 0x1CC03B0 Offset: 0x1CC04B1 VA: 0x1CC03B0
	public void ResetNames() { }

	// RVA: 0x1CC06F0 Offset: 0x1CC07F1 VA: 0x1CC06F0
	private void ShowBaseAll() { }

	// RVA: 0x1CC0B00 Offset: 0x1CC0C01 VA: 0x1CC0B00
	private void HideBaseAll() { }

	// RVA: 0x1CC0D10 Offset: 0x1CC0E11 VA: 0x1CC0D10
	public void CreateAll() { }

	// RVA: 0x1CC0EE0 Offset: 0x1CC0FE1 VA: 0x1CC0EE0
	public void CreateBaseAll() { }

	// RVA: 0x1CC01B0 Offset: 0x1CC02B1 VA: 0x1CC01B0
	public void DeleteAll() { }

	// RVA: 0x1CC10A0 Offset: 0x1CC11A1 VA: 0x1CC10A0
	public void DeleteModelAll() { }

	// RVA: 0x1CBFFB0 Offset: 0x1CC00B1 VA: 0x1CBFFB0
	public void ShowAll() { }

	// RVA: 0x1CC1430 Offset: 0x1CC1531 VA: 0x1CC1430
	public void HideAll() { }

	// RVA: 0x1CC0930 Offset: 0x1CC0A31 VA: 0x1CC0930
	public void ResetPositionAll() { }

	// RVA: 0x1CBF7A0 Offset: 0x1CBF8A1 VA: 0x1CBF7A0
	private void SetPosition(ActorID actorID) { }

	// RVA: 0x1CBEAB0 Offset: 0x1CBEBB1 VA: 0x1CBEAB0
	public string GetName(ActorID actorID) { }

	// RVA: 0x1CBF110 Offset: 0x1CBF211 VA: 0x1CBF110
	public float GetSpeedRate(ActorID actorID) { }

	// RVA: 0x1CC1740 Offset: 0x1CC1841 VA: 0x1CC1740
	public void OnResetPlaceID() { }

	// RVA: 0x1CBE070 Offset: 0x1CBE171 VA: 0x1CBE070
	public void OnDayCarry(int days) { }

	// RVA: 0x1CC1310 Offset: 0x1CC1411 VA: 0x1CC1310
	public void DoCheck() { }

	// RVA: 0x1CC1750 Offset: 0x1CC1851 VA: 0x1CC1750
	public void .ctor() { }

	// RVA: 0x1CC1890 Offset: 0x1CC1991 VA: 0x1CC1890
	private static void .cctor() { }
}

