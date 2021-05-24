public class IPHostEntry // TypeDefIndex: 1886
{
	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties
	public string HostName { get; set; }
	public string[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x1794B40 Offset: 0x1794C41 VA: 0x1794B40
	public string get_HostName() { }

	// RVA: 0x1794B50 Offset: 0x1794C51 VA: 0x1794B50
	public void set_HostName(string value) { }

	// RVA: 0x1794B60 Offset: 0x1794C61 VA: 0x1794B60
	public void set_Aliases(string[] value) { }

	// RVA: 0x1794B70 Offset: 0x1794C71 VA: 0x1794B70
	public IPAddress[] get_AddressList() { }

	// RVA: 0x1794B80 Offset: 0x1794C81 VA: 0x1794B80
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x177D200 Offset: 0x177D301 VA: 0x177D200
	public void .ctor() { }
}

