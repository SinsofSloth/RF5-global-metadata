public class Authorization // TypeDefIndex: 1872
{
	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x28F3470 Offset: 0x28F3571 VA: 0x28F3470
	public void .ctor(string token) { }

	// RVA: 0x28F3510 Offset: 0x28F3611 VA: 0x28F3510
	public void .ctor(string token, bool finished) { }

	// RVA: 0x28F35B0 Offset: 0x28F36B1 VA: 0x28F35B0
	public string get_Message() { }

	// RVA: 0x28F35C0 Offset: 0x28F36C1 VA: 0x28F35C0
	public bool get_Complete() { }
}

