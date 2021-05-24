[ComDefaultInterfaceAttribute] // RVA: 0xABEB0 Offset: 0xABFB1 VA: 0xABEB0
[ComVisibleAttribute] // RVA: 0xABEB0 Offset: 0xABFB1 VA: 0xABEB0
[ClassInterfaceAttribute] // RVA: 0xABEB0 Offset: 0xABFB1 VA: 0xABEB0
[Serializable]
public class Exception : ISerializable, _Exception // TypeDefIndex: 228
{
	// Fields
	[OptionalFieldAttribute] // RVA: 0xB43A0 Offset: 0xB44A1 VA: 0xB43A0
	private static object s_EDILock; // 0x0
	private string _className; // 0x10
	internal string _message; // 0x18
	private IDictionary _data; // 0x20
	private Exception _innerException; // 0x28
	private string _helpURL; // 0x30
	private object _stackTrace; // 0x38
	private string _stackTraceString; // 0x40
	private string _remoteStackTraceString; // 0x48
	private int _remoteStackIndex; // 0x50
	private object _dynamicMethods; // 0x58
	internal int _HResult; // 0x60
	private string _source; // 0x68
	[OptionalFieldAttribute] // RVA: 0xB43B0 Offset: 0xB44B1 VA: 0xB43B0
	private SafeSerializationManager _safeSerializationManager; // 0x70
	internal StackTrace[] captured_traces; // 0x78
	private IntPtr[] native_trace_ips; // 0x80
	private const int _COMPlusExceptionCode = -532462766;

	// Properties
	public virtual string Message { get; }
	public virtual IDictionary Data { get; }
	public Exception InnerException { get; }
	public MethodBase TargetSite { get; }
	public virtual string StackTrace { get; }
	public virtual string HelpLink { get; set; }
	public virtual string Source { get; set; }
	internal string RemoteStackTrace { get; }
	public int HResult { get; set; }
	internal bool IsTransient { get; }

	// Methods

	// RVA: 0x179D920 Offset: 0x179DA21 VA: 0x179D920
	private void Init() { }

	// RVA: 0x179D9D0 Offset: 0x179DAD1 VA: 0x179D9D0
	public void .ctor() { }

	// RVA: 0x179DA00 Offset: 0x179DB01 VA: 0x179DA00
	public void .ctor(string message) { }

	// RVA: 0x179DA40 Offset: 0x179DB41 VA: 0x179DA40
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x179DAA0 Offset: 0x179DBA1 VA: 0x179DAA0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x179DE90 Offset: 0x179DF91 VA: 0x179DE90 Slot: 5
	public virtual string get_Message() { }

	// RVA: 0x179E020 Offset: 0x179E121 VA: 0x179E020 Slot: 6
	public virtual IDictionary get_Data() { }

	// RVA: 0x179E0D0 Offset: 0x179E1D1 VA: 0x179E0D0
	private static bool IsImmutableAgileException(Exception e) { }

	// RVA: 0x179DFB0 Offset: 0x179E0B1 VA: 0x179DFB0
	private string GetClassName() { }

	// RVA: 0x179E0F0 Offset: 0x179E1F1 VA: 0x179E0F0 Slot: 7
	public virtual Exception GetBaseException() { }

	// RVA: 0x179E110 Offset: 0x179E211 VA: 0x179E110 Slot: 8
	public Exception get_InnerException() { }

	// RVA: 0x179E120 Offset: 0x179E221 VA: 0x179E120
	private static IRuntimeMethodInfo GetMethodFromStackTrace(object stackTrace) { }

	// RVA: 0x179E130 Offset: 0x179E231 VA: 0x179E130 Slot: 9
	public MethodBase get_TargetSite() { }

	// RVA: 0x179E1F0 Offset: 0x179E2F1 VA: 0x179E1F0 Slot: 10
	public virtual string get_StackTrace() { }

	// RVA: 0x179E200 Offset: 0x179E301 VA: 0x179E200
	private string GetStackTrace(bool needFileInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB6A20 Offset: 0xB6B21 VA: 0xB6A20
	// RVA: 0x1796D70 Offset: 0x1796E71 VA: 0x1796D70
	internal void SetErrorCode(int hr) { }

	// RVA: 0x179E2D0 Offset: 0x179E3D1 VA: 0x179E2D0 Slot: 11
	public virtual string get_HelpLink() { }

	// RVA: 0x179E2E0 Offset: 0x179E3E1 VA: 0x179E2E0 Slot: 12
	public virtual void set_HelpLink(string value) { }

	// RVA: 0x179E2F0 Offset: 0x179E3F1 VA: 0x179E2F0 Slot: 13
	public virtual string get_Source() { }

	// RVA: 0x179E420 Offset: 0x179E521 VA: 0x179E420 Slot: 14
	public virtual void set_Source(string value) { }

	// RVA: 0x179E430 Offset: 0x179E531 VA: 0x179E430 Slot: 3
	public override string ToString() { }

	// RVA: 0x179E440 Offset: 0x179E541 VA: 0x179E440
	private string ToString(bool needFileLineInfo, bool needMessage) { }

	// RVA: 0x179E870 Offset: 0x179E971 VA: 0x179E870
	protected void add_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	// RVA: 0x179E890 Offset: 0x179E991 VA: 0x179E890
	protected void remove_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	// RVA: 0x179E8B0 Offset: 0x179E9B1 VA: 0x179E8B0 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x179ED20 Offset: 0x179EE21 VA: 0x179ED20
	internal Exception PrepForRemoting() { }

	[OnDeserializedAttribute] // RVA: 0xB6A30 Offset: 0xB6B31 VA: 0xB6A30
	// RVA: 0x179F500 Offset: 0x179F601 VA: 0x179F500
	private void OnDeserialized(StreamingContext context) { }

	// RVA: 0x179F5A0 Offset: 0x179F6A1 VA: 0x179F5A0
	internal void InternalPreserveStackTrace() { }

	// RVA: 0x179F680 Offset: 0x179F781 VA: 0x179F680
	internal string get_RemoteStackTrace() { }

	// RVA: 0x179E2C0 Offset: 0x179E3C1 VA: 0x179E2C0
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	// RVA: 0x179F690 Offset: 0x179F791 VA: 0x179F690
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	// RVA: 0x179F750 Offset: 0x179F851 VA: 0x179F750
	public int get_HResult() { }

	// RVA: 0x179F760 Offset: 0x179F861 VA: 0x179F760
	protected void set_HResult(int value) { }

	// RVA: 0x179F770 Offset: 0x179F871 VA: 0x179F770 Slot: 16
	internal virtual string InternalToString() { }

	// RVA: 0x179E0E0 Offset: 0x179E1E1 VA: 0x179E0E0 Slot: 17
	public Type GetType() { }

	// RVA: 0x179F780 Offset: 0x179F881 VA: 0x179F780
	internal bool get_IsTransient() { }

	// RVA: 0x179F800 Offset: 0x179F901 VA: 0x179F800
	private static bool nIsTransient(int hr) { }

	// RVA: 0x179F810 Offset: 0x179F911 VA: 0x179F810
	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	// RVA: 0x179F870 Offset: 0x179F971 VA: 0x179F870
	internal void SetMessage(string s) { }

	// RVA: 0x179F880 Offset: 0x179F981 VA: 0x179F880
	internal void SetStackTrace(string s) { }

	// RVA: 0x179F890 Offset: 0x179F991 VA: 0x179F890
	internal Exception FixRemotingException() { }

	// RVA: 0x179F9F0 Offset: 0x179FAF1 VA: 0x179F9F0
	internal static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x179FA00 Offset: 0x179FB01 VA: 0x179FA00
	private static void .cctor() { }
}

