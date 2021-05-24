[Serializable]
public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 1820
{
	// Fields
	private readonly int nativeErrorCode; // 0x88
	private static bool s_ErrorMessagesInitialized; // 0x0
	private static Dictionary<int, string> s_ErrorMessage; // 0x8

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x28E83E0 Offset: 0x28E84E1 VA: 0x28E83E0
	public void .ctor() { }

	// RVA: 0x28E84C0 Offset: 0x28E85C1 VA: 0x28E84C0
	public void .ctor(int error) { }

	// RVA: 0x28E86A0 Offset: 0x28E87A1 VA: 0x28E86A0
	public void .ctor(int error, string message) { }

	// RVA: 0x28E86D0 Offset: 0x28E87D1 VA: 0x28E86D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E8770 Offset: 0x28E8871 VA: 0x28E8770
	public int get_NativeErrorCode() { }

	// RVA: 0x28E8780 Offset: 0x28E8881 VA: 0x28E8780 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E8550 Offset: 0x28E8651 VA: 0x28E8550
	internal static string GetErrorMessage(int error) { }

	// RVA: 0x28E8850 Offset: 0x28E8951 VA: 0x28E8850
	private static void InitializeErrorMessages() { }

	// RVA: 0x28E9C20 Offset: 0x28E9D21 VA: 0x28E9C20
	private static void .cctor() { }
}

