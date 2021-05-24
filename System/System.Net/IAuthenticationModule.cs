public interface IAuthenticationModule // TypeDefIndex: 1881
{
	// Properties
	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_AuthenticationType() { }
}

