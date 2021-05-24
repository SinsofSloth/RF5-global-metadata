public static class NetworkServiceAccount // TypeDefIndex: 11712
{
	// Fields
	public const int IdTokenLengthMax = 3072;

	// Properties
	public static ErrorRange ResultNetworkServiceAccountUnavailable { get; }
	public static ErrorRange ResultTokenCacheUnavailable { get; }
	public static ErrorRange ResultNetworkCommunicationError { get; }
	public static ErrorRange ResultSslService { get; }

	// Methods

	// RVA: 0x26A4AB0 Offset: 0x26A4BB1 VA: 0x26A4AB0
	public static extern Result EnsureAvailable(UserHandle handle) { }

	// RVA: 0x26A4AF0 Offset: 0x26A4BF1 VA: 0x26A4AF0
	public static extern Result IsAvailable(ref bool pOut, UserHandle handle) { }

	// RVA: 0x26A4B30 Offset: 0x26A4C31 VA: 0x26A4B30
	public static extern Result GetId(ref NetworkServiceAccountId pOutId, UserHandle handle) { }

	// RVA: 0x26A4B70 Offset: 0x26A4C71 VA: 0x26A4B70
	public static Result EnsurIdTokenCacheAsync(AsyncContext pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BB0 Offset: 0x26A4CB1 VA: 0x26A4BB0
	public static extern Result EnsurIdTokenCacheAsync(IntPtr pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BF0 Offset: 0x26A4CF1 VA: 0x26A4BF0
	public static Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, UserHandle handle) { }

	// RVA: 0x26A4C50 Offset: 0x26A4D51 VA: 0x26A4C50
	private static extern Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, int bufferSize, UserHandle handle) { }

	// RVA: 0x26A4C90 Offset: 0x26A4D91 VA: 0x26A4C90
	public static ErrorRange get_ResultNetworkServiceAccountUnavailable() { }

	// RVA: 0x26A4CA0 Offset: 0x26A4DA1 VA: 0x26A4CA0
	public static ErrorRange get_ResultTokenCacheUnavailable() { }

	// RVA: 0x26A4CB0 Offset: 0x26A4DB1 VA: 0x26A4CB0
	public static ErrorRange get_ResultNetworkCommunicationError() { }

	// RVA: 0x26A4CC0 Offset: 0x26A4DC1 VA: 0x26A4CC0
	public static ErrorRange get_ResultSslService() { }
}

public static class NetworkServiceAccount // TypeDefIndex: 11712
{
	// Fields
	public const int IdTokenLengthMax = 3072;

	// Properties
	public static ErrorRange ResultNetworkServiceAccountUnavailable { get; }
	public static ErrorRange ResultTokenCacheUnavailable { get; }
	public static ErrorRange ResultNetworkCommunicationError { get; }
	public static ErrorRange ResultSslService { get; }

	// Methods

	// RVA: 0x26A4AB0 Offset: 0x26A4BB1 VA: 0x26A4AB0
	public static extern Result EnsureAvailable(UserHandle handle) { }

	// RVA: 0x26A4AF0 Offset: 0x26A4BF1 VA: 0x26A4AF0
	public static extern Result IsAvailable(ref bool pOut, UserHandle handle) { }

	// RVA: 0x26A4B30 Offset: 0x26A4C31 VA: 0x26A4B30
	public static extern Result GetId(ref NetworkServiceAccountId pOutId, UserHandle handle) { }

	// RVA: 0x26A4B70 Offset: 0x26A4C71 VA: 0x26A4B70
	public static Result EnsurIdTokenCacheAsync(AsyncContext pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BB0 Offset: 0x26A4CB1 VA: 0x26A4BB0
	public static extern Result EnsurIdTokenCacheAsync(IntPtr pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BF0 Offset: 0x26A4CF1 VA: 0x26A4BF0
	public static Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, UserHandle handle) { }

	// RVA: 0x26A4C50 Offset: 0x26A4D51 VA: 0x26A4C50
	private static extern Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, int bufferSize, UserHandle handle) { }

	// RVA: 0x26A4C90 Offset: 0x26A4D91 VA: 0x26A4C90
	public static ErrorRange get_ResultNetworkServiceAccountUnavailable() { }

	// RVA: 0x26A4CA0 Offset: 0x26A4DA1 VA: 0x26A4CA0
	public static ErrorRange get_ResultTokenCacheUnavailable() { }

	// RVA: 0x26A4CB0 Offset: 0x26A4DB1 VA: 0x26A4CB0
	public static ErrorRange get_ResultNetworkCommunicationError() { }

	// RVA: 0x26A4CC0 Offset: 0x26A4DC1 VA: 0x26A4CC0
	public static ErrorRange get_ResultSslService() { }
}

public static class NetworkServiceAccount // TypeDefIndex: 11712
{
	// Fields
	public const int IdTokenLengthMax = 3072;

	// Properties
	public static ErrorRange ResultNetworkServiceAccountUnavailable { get; }
	public static ErrorRange ResultTokenCacheUnavailable { get; }
	public static ErrorRange ResultNetworkCommunicationError { get; }
	public static ErrorRange ResultSslService { get; }

	// Methods

	// RVA: 0x26A4AB0 Offset: 0x26A4BB1 VA: 0x26A4AB0
	public static extern Result EnsureAvailable(UserHandle handle) { }

	// RVA: 0x26A4AF0 Offset: 0x26A4BF1 VA: 0x26A4AF0
	public static extern Result IsAvailable(ref bool pOut, UserHandle handle) { }

	// RVA: 0x26A4B30 Offset: 0x26A4C31 VA: 0x26A4B30
	public static extern Result GetId(ref NetworkServiceAccountId pOutId, UserHandle handle) { }

	// RVA: 0x26A4B70 Offset: 0x26A4C71 VA: 0x26A4B70
	public static Result EnsurIdTokenCacheAsync(AsyncContext pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BB0 Offset: 0x26A4CB1 VA: 0x26A4BB0
	public static extern Result EnsurIdTokenCacheAsync(IntPtr pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BF0 Offset: 0x26A4CF1 VA: 0x26A4BF0
	public static Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, UserHandle handle) { }

	// RVA: 0x26A4C50 Offset: 0x26A4D51 VA: 0x26A4C50
	private static extern Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, int bufferSize, UserHandle handle) { }

	// RVA: 0x26A4C90 Offset: 0x26A4D91 VA: 0x26A4C90
	public static ErrorRange get_ResultNetworkServiceAccountUnavailable() { }

	// RVA: 0x26A4CA0 Offset: 0x26A4DA1 VA: 0x26A4CA0
	public static ErrorRange get_ResultTokenCacheUnavailable() { }

	// RVA: 0x26A4CB0 Offset: 0x26A4DB1 VA: 0x26A4CB0
	public static ErrorRange get_ResultNetworkCommunicationError() { }

	// RVA: 0x26A4CC0 Offset: 0x26A4DC1 VA: 0x26A4CC0
	public static ErrorRange get_ResultSslService() { }
}

public static class NetworkServiceAccount // TypeDefIndex: 11712
{
	// Fields
	public const int IdTokenLengthMax = 3072;

	// Properties
	public static ErrorRange ResultNetworkServiceAccountUnavailable { get; }
	public static ErrorRange ResultTokenCacheUnavailable { get; }
	public static ErrorRange ResultNetworkCommunicationError { get; }
	public static ErrorRange ResultSslService { get; }

	// Methods

	// RVA: 0x26A4AB0 Offset: 0x26A4BB1 VA: 0x26A4AB0
	public static extern Result EnsureAvailable(UserHandle handle) { }

	// RVA: 0x26A4AF0 Offset: 0x26A4BF1 VA: 0x26A4AF0
	public static extern Result IsAvailable(ref bool pOut, UserHandle handle) { }

	// RVA: 0x26A4B30 Offset: 0x26A4C31 VA: 0x26A4B30
	public static extern Result GetId(ref NetworkServiceAccountId pOutId, UserHandle handle) { }

	// RVA: 0x26A4B70 Offset: 0x26A4C71 VA: 0x26A4B70
	public static Result EnsurIdTokenCacheAsync(AsyncContext pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BB0 Offset: 0x26A4CB1 VA: 0x26A4BB0
	public static extern Result EnsurIdTokenCacheAsync(IntPtr pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BF0 Offset: 0x26A4CF1 VA: 0x26A4BF0
	public static Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, UserHandle handle) { }

	// RVA: 0x26A4C50 Offset: 0x26A4D51 VA: 0x26A4C50
	private static extern Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, int bufferSize, UserHandle handle) { }

	// RVA: 0x26A4C90 Offset: 0x26A4D91 VA: 0x26A4C90
	public static ErrorRange get_ResultNetworkServiceAccountUnavailable() { }

	// RVA: 0x26A4CA0 Offset: 0x26A4DA1 VA: 0x26A4CA0
	public static ErrorRange get_ResultTokenCacheUnavailable() { }

	// RVA: 0x26A4CB0 Offset: 0x26A4DB1 VA: 0x26A4CB0
	public static ErrorRange get_ResultNetworkCommunicationError() { }

	// RVA: 0x26A4CC0 Offset: 0x26A4DC1 VA: 0x26A4CC0
	public static ErrorRange get_ResultSslService() { }
}

public static class NetworkServiceAccount // TypeDefIndex: 11712
{
	// Fields
	public const int IdTokenLengthMax = 3072;

	// Properties
	public static ErrorRange ResultNetworkServiceAccountUnavailable { get; }
	public static ErrorRange ResultTokenCacheUnavailable { get; }
	public static ErrorRange ResultNetworkCommunicationError { get; }
	public static ErrorRange ResultSslService { get; }

	// Methods

	// RVA: 0x26A4AB0 Offset: 0x26A4BB1 VA: 0x26A4AB0
	public static extern Result EnsureAvailable(UserHandle handle) { }

	// RVA: 0x26A4AF0 Offset: 0x26A4BF1 VA: 0x26A4AF0
	public static extern Result IsAvailable(ref bool pOut, UserHandle handle) { }

	// RVA: 0x26A4B30 Offset: 0x26A4C31 VA: 0x26A4B30
	public static extern Result GetId(ref NetworkServiceAccountId pOutId, UserHandle handle) { }

	// RVA: 0x26A4B70 Offset: 0x26A4C71 VA: 0x26A4B70
	public static Result EnsurIdTokenCacheAsync(AsyncContext pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BB0 Offset: 0x26A4CB1 VA: 0x26A4BB0
	public static extern Result EnsurIdTokenCacheAsync(IntPtr pOutContext, UserHandle handle) { }

	// RVA: 0x26A4BF0 Offset: 0x26A4CF1 VA: 0x26A4BF0
	public static Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, UserHandle handle) { }

	// RVA: 0x26A4C50 Offset: 0x26A4D51 VA: 0x26A4C50
	private static extern Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, int bufferSize, UserHandle handle) { }

	// RVA: 0x26A4C90 Offset: 0x26A4D91 VA: 0x26A4C90
	public static ErrorRange get_ResultNetworkServiceAccountUnavailable() { }

	// RVA: 0x26A4CA0 Offset: 0x26A4DA1 VA: 0x26A4CA0
	public static ErrorRange get_ResultTokenCacheUnavailable() { }

	// RVA: 0x26A4CB0 Offset: 0x26A4DB1 VA: 0x26A4CB0
	public static ErrorRange get_ResultNetworkCommunicationError() { }

	// RVA: 0x26A4CC0 Offset: 0x26A4DC1 VA: 0x26A4CC0
	public static ErrorRange get_ResultSslService() { }
}

