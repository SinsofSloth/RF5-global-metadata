[ServiceAttribute] // RVA: 0x13B840 Offset: 0x13B941 VA: 0x13B840
public class DockConsoleServiceImpl : IDockConsoleService // TypeDefIndex: 5631
{
	// Fields
	private ConsoleAlignment _alignment; // 0x10
	private DockConsoleController _consoleRoot; // 0x18
	private bool _didSuspendTrigger; // 0x20
	private bool _isExpanded; // 0x21
	private bool _isVisible; // 0x22

	// Properties
	public bool IsVisible { get; set; }
	public bool IsExpanded { get; set; }
	public ConsoleAlignment Alignment { get; set; }

	// Methods

	// RVA: 0x1536A80 Offset: 0x1536B81 VA: 0x1536A80
	public void .ctor() { }

	// RVA: 0x1536AC0 Offset: 0x1536BC1 VA: 0x1536AC0 Slot: 4
	public bool get_IsVisible() { }

	// RVA: 0x1536AD0 Offset: 0x1536BD1 VA: 0x1536AD0 Slot: 5
	public void set_IsVisible(bool value) { }

	// RVA: 0x1537230 Offset: 0x1537331 VA: 0x1537230 Slot: 6
	public bool get_IsExpanded() { }

	// RVA: 0x1537240 Offset: 0x1537341 VA: 0x1537240 Slot: 7
	public void set_IsExpanded(bool value) { }

	// RVA: 0x1537320 Offset: 0x1537421 VA: 0x1537320 Slot: 8
	public ConsoleAlignment get_Alignment() { }

	// RVA: 0x1537330 Offset: 0x1537431 VA: 0x1537330 Slot: 9
	public void set_Alignment(ConsoleAlignment value) { }

	// RVA: 0x1536BC0 Offset: 0x1536CC1 VA: 0x1536BC0
	private void Load() { }

	// RVA: 0x1536DE0 Offset: 0x1536EE1 VA: 0x1536DE0
	private void CheckTrigger() { }
}

