internal class WebRequest.WebProxyWrapperOpaque : IWebProxy // TypeDefIndex: 1907
{
	// Fields
	protected readonly WebProxy webProxy; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x170E260 Offset: 0x170E361 VA: 0x170E260 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x170E280 Offset: 0x170E381 VA: 0x170E280 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x170E2A0 Offset: 0x170E3A1 VA: 0x170E2A0 Slot: 6
	public ICredentials get_Credentials() { }
}

