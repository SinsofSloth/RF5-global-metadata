public class InfoTabController : SRMonoBehaviourEx // TypeDefIndex: 5552
{
	// Fields
	public const char Tick = '\x2713';
	public const char Cross = '\xd7';
	public const string NameColor = "#BCBCBC";
	private Dictionary<string, InfoBlock> _infoBlocks; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C240 Offset: 0x13C341 VA: 0x13C240
	public InfoBlock InfoBlockPrefab; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C250 Offset: 0x13C351 VA: 0x13C250
	public RectTransform LayoutContainer; // 0x58

	// Methods

	// RVA: 0x1B348A0 Offset: 0x1B349A1 VA: 0x1B348A0 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B348D0 Offset: 0x1B349D1 VA: 0x1B348D0
	public void Refresh() { }

	// RVA: 0x1B34EB0 Offset: 0x1B34FB1 VA: 0x1B34EB0
	private void FillInfoBlock(InfoBlock block, IList<InfoEntry> info) { }

	// RVA: 0x1B34E00 Offset: 0x1B34F01 VA: 0x1B34E00
	private InfoBlock CreateBlock(string title) { }

	// RVA: 0x1B356B0 Offset: 0x1B357B1 VA: 0x1B356B0
	public void .ctor() { }
}

