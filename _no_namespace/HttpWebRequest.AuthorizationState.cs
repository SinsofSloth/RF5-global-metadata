private struct HttpWebRequest.AuthorizationState // TypeDefIndex: 1977
{
	// Fields
	private readonly HttpWebRequest request; // 0x0
	private readonly bool isProxy; // 0x8
	private bool isCompleted; // 0x9
	private HttpWebRequest.NtlmAuthState ntlm_auth_state; // 0xC

	// Properties
	public bool IsCompleted { get; }
	public HttpWebRequest.NtlmAuthState NtlmAuthState { get; }
	public bool IsNtlmAuthenticated { get; }

	// Methods

	// RVA: 0x9810 Offset: 0x9911 VA: 0x9810
	public bool get_IsCompleted() { }

	// RVA: 0x9820 Offset: 0x9921 VA: 0x9820
	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x9830 Offset: 0x9931 VA: 0x9830
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x9850 Offset: 0x9951 VA: 0x9850
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x9890 Offset: 0x9991 VA: 0x9890
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x98A0 Offset: 0x99A1 VA: 0x98A0
	public void Reset() { }

	// RVA: 0x9920 Offset: 0x9A21 VA: 0x9920 Slot: 3
	public override string ToString() { }
}

