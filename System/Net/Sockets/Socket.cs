public class Socket : IDisposable // TypeDefIndex: 2015
{
	// Fields
	private static object s_InternalSyncObject; // 0x0
	internal static bool s_SupportsIPv4; // 0x8
	internal static bool s_SupportsIPv6; // 0x9
	internal static bool s_OSSupportsIPv6; // 0xA
	internal static bool s_Initialized; // 0xB
	private static bool s_LoggingEnabled; // 0xC
	private bool is_closed; // 0x10
	private bool is_listening; // 0x11
	private bool useOverlappedIO; // 0x12
	private int linger_timeout; // 0x14
	private AddressFamily addressFamily; // 0x18
	private SocketType socketType; // 0x1C
	private ProtocolType protocolType; // 0x20
	internal SafeSocketHandle m_Handle; // 0x28
	internal EndPoint seed_endpoint; // 0x30
	internal SemaphoreSlim ReadSem; // 0x38
	internal SemaphoreSlim WriteSem; // 0x40
	internal bool is_blocking; // 0x48
	internal bool is_bound; // 0x49
	internal bool is_connected; // 0x4A
	private int m_IntCleanedUp; // 0x4C
	internal bool connect_in_progress; // 0x50
	private static AsyncCallback AcceptAsyncCallback; // 0x10
	private static IOAsyncCallback BeginAcceptCallback; // 0x18
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x20
	private static AsyncCallback ConnectAsyncCallback; // 0x28
	private static IOAsyncCallback BeginConnectCallback; // 0x30
	private static AsyncCallback DisconnectAsyncCallback; // 0x38
	private static IOAsyncCallback BeginDisconnectCallback; // 0x40
	private static AsyncCallback ReceiveAsyncCallback; // 0x48
	private static IOAsyncCallback BeginReceiveCallback; // 0x50
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x58
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x60
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x68
	private static AsyncCallback SendAsyncCallback; // 0x70
	private static IOAsyncCallback BeginSendGenericCallback; // 0x78
	private static AsyncCallback SendToAsyncCallback; // 0x80

	// Properties
	[ObsoleteAttribute] // RVA: 0xBDD60 Offset: 0xBDE61 VA: 0xBDD60
	public static bool SupportsIPv4 { get; }
	public static bool OSSupportsIPv4 { get; }
	[ObsoleteAttribute] // RVA: 0xBDDA0 Offset: 0xBDEA1 VA: 0xBDDA0
	public static bool SupportsIPv6 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public bool DontFragment { set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; }
	public bool NoDelay { set; }
	internal static int FamilyHint { get; }

	// Methods

	// RVA: 0x16D4A60 Offset: 0x16D4B61 VA: 0x16D4A60
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x16D5310 Offset: 0x16D5411 VA: 0x16D5310
	public static bool get_SupportsIPv4() { }

	// RVA: 0x16D5390 Offset: 0x16D5491 VA: 0x16D5390
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x16D5410 Offset: 0x16D5511 VA: 0x16D5410
	public static bool get_SupportsIPv6() { }

	// RVA: 0x16D5490 Offset: 0x16D5591 VA: 0x16D5490
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x16D5510 Offset: 0x16D5611 VA: 0x16D5510
	public IntPtr get_Handle() { }

	// RVA: 0x16D5530 Offset: 0x16D5631 VA: 0x16D5530
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x16D5540 Offset: 0x16D5641 VA: 0x16D5540
	public SocketType get_SocketType() { }

	// RVA: 0x16D5550 Offset: 0x16D5651 VA: 0x16D5550
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x16D5560 Offset: 0x16D5661 VA: 0x16D5560
	public void set_DontFragment(bool value) { }

	// RVA: 0x16D5740 Offset: 0x16D5841 VA: 0x16D5740
	public bool get_DualMode() { }

	// RVA: 0x16D5830 Offset: 0x16D5931 VA: 0x16D5830
	public void set_DualMode(bool value) { }

	// RVA: 0x16D58F0 Offset: 0x16D59F1 VA: 0x16D58F0
	private bool get_IsDualMode() { }

	// RVA: 0x16D5910 Offset: 0x16D5A11 VA: 0x16D5910
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x16D2640 Offset: 0x16D2741 VA: 0x16D2640
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x16D20D0 Offset: 0x16D21D1 VA: 0x16D20D0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x16D6320 Offset: 0x16D6421 VA: 0x16D6320
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x16CCE40 Offset: 0x16CCF41 VA: 0x16CCE40
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x16D50F0 Offset: 0x16D51F1 VA: 0x16D50F0
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x16D38E0 Offset: 0x16D39E1 VA: 0x16D38E0
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x16D3D90 Offset: 0x16D3E91 VA: 0x16D3D90
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x16D2EC0 Offset: 0x16D2FC1 VA: 0x16D2EC0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x16D3370 Offset: 0x16D3471 VA: 0x16D3370
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x16D72B0 Offset: 0x16D73B1 VA: 0x16D72B0
	private static object get_InternalSyncObject() { }

	// RVA: 0x16D73B0 Offset: 0x16D74B1 VA: 0x16D73B0
	internal bool get_CleanedUp() { }

	// RVA: 0x16D4D00 Offset: 0x16D4E01 VA: 0x16D4D00
	internal static void InitializeSockets() { }

	// RVA: 0x16D7440 Offset: 0x16D7541 VA: 0x16D7440 Slot: 4
	public void Dispose() { }

	// RVA: 0x16D74C0 Offset: 0x16D75C1 VA: 0x16D74C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16D2850 Offset: 0x16D2951 VA: 0x16D2850
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x16D7650 Offset: 0x16D7751 VA: 0x16D7650
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x16D5210 Offset: 0x16D5311 VA: 0x16D5210
	private void SocketDefaults() { }

	// RVA: 0x16D5060 Offset: 0x16D5161 VA: 0x16D5060
	private IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x16D7810 Offset: 0x16D7911 VA: 0x16D7810
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x16D79C0 Offset: 0x16D7AC1 VA: 0x16D79C0
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x16D7AE0 Offset: 0x16D7BE1 VA: 0x16D7AE0
	private static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x16D7AF0 Offset: 0x16D7BF1 VA: 0x16D7AF0
	public bool get_Blocking() { }

	// RVA: 0x16D7B00 Offset: 0x16D7C01 VA: 0x16D7B00
	public void set_Blocking(bool value) { }

	// RVA: 0x16D7BE0 Offset: 0x16D7CE1 VA: 0x16D7BE0
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x16D44C0 Offset: 0x16D45C1 VA: 0x16D44C0
	internal static void Blocking_internal(IntPtr socket, bool block, out int error) { }

	// RVA: 0x16D7CF0 Offset: 0x16D7DF1 VA: 0x16D7CF0
	public bool get_Connected() { }

	// RVA: 0x16D7770 Offset: 0x16D7871 VA: 0x16D7770
	public void set_NoDelay(bool value) { }

	// RVA: 0x16D7D80 Offset: 0x16D7E81 VA: 0x16D7D80
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x16D7F00 Offset: 0x16D8001 VA: 0x16D7F00
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x16D8030 Offset: 0x16D8131 VA: 0x16D8030
	private static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x16D8040 Offset: 0x16D8141 VA: 0x16D8040
	public Socket Accept() { }

	// RVA: 0x16D82A0 Offset: 0x16D83A1 VA: 0x16D82A0
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x16D83E0 Offset: 0x16D84E1 VA: 0x16D83E0
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x16D8410 Offset: 0x16D8511 VA: 0x16D8410
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x16D8180 Offset: 0x16D8281 VA: 0x16D8180
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x16D86F0 Offset: 0x16D87F1 VA: 0x16D86F0
	private static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x16CE460 Offset: 0x16CE561 VA: 0x16CE460
	public void Bind(EndPoint localEP) { }

	// RVA: 0x16D87D0 Offset: 0x16D88D1 VA: 0x16D87D0
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x16D88E0 Offset: 0x16D89E1 VA: 0x16D88E0
	private static void Bind_internal(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x16D88F0 Offset: 0x16D89F1 VA: 0x16D88F0
	public void Listen(int backlog) { }

	// RVA: 0x16D89E0 Offset: 0x16D8AE1 VA: 0x16D89E0
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x16D8AF0 Offset: 0x16D8BF1 VA: 0x16D8AF0
	private static void Listen_internal(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x16D8B00 Offset: 0x16D8C01 VA: 0x16D8B00
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x16D8F70 Offset: 0x16D9071 VA: 0x16D8F70
	private static void BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x16D9150 Offset: 0x16D9251 VA: 0x16D9150
	private static void BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x16D96C0 Offset: 0x16D97C1 VA: 0x16D96C0
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x16D8E70 Offset: 0x16D8F71 VA: 0x16D8E70
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x16D9770 Offset: 0x16D9871 VA: 0x16D9770
	private static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x16D9780 Offset: 0x16D9881 VA: 0x16D9780
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x16D9980 Offset: 0x16D9A81 VA: 0x16D9980
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x16D9870 Offset: 0x16D9971 VA: 0x16D9870
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x16D9A30 Offset: 0x16D9B31 VA: 0x16D9A30
	private static void Disconnect_internal(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x16D61A0 Offset: 0x16D62A1 VA: 0x16D61A0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0xBDB20 Offset: 0xBDC21 VA: 0xBDB20
	// RVA: 0x16D63D0 Offset: 0x16D64D1 VA: 0x16D63D0
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x16D6F40 Offset: 0x16D7041 VA: 0x16D6F40
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x16D7150 Offset: 0x16D7251 VA: 0x16D7150
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x16D9D20 Offset: 0x16D9E21 VA: 0x16D9D20
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x16DA080 Offset: 0x16DA181 VA: 0x16DA080
	private static int Receive_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x16D9C00 Offset: 0x16D9D01 VA: 0x16D9C00
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x16DA090 Offset: 0x16DA191 VA: 0x16DA090
	private static int Receive_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x16DA0A0 Offset: 0x16DA1A1 VA: 0x16DA0A0
	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x16DA380 Offset: 0x16DA481 VA: 0x16DA380
	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	// RVA: 0x16DA250 Offset: 0x16DA351 VA: 0x16DA250
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x16DA490 Offset: 0x16DA591 VA: 0x16DA490
	private static int ReceiveFrom_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x16D5FF0 Offset: 0x16D60F1 VA: 0x16D5FF0
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0xBDB40 Offset: 0xBDC41 VA: 0xBDB40
	// RVA: 0x16D59C0 Offset: 0x16D5AC1 VA: 0x16D59C0
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x16D6B40 Offset: 0x16D6C41 VA: 0x16D6B40
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x16DA6E0 Offset: 0x16DA7E1 VA: 0x16DA6E0
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x16D6DE0 Offset: 0x16D6EE1 VA: 0x16D6DE0
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x16DA5C0 Offset: 0x16DA6C1 VA: 0x16DA5C0
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x16DAA40 Offset: 0x16DAB41 VA: 0x16DAA40
	private static int Send_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x16DA4A0 Offset: 0x16DA5A1 VA: 0x16DA4A0
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x16DAA50 Offset: 0x16DAB51 VA: 0x16DAA50
	private static int Send_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x16DAA60 Offset: 0x16DAB61 VA: 0x16DAA60
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x16D1810 Offset: 0x16D1911 VA: 0x16D1810
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x16DAB10 Offset: 0x16DAC11 VA: 0x16DAB10
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x16DAC30 Offset: 0x16DAD31 VA: 0x16DAC30
	private static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x16D5620 Offset: 0x16D5721 VA: 0x16D5620
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x16DAC40 Offset: 0x16DAD41 VA: 0x16DAC40
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x16DAD80 Offset: 0x16DAE81 VA: 0x16DAD80
	private static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x16D69C0 Offset: 0x16D6AC1 VA: 0x16D69C0
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x16DAD90 Offset: 0x16DAE91 VA: 0x16DAD90
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x16DAED0 Offset: 0x16DAFD1 VA: 0x16DAED0
	private static int IOControl_internal(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x16DAEE0 Offset: 0x16DAFE1 VA: 0x16DAEE0
	public void Close() { }

	// RVA: 0x16D28F0 Offset: 0x16D29F1 VA: 0x16D28F0
	public void Close(int timeout) { }

	// RVA: 0x16D44F0 Offset: 0x16D45F1 VA: 0x16D44F0
	internal static void Close_internal(IntPtr socket, out int error) { }

	// RVA: 0x16D7540 Offset: 0x16D7641 VA: 0x16D7540
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x16D44D0 Offset: 0x16D45D1 VA: 0x16D44D0
	internal static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x16DAF60 Offset: 0x16DB061 VA: 0x16DAF60 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16DAFD0 Offset: 0x16DB0D1 VA: 0x16DAFD0
	private void Linger(IntPtr handle) { }

	// RVA: 0x16D7910 Offset: 0x16D7A11 VA: 0x16D7910
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x16D9A40 Offset: 0x16D9B41 VA: 0x16D9A40
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x16D9AC0 Offset: 0x16D9BC1 VA: 0x16D9AC0
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x16D7D00 Offset: 0x16D7E01 VA: 0x16D7D00
	private void ThrowIfUdp() { }

	// RVA: 0x16D84F0 Offset: 0x16D85F1 VA: 0x16D84F0
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x16D9E90 Offset: 0x16D9F91 VA: 0x16D9E90
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x16D8700 Offset: 0x16D8801 VA: 0x16D8700
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x16D44E0 Offset: 0x16D45E1 VA: 0x16D44E0
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x16DB160 Offset: 0x16DB261 VA: 0x16DB160
	internal static int get_FamilyHint() { }

	// RVA: 0x16DB2C0 Offset: 0x16DB3C1 VA: 0x16DB2C0
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x16D73C0 Offset: 0x16D74C1 VA: 0x16D73C0
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x16DB2D0 Offset: 0x16DB3D1 VA: 0x16DB2D0
	private static void .cctor() { }
}

