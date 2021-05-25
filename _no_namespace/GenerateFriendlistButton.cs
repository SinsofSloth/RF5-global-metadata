public class GenerateFriendlistButton : UIScrollBoxBase // TypeDefIndex: 8664
{
	// Fields
	[SerializeField] // RVA: 0x171EA0 Offset: 0x171FA1 VA: 0x171EA0
	private GameObject HasDataObject; // 0x68
	[SerializeField] // RVA: 0x171EB0 Offset: 0x171FB1 VA: 0x171EB0
	private GameObject NoDataObject; // 0x70
	private ButtonLinker menuButton; // 0x78
	[SerializeField] // RVA: 0x171EC0 Offset: 0x171FC1 VA: 0x171EC0
	private GameObject[] childObjects; // 0x80
	[SerializeField] // RVA: 0x171ED0 Offset: 0x171FD1 VA: 0x171ED0
	private FriendPageStatusDisp FriendPageStatusDispPrefabs; // 0x88
	[SerializeField] // RVA: 0x171EE0 Offset: 0x171FE1 VA: 0x171EE0
	private UISortBlock sortBlock; // 0x90
	private GenerateFriendlistButton.SortType sortType; // 0x98
	private bool sortRevert; // 0x9C
	private GenerateFriendlistButton.FriendType friendType; // 0xA0
	private List<ActorID> ActorIds; // 0xA8
	private List<int> MonsterStatusDataIds; // 0xB0
	private readonly List<ActorID> CanGenerateActorIDTable; // 0xB8
	private readonly int[] FriendMeetCheckFlag; // 0xC0

	// Methods

	// RVA: 0x1E46150 Offset: 0x1E46251 VA: 0x1E46150
	private void OnEnable() { }

	// RVA: 0x1E46710 Offset: 0x1E46811 VA: 0x1E46710 Slot: 9
	protected override void Update() { }

	// RVA: 0x1E46310 Offset: 0x1E46411 VA: 0x1E46310
	private void GenerateFriendData() { }

	// RVA: 0x1E46A50 Offset: 0x1E46B51 VA: 0x1E46A50
	private void InputSubmit() { }

	// RVA: 0x1E46BF0 Offset: 0x1E46CF1 VA: 0x1E46BF0
	private void SetSortType() { }

	// RVA: 0x1E469E0 Offset: 0x1E46AE1 VA: 0x1E469E0
	private void ChangeSortType() { }

	// RVA: 0x1E47440 Offset: 0x1E47541 VA: 0x1E47440
	public void ChangePage(GenerateFriendlistButton.FriendType newType, CursorLinker PageButton) { }

	// RVA: 0x1E46960 Offset: 0x1E46A61 VA: 0x1E46960
	public int GetFriendCount() { }

	// RVA: 0x1E47530 Offset: 0x1E47631 VA: 0x1E47530
	public ActorID GetActorID(int PageNo) { }

	// RVA: 0x1E475B0 Offset: 0x1E476B1 VA: 0x1E475B0
	public void CloseFriendObj(int pageId) { }

	// RVA: 0x1E46290 Offset: 0x1E46391 VA: 0x1E46290
	private void SetOnOffChild(bool state) { }

	// RVA: 0x1E477C0 Offset: 0x1E478C1 VA: 0x1E477C0 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1E47840 Offset: 0x1E47941 VA: 0x1E47840 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1E479C0 Offset: 0x1E47AC1 VA: 0x1E479C0 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1E479D0 Offset: 0x1E47AD1 VA: 0x1E479D0
	public void .ctor() { }
}

