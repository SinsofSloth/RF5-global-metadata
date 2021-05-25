private class WebConnectionGroup.ConnectionState : IWebConnectionState // TypeDefIndex: 2001
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCF60 Offset: 0xBD061 VA: 0xBCF60
	private WebConnection <Connection>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBCF70 Offset: 0xBD071 VA: 0xBCF70
	private WebConnectionGroup <Group>k__BackingField; // 0x18
	private bool busy; // 0x20
	private DateTime idleSince; // 0x28

	// Properties
	public WebConnection Connection { get; set; }
	public WebConnectionGroup Group { get; set; }
	public ServicePoint ServicePoint { get; }
	public bool Busy { get; }
	public DateTime IdleSince { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBDAD0 Offset: 0xBDBD1 VA: 0xBDAD0
	// RVA: 0x1704050 Offset: 0x1704151 VA: 0x1704050
	public WebConnection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAE0 Offset: 0xBDBE1 VA: 0xBDAE0
	// RVA: 0x1704060 Offset: 0x1704161 VA: 0x1704060
	private void set_Connection(WebConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAF0 Offset: 0xBDBF1 VA: 0xBDAF0
	// RVA: 0x1704070 Offset: 0x1704171 VA: 0x1704070 Slot: 4
	public WebConnectionGroup get_Group() { }

	[CompilerGeneratedAttribute] // RVA: 0xBDB00 Offset: 0xBDC01 VA: 0xBDB00
	// RVA: 0x1704080 Offset: 0x1704181 VA: 0x1704080
	private void set_Group(WebConnectionGroup value) { }

	// RVA: 0x1704090 Offset: 0x1704191 VA: 0x1704090 Slot: 7
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x17040B0 Offset: 0x17041B1 VA: 0x17040B0 Slot: 8
	public bool get_Busy() { }

	// RVA: 0x17040C0 Offset: 0x17041C1 VA: 0x17040C0 Slot: 9
	public DateTime get_IdleSince() { }

	// RVA: 0x17040D0 Offset: 0x17041D1 VA: 0x17040D0 Slot: 5
	public bool TrySetBusy() { }

	// RVA: 0x1704260 Offset: 0x1704361 VA: 0x1704260 Slot: 6
	public void SetIdle() { }

	// RVA: 0x1703A30 Offset: 0x1703B31 VA: 0x1703A30
	public void .ctor(WebConnectionGroup group) { }
}

