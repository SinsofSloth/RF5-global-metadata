[Serializable]
public struct ObjectInitializationData // TypeDefIndex: 4474
{
	// Fields
	[SerializeField] // RVA: 0x129CF0 Offset: 0x129DF1 VA: 0x129CF0
	[FormerlySerializedAsAttribute] // RVA: 0x129CF0 Offset: 0x129DF1 VA: 0x129CF0
	private string m_Id; // 0x0
	[SerializeField] // RVA: 0x129D40 Offset: 0x129E41 VA: 0x129D40
	[FormerlySerializedAsAttribute] // RVA: 0x129D40 Offset: 0x129E41 VA: 0x129D40
	private SerializedType m_ObjectType; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x129D90 Offset: 0x129E91 VA: 0x129D90
	[SerializeField] // RVA: 0x129D90 Offset: 0x129E91 VA: 0x129D90
	private string m_Data; // 0x28

	// Properties
	public string Id { get; }
	public SerializedType ObjectType { get; }
	public string Data { get; }

	// Methods

	// RVA: 0x16710 Offset: 0x16811 VA: 0x16710
	public string get_Id() { }

	// RVA: 0x16720 Offset: 0x16821 VA: 0x16720
	public SerializedType get_ObjectType() { }

	// RVA: 0x16740 Offset: 0x16841 VA: 0x16740
	public string get_Data() { }

	// RVA: 0x16750 Offset: 0x16851 VA: 0x16750 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	public TObject CreateInstance<TObject>(string idOverride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F1E80 Offset: 0x2F1F81 VA: 0x2F1E80
	|-ObjectInitializationData.CreateInstance<IInstanceProvider>
	|-ObjectInitializationData.CreateInstance<IResourceProvider>
	|-ObjectInitializationData.CreateInstance<ISceneProvider>
	|-ObjectInitializationData.CreateInstance<object>
	*/

	// RVA: 0x167E0 Offset: 0x168E1 VA: 0x167E0
	public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride) { }
}

