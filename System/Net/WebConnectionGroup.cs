internal class WebConnectionGroup // TypeDefIndex: 2000
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private string name; // 0x18
	private LinkedList<WebConnectionGroup.ConnectionState> connections; // 0x20
	private Queue queue; // 0x28
	private bool closing; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xBCF50 Offset: 0xBD051 VA: 0xBCF50
	private EventHandler ConnectionClosed; // 0x38

	// Properties
	public string Name { get; }
	internal Queue Queue { get; }

	// Methods

	// RVA: 0x1703130 Offset: 0x1703231 VA: 0x1703130
	public void .ctor(ServicePoint sPoint, string name) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAB0 Offset: 0xBDBB1 VA: 0xBDAB0
	// RVA: 0x1703210 Offset: 0x1703311 VA: 0x1703210
	public void add_ConnectionClosed(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAC0 Offset: 0xBDBC1 VA: 0xBDAC0
	// RVA: 0x17032C0 Offset: 0x17033C1 VA: 0x17032C0
	public void remove_ConnectionClosed(EventHandler value) { }

	// RVA: 0x1703370 Offset: 0x1703471 VA: 0x1703370
	public WebConnection GetConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x1703570 Offset: 0x1703671 VA: 0x1703570
	private static void PrepareSharingNtlm(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x17038C0 Offset: 0x17039C1 VA: 0x17038C0
	private WebConnectionGroup.ConnectionState FindIdleConnection() { }

	// RVA: 0x1703430 Offset: 0x1703531 VA: 0x1703430
	private WebConnection CreateOrReuseConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x1703B00 Offset: 0x1703C01 VA: 0x1703B00
	public string get_Name() { }

	// RVA: 0x1703B10 Offset: 0x1703C11 VA: 0x1703B10
	internal Queue get_Queue() { }

	// RVA: 0x1703B20 Offset: 0x1703C21 VA: 0x1703B20
	internal bool TryRecycle(TimeSpan maxIdleTime, ref DateTime idleSince) { }
}

