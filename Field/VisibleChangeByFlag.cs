public class VisibleChangeByFlag : ObjectLoader // TypeDefIndex: 10472
{
	// Fields
	[SerializeField] // RVA: 0x181AE0 Offset: 0x181BE1 VA: 0x181AE0
	public GameFlagData GameFlagData; // 0x2C
	[SerializeField] // RVA: 0x181AF0 Offset: 0x181BF1 VA: 0x181AF0
	protected bool _IsFlagVisivle; // 0x30
	[SerializeField] // RVA: 0x181B00 Offset: 0x181C01 VA: 0x181B00
	protected GameObject[] VisibleChangeObject; // 0x38
	public int[] LoadIds; // 0x40
	public List<int> LoadDataList; // 0x48
	public Dictionary<int, GameObject> LoadObjectDict; // 0x50
	protected bool _IsInit; // 0x58

	// Properties
	public bool IsInit { get; }

	// Methods

	// RVA: 0x1EF0D40 Offset: 0x1EF0E41 VA: 0x1EF0D40
	public bool get_IsInit() { }

	// RVA: 0x1EF0D50 Offset: 0x1EF0E51 VA: 0x1EF0D50
	public bool NeedsLoad() { }

	// RVA: 0x1EF0D60 Offset: 0x1EF0E61 VA: 0x1EF0D60
	private void OnDestroy() { }

	// RVA: 0x1EF0EC0 Offset: 0x1EF0FC1 VA: 0x1EF0EC0
	private void Awake() { }

	// RVA: 0x1EF10D0 Offset: 0x1EF11D1 VA: 0x1EF10D0 Slot: 5
	public virtual void UpdateObjectVisible() { }

	// RVA: 0x1EF1190 Offset: 0x1EF1291 VA: 0x1EF1190
	protected void SetTargetActive(bool setValue) { }

	// RVA: 0x1EF1460 Offset: 0x1EF1561 VA: 0x1EF1460
	public void .ctor() { }
}

