[RequireComponent] // RVA: 0x13B490 Offset: 0x13B591 VA: 0x13B490
public class ConsoleEntryView : SRMonoBehaviourEx, IVirtualView // TypeDefIndex: 5580
{
	// Fields
	public const string ConsoleBlobInfo = "Console_Info_Blob";
	public const string ConsoleBlobWarning = "Console_Warning_Blob";
	public const string ConsoleBlobError = "Console_Error_Blob";
	private int _count; // 0x48
	private bool _hasCount; // 0x4C
	private ConsoleEntry _prevData; // 0x50
	private RectTransform _rectTransform; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C720 Offset: 0x13C821 VA: 0x13C720
	public Text Count; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C730 Offset: 0x13C831 VA: 0x13C730
	public CanvasGroup CountContainer; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C740 Offset: 0x13C841 VA: 0x13C740
	public StyleComponent ImageStyle; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C750 Offset: 0x13C851 VA: 0x13C750
	public Text Message; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C760 Offset: 0x13C861 VA: 0x13C760
	public Text StackTrace; // 0x80

	// Methods

	// RVA: 0x15434A0 Offset: 0x15435A1 VA: 0x15434A0 Slot: 11
	public void SetDataContext(object data) { }

	// RVA: 0x15437B0 Offset: 0x15438B1 VA: 0x15437B0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1543870 Offset: 0x1543971 VA: 0x1543870
	public void .ctor() { }
}

