public class SearchCharacterController // TypeDefIndex: 6434
{
	// Fields
	private float TickTime; // 0x10
	private bool IsOnlyTimerTick; // 0x14
	private Vector3 ForwardDirection; // 0x18
	private Vector3 OffsetPosition; // 0x24
	private float timer; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15C610 Offset: 0x15C711 VA: 0x15C610
	private Transform <HeadTransform>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15C620 Offset: 0x15C721 VA: 0x15C620
	private float <MaxDistance>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15C630 Offset: 0x15C731 VA: 0x15C630
	private int <MaxDistanceType>k__BackingField; // 0x44
	private bool IsSetup; // 0x48
	private bool IsTick; // 0x49
	private Collider[] results; // 0x50
	private List<SearchCharacterController.SearchParameter> SearchParameterList; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x15C640 Offset: 0x15C741 VA: 0x15C640
	private Dictionary<int, List<Character>> <FindCharacterListDic>k__BackingField; // 0x60
	private List<Character> CheckCharacterList; // 0x68
	private Func<Character, bool> IgnoreCharacterFunc; // 0x70
	private RaycastHit ObjectHit; // 0x78

	// Properties
	protected Transform HeadTransform { get; set; }
	public float MaxDistance { get; set; }
	public int MaxDistanceType { get; set; }
	public Dictionary<int, List<Character>> FindCharacterListDic { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B060 Offset: 0x19B161 VA: 0x19B060
	// RVA: 0x1C810C0 Offset: 0x1C811C1 VA: 0x1C810C0
	protected Transform get_HeadTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B070 Offset: 0x19B171 VA: 0x19B070
	// RVA: 0x1C810D0 Offset: 0x1C811D1 VA: 0x1C810D0
	protected void set_HeadTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B080 Offset: 0x19B181 VA: 0x19B080
	// RVA: 0x1C810E0 Offset: 0x1C811E1 VA: 0x1C810E0
	public float get_MaxDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B090 Offset: 0x19B191 VA: 0x19B090
	// RVA: 0x1C810F0 Offset: 0x1C811F1 VA: 0x1C810F0
	protected void set_MaxDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B0A0 Offset: 0x19B1A1 VA: 0x19B0A0
	// RVA: 0x1C81100 Offset: 0x1C81201 VA: 0x1C81100
	public int get_MaxDistanceType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B0B0 Offset: 0x19B1B1 VA: 0x19B0B0
	// RVA: 0x1C81110 Offset: 0x1C81211 VA: 0x1C81110
	protected void set_MaxDistanceType(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B0C0 Offset: 0x19B1C1 VA: 0x19B0C0
	// RVA: 0x1C81120 Offset: 0x1C81221 VA: 0x1C81120
	public Dictionary<int, List<Character>> get_FindCharacterListDic() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B0D0 Offset: 0x19B1D1 VA: 0x19B0D0
	// RVA: 0x1C81130 Offset: 0x1C81231 VA: 0x1C81130
	private void set_FindCharacterListDic(Dictionary<int, List<Character>> value) { }

	// RVA: 0x1C81140 Offset: 0x1C81241 VA: 0x1C81140
	public void SetIgnoreCharacterFunc(Func<Character, bool> ignoreCharacterFunc) { }

	// RVA: 0x1C81150 Offset: 0x1C81251 VA: 0x1C81150
	public void SetOnlyTimerTick(bool isOnlyTimerTick) { }

	// RVA: 0x1C81160 Offset: 0x1C81261 VA: 0x1C81160
	public void ClearFindCharacterList() { }

	// RVA: 0x1C81250 Offset: 0x1C81351 VA: 0x1C81250
	public void Setup(Vector3 offsetPosition, Vector3 forwardDirection, Transform headTransform) { }

	// RVA: 0x1C81330 Offset: 0x1C81431 VA: 0x1C81330
	public void Setup(Vector3 offsetPosition, Transform headTransform) { }

	// RVA: 0x1C813F0 Offset: 0x1C814F1 VA: 0x1C813F0 Slot: 4
	protected virtual void OnSetup() { }

	// RVA: 0x1C81400 Offset: 0x1C81501 VA: 0x1C81400
	public void Release() { }

	// RVA: 0x1C81480 Offset: 0x1C81581 VA: 0x1C81480
	public void SetTickTime(float tickTime) { }

	// RVA: 0x1C81490 Offset: 0x1C81591 VA: 0x1C81490
	public void AddSearchParameter(int type, float angle, float distance) { }

	// RVA: 0x1C81540 Offset: 0x1C81641 VA: 0x1C81540
	public void AddSearchParameter(int type, float angle, float distance, Vector3 localDirection) { }

	// RVA: 0x1C816A0 Offset: 0x1C817A1 VA: 0x1C816A0
	public SearchCharacterController.SearchParameter GetSearchParameter(int type) { }

	// RVA: 0x1C817C0 Offset: 0x1C818C1 VA: 0x1C817C0
	public List<Character> GetFindCharacterList() { }

	// RVA: 0x1C81820 Offset: 0x1C81921 VA: 0x1C81820
	public void ChangeSearchParameter(int type, float angle, float distance) { }

	// RVA: 0x1C81960 Offset: 0x1C81A61 VA: 0x1C81960
	public void Update() { }

	// RVA: 0x1C819E0 Offset: 0x1C81AE1 VA: 0x1C819E0
	public void Tick(bool isTimerTick = False) { }

	// RVA: 0x1C821D0 Offset: 0x1C822D1 VA: 0x1C821D0 Slot: 5
	protected virtual void OnBeforeTick() { }

	// RVA: 0x1C821E0 Offset: 0x1C822E1 VA: 0x1C821E0 Slot: 6
	protected virtual void OnFindCharacter(Character character, int searchParameterType) { }

	// RVA: 0x1C82010 Offset: 0x1C82111 VA: 0x1C82010
	private bool CheckSerchParameter(float angle, float sqrMagnitude, Vector3 targetPosition, SearchCharacterController.SearchParameter parameter, Collider collider, bool isCheckObstacle = False) { }

	// RVA: 0x1C821F0 Offset: 0x1C822F1 VA: 0x1C821F0
	public void OnDrawGizmosSelected() { }

	// RVA: 0x1C82200 Offset: 0x1C82301 VA: 0x1C82200
	public void .ctor() { }
}

