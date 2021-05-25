public abstract class SharedVariable // TypeDefIndex: 4710
{
	// Fields
	[SerializeField] // RVA: 0x12D7B0 Offset: 0x12D8B1 VA: 0x12D7B0
	private bool mIsShared; // 0x10
	[SerializeField] // RVA: 0x12D7C0 Offset: 0x12D8C1 VA: 0x12D7C0
	private bool mIsGlobal; // 0x11
	[SerializeField] // RVA: 0x12D7D0 Offset: 0x12D8D1 VA: 0x12D7D0
	private bool mIsDynamic; // 0x12
	[SerializeField] // RVA: 0x12D7E0 Offset: 0x12D8E1 VA: 0x12D7E0
	private string mName; // 0x18
	[SerializeField] // RVA: 0x12D7F0 Offset: 0x12D8F1 VA: 0x12D7F0
	private string mToolTip; // 0x20
	[SerializeField] // RVA: 0x12D800 Offset: 0x12D901 VA: 0x12D800
	private string mPropertyMapping; // 0x28
	[SerializeField] // RVA: 0x12D810 Offset: 0x12D911 VA: 0x12D810
	private GameObject mPropertyMappingOwner; // 0x30
	[SerializeField] // RVA: 0x12D820 Offset: 0x12D921 VA: 0x12D820
	private bool mNetworkSync; // 0x38

	// Properties
	public bool IsShared { get; set; }
	public bool IsGlobal { get; set; }
	public bool IsDynamic { set; }
	public string Name { get; set; }
	public string Tooltip { set; }
	public string PropertyMapping { get; set; }
	public GameObject PropertyMappingOwner { get; set; }
	public bool NetworkSync { get; set; }
	public bool IsNone { get; }

	// Methods

	// RVA: 0x1B224D0 Offset: 0x1B225D1 VA: 0x1B224D0
	protected void .ctor() { }

	// RVA: 0x1B224E0 Offset: 0x1B225E1 VA: 0x1B224E0
	public bool get_IsShared() { }

	// RVA: 0x1B224F0 Offset: 0x1B225F1 VA: 0x1B224F0
	public void set_IsShared(bool value) { }

	// RVA: 0x1B22500 Offset: 0x1B22601 VA: 0x1B22500
	public bool get_IsGlobal() { }

	// RVA: 0x1B22510 Offset: 0x1B22611 VA: 0x1B22510
	public void set_IsGlobal(bool value) { }

	// RVA: 0x1B22520 Offset: 0x1B22621 VA: 0x1B22520
	public void set_IsDynamic(bool value) { }

	// RVA: 0x1B22530 Offset: 0x1B22631 VA: 0x1B22530
	public string get_Name() { }

	// RVA: 0x1B22540 Offset: 0x1B22641 VA: 0x1B22540
	public void set_Name(string value) { }

	// RVA: 0x1B22550 Offset: 0x1B22651 VA: 0x1B22550
	public void set_Tooltip(string value) { }

	// RVA: 0x1B22560 Offset: 0x1B22661 VA: 0x1B22560
	public string get_PropertyMapping() { }

	// RVA: 0x1B22570 Offset: 0x1B22671 VA: 0x1B22570
	public void set_PropertyMapping(string value) { }

	// RVA: 0x1B22580 Offset: 0x1B22681 VA: 0x1B22580
	public GameObject get_PropertyMappingOwner() { }

	// RVA: 0x1B22590 Offset: 0x1B22691 VA: 0x1B22590
	public void set_PropertyMappingOwner(GameObject value) { }

	// RVA: 0x1B225A0 Offset: 0x1B226A1 VA: 0x1B225A0
	public bool get_NetworkSync() { }

	// RVA: 0x1B225B0 Offset: 0x1B226B1 VA: 0x1B225B0
	public void set_NetworkSync(bool value) { }

	// RVA: 0x1B225C0 Offset: 0x1B226C1 VA: 0x1B225C0
	public bool get_IsNone() { }

	// RVA: 0x1B225E0 Offset: 0x1B226E1 VA: 0x1B225E0
	public void ValueChanged() { }

	// RVA: 0x1B225F0 Offset: 0x1B226F1 VA: 0x1B225F0 Slot: 4
	public virtual void InitializePropertyMapping(BehaviorSource behaviorSource) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object GetValue() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetValue(object value) { }
}

