public class NetworkCredential : ICredentials // TypeDefIndex: 1894
{
	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x16C88B0 Offset: 0x16C89B1 VA: 0x16C88B0
	public void .ctor(string userName, string password) { }

	// RVA: 0x16C8920 Offset: 0x16C8A21 VA: 0x16C8920
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x16C8B80 Offset: 0x16C8C81 VA: 0x16C8B80
	public string get_UserName() { }

	// RVA: 0x16C8A30 Offset: 0x16C8B31 VA: 0x16C8A30
	public void set_UserName(string value) { }

	// RVA: 0x16C8B90 Offset: 0x16C8C91 VA: 0x16C8B90
	public string get_Password() { }

	// RVA: 0x16C8AC0 Offset: 0x16C8BC1 VA: 0x16C8AC0
	public void set_Password(string value) { }

	// RVA: 0x16C8C60 Offset: 0x16C8D61 VA: 0x16C8C60
	public string get_Domain() { }

	// RVA: 0x16C8AF0 Offset: 0x16C8BF1 VA: 0x16C8AF0
	public void set_Domain(string value) { }

	// RVA: 0x16C8C70 Offset: 0x16C8D71 VA: 0x16C8C70
	internal string InternalGetUserName() { }

	// RVA: 0x16C8BA0 Offset: 0x16C8CA1 VA: 0x16C8BA0
	internal string InternalGetPassword() { }

	// RVA: 0x16C8DD0 Offset: 0x16C8ED1 VA: 0x16C8DD0
	internal string InternalGetDomain() { }

	// RVA: 0x16C8DE0 Offset: 0x16C8EE1 VA: 0x16C8DE0 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }
}

