[Serializable]
public class PlayerConnection : ScriptableObject // TypeDefIndex: 3255
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField] // RVA: 0xCB360 Offset: 0xCB461 VA: 0xCB360
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField] // RVA: 0xCB370 Offset: 0xCB471 VA: 0xCB370
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public bool isConnected { get; }

	// Methods

	// RVA: 0x2B67DD0 Offset: 0x2B67ED1 VA: 0x2B67DD0
	public static PlayerConnection get_instance() { }

	// RVA: 0x2B68090 Offset: 0x2B68191 VA: 0x2B68090
	public bool get_isConnected() { }

	// RVA: 0x2B67FD0 Offset: 0x2B680D1 VA: 0x2B67FD0
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x2B68280 Offset: 0x2B68381 VA: 0x2B68280
	public void OnEnable() { }

	// RVA: 0x2B681A0 Offset: 0x2B682A1 VA: 0x2B681A0
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x2B683B0 Offset: 0x2B684B1 VA: 0x2B683B0 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x2B68850 Offset: 0x2B68951 VA: 0x2B68850 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x2B68B80 Offset: 0x2B68C81 VA: 0x2B68B80 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x2B68D00 Offset: 0x2B68E01 VA: 0x2B68D00 Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x2B68D70 Offset: 0x2B68E71 VA: 0x2B68D70 Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x2B68DE0 Offset: 0x2B68EE1 VA: 0x2B68DE0 Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x2B68E50 Offset: 0x2B68F51 VA: 0x2B68E50 Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x2B69000 Offset: 0x2B69101 VA: 0x2B69000 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x2B691B0 Offset: 0x2B692B1 VA: 0x2B691B0
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x2B69430 Offset: 0x2B69531 VA: 0x2B69430 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9920 Offset: 0xD9A21 VA: 0xD9920
	// RVA: 0x2B69540 Offset: 0x2B69641 VA: 0x2B69540
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9930 Offset: 0xD9A31 VA: 0xD9930
	// RVA: 0x2B69A50 Offset: 0x2B69B51 VA: 0x2B69A50
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9940 Offset: 0xD9A41 VA: 0xD9940
	// RVA: 0x2B69AE0 Offset: 0x2B69BE1 VA: 0x2B69AE0
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x2B69B70 Offset: 0x2B69C71 VA: 0x2B69B70
	public void .ctor() { }
}

